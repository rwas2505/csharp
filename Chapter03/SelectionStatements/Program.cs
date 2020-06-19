﻿using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            //add and remove the "" to change the behavior
            object o = 3;

            int j = 4;

            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

            A_label:

                string path = "/Users/ryan/desktop/csharp/Chapter03";

                Stream s = File.Open(
                    Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

                string message = string.Empty;

                switch (s)
                {
                    case FileStream writeableFile when s.CanWrite:
                        message = "The stream is a file that I can write to.";
                        break;
                    case FileStream readOnlyFile:
                        message = "The stream is a read-only file.";
                        break;
                    case MemoryStream memoryStream:
                        message = "The stream is a memory address";
                        break;
                    default: //always evaluated last despite its current position 
                        message = "The stream is some other type.";
                        break;
                    case null:
                        message = "The stream is null.";
                        break;
                }

                // WriteLine(message);

                message = s switch
                {
                    FileStream writeableFile when s.CanWrite
                        => "The stream is a file that I can write to.",
                    FileStream readOnlyFile
                        => "The stream is a read-only file.",
                    MemoryStream ms
                        => "The stream is a memory address.",
                    null
                        => "The stream is null.",
                    _
                        => "The stream is some other type."  
                };
                    WriteLine(message);
        }
    }
}
