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
    public partial class frmJobProperties : Form
    {
        public frmJobProperties()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tvStatusJobsCollection.Nodes.Clear();
            tvStatusJobsInstancia.Nodes.Clear();

            try
            {
                var processamento = WebService.WsBIClient.GetJobProperties(null, null, null);

                JobsCollection(processamento);
                JobsInstancia(processamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao recuperar as configurações ! Detalhes: " + ex.Message);
                return;
            }

        }

        private void JobsInstancia(WSControleCenter.WarehouseProcessingJobProperties processamento)
        {
            TreeNode rootnode = tvStatusJobsInstancia.Nodes.Add("Instancia");

            foreach (var jobs in processamento.Instance.Jobs)
            {
                TreeNode child = rootnode.Nodes.Add(jobs.Name);

                TreeNode prop = child.Nodes.Add(jobs.Name);

                prop.Nodes.Add("Intervalo de execução: " + jobs.RunInterval.ToString());
                prop.Nodes.Add("Enabled State:" + jobs.EnabledState.ToString());
            }

            tvStatusJobsInstancia.ExpandAll();
        }

        private void JobsCollection(WSControleCenter.WarehouseProcessingJobProperties processamento)
        {
            foreach (var collection in processamento.Collections)
            {
                TreeNode rootnode = tvStatusJobsCollection.Nodes.Add(collection.Name);

                foreach (var jobs in collection.Jobs)
                {
                    TreeNode child = rootnode.Nodes.Add(jobs.Name);

                    TreeNode prop = child.Nodes.Add(jobs.Name);

                    prop.Nodes.Add("Intervalo de execução: " + jobs.RunInterval.ToString());
                    prop.Nodes.Add("Enabled State:" + jobs.EnabledState.ToString());
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
