using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Admin.ClientBuilder.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules
{
    public abstract class ScaffoldModule
    {
        public ScaffoldModule(string name, InstanceType type, bool locked)
        {
            Name = name;
            Type = type;
            Locked = locked;
            Files = new List<ModuleFile>();
            Folders = new List<ModuleFolder>();
        }

        public string Id
        {
            get
            {
                return Name.Replace(" ", "-").ToLower();
            }
        }

        [JsonIgnore]
        protected string SourceDirectory { get; private set; }

        [JsonIgnore]
        protected ClientBuilderOptions Options { get; private set; }

        public int Order { get; set; }

        public string Name { get; set; }

        public string Icon { get; protected set; }

        public string ScaffoldTypeName { get; protected set; }

        public InstanceType Type { get; set; }

        public string ParentModuleId { get; protected set; }

        public List<ModuleFile> Files { get; private set; }

        public List<ModuleFolder> Folders { get; private set; }

        public bool Generated { get; set; }

        public bool Locked { get; set; }

        public IServiceProvider ServiceProvider { get; private set; }

        internal void SetSourceDirectory(string sourceDirectory)
        {
            SourceDirectory = sourceDirectory;
        }

        internal void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public void AddFile(ModuleFile file)
        {
            Files.Add(file);
        }

        public ModuleFile GetFile(string referenceId)
        {
            return Files.FirstOrDefault(x => x.ReferenceId == referenceId);
        }

        public void AddFolder(ModuleFolder folder)
        {
            Folders.Add(folder);
        }

        public ModuleFolder GetFolder(string name)
        {
            return Folders.FirstOrDefault(x => x.Name == name);
        }

        public void Sync()
        {
            bool filesChecked = false;
            if (Files != null && Files.Count > 0)
            {
                filesChecked = true;
                Generated = true;
                foreach (var file in Files)
                {
                    var currentFilePath = Path.Combine(SourceDirectory, file.RelativePath, file.Name);
                    Generated = Generated && File.Exists(currentFilePath);
                }
            }

            if (Folders != null && Folders.Count > 0)
            {
                if (filesChecked && !Generated)
                {
                    return;
                }

                Generated = true;
                foreach (var folder in Folders)
                {
                    var currentFolderPath = Path.Combine(SourceDirectory, folder.RelativePath, folder.Name);
                    Generated = Generated && Directory.Exists(currentFolderPath);
                }
            }
        }

        public void LoadOptions(ClientBuilderOptions options)
        {
            Options = options;
        }

        public abstract void DefineFiles();

        public abstract void DefineFolders();

        public bool Generate(out string errorMessage)
        {
            try
            {
                foreach (var folder in Folders)
                {
                    var folderPath = Path.Combine(SourceDirectory, folder.RelativePath, folder.Name);
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                }

                foreach (var file in Files)
                {
                    string fileContent = file.RenderFunction.Invoke(file);
                    string filePath = Path.Combine(this.SourceDirectory, file.RelativePath, file.Name);
                    if (!File.Exists(filePath) || Locked)
                    {
                        File.WriteAllText(filePath, fileContent);
                    }
                }

                errorMessage = string.Empty;
                return true;
            }
            catch (System.Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        protected TService GetService<TService>()
        {
            return (TService)ServiceProvider.GetService(typeof(TService));
        }
    }
}
