using System;
using System.Text.RegularExpressions;

namespace EntityOperations.Classes
{
    public class Increment
    {
        public static string AlphaNumericValue(string value) 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            //We only allow Characters a-b, A-Z, 0-9
            if (Regex.IsMatch(value, "^[a-zA-Z0-9]+$") == false)
            {
                throw new Exception("Invalid Character: Must be a-Z or 0-9");
            }

            //We work with each Character so it's best to convert the string to a char array for incrementing
            var characterArray = value.ToCharArray();

            //So what we do here is step backwards through the Characters and increment the first one we can. 
            for (var charIndex = characterArray.Length - 1; charIndex >= 0; charIndex--)
            {
                //Converts the Character to it's ASCII value
                var charValue = Convert.ToInt32(characterArray[charIndex]);

                //We only Increment this Character Position, if it is not already at it's Max value (Z = 90, z = 122, 57 = 9)
                if (charValue != 57 && charValue != 90 && charValue != 122)
                {
                    characterArray[charIndex]++;

                    //Now that we have Incremented the Character, we "reset" all the values to the right of it
                    for (int myResetIndex = charIndex + 1; myResetIndex < characterArray.Length; myResetIndex++)
                    {
                        charValue = Convert.ToInt32(characterArray[myResetIndex]);
                        if (charValue >= 65 && charValue <= 90)
                        {
                            characterArray[myResetIndex] = 'A';
                        }
                        else if (charValue >= 97 && charValue <= 122)
                        {
                            characterArray[myResetIndex] = 'a';
                        }
                        else if (charValue >= 48 && charValue <= 57)
                        {
                            characterArray[myResetIndex] = '0';
                        }
                    }

                    //Now we just return an new Value
                    return new string(characterArray);
                }
            }

            //If we got through the Character Loop and were not able to increment anything, we return a NULL. 
            return null;
        }
    }
}
