using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace FFCG.G4.StringCalculator
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
        public void term_plus_term_equals_sum()
        {
            string numbers = "1\n2,3 and 4";
            int expected = 10;
            var actual = _stringCalculator.addNumbers(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void empty_string_equals_the_sum_zero()
        {
            string numbers = "";
            int expected = 0;
            var actual = _stringCalculator.addNumbers(numbers);
            Assert.AreEqual(expected, actual);
        }

    }
}
