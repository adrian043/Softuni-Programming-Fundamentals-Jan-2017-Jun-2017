﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FolderSize
{
    class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
            Console.WriteLine(sum);
        }
    }
}