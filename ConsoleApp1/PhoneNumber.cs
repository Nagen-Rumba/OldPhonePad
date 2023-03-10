public class PhoneNumber
{


    // Define a dictionary to map numbers to letters

    private static readonly Dictionary<string, string> NumberToLetterMap = new Dictionary<string, string> {
        {"1", "&"},
        {"11", "'"},
        {"111", "("},
        {"2", "A"},
        {"22", "B"},
        {"222", "C"},
        {"3", "D"},
        {"33", "E"},
        {"333", "F"},
        {"4", "G"},
        {"44", "H"},
        {"444", "I"},
        {"5", "J"},
        {"55", "K"},
        {"555", "L"},
        {"6", "M"},
        {"66", "N"},
        {"666", "O"},
        {"7", "P"},
        {"77", "Q"},
        {"777", "R"},
        {"7777", "S"},
        {"8", "T"},
        {"88", "U"},
        {"888", "V"},
        {"9", "W"},
        {"99", "X"},
        {"999", "Y"},
        {"9999", "Z"},
        {"0", " " },
        {"*", "*" },
        {"#", "" }

    };


    //This function returns the numbers in sequence.
    public static string checkSequence(string input)
    {
        string outputText = "";
        string result = "";
        int i = 0;


        while (input.Count() > 1 && i < input.Count())
        {
            for (int j = i; j < input.Count(); j++)
            {
                //If the letter are same the following Checks are performed
                if (input[i] == input[j])
                {
                    // Check if the length of the letters in under 3 for all numbers except 7 and 9
                    if (outputText.Count() < 3 && !(outputText.Contains("9") || outputText.Contains("7")))
                    {
                        outputText += input[i].ToString();
                    }
                    // Check if the length of the letters in under 4 for all numbers 7 and 9 since they have 'pqrs' and 'wxyz' respectively
                    else if (outputText.Count() < 4 && (outputText.Contains("9") || outputText.Contains("7")))
                    {
                        outputText += input[i];
                    }

                    // If the above checks fail then we reset the letter to the initial character
                    else
                    {
                        outputText = input[i].ToString();
                    }
                }
                //if the letters are not the same the following code adds it to the result
                else
                {
                    //Any invalid characters are ignored
                    result += NumberToLetterMap.ContainsKey(outputText) ? NumberToLetterMap[outputText.Trim()] : "";
                    i = j;
                    j--;
                    outputText = "";
                }

                //CHECKS FOR *, " ", # symbols which perform delete, 1 sec wait, send respectively -------------------
                if (input[j] == '*' && result.Count() > 0)
                {
                    result = result.Remove(result.Length - 1);
                }
                if (input[j] == ' ')
                {
                    outputText = "";
                    i++;
                }
                if (input[j] == '#')
                {
                    return result;
                }
                //End of check -------------------
            }
        }


        return result;
    }
}
