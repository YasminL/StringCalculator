using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCG.G4.StringCalculator
{
    class Addition
    {
        private List<int> listOfNumbers;
        private int sumOfNumbers;

        public int GetSumOfNumbers(string[] numbers)
        {
            List<int> numbersInList = PutNumbersInList(numbers);
            sumOfNumbers = numbersInList.Sum();
            return sumOfNumbers;
        }

        private List<int> PutNumbersInList(string[] numbers)
        {
            listOfNumbers = new List<int>();

            foreach (string number in numbers)
            {
                int numberInList = int.Parse(number);
                listOfNumbers.Add(numberInList);
            }
            return listOfNumbers;
        }

    }
}
