using System;
using System.IO;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("../../copyMe.png", FileMode.Open);

            FileStream fileCopy = new FileStream("../../copyMe2.png", FileMode.CreateNew);
            file.CopyTo(fileCopy);
        }
    }
}
