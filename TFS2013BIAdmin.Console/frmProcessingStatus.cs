using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFS2013BIAdmin.Console
{
    public partial class frmProcessingStatus : Form
    {
        public frmProcessingStatus()
        {
            InitializeComponent();
        }

        private void btnBuscarStatus_Click(object sender, EventArgs e)
        {
            tvStatusJobsCollection.Nodes.Clear();
            tvStatusJobsInstancia.Nodes.Clear();

            try
            {
                var processamento = WebService.WsBIClient.GetProcessingStatus(null, null, null, true);

                JobsCollection(processamento);

                JobsInstancia(processamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao recuperar as configurações ! Detalhes: " + ex.Message);
                return;
            }
            
        }

        void JobsInstancia(WSControleCenter.WarehouseProcessingStatusDetails processamento)
        {
            tvStatusJobsInstancia.Nodes.Add("Werehouse status: " + processamento.WarehouseProcessingOnlineStatus.ToString());
            tvStatusJobsInstancia.Nodes.Add("Analises status: " + processamento.AnalysisProcessingOnlineStatus.ToString());

            tvStatusJobsInstancia.Nodes.Add("JOBs executando: " + processamento.JobsRunning.ToString());
            tvStatusJobsInstancia.Nodes.Add("JOBs em fila: " + processamento.JobsQueued.ToString());
            
            TreeNode rootnode = tvStatusJobsInstancia.Nodes.Add("JOBs da intancia");

            foreach (var job in processamento.Instance.Jobs)
            {
                TreeNode child = rootnode.Nodes.Add(job.Name);

                TreeNode lastRun = child.Nodes.Add("Ultima Execução");

                lastRun.Nodes.Add("Resultado: " + job.LastRun.Result.ToString());
                lastRun.Nodes.Add("Inicio: " + job.LastRun.ExecutionStartTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                lastRun.Nodes.Add("Fim: " + job.LastRun.EndTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));

                if (job.NextRun != null)
                {
                    TreeNode nextRun = child.Nodes.Add("Proxima Execução");
                    nextRun.Nodes.Add("Status: " + job.NextRun.JobState.ToString());
                    nextRun.Nodes.Add("Agendamento: " + job.NextRun.QueueTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                }

                if (job.CurrentRun != null)
                {
                    TreeNode nextRun = child.Nodes.Add("Execução Atual");
                    nextRun.Nodes.Add("Status: " + job.CurrentRun.JobState.ToString());
                    nextRun.Nodes.Add("Agendamento: " + job.CurrentRun.QueueTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                }
            }
        }

        void JobsCollection(WSControleCenter.WarehouseProcessingStatusDetails processamento)
        {
            foreach (var collection in processamento.Collections)
            {
                TreeNode rootnode = tvStatusJobsCollection.Nodes.Add(collection.Name);

                foreach (var jobs in collection.Jobs)
                {
                    TreeNode child = rootnode.Nodes.Add(jobs.Name);

                    TreeNode lastRun = child.Nodes.Add("Ultima Execução");

                    lastRun.Nodes.Add("Resultado: " + jobs.LastRun.Result.ToString());
                    lastRun.Nodes.Add("Inicio: " + jobs.LastRun.ExecutionStartTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                    lastRun.Nodes.Add("Fim: " + jobs.LastRun.EndTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));

                    if (jobs.NextRun != null)
                    {
                        TreeNode nextRun = child.Nodes.Add("Proxima Execução");
                        nextRun.Nodes.Add("Status: " + jobs.NextRun.JobState.ToString());
                        nextRun.Nodes.Add("Agendamento: " + jobs.NextRun.QueueTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                    }

                    if (jobs.CurrentRun != null)
                    {
                        TreeNode nextRun = child.Nodes.Add("Execução Atual");
                        nextRun.Nodes.Add("Status: " + jobs.CurrentRun.JobState.ToString());
                        nextRun.Nodes.Add("Agendamento: " + jobs.CurrentRun.QueueTimeUtc.ToString("dd/MM/yyyy HH:mm:ss"));
                    }

                }
            }
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
    }
}
