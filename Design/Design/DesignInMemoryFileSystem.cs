using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    public class DesignInMemoryFileSystem
    {
        File root = null;
        public DesignInMemoryFileSystem()
        {
            root = new File();
        }

        public IList<string> Ls(string path)
        {
            List<string> result = new List<string>();
            File curr = root;
            if (path != "/")
            {
                var patharr = path.Split('/');
                for (int i = 1; i < patharr.Length; i++)
                    curr = curr.files[patharr[i]];

                if (curr.IsFile)
                {
                    result.Add(patharr[patharr.Length - 1]);
                    return result;
                }
            }
            result.AddRange(curr.files.Keys.OrderBy(x => x));
            return result;
        }

        public void Mkdir(string path)
        {
            File curr = root;
            string[] patharr = path.Split('/');

            for (int i = 1; i < patharr.Length; i++)
            {
                if (!curr.files.ContainsKey(patharr[i]))
                {
                    curr.files.Add(patharr[i], new File());
                }
                curr = curr.files[patharr[i]];
            }
        }

        public void AddContentToFile(string filePath, string content)
        {
            File curr = root;
            string[] patharr = filePath.Split('/');

            for (int i = 1; i < patharr.Length - 1; i++)
            {
                if (!curr.files.ContainsKey(patharr[i]))
                {
                    curr.files.Add(patharr[i], new File());
                }
                curr = curr.files[patharr[i]];
            }

            if (!curr.files.ContainsKey(patharr[patharr.Length - 1]))
            {
                curr.files.Add(patharr[patharr.Length - 1], new File());
            }
            curr = curr.files[patharr[patharr.Length - 1]];
            curr.IsFile = true;
            curr.content += content;

        }

        public string ReadContentFromFile(string filePath)
        {
            File curr = root;
            string[] patharr = filePath.Split('/');

            for (int i = 1; i < patharr.Length - 1; i++)
            {
                curr = curr.files[patharr[i]];
            }
            return curr.files[patharr[patharr.Length - 1]].content;
        }
    }
}

public class File
{
    public bool IsFile;
    public Dictionary<string, File> files = new Dictionary<string, File>();
    public string content = "";
}
