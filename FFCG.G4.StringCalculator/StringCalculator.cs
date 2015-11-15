using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FFCG.G4.StringCalculator
{
    public class StringCalculator
    {
        private List<int> listOfNumbers;
        private int result;

        public int addNumbers(string input)
        {
            bool isInputNullOrEmpty = checkifInputIsNullOrEmpty(input);

            if (isInputNullOrEmpty)
            {
                result = inputIsNullOrEmptyReturnZero();
            }

            else
            {
            string[] numbers = getNumbersFromInput(input);
            List<int> numbersInList = putNumbersFromInputInList(numbers);
            result = getSumOfNumbers(numbersInList);
            }
            return result;
        }

        private string[] getNumbersFromInput(string input)
        {
            string[] numbers = Regex.Split(input, @"\D+");
            return numbers;
        }

        private List<int> putNumbersFromInputInList(string[] numbers)
        {
            listOfNumbers = new List<int>();
            foreach (string number in numbers)
            {
                int numberInList = int.Parse(number);
                listOfNumbers.Add(numberInList);
            }
            return listOfNumbers;
        }

        private int getSumOfNumbers(List<int> numbersInList)
        {
            return numbersInList.Sum();
        }

        private bool checkifInputIsNullOrEmpty(string input)
        {
            return String.IsNullOrEmpty(input);
        }

        private int inputIsNullOrEmptyReturnZero()
        {
            return 0;
        }
    }
}
