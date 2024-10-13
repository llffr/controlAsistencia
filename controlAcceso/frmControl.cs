using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;

namespace controlAcceso
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        clsControlAsistencia dao = new clsControlAsistencia();

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dao.registrarAsistenciaPersonal(txtdni.Text);
            }
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txtdni.Text.Length <= 8 || txtdni.Text.Length >= 8)
            {
                DataTable dt = new DataTable();
                dt = dao.filtrarDatosPersona(txtdni.Text);
                if (dt.Rows.Count > 0)
                {
                    txtnom.Text = dt.Rows[0][1].ToString();
//                    txtape.Text = dt.Rows[0][2].ToString();
                }
            }
            */
            DataTable dt = new DataTable();
            dt = dao.filtrarDatosPersona(txtdni.Text);
            dataGridView1.DataSource = dt;
        }

    }
}
