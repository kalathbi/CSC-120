using LogicCircuit.Gates.Simple;
using LogicCircuit.Gates.Composite;
using LogicCircuit.Abstractions.Gates;
using LogicCircuit.Infrastructure;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_LogicGates
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truth table for AND Logic Gate");
            // Testing the AND Circuit

            //----------------------------------
            // State  Input A   Input B   Output
            //           0         0        0(False)
            //           1         0        0(false)
            //           0         1        0(false)
            //           1         1        1(true)


            var logicCircuit = new AND();

            logicCircuit.SetInputA(false);

            logicCircuit.SetInputB(false);

            var output = logicCircuit.Output.State;

            Console.WriteLine(output);

            logicCircuit.SetInputA(true);

            logicCircuit.SetInputB(false);

            var output1 = logicCircuit.Output.State;

            Console.WriteLine(output1);

            logicCircuit.SetInputA(false);

            logicCircuit.SetInputB(true);

            var output2 = logicCircuit.Output.State;

            Console.WriteLine(output2);

            logicCircuit.SetInputA(true);

            logicCircuit.SetInputB(true);

            var output3 = logicCircuit.Output.State;

            Console.WriteLine(output3);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Truth table for OR Logic Gate");


            // Testing the OR circuit

            //----------------------------------
            // State  Input A   Input B   Output
            //           0         0        0(False)
            //           1         0        1(true)
            //           1         0        0(true)
            //           1         1        1(true)


            var logicCircuitOR = new OR();

            logicCircuitOR.SetInputA(false);

            logicCircuitOR.SetInputB(false);


            var output4 = logicCircuitOR.Output.State;

            Console.WriteLine(output4);

            logicCircuitOR.SetInputA(true);

            logicCircuitOR.SetInputB(false);

            var output5 = logicCircuitOR.Output.State;

            Console.WriteLine(output5);

            logicCircuitOR.SetInputA(false);

            logicCircuitOR.SetInputB(true);

            var output6 = logicCircuitOR.Output.State;

            Console.WriteLine(output6);

            logicCircuitOR.SetInputA(true) ;

            logicCircuitOR.SetInputB(true);

            var output7 = logicCircuitOR.Output.State;

            Console.WriteLine(output7);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Truth table for NOT Logic Gate");

            // Testing the NOT circuit

            //----------------------------------
            // State  Input A               Output
            //           0                 1(True)
            //           1                 0(False)

            var logicCircuitNOT = new NOT();

            logicCircuitNOT.SetInputA(false);

           var output8 = logicCircuitNOT.Output.State;
            Console.WriteLine(output8);

           logicCircuitNOT.SetInputA(true);

            

            var output9 = logicCircuitNOT.Output.State;

            Console.WriteLine(output9);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Truth table for NAND Logic Gate");


            // Testing the NAND Circuit

            //----------------------------------
            // State  Input A   Input B   Output
            //           0         0        1(True)
            //           1         0        1(True)
            //           0         1        1(True)
            //           1         1        0(False)

            var logicCircuitNAND = new AND();

            logicCircuitNAND.SetInputA(false);

            logicCircuitNAND.SetInputB(false);

            var output10 = logicCircuitNAND.Output.State;

            logicCircuitNOT.SetInputA(output10);

            var output11 = logicCircuitNOT.Output.State;

            Console.WriteLine(output11);

            logicCircuitNAND.SetInputA(true);

            logicCircuitNAND.SetInputB(false);

            var output12 = logicCircuitNAND.Output.State;

            logicCircuitNOT.SetInputA(output12);

            var output13 = logicCircuitNOT.Output.State;


            Console.WriteLine(output13);

            logicCircuitNAND.SetInputA(false);

            logicCircuitNAND.SetInputB(true);

            var output14 = logicCircuitNAND.Output.State;

            logicCircuitNOT.SetInputA(output14);

            var output15 = logicCircuitNOT.Output.State;


            Console.WriteLine(output15);

            logicCircuitNAND.SetInputA(true);

            logicCircuitNAND.SetInputB(true);

            var output16 = logicCircuitNAND.Output.State;

            logicCircuitNOT.SetInputA(output16);

            var output17 = logicCircuitNOT.Output.State;

            Console.WriteLine(output17);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Truth table for NOR Logic Gate");


            // Testing the NOR Circuit

            //----------------------------------
            // State  Input A   Input B   Output
            //           0         0        1(True)
            //           1         0        0(True)
            //           0         1        0(True)
            //           1         1        0(False)

            var logicCircuitNOR = new OR();

            logicCircuitNOR.SetInputA(false);

            logicCircuitNOR.SetInputB(false);

            var output18 = logicCircuitNOR.Output.State;

            logicCircuitNOT.SetInputA(output18);

            var output19 = logicCircuitNOT.Output.State;

            Console.WriteLine(output19);

            logicCircuitNOR.SetInputA(true);

            logicCircuitNOR.SetInputB(false);

            var output20 = logicCircuitNOR.Output.State;

            logicCircuitNOT.SetInputA(output20);

            var output21 = logicCircuitNOT.Output.State;


            Console.WriteLine(output21);

            logicCircuitNOR.SetInputA(false);

            logicCircuitNOR.SetInputB(true);

            var output22 = logicCircuitNOR.Output.State;

            logicCircuitNOT.SetInputA(output22);

            var output23 = logicCircuitNOT.Output.State;


            Console.WriteLine(output23);

            logicCircuitNOR.SetInputA(true);

            logicCircuitNOR.SetInputB(true);

            var output24 = logicCircuitNOR.Output.State;

            logicCircuitNOT.SetInputA(output24);

            var output25 = logicCircuitNOT.Output.State;

            Console.WriteLine(output25);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Truth table for XOR Logic Gate");


            // Testing the XOR Circuit
            // XOR Gate system was not working

            //----------------------------------
            // State  Input A   Input B   Output
            //           0         0        1(True)
            //           1         0        1(True)
            //           0         1        1(True)
            //           1         1        0(False)

            //var logicCircuitXOR = new XOR();

            //logicCircuitXOR.SetInputA(false);

            //logicCircuitXOR.SetInputB(false);

            //var output26 = logicCircuitXOR.Output.State;



        }





    }
}
