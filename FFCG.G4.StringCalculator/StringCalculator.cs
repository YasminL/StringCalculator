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

        public int AddNumbers(string input)
        {
            bool isInputNullOrEmpty = CheckifInputIsNullOrEmpty(input);

            if (isInputNullOrEmpty)
            {
                result = InputIsNullOrEmptyReturnZero();
            }

            else
            {
            string[] numbers = GetNumbersFromInput(input);
            List<int> numbersInList = PutNumbersFromInputInList(numbers);
            result = GetSumOfNumbers(numbersInList);
            }
            return result;
        }

        private string[] GetNumbersFromInput(string input)
        {
            string[] numbers = Regex.Split(input, @"\D+");
            return numbers;
        }

        private List<int> PutNumbersFromInputInList(string[] numbers)
        {
            listOfNumbers = new List<int>();
            foreach (string number in numbers)
            {
                int numberInList = int.Parse(number);
                listOfNumbers.Add(numberInList);
            }
            return listOfNumbers;
        }

        private int GetSumOfNumbers(List<int> numbersInList)
        {
            return numbersInList.Sum();
        }

        private bool CheckifInputIsNullOrEmpty(string input)
        {
            return String.IsNullOrEmpty(input);
        }

        private int InputIsNullOrEmptyReturnZero()
        {
            return 0;
        }
    }
}
