using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Extra_exercises_5___Generic_lists
{
    class Filter
    {
        /*public List<int> GetNumbersBeetween5and10(List<int> num1)
        {
            List<int> getNumber = new List<int>();
            foreach (var number in num1)
            {
                if (number >= 5 && number <= 10)
                {
                    getNumber.Add(number);
                }
            }
            return getNumber;
        }

        public int GetMaxValue(List<int> num1)
        {


            var maxValue = int.MinValue;

            foreach (var number in num1)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            return maxValue;

        }


        public int Sum(List<int> num1)
        {
            var summa = 0;

            foreach (var number in num1)
            {
                summa = sum + number;
            }
            return summa;
        }
         */   
        public List <int> TakeFive(List<int> num1)
        {
            List<int> list = new List<int>();
            
            var listOfFive = 0;

            foreach (var item in num1)
            {
                list.Add(item);
                listOfFive++;

                if (listOfFive == 5)
                {
                    break;
                }
                
            }
            return list;
        }

        public List<int> RemoveDuplicates (List<int> num1)
        {
            List<int> list = new List<int>();


            foreach (var item in num1)
            {
                if(list.Contains(item) == false)
                {
                    list.Add(item);
                }
            }
            return list;

        }
        public List<int> GetCommon (List<int> num1, List<int> num2)
        {
            List<int> list = new List<int>();

            foreach (var item in num1)
            {
                if (num2.Contains(item))
                {
                    list.Add(item);
                }

            }
            return list;
            
        }
        public List<int> GetDifferences(List<int> num1, List<int> num2)
        {
            List<int> list = new List<int>();

            foreach (var item in num1)
            {
                if (!num2.Contains(item))
                {
                    list.Add(item);
                }

            }
            return list;
        }
    }

}


