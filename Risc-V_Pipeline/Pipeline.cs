///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Risc-V Pipeline
//	File Name:         Pipeline.cs
//	Description:       
//	Course:            CSCI 3160 - Computer Systems	
//	Author:            Amanda Lee, leea06@etsu.edu, Undergrad, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, October 5th, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risc_V_Pipeline
{
    internal class Pipeline
    {

        

        
        public static void Fetch()
        {
            //Instruction fetchedI = i.Dequeue();
            //fetchedI.cycles[0] = counter++;
            //iList.Add(fetchedI);
            // add 1 to cycle at correct index
            //return fetchedI;
        }



        public static void RunPipeline(List<Instruction> i, List<string> l)
        {
            Utility.printP(l);
        }


    }
}
