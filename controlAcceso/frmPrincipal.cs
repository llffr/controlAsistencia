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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            frmCargo ca= new frmCargo();
            ca.MdiParent = this;
            ca.Show();
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            frmPersonal p= new frmPersonal();
            p.MdiParent = this;
            p.Show();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            frmControl co= new frmControl();
            co.MdiParent = this;
            co.Show();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            frmConsultaIndividual ca= new frmConsultaIndividual();
            ca.MdiParent = this;
            ca.Show();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            frmConsultaFecha ca= new frmConsultaFecha();
            ca.MdiParent = this;
            ca.Show();
        }
    }
}
