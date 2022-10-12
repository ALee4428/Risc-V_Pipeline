///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Risc-V Pipeline
//	File Name:         Driver.cs
//	Description:       
//	Course:            CSCI 3160 - Computer Systems	
//	Author:            Amanda Lee, leea06@etsu.edu, Undergrad, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, October 5th, 2022
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Risc_V_Pipeline
{
    internal class Driver
    {
        static void Main()
        {
            List<string> list = Utility.GetInput(); ;
            List<Instruction> i = Utility.CreateInstructions(list);



            //Pipeline.RunPipeline(i, list);
            
        }
    }
}
