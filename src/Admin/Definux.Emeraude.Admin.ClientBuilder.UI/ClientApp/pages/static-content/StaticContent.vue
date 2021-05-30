<template>
    <div class="client-builder-page">
        <b-card class="main-card" title="Static content items list" sub-title="List of all static content items defined by key and translation content stored into the localization content. To create a new one use the form placed on the top of the page.">
            <hr class="w-100" />
            <div class="row m-0">
                <div class="form-group px-1 col">
                    <select class="form-control" v-model="selectedKey" @change="selectContentKey">
                        <option :value="0">Add New Key</option>
                        <optgroup label="Current Keys">
                            <option :value="contentKey.id" v-for="contentKey in contentKeys" :key="'contentKey' + contentKey.id">{{contentKey.key}}</option>
                        </optgroup>
                    </select>
                </div>
                <div class="form-group px-1 col">
                    <input class="form-control"
                           v-model="currentContentEntity.key"
                           @keypress="isValidKeyValue"
                           @input="currentContentEntity.key = transformKeyInput($event)"
                           placeholder="Key" />
                </div>
                <div class="form-group px-1">
                    <button v-if="!editMode" class="btn btn-primary h-100" @click="createContentKey">Add</button>
                    <button v-if="editMode" class="btn btn-primary h-100" @click="editContentKey">Edit</button>
                    <button v-if="editMode" class="btn btn-danger h-100" @click="deleteContentKey">Delete</button>
                </div>
            </div>
            <div v-for="contentItem in currentContentEntity.staticContentList" :key="'codeEditor' + contentItem.languageId">
                <hr />
                <h5>{{ getLanguageById(contentItem.languageId).name }} Version</h5>
                <div class="border">
                    <codemirror v-model="contentItem.content" :options="codeMirrorOptions"></codemirror>
                </div>
            </div>
        </b-card>
    </div>
</template>

<script>
    import { codemirror } from "vue-codemirror";
    import 'codemirror/mode/htmlmixed/htmlmixed.js';
    import "codemirror/lib/codemirror.css";
import inputMixin from "../../mixins/inputMixin.js";

export default {
  data() {
    return {
      languages: [],
      contentKeys: [],
      codeMirrorOptions: {
          tabSize: 2,
        mode: 'htmlmixed',
        lineNumbers: true,
        line: true,
        },
        currentContentEntity: {
            key: '',
            staticContentList: []
        },
        selectedKey: 0
    };
  },
  mixins: [inputMixin],
  components: {
    codemirror,
  },
        computed: {
            editMode() {
                return this.selectedKey !== 0;
            }
        },
  methods: {
    loadLanguages() {
      let self = this;
      this.$http.get("/api/client-builder/languages")
        .then((response) => {
            self.languages = response.data;
            self.initEmptyEntity();
        })
        .catch((error) => {
          console.log(error);
        });
      },
      loadContentKeys() {
        let self = this;
        this.$http.get("/api/client-builder/languages/content-keys")
        .then((response) => {
            self.contentKeys = response.data;
        })
        .catch((error) => {
          console.log(error);
        });
      },
      createContentKey() {
          let self = this;
          this.$http.post('/api/client-builder/languages/content-keys', this.currentContentEntity)
              .then(() => {
                self.$bvToast.toast('The new key has been added.', {
                    title: 'New Key Operation',
                    autoHideDelay: 1500,
                    variant: 'success',
                    solid: true
                });
                  self.loadContentKeys();
                  self.initEmptyEntity();
              })
              .catch(() => {
                self.$bvToast.toast('The new key has not been added.', {
                    title: 'New Key Operation',
                    autoHideDelay: 1500,
                    variant: 'danger',
                    solid: true
                });
              })
      },
      initEmptyEntity() {
          this.currentContentEntity = {
              key: '',
              staticContentList: []
          };

          for (let i = 0; i < this.languages.length; i++) {
            this.currentContentEntity.staticContentList.push({
              content: "",
              languageId: this.languages[i].id,
            });
          }
      },
      getLanguageById(id) {
          return this.languages.filter(obj => {
              return obj.id == id;
          })[0];
      },
      loadContentKey(keyId) {
        let self = this;
        this.$http.get("/api/client-builder/languages/content-keys/" + keyId)
        .then((response) => {
            self.currentContentEntity = response.data;
        })
        .catch((error) => {
          console.log(error);
        });
      },
      selectContentKey() {
          if (this.selectedKey !== 0) {
              this.loadContentKey(this.selectedKey);
          }
          else {
              this.initEmptyEntity();
          }
      },
      editContentKey() {
          let self = this;
          this.$http.put('/api/client-builder/languages/content-keys/' + self.currentContentEntity.id, self.currentContentEntity)
              .then(() => {
                self.$bvToast.toast('The key has been edited.', {
                    title: 'Edit Key Operation',
                    autoHideDelay: 1500,
                    variant: 'success',
                    solid: true
                });
                  self.loadContentKeys();
              })
              .catch(() => {
                self.$bvToast.toast('The key has not been edited.', {
                    title: 'Edit Key Operation',
                    autoHideDelay: 1500,
                    variant: 'danger',
                    solid: true
                });
              })
      },
      deleteContentKey() {
          let self = this;
          this.$bvModal.msgBoxConfirm('By clicking the \'Yes\' button you will delete the selected content key and its content items.', {
              title: 'Are you sure you want to delete this key?',
              size: 'md',
              okVariant: 'danger',
              cancelVariant: 'primary',
              okTitle: 'DELETE',
              cancelTitle: 'CANCEL',
              headerClass: 'p-2 border-bottom-0',
              footerClass: 'p-2 border-top-0',
              centered: true
          })
              .then(value => {
                  if (value) {
                      this.$http.delete('/api/client-builder/languages/content-keys/' + self.currentContentEntity.id)
                          .then(() => {
                              self.loadContentKeys();
                              self.initEmptyEntity();
                              self.selectedKey = 0;
                          })
                          .catch(error => {
                              console.log(error);
                          });
                  }
              })
      },
  },
  mounted() {
      this.loadLanguages();
      this.loadContentKeys();
  },
};
</script>
