using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLatch
{
    class Program
    {
        
        static void Main(string[] args)
        {

            evaluate();
        }
        
        public static void evaluate() { 
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { S = false, R = false });
            inputs.Add(new IdentityInput() { S = false, R = false});
            inputs.Add(new IdentityInput() { S = false, R = true });
            inputs.Add(new IdentityInput() { S = true, R = false });
            inputs.Add(new IdentityInput() { S = true, R = true });

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputS = item.S;
                identity.SetInputR = item.R;
                var output = identity.SRlatch();
                var output1 = identity.SRlatch2();



                
            }


        }

        

    }
}
