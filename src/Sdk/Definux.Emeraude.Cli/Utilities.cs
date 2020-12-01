using System.IO;

namespace Definux.Emeraude.Cli
{
    /// <summary>
    /// Utility functions.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Deletes folders recursively.
        /// </summary>
        /// <param name="directory"></param>
        internal static void RecursiveDelete(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                return;
            }

            var filesInfos = directory.EnumerateFiles();
            foreach (var fileInfo in filesInfos)
            {
                fileInfo.Attributes = FileAttributes.Normal;
                fileInfo.Delete();
            }

            var directoryInfos = directory.EnumerateDirectories();
            foreach (var directoryInfo in directoryInfos)
            {
                RecursiveDelete(directoryInfo);
            }

            directory.Delete(true);
        }
    }
}
