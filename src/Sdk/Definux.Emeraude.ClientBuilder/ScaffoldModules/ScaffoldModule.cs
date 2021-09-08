using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using Definux.Emeraude.ClientBuilder.Options;
using Definux.Emeraude.ClientBuilder.Shared;

namespace Definux.Emeraude.ClientBuilder.ScaffoldModules
{
    /// <summary>
    /// Abstract module that provides all abstractions and methods for a module for client builder.
    /// </summary>
    public abstract class ScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScaffoldModule"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="locked"></param>
        public ScaffoldModule(string name, InstanceType type, bool locked)
        {
            this.Name = name;
            this.Type = type;
            this.Locked = locked;
            this.Files = new List<ModuleFile>();
            this.Folders = new List<ModuleFolder>();
        }

        /// <summary>
        /// Identifier of the module.
        /// </summary>
        public string Id => this.Name.Replace(" ", "-").ToLower();

        /// <summary>
        /// Order of the module.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the module.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Icon of the module.
        /// </summary>
        public string IconUrl { get; protected set; }

        /// <summary>
        /// Type name of the module. The main use of this property is to give the name of the grouped modules.
        /// </summary>
        public string ScaffoldTypeName { get; protected set; }

        /// <summary>
        /// Instance type of the module - target application type of the generation (web, mobile, etc).
        /// </summary>
        public InstanceType Type { get; set; }

        /// <summary>
        /// Identification of the module that allows easy modules grouping.
        /// </summary>
        public string ParentModuleId { get; protected set; }

        /// <summary>
        /// List of files for generation.
        /// </summary>
        public List<ModuleFile> Files { get; private set; }

        /// <summary>
        /// List of folders for generation.
        /// </summary>
        public List<ModuleFolder> Folders { get; private set; }

        /// <summary>
        /// Flag that indicates that the module is generated already.
        /// </summary>
        public bool Generated { get; set; }

        /// <summary>
        /// Flag that indicates that the module generated files is locked for changes or not.
        /// </summary>
        public bool Locked { get; set; }

        /// <inheritdoc cref="IServiceProvider"/>
        public IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// Startup directory of the module generation.
        /// </summary>
        [JsonIgnore]
        protected string SourceDirectory { get; private set; }

        /// <summary>
        /// General options of the client builder.
        /// </summary>
        [JsonIgnore]
        protected EmClientBuilderOptions Options { get; private set; }

        /// <summary>
        /// Add module file.
        /// </summary>
        /// <param name="file"></param>
        public void AddFile(ModuleFile file)
        {
            this.Files.Add(file);
        }

        /// <summary>
        /// Get module file by reference id.
        /// </summary>
        /// <param name="referenceId"></param>
        /// <returns></returns>
        public ModuleFile GetFile(string referenceId)
        {
            return this.Files.FirstOrDefault(x => x.ReferenceId == referenceId);
        }

        /// <summary>
        /// Add module folder.
        /// </summary>
        /// <param name="folder"></param>
        public void AddFolder(ModuleFolder folder)
        {
            this.Folders.Add(folder);
        }

        /// <summary>
        /// Get module folder by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ModuleFolder GetFolder(string name)
        {
            return this.Folders.FirstOrDefault(x => x.Name == name);
        }

        /// <summary>
        /// Sync defined folders and files with the generated ones.
        /// </summary>
        public void Sync()
        {
            bool filesChecked = false;
            if (this.Files != null && this.Files.Count > 0)
            {
                filesChecked = true;
                this.Generated = true;
                foreach (var file in this.Files)
                {
                    var currentFilePath = Path.Combine(this.SourceDirectory, file.RelativePath, file.Name);
                    this.Generated = this.Generated && File.Exists(currentFilePath);
                }
            }

            if (this.Folders != null && this.Folders.Count > 0)
            {
                if (filesChecked && !this.Generated)
                {
                    return;
                }

                this.Generated = true;
                foreach (var folder in this.Folders)
                {
                    var currentFolderPath = Path.Combine(this.SourceDirectory, folder.RelativePath, folder.Name);
                    this.Generated = this.Generated && Directory.Exists(currentFolderPath);
                }
            }
        }

        /// <summary>
        /// Load client builder options.
        /// </summary>
        /// <param name="options"></param>
        public void LoadOptions(EmClientBuilderOptions options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Method used for files definitions of the module.
        /// </summary>
        public abstract void DefineFiles();

        /// <summary>
        /// Method used for folder definitions of the module.
        /// </summary>
        public abstract void DefineFolders();

        /// <summary>
        /// Generate folder and files defined in the module.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool Generate(out string errorMessage)
        {
            try
            {
                foreach (var folder in this.Folders)
                {
                    var folderPath = Path.Combine(this.SourceDirectory, folder.RelativePath, folder.Name);
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                }

                foreach (var file in this.Files)
                {
                    string fileContent = file.RenderFunction.Invoke(file);
                    string filePath = Path.Combine(this.SourceDirectory, file.RelativePath, file.Name);
                    if (!File.Exists(filePath) || this.Locked)
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

        /// <summary>
        /// Set source directory.
        /// </summary>
        /// <param name="sourceDirectory"></param>
        public void SetSourceDirectory(string sourceDirectory)
        {
            this.SourceDirectory = sourceDirectory;
        }

        /// <summary>
        /// Set service provider.
        /// </summary>
        /// <param name="serviceProvider"></param>
        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        /// <summary>
        /// Get service from the services container.
        /// </summary>
        /// <typeparam name="TService">Service type.</typeparam>
        /// <returns></returns>
        protected TService GetService<TService>()
        {
            return (TService)this.ServiceProvider.GetService(typeof(TService));
        }
    }
}
