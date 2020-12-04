using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Identity
    {
        public bool SetInputX { get; set; }

        public bool SetInputY { get; set; }

        

        public bool Or()
        {
            var result = true;
            //solution
            if (SetInputX == false && SetInputY == false)
            {
                result = false;
            }
            else if (SetInputX == false && SetInputY == true)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == true)
            {
                result = true;
            }


            return result;
        }

        public bool NOTOr()
        {
            var result = true;
            //solution
            if (SetInputX == false && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == false && SetInputY == true)
            {
                result = false;
            }
            else if (SetInputX == true && SetInputY == false)
            {
                result = false;
            }
            else if (SetInputX == true && SetInputY == true)
            {
                result = false;
            }


            return result;
        }

        public bool NOTAnd()
        {
            var result = true;
            //solution
            if (SetInputX == false && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == false && SetInputY == true)
            {
                result = false;
            }
            else if (SetInputX == true && SetInputY == false)
            {
                result = false;
            }
            else if (SetInputX == true && SetInputY == true)
            {
                result = false;
            }


            return result;
        }

        public bool NOTXorNOTY()
        {
            var result = true;
            //solution
            if (SetInputX == false && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == false && SetInputY == true)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == true)
            {
                result = false;
            }


            return result;
        }

        public bool NOTXandY()
        {
            var result = true;
            //solution
            if (SetInputX == false && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == false && SetInputY == true)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == false)
            {
                result = true;
            }
            else if (SetInputX == true && SetInputY == true)
            {
                result = false;
            }


            return result;
        }

    }
}
