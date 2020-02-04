using System;
using System.Collections;

namespace MultiBracketValidations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to validate if brackets are balanced: ");
            string input = Console.ReadLine();
            MultiBracketValidation(input);
            if (MultiBracketValidation(input))
            {
                Console.WriteLine("The string has balanced brackets.");
            }
            else
            {
                Console.WriteLine("The string does not have balanced brackets.");
            }
        }
        /// <summary>
        /// First, create a new empty stack. Then split the string input into a char array.
        /// Use for loop to loop through each character and check if it is one the of opening brackets.
        /// If yes, add that opening bracket into the stack then move to the next character in the for loop.
        /// Keep adding the opening brackets into the stack when you find it.
        /// If you find one of the closing brackets, check to see if it matches with the last opening bracket in the stack.
        /// If no, the string input does not have balanced brackets. If yes, pop the opening bracket from the stack.
        /// Keep checking the last opening bracket in the stack every time you find a closing bracket in the for loop until you loop through all the characters in the char array.
        /// Then check if there is any opening brackets left in the stack. If yes, the string does not have balanced brackets. If not, the string has balanced brackets.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();
            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == '(' || characters[i] == '[' || characters[i] == '{')
                {
                    stack.Push(characters[i]);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        char lastOnStack = stack.Peek().ToString()[0];
                        if (characters[i] == ')' && lastOnStack != '(' ||
                           characters[i] == ']' && lastOnStack != '[' ||
                           characters[i] == '}' && lastOnStack != '{')
                        {
                            return false;
                        }
                        if (characters[i] == ')' && lastOnStack == '(' ||
                            characters[i] == ']' && lastOnStack == '[' ||
                            characters[i] == '}' && lastOnStack == '{')
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
