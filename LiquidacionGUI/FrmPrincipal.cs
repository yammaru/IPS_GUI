using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace LiquidacionGUI
{
    public partial class FrmPrincipal : Form
    {

        LiquidacionCuotaModeradora regimenContributivo = new RegimenContributivo();
        LiquidacionCuotaModeradora regimenSubsidiado = new RegimenSubsidiado();
        List<LiquidacionCuotaModeradora> liquidaciones = new List<LiquidacionCuotaModeradora>();
        string mensaje;
        LiquidacionCuotaModeradoraService servicios = new LiquidacionCuotaModeradoraService();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFltrar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            if ((combo_afiliacion.Text!="")||(txtConsultaAÑO.Text!="")||(txtConsultaMES.Text!=""))
            {
                dataGridView1.DataSource = servicios.Filtro(combo_afiliacion.Text, int.Parse(txtConsultaAÑO.Text), int.Parse(txtConsultaMES.Text));
                lbbTotalizar.Text = servicios.Totalizar().ToString();
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
           dataGridView1.DataSource= servicios.Consultar();
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (CbmAfiliacion.Text=="Contributivo")
            {
                
                
                regimenContributivo.NumeroLiquidacion = txtNLiquidacion.Text;
                regimenContributivo.Fecha = CalendarioSkill.Value.Date;
                regimenContributivo.IdentificacionPasiente = txtIDPaciente.Text;
                regimenContributivo.Tipo = CbmAfiliacion.Text;
                regimenContributivo.SalarioPaciente = decimal.Parse( txtSalario.Text);
                regimenContributivo.ValorServicio = decimal.Parse( txtValorServicio.Text);
                regimenContributivo.Liquidar();
                string mensaje = servicios.Guardar(regimenContributivo);
                MessageBox.Show(mensaje, "guardo");


            }
            else
            {
                
                regimenSubsidiado.NumeroLiquidacion = txtNLiquidacion.Text;
                regimenSubsidiado.Fecha = CalendarioSkill.Value.Date;
                regimenSubsidiado.IdentificacionPasiente = txtIDPaciente.Text;
                regimenSubsidiado.Tipo = CbmAfiliacion.Text;
                regimenSubsidiado.SalarioPaciente = decimal.Parse(txtSalario.Text);
                regimenSubsidiado.ValorServicio = decimal.Parse(txtValorServicio.Text);
                regimenSubsidiado.Liquidar();
                string mensaje = servicios.Guardar(regimenSubsidiado);
                MessageBox.Show(mensaje, "guardo");
            }

            
        }
    }
}
