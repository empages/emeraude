<template>
    <tr>
        <td class="p-1">
            <div class="position-relative">
                <input @keyup.enter="editKey"
                       @keypress="isValidKeyValue"
                       @input="data.key = transformKeyInput($event); keyEditedStatus = true;"
                       class="form-control"
                       :class="{ 'pr-5': keyEditedStatus }"
                       v-model="data.key" />
                <button v-if="keyEditedStatus" class="btn-save-in-input btn btn-primary btn-icons position-absolute" @click="editKey"><i class="mdi mdi-content-save"></i></button>
            </div>
        </td>
        <td class="p-1" v-for="(translation, translationIndex) in data.languageValues" :key="data.key + 'Translation' + translationIndex">
            <div class="position-relative">
                <input @input="translationInput(translationIndex)"
                       @keyup.enter="editTranslation(translationIndex, $event)"
                       class="form-control"
                       :class="{ 'pr-5': valueEditedStatuses[translationIndex] }"
                       v-model="translation.value" />
                <button v-if="valueEditedStatuses[translationIndex]" class="btn-save-in-input btn btn-primary btn-icons position-absolute" @click="editTranslation(translationIndex, $event)"><i class="mdi mdi-content-save"></i></button>
            </div>
        </td>
        <td class="px-2 py-0 text-center fit">
            <b-button @click="deleteKey" variant="danger" class="btn btn-icons">
                <i class="mdi mdi-delete-forever"></i>
            </b-button>
        </td>
    </tr>
</template>

<script>
    import inputMixin from '../../../mixins/inputMixin.js';
    export default {
        name: 'KeyRow',
        props: {
            data: Object,
            reloadCallback: Function
        },
        data() {
            return {
                keyEditedStatus: false,
                valueEditedStatuses: []
            }
        },
        mixins: [inputMixin],
        computed: {
            keyId() {
                return this.data.keyId;
            },
            key() {
                return this.data.key;
            }
        },
        methods: {
            translationInput(index) {
                this.valueEditedStatuses[index] = true;
            },
            deleteKey() {
                let self = this;
                this.$bvModal.msgBoxConfirm('By clicking the \'Yes\' button you will delete the selected translation key and its translations.', {
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
                            this.$http.delete('/api/client-builder/languages/keys/' + self.keyId)
                                .then(response => {
                                    self.reloadCallback();
                                })
                                .catch(error => {
                                    console.log(error);
                                });
                        }
                    })
            },
            editTranslation(index, event) {
                let self = this;
                let translation = this.data.languageValues[index];
                this.$http.put('/api/client-builder/languages/translations/' + translation.id + "/edit", {
                    value: translation.value
                })
                    .then(response => {
                        self.$bvToast.toast('Value has been edited.', {
                            title: 'Edit Value',
                            autoHideDelay: 1500,
                            variant: 'success',
                            solid: true
                        });

                        self.valueEditedStatuses[index] = false;
                        event.target.blur();
                        self.$forceUpdate();
                    })
                    .catch(error => {
                        self.$bvToast.toast('Value has not been edited.', {
                            title: 'Edit Value',
                            autoHideDelay: 1500,
                            variant: 'danger',
                            solid: true
                        });

                        self.valueEditedStatuses[index] = false;
                    });
            },
            editKey(event) {
                if (this.keyEditedStatus === false) {
                    return;
                }

                let self = this;
                this.$http.put('/api/client-builder/languages/keys/' + this.keyId + "/edit", {
                    value: this.key
                })
                    .then(response => {
                        self.$bvToast.toast('Key has been edited.', {
                            title: 'Edit Key',
                            autoHideDelay: 1500,
                            variant: 'success',
                            solid: true
                        });

                        self.keyEditedStatus = false;
                        event.target.blur();
                    })
                    .catch(error => {
                        self.$bvToast.toast('Key has not been edited.', {
                            title: 'Edit Key',
                            autoHideDelay: 1500,
                            variant: 'danger',
                            solid: true
                        });

                        self.keyEditedStatus = false;
                    });
            }
        },
        mounted() {
            for (var i = 0; i < this.data.languageValues.length; i++) {
                this.valueEditedStatuses.push(false);
            }
        }
    }
</script>