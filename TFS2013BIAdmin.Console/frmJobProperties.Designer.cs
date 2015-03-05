namespace TFS2013BIAdmin.Console
{
    partial class frmJobProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobProperties));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbJobInstancia = new System.Windows.Forms.GroupBox();
            this.tvStatusJobsInstancia = new System.Windows.Forms.TreeView();
            this.gbJobCollection = new System.Windows.Forms.GroupBox();
            this.tvStatusJobsCollection = new System.Windows.Forms.TreeView();
            this.gbJobInstancia.SuspendLayout();
            this.gbJobCollection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Propriedades";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbJobInstancia
            // 
            this.gbJobInstancia.Controls.Add(this.tvStatusJobsInstancia);
            this.gbJobInstancia.Location = new System.Drawing.Point(343, 51);
            this.gbJobInstancia.Name = "gbJobInstancia";
            this.gbJobInstancia.Size = new System.Drawing.Size(339, 415);
            this.gbJobInstancia.TabIndex = 5;
            this.gbJobInstancia.TabStop = false;
            this.gbJobInstancia.Text = "JOBs da instancia";
            // 
            // tvStatusJobsInstancia
            // 
            this.tvStatusJobsInstancia.Location = new System.Drawing.Point(17, 19);
            this.tvStatusJobsInstancia.Name = "tvStatusJobsInstancia";
            this.tvStatusJobsInstancia.Size = new System.Drawing.Size(307, 378);
            this.tvStatusJobsInstancia.TabIndex = 2;
            // 
            // gbJobCollection
            // 
            this.gbJobCollection.Controls.Add(this.tvStatusJobsCollection);
            this.gbJobCollection.Location = new System.Drawing.Point(12, 51);
            this.gbJobCollection.Name = "gbJobCollection";
            this.gbJobCollection.Size = new System.Drawing.Size(325, 415);
            this.gbJobCollection.TabIndex = 4;
            this.gbJobCollection.TabStop = false;
            this.gbJobCollection.Text = "JOBs por collection";
            // 
            // tvStatusJobsCollection
            // 
            this.tvStatusJobsCollection.Location = new System.Drawing.Point(17, 19);
            this.tvStatusJobsCollection.Name = "tvStatusJobsCollection";
            this.tvStatusJobsCollection.Size = new System.Drawing.Size(295, 378);
            this.tvStatusJobsCollection.TabIndex = 2;
            // 
            // frmJobProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 477);
            this.Controls.Add(this.gbJobInstancia);
            this.Controls.Add(this.gbJobCollection);
            this.Controls.Add(this.btnBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJobProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades das JOBs";
            this.gbJobInstancia.ResumeLayout(false);
            this.gbJobCollection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbJobInstancia;
        private System.Windows.Forms.TreeView tvStatusJobsInstancia;
        private System.Windows.Forms.GroupBox gbJobCollection;
        private System.Windows.Forms.TreeView tvStatusJobsCollection;
    }
}