namespace TFS2013BIAdmin.Console
{
    partial class frmProcessamentoManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessamentoManual));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoProcessamentoAnalysis = new System.Windows.Forms.ComboBox();
            this.btnProcessarAnalysis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbJobName = new System.Windows.Forms.ComboBox();
            this.cbCollection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcessarWerehouse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoProcessamentoAnalysis);
            this.groupBox1.Controls.Add(this.btnProcessarAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Database";
            // 
            // cbTipoProcessamentoAnalysis
            // 
            this.cbTipoProcessamentoAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProcessamentoAnalysis.FormattingEnabled = true;
            this.cbTipoProcessamentoAnalysis.Location = new System.Drawing.Point(24, 28);
            this.cbTipoProcessamentoAnalysis.Name = "cbTipoProcessamentoAnalysis";
            this.cbTipoProcessamentoAnalysis.Size = new System.Drawing.Size(217, 21);
            this.cbTipoProcessamentoAnalysis.TabIndex = 1;
            // 
            // btnProcessarAnalysis
            // 
            this.btnProcessarAnalysis.Location = new System.Drawing.Point(556, 26);
            this.btnProcessarAnalysis.Name = "btnProcessarAnalysis";
            this.btnProcessarAnalysis.Size = new System.Drawing.Size(121, 23);
            this.btnProcessarAnalysis.TabIndex = 0;
            this.btnProcessarAnalysis.Text = "Processar";
            this.btnProcessarAnalysis.UseVisualStyleBackColor = true;
            this.btnProcessarAnalysis.Click += new System.EventHandler(this.btnProcessarAnalysis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbJobName);
            this.groupBox2.Controls.Add(this.cbCollection);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnProcessarWerehouse);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warehouse";
            // 
            // cbJobName
            // 
            this.cbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobName.FormattingEnabled = true;
            this.cbJobName.Location = new System.Drawing.Point(258, 43);
            this.cbJobName.Name = "cbJobName";
            this.cbJobName.Size = new System.Drawing.Size(243, 21);
            this.cbJobName.TabIndex = 15;
            // 
            // cbCollection
            // 
            this.cbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollection.FormattingEnabled = true;
            this.cbCollection.Location = new System.Drawing.Point(24, 43);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.Size = new System.Drawing.Size(217, 21);
            this.cbCollection.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Collection";
            // 
            // btnProcessarWerehouse
            // 
            this.btnProcessarWerehouse.Location = new System.Drawing.Point(556, 41);
            this.btnProcessarWerehouse.Name = "btnProcessarWerehouse";
            this.btnProcessarWerehouse.Size = new System.Drawing.Size(121, 23);
            this.btnProcessarWerehouse.TabIndex = 1;
            this.btnProcessarWerehouse.Text = "Processar";
            this.btnProcessarWerehouse.UseVisualStyleBackColor = true;
            this.btnProcessarWerehouse.Click += new System.EventHandler(this.btnProcessarWerehouse_Click);
            // 
            // frmProcessamentoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcessamentoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processamento Manual";
            this.Load += new System.EventHandler(this.frmProcessamentoManual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcessarAnalysis;
        private System.Windows.Forms.Button btnProcessarWerehouse;
        private System.Windows.Forms.ComboBox cbTipoProcessamentoAnalysis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCollection;
        private System.Windows.Forms.ComboBox cbJobName;
    }
}