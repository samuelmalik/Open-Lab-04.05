﻿using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string newString = "";
            for (int i = 0; i < orig.Length; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    newString += orig[i];
                }
            }
            return newString;
        }
    }
}
