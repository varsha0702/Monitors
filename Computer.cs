using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Computer
    {
        //variables declaration======================================================================================= 

        public string manufacturer { get; set; }//variables to store manufacturer name
        public double CPU_frequency { get; set; }//variable to store the size of monitor
        public int memory { get; set; }//variable to store the year of manufacture

        //constructos=================================================================================================

        public Computer(string manufacturer, double CPU_frequency, int memory)//Constructor with parameters
        {
            this.manufacturer = manufacturer;
            this.CPU_frequency = CPU_frequency;
            this.memory = memory;
        }
        public Computer()//constructor without parameters
        {
            manufacturer = ""; CPU_frequency = 0.0; memory = 0;

        }
    }
}
