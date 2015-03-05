namespace TFS2013BIAdmin.Console
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.paramertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDasJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriedadesDasJobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.processamentoManualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarStatusDosServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramertosToolStripMenuItem,
            this.statusDasJobsToolStripMenuItem,
            this.propriedadesDasJobsToolStripMenuItem1,
            this.processamentoManualToolStripMenuItem1,
            this.alterarStatusDosServiçosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // paramertosToolStripMenuItem
            // 
            this.paramertosToolStripMenuItem.Name = "paramertosToolStripMenuItem";
            this.paramertosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.paramertosToolStripMenuItem.Text = "Parametros";
            this.paramertosToolStripMenuItem.Click += new System.EventHandler(this.paramertosToolStripMenuItem_Click);
            // 
            // statusDasJobsToolStripMenuItem
            // 
            this.statusDasJobsToolStripMenuItem.Name = "statusDasJobsToolStripMenuItem";
            this.statusDasJobsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.statusDasJobsToolStripMenuItem.Text = "Status das Jobs";
            this.statusDasJobsToolStripMenuItem.Click += new System.EventHandler(this.statusDasJobsToolStripMenuItem_Click);
            // 
            // propriedadesDasJobsToolStripMenuItem1
            // 
            this.propriedadesDasJobsToolStripMenuItem1.Name = "propriedadesDasJobsToolStripMenuItem1";
            this.propriedadesDasJobsToolStripMenuItem1.Size = new System.Drawing.Size(135, 20);
            this.propriedadesDasJobsToolStripMenuItem1.Text = "Propriedades das Jobs";
            this.propriedadesDasJobsToolStripMenuItem1.Click += new System.EventHandler(this.propriedadesDasJobsToolStripMenuItem1_Click);
            // 
            // processamentoManualToolStripMenuItem1
            // 
            this.processamentoManualToolStripMenuItem1.Name = "processamentoManualToolStripMenuItem1";
            this.processamentoManualToolStripMenuItem1.Size = new System.Drawing.Size(143, 20);
            this.processamentoManualToolStripMenuItem1.Text = "Processamento Manual";
            this.processamentoManualToolStripMenuItem1.Click += new System.EventHandler(this.processamentoManualToolStripMenuItem1_Click);
            // 
            // alterarStatusDosServiçosToolStripMenuItem
            // 
            this.alterarStatusDosServiçosToolStripMenuItem.Name = "alterarStatusDosServiçosToolStripMenuItem";
            this.alterarStatusDosServiçosToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.alterarStatusDosServiçosToolStripMenuItem.Text = "Alterar Status dos Serviços";
            this.alterarStatusDosServiçosToolStripMenuItem.Click += new System.EventHandler(this.alterarStatusDosServiçosToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripServer});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(803, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripServer
            // 
            this.toolStripServer.Name = "toolStripServer";
            this.toolStripServer.Size = new System.Drawing.Size(80, 17);
            this.toolStripServer.Text = "tollStripServer";
            this.toolStripServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "TFS Warehouse Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripServer;
        private System.Windows.Forms.ToolStripMenuItem paramertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusDasJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriedadesDasJobsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem processamentoManualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarStatusDosServiçosToolStripMenuItem;
    }
}



