using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Monitor
    {
        //variables declaration======================================================================================= 

        public string manufacturer { get; set; }//variables to store manufacturer name
        public int size { get; set; }//variable to store the size of monitor
        public int year { get; set; }//variable to store the year of manufacture

        //constructos=================================================================================================

        public Monitor(string manufacturer, int n, int year)//Constructor with parameters
        {
            this.manufacturer = manufacturer;
            size = n;
            this.year = year;
        }
        public Monitor()//constructor without parameters
        {
           manufacturer = "";size=0;year=0;

        }

        //override method============================================================================================

        public override string ToString()//ToString method to print the output file
        {
            string line;
            line = string.Format("{0, -9} | {1, 9} | {2,9}",
            manufacturer,size,year);
            return line;
        }
    }
}
