using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFS2013BIAdmin.Console
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripServer.Text = "Conectado a: " + ConfigurationManager.AppSettings["TfsServer"];
        }

        private void paramertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoesWsWhereHouseControl frmConfig = new frmConfiguracoesWsWhereHouseControl();
            frmConfig.MdiParent = this;
            frmConfig.Show();
        }

        private void statusDasJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessingStatus frmStatus = new frmProcessingStatus();
            frmStatus.MdiParent = this;
            frmStatus.Show();
        }

        private void propriedadesDasJobsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmJobProperties frmJobs = new frmJobProperties();
            frmJobs.MdiParent = this;
            frmJobs.Show();
        }

        private void processamentoManualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProcessamentoManual frmProcManual = new frmProcessamentoManual();
            frmProcManual.MdiParent = this;
            frmProcManual.Show();
        }

        private void alterarStatusDosServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetStates frmState = new frmSetStates();
            frmState.MdiParent = this;
            frmState.Show();
        }

    }
}
