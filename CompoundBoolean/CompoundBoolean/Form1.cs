using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundBoolean
{
    public partial class Form1 : Form
    {
        public int score = 0;
        
        public static Color[] colorlist = { Color.Red, Color.Yellow, Color.Gray, Color.Green };
        public static  String[] colors = { "Red", "Yellow", "Gray", "Green" };
        public static String[] logic = { " || ", " && "};
        public static String[] notlogic = { " ! ", " " };
        private static readonly Random random = new Random();
        private static readonly Random random2 = new Random();
        public bool winstatus;

        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public static int newRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random2.Next(min, max);
            }
        }


        public Form1()
        {

            InitializeComponent();
            button3.BackColor = Color.DeepSkyBlue;
            button4.BackColor = Color.DeepSkyBlue;
            button5.BackColor = Color.Red;
            button1.Text = "Score = " + score;
            
            initialize();

            
        }

        public void initialize()
        {
            button3.Enabled = true;
            button4.Enabled = true;
            int number = RandomNumber(1,4);
            int randomcolor = newRandomNumber(0,4);
            button2.BackColor = colorlist[randomcolor];
            button2.Text = number.ToString();
            int colornum = RandomNumber(0, 4);
            int randomsymbol = RandomNumber(0, 2);
            int boolnumber = newRandomNumber(0, 2);
            int otherbool = RandomNumber(0, 2);
            int evaluate = RandomNumber(1, 5);

            string frontlogic = notlogic[boolnumber];
            string colorname = colors[colornum];
            string symbol = logic[randomsymbol];
            string numberlogic = notlogic[otherbool];
            string testnumber = evaluate.ToString();
            button6.Text = "( " + frontlogic + colorname + symbol + numberlogic + testnumber + " )";

            winstatus = false;


            if (frontlogic == " " && numberlogic == " ")
            {
                if (symbol == " && " && randomcolor == colornum && number == evaluate)
                {
                    winstatus = true;
                }
                else if (symbol == " || " && (randomcolor == colornum || number == evaluate))
                {
                    winstatus = true;
                }
            }
            else if (frontlogic == " ! " && numberlogic == " ! ")
            {
                if (symbol == " && " && randomcolor != colornum && number != evaluate)
                {
                    winstatus = true;
                }
                else if (symbol == " || " && (randomcolor != colornum || number != evaluate))
                {
                    winstatus = true;
                }
            }
            else if (frontlogic == " ! " && numberlogic == " ")
            {
                if (symbol == " && " && randomcolor != colornum && number == evaluate)
                {
                    winstatus = true;
                }
                else if (symbol == " || " && (randomcolor != colornum || number == evaluate))
                {
                    winstatus = true;
                }
          
            }
            else if (frontlogic == " " && numberlogic == " ! ")
            {
                if(symbol == " && " && randomcolor == colornum && number != evaluate)
                {
                    winstatus = true;
                }
                else if(symbol == " || " && (randomcolor == colornum || number != evaluate))
                {
                    winstatus = true;
                }
            }
            

            


        }

        private void button5_Click(object sender, EventArgs e) // Restart Button
        {
            score = 0;
            button1.Text = "Score = " + score;
            button3.BackColor = Color.DeepSkyBlue;
            button4.BackColor = Color.DeepSkyBlue;
            initialize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(winstatus == true)
            {
                score = score + 1;
                button1.Text = "Score = " + score;
                initialize();
            }
            else if(winstatus == false)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (winstatus == false)
            {
                score = score + 1;
                button1.Text = "Score = " + score;
                initialize();
            }
            else if (winstatus == true)
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        
    }
}
