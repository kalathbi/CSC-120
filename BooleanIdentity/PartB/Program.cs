using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { X = false, Y = false});
            inputs.Add(new IdentityInput() { X = false, Y = true});
            inputs.Add(new IdentityInput() { X = true, Y = false});
            inputs.Add(new IdentityInput() { X = true, Y = true});




            //Step 2
            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;
               


                var output = identity.Or();
                Console.WriteLine($" X = {identity.SetInputX}," +
                   $" Y = {identity.SetInputY}," +
                   
                   $" X + Y = {output}");
            }

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;



                var output = identity.NOTOr();
                Console.WriteLine($" X = {identity.SetInputX}," +
                   $" Y = {identity.SetInputY}," +

                   $" Not(X + Y) = {output}");
            }

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;



                var output = identity.NOTAnd();
                Console.WriteLine($" X = {identity.SetInputX}," +
                   $" Y = {identity.SetInputY}," +

                   $" (NotX * NotY) = {output}");
            }

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;



                var output = identity.NOTXorNOTY();
                Console.WriteLine($" X = {identity.SetInputX}," +
                   $" Y = {identity.SetInputY}," +

                   $" (NotX + NotY) = {output}");
            }

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputX = item.X;
                identity.SetInputY = item.Y;



                var output = identity.NOTXorNOTY();
                Console.WriteLine($" X = {identity.SetInputX}," +
                   $" Y = {identity.SetInputY}," +

                   $" Not(X * Y) = {output}");
            }


        }
    }
}
