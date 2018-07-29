using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlasmidDatabaseV3
{
    class Modul
    {
        

        public void CreatePlasmid(string name, string sequence, string file)
        {
            string filepath = file;
            
            var list = new List<string>();
            list.Add(name.ToString());
            list.Add(sequence.ToString());
            string[] plasmidData = list.ToArray();

            File.WriteAllLines(filepath, list);

        }

        public string CreateFilePath(string name)
        {
            string path = $"C:\\Users\\Hendrik\\Desktop\\Plasmiddatenbank\\plasmid_{name}.text";
            return path;
        }
        

        public bool CheckFileExistence(string file)
        {
            bool b = File.Exists(file);
            return b;
        }
    }
}
