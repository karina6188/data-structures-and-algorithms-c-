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
