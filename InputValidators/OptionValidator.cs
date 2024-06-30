using ConsoleApp1.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InputValidators
{
    internal class OptionValidator
    {
        /// <summary>
        /// Checks if the selected option is available in the menus. Returns and error message if it isn't.
        /// </summary>
        /// <param name="option"></param>
        /// <param name="optionAmount"></param>
        /// <returns></returns>
        public static bool ValidateOption(int choosenOption, int optionAmount)
        {

            switch (optionAmount)
            {
                case 2:

                    if (choosenOption == 1 || choosenOption == 2)
                        return true;

                    break;

                case 3:

                    if (choosenOption == 0 || choosenOption == 1 || choosenOption == 2)
                        return true;

                    break;
            }

            UnavailableOption.Print();
            return false;

        }
    }
}
