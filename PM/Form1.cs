using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using API;

namespace PM
{
    public partial class Form1 : Form
    {
        IPCS pcs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcs = (IPCS)Activator.GetObject(typeof(IPCS), "tcp://localhost:50000/MSPCS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number_servs = Int32.Parse(lst_n_serv.SelectedItem.ToString());
            //TODO this is just an example of a method call
            pcs.StartServer("oi", "ola", 2, 2, 2);
        }
    }
}
