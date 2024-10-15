using capaDatos;
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
    public partial class frmConsultaIndividual : Form
    {
        public frmConsultaIndividual()
        {
            InitializeComponent();
        }
        clsControlAsistencia contrAsis = new clsControlAsistencia();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = contrAsis.consultaAsistenciaDNI(textBox1.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
