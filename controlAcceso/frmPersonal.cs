using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;

namespace controlAcceso
{
    public partial class frmPersonal : Form
    {
        clsPersonal op= new clsPersonal();
        public frmPersonal()
        {
            InitializeComponent();
            llenarCargo();
            listarPersonal();
        }
        void llenarCargo()
        {
            DataTable dt = new DataTable();
            dt= op.llenarCargo();
            cmoCargo.Items.Clear();
            cmoCargo.DataSource = dt;
            cmoCargo.DisplayMember = "NOMCARGO";
            cmoCargo.ValueMember = "IDCARGO";

        }
        void listarPersonal()
        {
            dgvPersonal.DataSource = op.listadoPersonal();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            op.registrarPersonal(txtDni.Text, txtNom.Text, txtApe.Text, txtTele.Text, Convert.ToInt32(cmoCargo.SelectedValue));
            listarPersonal();
        }
         private void btnActualizar_Click(object sender, EventArgs e)
        {
            op.actualizarPersonal(txtDni.Text, txtNom.Text, txtApe.Text, txtTele.Text, Convert.ToInt32(cmoCargo.SelectedValue));
            listarPersonal();
        }
        //actualizar cargo/datos
        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = dgvPersonal.CurrentRow.Cells[1].Value.ToString();
            txtNom.Text = dgvPersonal.CurrentRow.Cells[2].Value.ToString();
            txtApe.Text = dgvPersonal.CurrentRow.Cells[3].Value.ToString();
            txtTele.Text = dgvPersonal.CurrentRow.Cells[4].Value.ToString();
            cmoCargo.Text= dgvPersonal.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
