using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Identity
    {
        public bool SetInputD { get; set; }

        public bool SetInputA { get; set; }

        public bool SetInputX { get; set; }

        public bool Validate()
        {
            var result = true;
            //solution
            if(SetInputD == false && SetInputA == false && SetInputX == false)
            {
                result = false;
            }
            else if(SetInputD == false && SetInputA == false && SetInputX == true)
            {
                result = false;
            }
            else if (SetInputD == false && SetInputA == true && SetInputX == false)
            {
                result = true;
            }
            else if (SetInputD == false && SetInputA == true && SetInputX == true)
            {
                result = true;
            }
            else if (SetInputD == true && SetInputA == false && SetInputX == false)
            {
                result = true;
            }
            else if (SetInputD == true && SetInputA == false && SetInputX == true)
            {
                result = false;
            }
            else if (SetInputD == true && SetInputA == true && SetInputX == false)
            {
                result = true;
            }
            else
            {
                result = true;
            }

            return result;
        }


    }
}
