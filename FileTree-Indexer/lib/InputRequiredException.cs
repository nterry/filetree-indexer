using System;

namespace FileTree_Indexer.lib
{
    public enum FileType
    {
        File,
        Folder
    }

    public class InputRequiredException : Exception
    {
        public InputRequiredException(string message) : base(message) {}
    }
}
