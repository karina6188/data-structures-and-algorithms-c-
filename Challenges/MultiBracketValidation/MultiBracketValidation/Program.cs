using System;
using System.Collections;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to validate if brackets are balanced: ");
            string input = Console.ReadLine();
            MultiBracketValidation(input);
        }
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack();
            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == '(' || characters[i] == '[' || characters[i] == '{')
                {
                    stack.Push(characters[i]);
                }
                else
                {

                }
            }

            return true;
        }

        //        function peek(stack)
        //        {
        //            let top = stack[stack.length - 1];
        //            return top
        //}
        //        function isBalanced(string)
        //        {
        //            let leftCharacterStack = [];
        //            let splitString = string.split('');
        //            for (let i = 0; i < splitString.length; i++)
        //            {
        //                if (splitString[i] === '(' || splitString[i] === '{' || splitString[i] === '[')
        //                {
        //                    leftCharacterStack.push(splitString[i]);
        //                }
        //                else
        //                {
        //                    if (splitString[i] === ')' && peek(leftCharacterStack) != '(' ||
        //                        splitString[i] === '}' && peek(leftCharacterStack) != '{' ||
        //                        splitString[i] === ']' && peek(leftCharacterStack) != '[')
        //                    {
        //                        console.log('false');
        //                        return false
        //                    }
        //                    leftCharacterStack.pop();
        //                }
        //            }
        //            if (leftCharacterStack.length === 0)
        //            {
        //                console.log('true');
        //                return true
        //            }
        //        }
        //        isBalanced('{{[]}}')
        //        isBalanced('{}{}[{]')
        //        isBalanced('[[{}]]')
    }
}
