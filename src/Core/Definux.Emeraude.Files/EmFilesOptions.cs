using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Files
{
    /// <summary>
    /// Options for files infrastructure of Emeraude.
    /// </summary>
    public class EmFilesOptions : IEmOptions
    {
        /// <summary>
        /// Enables file upload. The default value is true.
        /// </summary>
        public bool AllowFileUpload { get; set; } = true;

        /// <summary>
        /// Enables image upload. The default value is false.
        /// </summary>
        public bool AllowImageUpload { get; set; }

        /// <summary>
        /// Enables video upload. The default value is false.
        /// </summary>
        public bool AllowVideoUpload { get; set; }

        /// <summary>
        /// Maximum allowed upload file size. The default value is 20971520 bytes (~20MB).
        /// </summary>
        public int MaxAllowedFileSize { get; set; } = 20971520;

        /// <summary>
        /// Maximum allowed upload image size. The default value is 10485760 bytes (~10MB).
        /// </summary>
        public int MaxAllowedImageFileSize { get; set; } = 10485760;

        /// <summary>
        /// Maximum allowed upload video size. The default value is 209715200 bytes (~200MB).
        /// </summary>
        public int MaxAllowedVideoFileSize { get; set; } = 209715200;
    }
}