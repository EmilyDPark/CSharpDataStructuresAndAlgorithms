using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Expression
    {
        private List<char> leftBrackets = new List<char> { '(', '<', '[', '{' };
        private List<char> rightBrackets = new List<char> { ')', '>', ']', '}' };

        public bool IsBalanced(string input)
        {
            if (input == null)
                throw new InvalidOperationException();

            var stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (IsLeftBracket(ch))
                    stack.Push(ch);

                if (IsRightBracket(ch))
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (!BracketsMatch(top, ch)) return false;
                }
            }

            return stack.Count == 0;
        } // IsBalanced method

        private bool IsLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        } // IsLeftBracket method

        private bool IsRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        } // IsRightBracket method

        private bool BracketsMatch(char left, char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        } // BracketsMatch method

    } // Expression class

} // Stacks namespace
