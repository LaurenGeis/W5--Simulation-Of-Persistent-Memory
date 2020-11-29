using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MemoryStream memStream = new MemoryStream(100)) {
            memStream.Write(firstString, 0 , firstString.Length);
            count = 0;
            while(count < secondString.Length)


            {
                memStream.WriteByte(secondString[count++]);
            }
            var inputPutDataFile = @"C:\Users\Lauren\Desktop\inputdata.txt";
            var truthTableInputs = Storage.ReadTruthTableData(inputPutDataFile);
            string text = System.IO.File.ReadAllText(@"C:\Users\Lauren\Desktop\inputdata.txt");


             {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null) {
                Console.WriteLine(ln);
                counter++;
}



            foreach( var input in truthTableInputs)
            {
                Console.WriteLine($"{input.A}, {input.X}, {input.D}, {input.R}");
            }

        }

      

        private static void Conversion()
        {
            var value = "1";
            var convertedValue = Utility.ConvertToBoolean(value);

            Console.WriteLine($"Conversion from string {value} to binary {convertedValue}");

           
            var bit = Utility.ConvertToBit(convertedValue);
            Console.WriteLine($"Conversion from Boolean {convertedValue} to Bit {bit}");

        }

        private static void SimulateMemory()
        {
            var a = 100;
            var storedValue = Storage.ReadData();
            if (storedValue > 0)
            {
                a = storedValue;
                Console.WriteLine($"Stored Value {a}");
                Console.WriteLine($"Press Any Key to continue");
                Console.ReadLine();
            }
            for (int i = storedValue; i < 10000; i++)
            {
                Storage.SaveData(a);
                Console.WriteLine($"Print Current Stored Value {i}");
                a = i;
            }

            Console.WriteLine($"Stored Value {a}");
        }
    }
}
