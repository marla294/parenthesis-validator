// See https://aka.ms/new-console-template for more information
using System;

namespace ParenthesesValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the code you would like to validate on the next line");

            var codeToValidate = Console.ReadLine();
            Stack<Char> stack = new System.Collections.Generic.Stack<Char>();

            for (var i = 0; i < codeToValidate?.Length; i++) {
              var current = codeToValidate[i];

              if (current == '(') {
                stack.Push('(');
              }

              if (current == ')') {
                if (stack.Count > 0 && !stack.Contains(')')) {
                  stack.Pop();
                }
                else {
                  stack.Push(')');
                }
              }
            }

            if (stack.Count == 0) {
              Console.WriteLine("The parenthesis in the code you entered are valid");
            }

            else {
              Console.WriteLine("The parenthesis in the code you entered are INvalid");
            }
        }
    }
}