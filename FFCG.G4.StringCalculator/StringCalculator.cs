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
        private int _result;
        private Addition _addition;
        private char _deliminator;
        private string[] _numbers;

        public int AddNumbers(string input)
        {
            bool isInputNullOrEmpty = CheckifInputIsNullOrEmpty(input);
            
            if (isInputNullOrEmpty)
            {
                _result = InputIsNullOrEmptyReturnZero();
            }

            else
            {
                bool isTheDeliminatorChanged = CheckIfBeginningOfInputHasDoubleSlashAndLineSeparator(input);

                if (isTheDeliminatorChanged)
                {
                    _deliminator = GetDeliminator(input);
                    _numbers = GetNumbersFromInputWithDeliminator(input, _deliminator);

                }

                else
                {
                    _numbers = GetNumbersFromInput(input);
                    _result = AddNumbers(_numbers);
                }
            }

            return _result;
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

        private bool CheckIfBeginningOfInputHasDoubleSlashAndLineSeparator(string input)
        {
            char deliminator = input[2];
            bool inputHasDoubleSlashInBeginning = input.Trim().StartsWith("//" + deliminator + "\n");
            return inputHasDoubleSlashInBeginning;
        }

        private char GetDeliminator(string input)
        {
            char deliminator = input[2];
            return deliminator;
        }

        private string[] GetNumbersFromInputWithDeliminator(string input, char deliminator)
        {
            string numbersAfterNextLine = input.Substring(input.Trim().LastIndexOf("\n" + 1));
            string[] numbers = numbersAfterNextLine.Split(deliminator);
            return numbers;
        }

        private int AddNumbers(string[] numbers)
        {
            _addition = new Addition();
            return _addition.GetSumOfNumbers(numbers);
        }
    }
}
