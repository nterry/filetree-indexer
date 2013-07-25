using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileTree_Indexer.lib
{
    public class Utils
    {
        public static List<string> DirSearch(string dir)
        {
            var list = new List<string>();
            foreach (var directory in Directory.GetDirectories(dir))
            {
                //list.Add(directory);
                list.AddRange(DirSearch(directory));
            }
            list.AddRange(Directory.EnumerateFiles(dir));
            return list;
        }

        public static string IndexFilePath(string absFilePath, string relFilePath, string delimiter)
        {
            var fieldBuilder = new StringBuilder();
            var fullIndex = absFilePath.Split('\\').ToList();
            var relIndex = relFilePath.Split('\\').ToList();
            var indexFieldList = new List<string>();

            for (var i = relIndex.Count - 1; i < fullIndex.Count; i++)  { if (!fullIndex.ElementAt(i).Equals(fullIndex.Last())) indexFieldList.Add(fullIndex.ElementAt(i)); }

            foreach (var indexField in indexFieldList)
            {
                fieldBuilder.Append(indexField);
                fieldBuilder.Append(!indexField.Equals(indexFieldList.Last()) ? delimiter : string.Format("{0}{1}{2}", delimiter, absFilePath, Environment.NewLine));
            }
            return fieldBuilder.ToString();
        }
    }
}
