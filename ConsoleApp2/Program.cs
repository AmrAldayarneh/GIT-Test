﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new branch 1
            //new branch 2
           
            List<String> firstlist = new List<String>();

            // Adding elements to List
            firstlist.Add("Geeks");
            firstlist.Add("For");
            firstlist.Add("Geeks");
            firstlist.Add("ajava");
            firstlist.Add("c#");
            firstlist.Add("Tutorials");
            firstlist.Add("GeeksforGeeksjava");

            Console.Write(firstlist.Contains("Java", StringComparer.OrdinalIgnoreCase)); // Should be the whole word
            //Console.Write(firstlist.Any(a => a.Contains("Java",StringComparison.OrdinalIgnoreCase))); // Should not be the whole word

            //aaa
        }
    }
}
