using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFS2013BIAdmin.Console
{
    public partial class frmConfiguracoesWsWhereHouseControl : Form
    {
        public frmConfiguracoesWsWhereHouseControl()
        {
            InitializeComponent();
        }

        private void btnBuscaConfigs_Click(object sender, EventArgs e)
        {

            WSControleCenter.WarehouseSettings retorno = null;

            try
            {
                retorno = WebService.WsBIClient.GetSettings();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao recuperar as configuracoes ! Detalhes: " + ex.Message);
                btnEfetivarAlteracoes.Enabled = false;
                return;
            }

            txtRunIntervalSeconds.Text = retorno.RunIntervalSeconds.Value;
            txtRunIntervalSecondsDefault.Text = retorno.RunIntervalSeconds.DefaultValue;

            txtIncrementalProcessIntervalSeconds.Text = retorno.IncrementalProcessIntervalSeconds.Value;
            txtIncrementalProcessIntervalSecondsDerfault.Text = retorno.IncrementalProcessIntervalSeconds.DefaultValue;

            txtFullProcessIntervalSeconds.Text = retorno.FullProcessIntervalSeconds.Value;
            txtFullProcessIntervalSecondsDefault.Text = retorno.FullProcessIntervalSeconds.DefaultValue;

            txtDailyFullProcessingTime.Text = retorno.DailyFullProcessingTime.Value;
            txtDailyFullProcessingTimeDefault.Text = retorno.DailyFullProcessingTime.DefaultValue;

            txtMaxParallelASProcessingCommands.Text = retorno.MaxParallelASProcessingCommands.Value;
            txtMaxParallelASProcessingCommandsDefault.Text = retorno.MaxParallelASProcessingCommands.DefaultValue;

            txtAnalysisSchemaUpdateWaitSeconds.Text = retorno.AnalysisSchemaUpdateWaitSeconds.Value;
            txtAnalysisSchemaUpdateWaitSecondsDefault.Text = retorno.AnalysisSchemaUpdateWaitSeconds.DefaultValue;

            txtSchemaUpdateWaitSeconds.Text = retorno.SchemaUpdateWaitSeconds.Value;
            txtSchemaUpdateWaitSecondsDefault.Text = retorno.SchemaUpdateWaitSeconds.DefaultValue;

            txtDataUpdateWaitSeconds.Text = retorno.DataUpdateWaitSeconds.Value;
            txtDataUpdateWaitSecondsDefault.Text = retorno.DataUpdateWaitSeconds.DefaultValue;

            txtWarehouseCommandSqlTimeout.Text = retorno.WarehouseCommandSqlTimeout.Value;
            txtWarehouseCommandSqlTimeoutDefault.Text = retorno.WarehouseCommandSqlTimeout.DefaultValue;

            txtAnalysisServicesProcessingTimeout.Text = retorno.AnalysisServicesProcessingTimeout.Value;
            txtAnalysisServicesProcessingTimeoutDefault.Text = retorno.AnalysisServicesProcessingTimeout.DefaultValue;

        }

        private void btnEfetivarAlteracoes_Click(object sender, EventArgs e)
        {
            WebService.WsBIClient.ChangeSetting("RunIntervalSeconds", txtRunIntervalSeconds.Text);
            WebService.WsBIClient.ChangeSetting("IncrementalProcessIntervalSeconds", txtIncrementalProcessIntervalSeconds.Text);
            WebService.WsBIClient.ChangeSetting("FullProcessIntervalSeconds", txtFullProcessIntervalSeconds.Text);
            WebService.WsBIClient.ChangeSetting("DailyFullProcessingTime", txtDailyFullProcessingTime.Text);
            WebService.WsBIClient.ChangeSetting("MaxParallelASProcessingCommands", txtMaxParallelASProcessingCommands.Text);
            WebService.WsBIClient.ChangeSetting("AnalysisSchemaUpdateWaitSeconds", txtAnalysisSchemaUpdateWaitSeconds.Text);
            WebService.WsBIClient.ChangeSetting("SchemaUpdateWaitSeconds", txtSchemaUpdateWaitSeconds.Text);
            WebService.WsBIClient.ChangeSetting("DataUpdateWaitSeconds", txtDataUpdateWaitSeconds.Text);
            WebService.WsBIClient.ChangeSetting("WarehouseCommandSqlTimeout", txtWarehouseCommandSqlTimeout.Text);
            WebService.WsBIClient.ChangeSetting("AnalysisServicesProcessingTimeout", txtAnalysisServicesProcessingTimeout.Text);  
                        
            MessageBox.Show("Alterações Efetivadas com sucesso !");
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
