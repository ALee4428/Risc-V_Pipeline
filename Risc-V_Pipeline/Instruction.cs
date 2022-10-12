///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Risc-V Pipeline
//	File Name:         Instruction.cs
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
    internal class Instruction
    {
        // may add cycle and string
        public string op;
        public string dr;
        public string sr1;
        public string sr2;

        public Instruction(string[] s)
        {
            this.op = s[0];
            this.dr = s[1];
            this.sr1 = s[2];
            this.sr2 = s[3];

        }






    }
}
