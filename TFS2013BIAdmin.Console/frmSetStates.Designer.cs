namespace TFS2013BIAdmin.Console
{
    partial class frmSetStates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetStates));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoProcessamentoAnalysis = new System.Windows.Forms.ComboBox();
            this.btnConfigAnalysis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCollection = new System.Windows.Forms.ComboBox();
            this.cbJobName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStateWerehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigWerehouse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoProcessamentoAnalysis);
            this.groupBox1.Controls.Add(this.btnConfigAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis";
            // 
            // cbTipoProcessamentoAnalysis
            // 
            this.cbTipoProcessamentoAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProcessamentoAnalysis.FormattingEnabled = true;
            this.cbTipoProcessamentoAnalysis.Location = new System.Drawing.Point(19, 29);
            this.cbTipoProcessamentoAnalysis.Name = "cbTipoProcessamentoAnalysis";
            this.cbTipoProcessamentoAnalysis.Size = new System.Drawing.Size(217, 21);
            this.cbTipoProcessamentoAnalysis.TabIndex = 2;
            // 
            // btnConfigAnalysis
            // 
            this.btnConfigAnalysis.Location = new System.Drawing.Point(631, 27);
            this.btnConfigAnalysis.Name = "btnConfigAnalysis";
            this.btnConfigAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnConfigAnalysis.TabIndex = 0;
            this.btnConfigAnalysis.Text = "Configurar";
            this.btnConfigAnalysis.UseVisualStyleBackColor = true;
            this.btnConfigAnalysis.Click += new System.EventHandler(this.btnConfigAnalysis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCollection);
            this.groupBox2.Controls.Add(this.cbJobName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbStateWerehouse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConfigWerehouse);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Werehouse";
            // 
            // cbCollection
            // 
            this.cbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollection.FormattingEnabled = true;
            this.cbCollection.Location = new System.Drawing.Point(18, 44);
            this.cbCollection.Name = "cbCollection";
            this.cbCollection.Size = new System.Drawing.Size(166, 21);
            this.cbCollection.TabIndex = 13;
            // 
            // cbJobName
            // 
            this.cbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobName.FormattingEnabled = true;
            this.cbJobName.Location = new System.Drawing.Point(190, 44);
            this.cbJobName.Name = "cbJobName";
            this.cbJobName.Size = new System.Drawing.Size(243, 21);
            this.cbJobName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "State";
            // 
            // cbStateWerehouse
            // 
            this.cbStateWerehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStateWerehouse.FormattingEnabled = true;
            this.cbStateWerehouse.Location = new System.Drawing.Point(439, 43);
            this.cbStateWerehouse.Name = "cbStateWerehouse";
            this.cbStateWerehouse.Size = new System.Drawing.Size(132, 21);
            this.cbStateWerehouse.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Collection";
            // 
            // btnConfigWerehouse
            // 
            this.btnConfigWerehouse.Location = new System.Drawing.Point(631, 41);
            this.btnConfigWerehouse.Name = "btnConfigWerehouse";
            this.btnConfigWerehouse.Size = new System.Drawing.Size(75, 23);
            this.btnConfigWerehouse.TabIndex = 1;
            this.btnConfigWerehouse.Text = "Configurar";
            this.btnConfigWerehouse.UseVisualStyleBackColor = true;
            this.btnConfigWerehouse.Click += new System.EventHandler(this.btnConfigWerehouse_Click);
            // 
            // frmSetStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 193);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetStates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar status dos servicos";
            this.Load += new System.EventHandler(this.frmSetStates_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfigAnalysis;
        private System.Windows.Forms.Button btnConfigWerehouse;
        private System.Windows.Forms.ComboBox cbTipoProcessamentoAnalysis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStateWerehouse;
        private System.Windows.Forms.ComboBox cbJobName;
        private System.Windows.Forms.ComboBox cbCollection;
    }
}