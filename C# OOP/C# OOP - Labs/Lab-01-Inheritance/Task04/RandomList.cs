using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            var rand = new Random();
            int idx = rand.Next(0, this.Count - 1);

            string result = base[idx];

            base.RemoveAt(idx);

            return result;
        }


    }
}
