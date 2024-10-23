using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ1
{
    internal class DescriptionController
    {
        public List<int> progress { get; }

        TestDescription testDescription;
        int[] scores;
        
        public DescriptionController(TestDescription testDescription, int[] scores)
        {
            this.testDescription = testDescription;
            this.scores = scores;
            progress = new List<int>();
            calculateProgress();
        }

        public void calculateProgress()
        {

            List<int> numbers = new List<int>();
            List<int> maxNumbers = new List<int>();
            foreach (Factor factor in testDescription.fastors)
            {
                int n = 0;
                
                foreach(int key in factor.answers.Keys)
                {
                    if (scores[key-1].Equals(factor.answers[key]))
                    {
                        n++;
                    }
                
                }

                maxNumbers.Add(factor.answers.Count);
                numbers.Add(n);
            }


            for (int i = 0; i < numbers.Count;  i++)
            {
                int percent = numbers[i]*100/maxNumbers[i];
                progress.Add(percent);

            }
        }


    }
}
