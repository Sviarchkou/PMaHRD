using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text.Json;
using System.Threading.Tasks;

namespace ПЗ1
{
    public class Test
    {
        public string path;
        public string name { get; set; }

    }

    public class MultyOptionalTests : Test
    {
        public MultyOptionalTests(string path) {

            this.path = path;
            string[] str;
            this.name = (str = path.Split('\\'))[str.Length - 1];
            addQuestions();
            addOptions();
            addResult();
        }

        public List<string> questions = new List<string>();
        public List<List<Option>> options;
        public List<Result> result = new List<Result>();
       
        private void addQuestions()
        {
            StreamReader streamReader = File.OpenText(path + "/questions.json.txt");
            string json = streamReader.ReadToEnd();
            questions = JsonSerializer.Deserialize<List<string>>(json);    
        }
        private void addResult()
        {
            StreamReader streamReader = File.OpenText(path + "/results.json.txt");
            string json = streamReader.ReadToEnd();
            result = JsonSerializer.Deserialize<List<Result>>(json);
        }
        private void addOptions()
        {

            StreamReader streamReader = File.OpenText(path + "/options.json.txt");
            string json = streamReader.ReadToEnd();
            options = JsonSerializer.Deserialize<List<List<Option>>>(json);
        }
    }

    public class Option {
        public string strOption { get; set; }
        public int value { get; set; }
        public Option(int value, string strOption)
        {
            this.value = value;
            this.strOption = strOption;
        }
    }

    public class TestsYN : Test
    {

        public List<string> questions = new List<string>();
        public List<Result> result = new List<Result>();
        public TestDescription testDescription;
        public TestsYN(string path)
        {
            this.path = path;
            string[] str;
            this.name = (str = path.Split('\\'))[str.Length - 1];
            addQuestions();
            addResult();
            if (File.Exists(path + "/description.json.txt"))
            {
                testDescription = new TestDescription(this.path);
            }
        }
        private void addQuestions()
        {
            StreamReader streamReader = File.OpenText(path + "/questions.json.txt");
            string json = streamReader.ReadToEnd();
            questions = JsonSerializer.Deserialize<List<string>>(json);

        }
        private void addResult()
        {
            StreamReader streamReader = File.OpenText(path + "/results.json.txt");
            string json = streamReader.ReadToEnd();
            result = JsonSerializer.Deserialize<List<Result>>(json);

        }
    }

    public class Result
    {
        public Result(int score, string strResult)
        {
            this.score = score;
            this.strResult = strResult;
        }
        public int score { get; set; }
        public string strResult { get; set; }

    }

}
