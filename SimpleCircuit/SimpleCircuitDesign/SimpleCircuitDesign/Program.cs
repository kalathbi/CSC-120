using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCircuitDesign
{
    class Program

    {
       
        static void Main(string[] args)
        {
            double voltage;
            Console.WriteLine("Enter a voltage:");
            double temp_voltage = Convert.ToInt32(Console.ReadLine());

            for (double i = 0; i <= temp_voltage; i += 0.6)
            {
                


                voltage = i;

                double voltage1 = 0, voltage2 =0, voltage3=0, voltage4 =0;

                double current1 = 0, current2 = 0, current3 = 0, current4 = 0;

                

                double resistance1 = 4000;
                double resistance2 = 3000;
                double resistance3 = 2000;
                double resistance4 = 1000;

                double branch1 = resistance1 + resistance2;
                double branch2 = resistance3 + resistance4;


                voltage1 = voltage * (resistance1 / branch1);
                voltage2 = voltage * (resistance2 / branch1);
                voltage3 = voltage * (resistance3 / branch2);
                voltage4 = voltage * (resistance4 / branch2);

                current1 = voltage1 / resistance1;
                current2 = voltage2 / resistance2;
                current3 = voltage3 / resistance3;
                current4 = voltage4 / resistance1;

                double totalcurrent = current1 + current3;

                Console.WriteLine("The supply voltage is: " + voltage + " V ");

                Console.WriteLine("Voltage across Resistor, R1 is :" + voltage1 + "V");

                Console.WriteLine("Voltage across Resistor, R2 is :" + voltage2 + "V");

                Console.WriteLine("Voltage across the branch is :" + (voltage1+voltage2) + "V");

                Console.WriteLine("The current for the branch is :" + current1 + "A");

                Console.WriteLine("Voltage across Resistor, R3 is :" + voltage3 + "V");

                Console.WriteLine("Voltage across Resistor, R4 is :" + voltage4 + "V");

                Console.WriteLine("Voltage across the branch is :" + (voltage3 + voltage4) + "V");

                Console.WriteLine("The current for the branch is :" + current3 + "A");

                Console.WriteLine("The current for the circuit is :" + totalcurrent + "A");
            }




        }

    }
}
