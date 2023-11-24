﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolstykhVS.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {   
           
                string strX = File.ReadAllText(path);
                double x = Convert.ToDouble(strX);
                double a1 = Math.Pow(x, 3);
                double a2 = x * 1.2;
                double rez = a1 * a2 + 2; 
                return Math.Round(rez,3);
            

        }
    }
}
