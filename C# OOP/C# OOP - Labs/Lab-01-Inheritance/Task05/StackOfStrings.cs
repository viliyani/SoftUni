﻿using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {

        public bool IsEmpty()
        {
            return base.Count == 0;
        }

        public Stack<string> AddRange(List<string> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                base.Push(strings[i]);
            }

            return this;
        }

    }
}
