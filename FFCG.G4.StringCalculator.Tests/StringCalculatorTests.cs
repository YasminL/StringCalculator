using NUnit.Framework;

//String Calculator
//1. Create a simple String calculator with a method int Add(string numbers)
//2. The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
//3. Start with the simplest test case of an empty string and move to 1 and two numbers
//4. Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
//5. Remember to refactor after each passing test
//6. Allow the Add method to handle an unknown amount of numbers
//7. Allow the Add method to handle new lines between numbers (instead of commas).
//8. the following input is ok: “1\n2,3” (will equal 6)
//9. the following input is NOT ok: “1,\n” (not need to prove it - just clarifying) 
//10. To change a delimiter, the beginning of the string will contain a separate line that looks like this:
// "//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’.

namespace FFCG.G4.StringCalculator.Tests
{
    [TestFixture]
    class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        [TestCase(10, "1\n2,3 and 4")]
        [TestCase(10, "1 and 2, 7")]
        public void Term_Plus_Term_Equals_Sum(int expected, string numbers)
        {
            var actual = _stringCalculator.AddNumbers(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Empty_String_Equals_The_Sum_Zero()
        {
            const string numbers = "";
            const int expected = 0;
            var actual = _stringCalculator.AddNumbers(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(3,"//;\n1;2")]
        [TestCase(3, "//A\n1A2")]
        public void Double_Backslash_At_Beginning_Of_Input_Changes_Deliminator_After_Next_Line_(int expected, string numbersWithDoubleBackslashAtBeginning)
        {
            var actual = _stringCalculator.AddNumbers(numbersWithDoubleBackslashAtBeginning);
            Assert.AreEqual(expected, actual);
        }


    }
}
