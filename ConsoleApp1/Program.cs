using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

/* Copyright (C) 2017 Andrew C. Estes - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the General Public License.  I, Andrew C. Estes 
 * will retrain all rights where written permission or royalties
 * have not been sought.
 *
 * You should have received a copy of the General Public License with
 * this project. 
 */

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // The Length property is used to obtain the length of the array. 
            // Notice that Length is a read-only property:
            //Console.WriteLine("Number of command line parameters = {0}",
            //   args.Length);
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}

            ConsoleMainMenu cf = new ConsoleMainMenu();
            cf.MainMenu();

        }
    }
}
