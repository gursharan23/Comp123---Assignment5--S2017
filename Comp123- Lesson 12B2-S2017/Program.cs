﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Name : Gursharan Singh
 *Date : 3rd August ,2017
 *Description : This is the calculator demo
 *Version : 1.0 Created the program class
 *Student ID : 300931676
 */ 
namespace Comp123__Lesson_12B2_S2017
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
