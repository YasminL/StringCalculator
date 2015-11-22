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
        private Addition _addition;

        public int PutNumbersInList(string input)
        {
            bool isInputNullOrEmpty = CheckifInputIsNullOrEmpty(input);

            if (isInputNullOrEmpty)
            {
                result = InputIsNullOrEmptyReturnZero();
            }

            else
            {
            string[] numbers = GetNumbersFromInput(input);
            result = AddNumbers(numbers);
            }

            return result;
        }

        private string[] GetNumbersFromInput(string input)
        {
            string[] numbers = Regex.Split(input, @"\D+");
            return numbers;
        }

        private bool CheckifInputIsNullOrEmpty(string input)
        {
            return String.IsNullOrEmpty(input);
        }

        private int InputIsNullOrEmptyReturnZero()
        {
            return 0;
        }

        private int AddNumbers(string[] numbers)
        {
            _addition = new Addition();
            return _addition.GetSumOfNumbers(numbers);
        }
    }
}
