using System;
using CommandLine;
using System.Collections.Generic;

namespace CmdLineParserTest
{

    class Options
    {
        [Option('v', "verbose", Required = true, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('r', "read", Required = true, HelpText = "Input files to be processed.")]
        public IEnumerable<string> InputFiles { get; set; }

        //[Option("stdin",
        //  Default = false, 
        //    HelpText = "Read from stdin")]
        //public bool stdin { get; set; }

        //[Value(0, MetaName = "offset", HelpText = "File offset.")]
        //public long? Offset { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                string[] splittedAnswer = Console.ReadLine().Split();
                Parser.Default.ParseArguments<Options>(splittedAnswer)
                   .WithParsed<Options>(o =>
                   {
                       if (o.Verbose)
                       {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                       }
                       else
                       {
                           Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example!");
                       }
                   });
            }

            
        }
    }
}
