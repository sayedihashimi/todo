using System;

namespace SayedTodo.Shared {
    public class FileHelper : IFileHelper {

        public string GetValidFilenameFrom(string str){
            if (!string.IsNullOrEmpty(str)) {
                foreach (char c in System.IO.Path.GetInvalidFileNameChars()) {
                    str = str.Replace(c, '_');
                }
            }

            return str;
        }
    }
}
