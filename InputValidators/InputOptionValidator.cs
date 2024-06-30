using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Errors;

namespace ConsoleApp1.InputValidators
{
    internal class InputOptionValidator
    {
        /// <summary>
        /// Receives an input and validates if it corresponds to with the asked input. After checking it's validity, controls if it corresponds to one of the available menu options. If it is, it returns it as an option. If it isn't, returns an error
        /// message and asks for a diferent input.
        /// </summary>
        /// <param name="optionAmount"></param>
        /// <returns></returns>
        public static int ValidateOption(int optionAmount)
        {
            int selectedOption;

            // Validates the input in here
            if (Int32.TryParse(Console.ReadLine(), out selectedOption))
            {
                if (OptionValidator.ValidateOption(selectedOption, optionAmount))
                {
                    return selectedOption;
                }
            }
            else
            {
                InvalidInput.Print();
                return -1; // Return -1 to indicate invalid option
            }

            return -1; // Return -1 to indicate invalid option
        }
    }
}
