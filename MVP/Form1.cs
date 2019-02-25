using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, IRectangle   
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Atext { get => txtA.Text; set => txtA.Text = value; }
        public string Btext { get => txtB.Text; set => txtB.Text = value; }
        public string Restext { get => label1.Text; set => label1.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.Calc();
        }
    }
}
