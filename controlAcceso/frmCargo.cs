using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//referencia a la capa
using capaDatos;

namespace controlAcceso
{
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
            listarCargo();
        }

        //crea la instancia
        clsCargo ocar = new clsCargo();
        void listarCargo()
        {
            dataGridView1.DataSource = ocar.listarCargo();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            ocar.registrarCargo(txtDes.Text);
            listarCargo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //cargo seleccionado para eliminar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ocar.eliminarCargo(Convert.ToInt32(txtCod.Text));
            listarCargo();
        }

        //click en cargo para eliminar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDes.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
