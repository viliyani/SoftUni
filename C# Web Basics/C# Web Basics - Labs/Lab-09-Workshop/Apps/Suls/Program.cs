﻿using SUS.MvcFramework;
using System;
using System.Threading.Tasks;

namespace Suls
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateHostAsync(new Startup(), 80);
        }
    }
}
