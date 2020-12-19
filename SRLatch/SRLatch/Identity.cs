using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRLatch
{
    class Identity
    {
        public bool SetInputS { get; set; }

        public bool SetInputR { get; set; }

        public bool SetInputQ { get; set; }

        public bool SetInputQprime { get; set; }
        public bool SRlatch()
        {

            
            //solution
            if (SetInputR == false && SetInputS == false)
            {
                SetInputQ = true; 
                
            }
            else if (SetInputR == false && SetInputS == false && SetInputQ == false)
            {
                SetInputQ = false; 
               
            }
            else if (SetInputR == true && SetInputS == false)
            {
                SetInputQ = false;
               
            }
            else if (SetInputS == true && SetInputR == false)
            {
                SetInputQ = true;
              
            }
            else if (SetInputS == true && SetInputR == true)
            {
                SetInputQ = false;
                
            }


            return SetInputQ;
        }
        public bool SRlatch2()
        {
          
            //solution
            if (SetInputR == false && SetInputS == false)
            {
                
                SetInputQprime = false;
            }
            else if (SetInputR == false && SetInputS == false && SetInputQ == false)
            {
                
                SetInputQprime = true;
            }
            else if (SetInputR == true && SetInputS == false)
            {
                
                SetInputQprime = true;
            }
            else if (SetInputS == true && SetInputR == false)
            {
                
                SetInputQprime = false;
            }
            else if (SetInputS == true && SetInputR == true)
            {
                
                SetInputQprime = false;
            }


            return SetInputQprime;
        }
    }
}
