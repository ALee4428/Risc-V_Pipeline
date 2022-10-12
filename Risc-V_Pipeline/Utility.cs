using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risc_V_Pipeline
{
    class Utility
    {
        

        /// <summary>
        /// Get command line input one line at a time and store it in a list of strings
        /// </summary>
        public static List<string> GetInput()
        {
            string line;
            List<string> lines = new List<string>();

            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                lines.Add(line);
            }
            return lines;
        }



        /// <summary>
        /// Create a list of Instruction objects
        /// </summary>
        /// <param name="l">list of strings</param>
        /// <returns>list of Instruction objects</returns>
        public static List<Instruction> CreateInstructions(List<string> l) 
        {
            List<Instruction> instructions = new List<Instruction>();
            foreach (string line in l)
            {
                string t = String.Concat(line.Split(','));
                string[] strings = t.Split(' ');
                instructions.Add(new Instruction(strings));
            }


            Console.WriteLine("\n===Testing===");
            foreach (Instruction i in instructions)
            {
                Console.WriteLine("{0} {1} {2} {3}", i.op, i.dr, i.sr1, i.sr2);
            }
            Console.WriteLine("===Testing===");

            return instructions;
        }



        /// <summary>
        /// Prints the simulation results
        /// </summary>
        public static void printP(List<string> l)
        {
            Console.WriteLine("\n\nConfiguration \n{0}\n" +
                              "buffers\n\n" +
                              "fetch: \n" +
                              "memory: \n" +
                              "ints: \n" +
                              "fp adds: \n" +
                              "fp muls: \n\n" +
                              "latencies\n\n" +
                              "memory: \n" +
                              "ints: \n" +
                              "fp_add: \n" +
                              "fp_mul: \n" +
                              "fp_div: \n\n",
                               new string('-', 13));
            Console.WriteLine("{0}Static Pipeline Simulation{1}", 
                              new string(' ', 27), new string(' ', 27));
            Console.WriteLine(new string('-', 80));
            //Console.WriteLine("\n     Instruction      " +
            //                  " Fetch    " +
            //                   "Read    " +
            //                  "Execute   " +
            //                  "Memory   " +
            //                  "Write");
            //Console.WriteLine("{0} {1} {2} {3} {4} {5}", 
            //                  new string('-', 21), new string('-', 8), 
            //                  new string('-', 8), new string('-',8), 
            //                  new string('-', 8), new string('-', 8));
            //foreach (string s in l)
            //{
            //    Console.WriteLine("{0}", s);
            //}

        }

    }
}
