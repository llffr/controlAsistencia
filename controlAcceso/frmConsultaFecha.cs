﻿using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlAcceso
{
    public partial class frmConsultaFecha : Form
    {
        public frmConsultaFecha()
        {
            InitializeComponent();
        }
        clsControlAsistencia conAsis= new clsControlAsistencia();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = conAsis.consultaAsistenciaFecha(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
        }
    }
}