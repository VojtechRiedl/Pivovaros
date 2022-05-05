using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pivovaros
{

    public partial class Form1 : Form
    {


        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivson.Enabled = true;

        }

        private void pivson_Tick(object sender, EventArgs e)
        {
            counter++;
            pivson.Interval = 100;
            jeCasVyrabet();


        }
        private void jeCasVyrabet()
        {
            if ((counter % (Pivo10.rychlostVyroby * 10)) == 0)
            {
                Pivo10.Recept();
            }
            if ((counter % (Pivo11.rychlostVyroby * 10)) == 0)
            {
                Pivo11.Recept();
            }
            if ((counter % (Pivo12.rychlostVyroby * 10)) == 0) 
            {
                Pivo12.Recept();
            }
        }
    }
}
