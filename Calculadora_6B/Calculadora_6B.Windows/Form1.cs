﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_6B.Libreria;

namespace Calculadora_6B.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora_6B.Libreria.Metodos misMetodos = new Metodos();//Calculadora_6B.Libreria.
            MessageBox.Show(misMetodos.Saludar());

        }
    }
}
