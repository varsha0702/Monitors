using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            const string data = @"players.txt";//input text file
            const string result = @"Result.txt";//result text file
            if (File.Exists(result)) File.Delete(result);

            const int max1 = 100;//max lenght of the array1
            Monitor[] Mon = new Monitor[max1];//array of objects
            int n1;//real length of arrays
            //read function for the array===================================================================================
            Read(data, Mon, out n1);
            //write array on console======================================================================================
            write(Mon, "initial data", n1);
            //taking input from user
            Console.WriteLine("Enter the size: ");
            int sizereq = int.Parse(Console.ReadLine());
            //Checking for monitors bigger than predefined size
            int n2;
            check(sizereq, Mon, n1,out n2);
            Console.WriteLine("Number of monitors bigger or equal to given size= {0}", n2);

            Console.ReadKey();
        }
        //reading the data file and storing the values in the variables declared in the class
        public static void Read(string data, Monitor[] Mon, out int i)
        {
            using (StreamReader reader = new StreamReader(data))
            {
                string line;
                i = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] Parts = line.Split(';');
                    Mon[i] = new Monitor(Parts[0], int.Parse(Parts[1]), int.Parse(Parts[2]));
                    i++;
                }

            }
        }
        //writing the data from in the output file================================================================================
        static void write(Monitor[] B, string title, int number)
        {
            Console.WriteLine(title);
            const string top = "--------------------------------------\r\n"
                                 + "| Manufacturer |    size  |   Year    |\r\n" +
                                   "|--------------|----------|-----------|";
            Console.WriteLine(top);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(B[i].ToString());
            }
            Console.WriteLine("======================================\r\n");
        }
        //function to check monitors bigger than size given by user
        static void check(int sizereq,Monitor[] mon,int number,out int n)
        {
            n = 0;
            for (int i = 0; i < number; i++)
            {
                if (sizereq <= mon[i].size)
                    n++;
            }
        }
    
    }
}
    

