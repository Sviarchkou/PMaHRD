using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ПЗ1
{
    public class TestDescription
    {
        string path;
        public List<Factor> fastors { get; set; }

        public TestDescription(string path)
        { 
            this.path = path;
            addFactorsDictiption();
        }
        private void addFactorsDictiption()
        {
            StreamReader streamReader = File.OpenText(path + "/description.json.txt");
            string json = streamReader.ReadToEnd();
            fastors = JsonSerializer.Deserialize<List<Factor>>(json);
        }
        
    }

    public class Factor
    {
        public string name { get; set; }
        public List<string> description { get; set; }
        public Dictionary<int, int> answers { get; set; }
        public Factor()
        {
            description = new List<string>();
            answers = new Dictionary<int, int>();
        }

    }

}
