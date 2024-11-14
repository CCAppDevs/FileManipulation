﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    public class FileLogger : ILogger
    {
        public string Identifier { get; set; }

        public FileLogger(string id)
        {
            Identifier = id;
        }


        public void Error(string message)
        {
            Console.WriteLine($"[{Identifier}] - FileERROR - {message}");
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{ Identifier }] - FileLOG - { message }");

            string docPath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");

            File.AppendAllText(docPath, $"[{Identifier}] - FileLOG - {message}\n");
        }
    }
}
