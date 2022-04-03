using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaslab
{
    public partial class v_IngreE : Form
    {
        public v_IngreE()
        {
            InitializeComponent();     

        }
        private void v_IngreE_Load(object sender, EventArgs e)
        {
            cmb_Genero.Items.Add("Hombre");
            cmb_Genero.Items.Add("Mujer");
            cmb_Genero.SelectedIndex = 0;
        }


        private void cmb_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        valilimpia vali = new valilimpia();
        private void limpiar()
        {
            vali.limpiarfrm(this);
        }

    }
}
