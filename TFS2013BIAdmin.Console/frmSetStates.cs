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
    public partial class frmSetStates : Form
    {
        public frmSetStates()
        {
            InitializeComponent();
        }

        private void btnConfigAnalysis_Click(object sender, EventArgs e)
        {
            bool retorno = false;

            switch (cbTipoProcessamentoAnalysis.SelectedItem.ToString())
            {
                case "Enabled":
                    retorno = WebService.WsBIClient.SetAnalysisJobEnabledState(WSControleCenter.TeamFoundationJobEnabledState.Enabled);
                    break;
                case "SchedulesDisabled":
                    retorno = WebService.WsBIClient.SetAnalysisJobEnabledState(WSControleCenter.TeamFoundationJobEnabledState.SchedulesDisabled);
                    break;
                case "FullyDisabled":
                    retorno = WebService.WsBIClient.SetAnalysisJobEnabledState(WSControleCenter.TeamFoundationJobEnabledState.FullyDisabled);
                    break;
                default:
                    break;
            }

            if (retorno)
                MessageBox.Show("Enviado com sucesso !");
            else
                MessageBox.Show("Falha no envio !");
        }

        private void btnConfigWerehouse_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            string collection = cbCollection.Text;
            string jobname = cbJobName.Text;
            WSControleCenter.TeamFoundationJobEnabledState state = WSControleCenter.TeamFoundationJobEnabledState.Enabled;

            switch (cbStateWerehouse.SelectedItem.ToString())
            {
                case "Enabled":
                    state = WSControleCenter.TeamFoundationJobEnabledState.Enabled;
                    break;
                case "SchedulesDisabled":
                    state = WSControleCenter.TeamFoundationJobEnabledState.SchedulesDisabled;
                    break;
                case "FullyDisabled":
                    state = WSControleCenter.TeamFoundationJobEnabledState.FullyDisabled;
                    break;
                default:
                    break;
            }

            try
            {
                retorno = WebService.WsBIClient.SetWarehouseJobEnabledState(collection, jobname, state);
            }
            catch (FaultException fex)
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

        private void frmSetStates_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Collections.GetTeamProjectCollections(ConfigurationManager.AppSettings["TfsServer"]))
                {
                    cbCollection.Items.Add(item.ToString());
                }


                foreach (var item in Jobs.JobsState())
                {
                    cbTipoProcessamentoAnalysis.Items.Add(item.ToString());
                    cbStateWerehouse.Items.Add(item.ToString());
                }

                foreach (var item in Jobs.WarehouseJobs())
                {
                    cbJobName.Items.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao recuperar as configurações ! Detalhes: " + ex.Message);
                btnConfigAnalysis.Enabled = false;
                btnConfigWerehouse.Enabled = false;
                return;
            }
        }
    }
}
