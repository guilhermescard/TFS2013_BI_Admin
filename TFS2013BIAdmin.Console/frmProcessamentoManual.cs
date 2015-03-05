using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFS2013BIAdmin.Console
{
    public partial class frmProcessamentoManual : Form
    {
        public frmProcessamentoManual()
        {
            InitializeComponent();
        }

        private void btnProcessarAnalysis_Click(object sender, EventArgs e)
        {
            bool retorno;
            if(cbTipoProcessamentoAnalysis.SelectedText == "Full")
                retorno = WebService.WsBIClient.ProcessAnalysisDatabase(WSControleCenter.AnalysisDatabaseProcessingType.Full);
            else
                retorno = WebService.WsBIClient.ProcessAnalysisDatabase(WSControleCenter.AnalysisDatabaseProcessingType.Incremental);

            if (retorno)
                MessageBox.Show("Enviado com sucesso !");
            else
                MessageBox.Show("Falha no envio !");
        }

        private void btnProcessarWerehouse_Click(object sender, EventArgs e)
        {
            bool retorno = false;

            try
            {
                retorno = WebService.WsBIClient.ProcessWarehouse(cbCollection.Text, cbJobName.Text);
            }
            catch(FaultException fex)
            {
                MessageBox.Show("Collection ou Job Name inválidos.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao processar ! Detalhes: " + ex.Message);
                return;
            }

            if (retorno)
                MessageBox.Show("Enviado com sucesso !");
            else
                MessageBox.Show("Falha no envio !");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmProcessamentoManual_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Collections.GetTeamProjectCollections(ConfigurationManager.AppSettings["TfsServer"]))
                {
                    cbCollection.Items.Add(item.ToString());
                }

                foreach (var item in Jobs.AnalysesProcessType())
                {
                    cbTipoProcessamentoAnalysis.Items.Add(item.ToString());
                }

                foreach (var item in Jobs.WarehouseJobs())
                {
                    cbJobName.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao recuperar as configurações ! Detalhes: " + ex.Message);
                btnProcessarAnalysis.Enabled = false;
                btnProcessarWerehouse.Enabled = false;
                return;
            }
        }
    }
}
