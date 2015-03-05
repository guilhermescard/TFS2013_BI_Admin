namespace TFS2013BIAdmin.Console
{
    partial class frmConfiguracoesWsWhereHouseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoesWsWhereHouseControl));
            this.btnBuscaConfigs = new System.Windows.Forms.Button();
            this.btnEfetivarAlteracoes = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.gbValoresDefault = new System.Windows.Forms.GroupBox();
            this.txtAnalysisServicesProcessingTimeoutDefault = new System.Windows.Forms.TextBox();
            this.txtWarehouseCommandSqlTimeoutDefault = new System.Windows.Forms.TextBox();
            this.txtDataUpdateWaitSecondsDefault = new System.Windows.Forms.TextBox();
            this.txtSchemaUpdateWaitSecondsDefault = new System.Windows.Forms.TextBox();
            this.txtAnalysisSchemaUpdateWaitSecondsDefault = new System.Windows.Forms.TextBox();
            this.txtMaxParallelASProcessingCommandsDefault = new System.Windows.Forms.TextBox();
            this.txtDailyFullProcessingTimeDefault = new System.Windows.Forms.TextBox();
            this.txtFullProcessIntervalSecondsDefault = new System.Windows.Forms.TextBox();
            this.txtIncrementalProcessIntervalSecondsDerfault = new System.Windows.Forms.TextBox();
            this.txtRunIntervalSecondsDefault = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAnalysisServicesProcessingTimeout = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWarehouseCommandSqlTimeout = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDataUpdateWaitSeconds = new System.Windows.Forms.TextBox();
            this.txtSchemaUpdateWaitSeconds = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAnalysisSchemaUpdateWaitSeconds = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxParallelASProcessingCommands = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDailyFullProcessingTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullProcessIntervalSeconds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIncrementalProcessIntervalSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRunIntervalSeconds = new System.Windows.Forms.TextBox();
            this.gbParametros.SuspendLayout();
            this.gbValoresDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscaConfigs
            // 
            this.btnBuscaConfigs.Location = new System.Drawing.Point(12, 12);
            this.btnBuscaConfigs.Name = "btnBuscaConfigs";
            this.btnBuscaConfigs.Size = new System.Drawing.Size(149, 23);
            this.btnBuscaConfigs.TabIndex = 0;
            this.btnBuscaConfigs.Text = "Buscar Configuracoes";
            this.btnBuscaConfigs.UseVisualStyleBackColor = true;
            this.btnBuscaConfigs.Click += new System.EventHandler(this.btnBuscaConfigs_Click);
            // 
            // btnEfetivarAlteracoes
            // 
            this.btnEfetivarAlteracoes.Location = new System.Drawing.Point(736, 576);
            this.btnEfetivarAlteracoes.Name = "btnEfetivarAlteracoes";
            this.btnEfetivarAlteracoes.Size = new System.Drawing.Size(154, 23);
            this.btnEfetivarAlteracoes.TabIndex = 3;
            this.btnEfetivarAlteracoes.Text = "Efetivar alteracoes";
            this.btnEfetivarAlteracoes.UseVisualStyleBackColor = true;
            this.btnEfetivarAlteracoes.Click += new System.EventHandler(this.btnEfetivarAlteracoes_Click);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.gbValoresDefault);
            this.gbParametros.Controls.Add(this.label12);
            this.gbParametros.Controls.Add(this.label18);
            this.gbParametros.Controls.Add(this.txtAnalysisServicesProcessingTimeout);
            this.gbParametros.Controls.Add(this.label14);
            this.gbParametros.Controls.Add(this.txtWarehouseCommandSqlTimeout);
            this.gbParametros.Controls.Add(this.label16);
            this.gbParametros.Controls.Add(this.txtDataUpdateWaitSeconds);
            this.gbParametros.Controls.Add(this.txtSchemaUpdateWaitSeconds);
            this.gbParametros.Controls.Add(this.label20);
            this.gbParametros.Controls.Add(this.txtAnalysisSchemaUpdateWaitSeconds);
            this.gbParametros.Controls.Add(this.label10);
            this.gbParametros.Controls.Add(this.txtMaxParallelASProcessingCommands);
            this.gbParametros.Controls.Add(this.label8);
            this.gbParametros.Controls.Add(this.txtDailyFullProcessingTime);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.txtFullProcessIntervalSeconds);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.txtIncrementalProcessIntervalSeconds);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.txtRunIntervalSeconds);
            this.gbParametros.Location = new System.Drawing.Point(12, 41);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(878, 529);
            this.gbParametros.TabIndex = 6;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // gbValoresDefault
            // 
            this.gbValoresDefault.Controls.Add(this.txtAnalysisServicesProcessingTimeoutDefault);
            this.gbValoresDefault.Controls.Add(this.txtWarehouseCommandSqlTimeoutDefault);
            this.gbValoresDefault.Controls.Add(this.txtDataUpdateWaitSecondsDefault);
            this.gbValoresDefault.Controls.Add(this.txtSchemaUpdateWaitSecondsDefault);
            this.gbValoresDefault.Controls.Add(this.txtAnalysisSchemaUpdateWaitSecondsDefault);
            this.gbValoresDefault.Controls.Add(this.txtMaxParallelASProcessingCommandsDefault);
            this.gbValoresDefault.Controls.Add(this.txtDailyFullProcessingTimeDefault);
            this.gbValoresDefault.Controls.Add(this.txtFullProcessIntervalSecondsDefault);
            this.gbValoresDefault.Controls.Add(this.txtIncrementalProcessIntervalSecondsDerfault);
            this.gbValoresDefault.Controls.Add(this.txtRunIntervalSecondsDefault);
            this.gbValoresDefault.Location = new System.Drawing.Point(697, 19);
            this.gbValoresDefault.Name = "gbValoresDefault";
            this.gbValoresDefault.Size = new System.Drawing.Size(175, 490);
            this.gbValoresDefault.TabIndex = 46;
            this.gbValoresDefault.TabStop = false;
            this.gbValoresDefault.Text = "Valores Default";
            // 
            // txtAnalysisServicesProcessingTimeoutDefault
            // 
            this.txtAnalysisServicesProcessingTimeoutDefault.Enabled = false;
            this.txtAnalysisServicesProcessingTimeoutDefault.Location = new System.Drawing.Point(24, 452);
            this.txtAnalysisServicesProcessingTimeoutDefault.Name = "txtAnalysisServicesProcessingTimeoutDefault";
            this.txtAnalysisServicesProcessingTimeoutDefault.Size = new System.Drawing.Size(90, 20);
            this.txtAnalysisServicesProcessingTimeoutDefault.TabIndex = 55;
            // 
            // txtWarehouseCommandSqlTimeoutDefault
            // 
            this.txtWarehouseCommandSqlTimeoutDefault.Enabled = false;
            this.txtWarehouseCommandSqlTimeoutDefault.Location = new System.Drawing.Point(24, 426);
            this.txtWarehouseCommandSqlTimeoutDefault.Name = "txtWarehouseCommandSqlTimeoutDefault";
            this.txtWarehouseCommandSqlTimeoutDefault.Size = new System.Drawing.Size(90, 20);
            this.txtWarehouseCommandSqlTimeoutDefault.TabIndex = 54;
            // 
            // txtDataUpdateWaitSecondsDefault
            // 
            this.txtDataUpdateWaitSecondsDefault.Enabled = false;
            this.txtDataUpdateWaitSecondsDefault.Location = new System.Drawing.Point(24, 349);
            this.txtDataUpdateWaitSecondsDefault.Name = "txtDataUpdateWaitSecondsDefault";
            this.txtDataUpdateWaitSecondsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtDataUpdateWaitSecondsDefault.TabIndex = 53;
            // 
            // txtSchemaUpdateWaitSecondsDefault
            // 
            this.txtSchemaUpdateWaitSecondsDefault.Enabled = false;
            this.txtSchemaUpdateWaitSecondsDefault.Location = new System.Drawing.Point(24, 275);
            this.txtSchemaUpdateWaitSecondsDefault.Name = "txtSchemaUpdateWaitSecondsDefault";
            this.txtSchemaUpdateWaitSecondsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtSchemaUpdateWaitSecondsDefault.TabIndex = 52;
            // 
            // txtAnalysisSchemaUpdateWaitSecondsDefault
            // 
            this.txtAnalysisSchemaUpdateWaitSecondsDefault.Enabled = false;
            this.txtAnalysisSchemaUpdateWaitSecondsDefault.Location = new System.Drawing.Point(24, 193);
            this.txtAnalysisSchemaUpdateWaitSecondsDefault.Name = "txtAnalysisSchemaUpdateWaitSecondsDefault";
            this.txtAnalysisSchemaUpdateWaitSecondsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtAnalysisSchemaUpdateWaitSecondsDefault.TabIndex = 51;
            // 
            // txtMaxParallelASProcessingCommandsDefault
            // 
            this.txtMaxParallelASProcessingCommandsDefault.Enabled = false;
            this.txtMaxParallelASProcessingCommandsDefault.Location = new System.Drawing.Point(24, 148);
            this.txtMaxParallelASProcessingCommandsDefault.Name = "txtMaxParallelASProcessingCommandsDefault";
            this.txtMaxParallelASProcessingCommandsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtMaxParallelASProcessingCommandsDefault.TabIndex = 50;
            // 
            // txtDailyFullProcessingTimeDefault
            // 
            this.txtDailyFullProcessingTimeDefault.Enabled = false;
            this.txtDailyFullProcessingTimeDefault.Location = new System.Drawing.Point(24, 96);
            this.txtDailyFullProcessingTimeDefault.Name = "txtDailyFullProcessingTimeDefault";
            this.txtDailyFullProcessingTimeDefault.Size = new System.Drawing.Size(130, 20);
            this.txtDailyFullProcessingTimeDefault.TabIndex = 49;
            // 
            // txtFullProcessIntervalSecondsDefault
            // 
            this.txtFullProcessIntervalSecondsDefault.Enabled = false;
            this.txtFullProcessIntervalSecondsDefault.Location = new System.Drawing.Point(24, 70);
            this.txtFullProcessIntervalSecondsDefault.Name = "txtFullProcessIntervalSecondsDefault";
            this.txtFullProcessIntervalSecondsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtFullProcessIntervalSecondsDefault.TabIndex = 48;
            // 
            // txtIncrementalProcessIntervalSecondsDerfault
            // 
            this.txtIncrementalProcessIntervalSecondsDerfault.Enabled = false;
            this.txtIncrementalProcessIntervalSecondsDerfault.Location = new System.Drawing.Point(24, 44);
            this.txtIncrementalProcessIntervalSecondsDerfault.Name = "txtIncrementalProcessIntervalSecondsDerfault";
            this.txtIncrementalProcessIntervalSecondsDerfault.Size = new System.Drawing.Size(90, 20);
            this.txtIncrementalProcessIntervalSecondsDerfault.TabIndex = 47;
            // 
            // txtRunIntervalSecondsDefault
            // 
            this.txtRunIntervalSecondsDefault.Enabled = false;
            this.txtRunIntervalSecondsDefault.Location = new System.Drawing.Point(24, 18);
            this.txtRunIntervalSecondsDefault.Name = "txtRunIntervalSecondsDefault";
            this.txtRunIntervalSecondsDefault.Size = new System.Drawing.Size(90, 20);
            this.txtRunIntervalSecondsDefault.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(549, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "O tempo de espera para uma chamada de processamento Analysis Services para comple" +
    "tar. Medido em segundos.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(491, 65);
            this.label18.TabIndex = 31;
            this.label18.Text = resources.GetString("label18.Text");
            // 
            // txtAnalysisServicesProcessingTimeout
            // 
            this.txtAnalysisServicesProcessingTimeout.Location = new System.Drawing.Point(561, 471);
            this.txtAnalysisServicesProcessingTimeout.Name = "txtAnalysisServicesProcessingTimeout";
            this.txtAnalysisServicesProcessingTimeout.Size = new System.Drawing.Size(90, 20);
            this.txtAnalysisServicesProcessingTimeout.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(410, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Timeout utilizado para a aquisição de um acesso exclusivo a um recurso de armazém" +
    ".";
            // 
            // txtWarehouseCommandSqlTimeout
            // 
            this.txtWarehouseCommandSqlTimeout.Location = new System.Drawing.Point(561, 445);
            this.txtWarehouseCommandSqlTimeout.Name = "txtWarehouseCommandSqlTimeout";
            this.txtWarehouseCommandSqlTimeout.Size = new System.Drawing.Size(90, 20);
            this.txtWarehouseCommandSqlTimeout.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(490, 78);
            this.label16.TabIndex = 35;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // txtDataUpdateWaitSeconds
            // 
            this.txtDataUpdateWaitSeconds.Location = new System.Drawing.Point(561, 368);
            this.txtDataUpdateWaitSeconds.Name = "txtDataUpdateWaitSeconds";
            this.txtDataUpdateWaitSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtDataUpdateWaitSeconds.TabIndex = 34;
            // 
            // txtSchemaUpdateWaitSeconds
            // 
            this.txtSchemaUpdateWaitSeconds.Location = new System.Drawing.Point(561, 294);
            this.txtSchemaUpdateWaitSeconds.Name = "txtSchemaUpdateWaitSeconds";
            this.txtSchemaUpdateWaitSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtSchemaUpdateWaitSeconds.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(521, 65);
            this.label20.TabIndex = 27;
            this.label20.Text = resources.GetString("label20.Text");
            // 
            // txtAnalysisSchemaUpdateWaitSeconds
            // 
            this.txtAnalysisSchemaUpdateWaitSeconds.Location = new System.Drawing.Point(561, 212);
            this.txtAnalysisSchemaUpdateWaitSeconds.Name = "txtAnalysisSchemaUpdateWaitSeconds";
            this.txtAnalysisSchemaUpdateWaitSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtAnalysisSchemaUpdateWaitSeconds.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(486, 39);
            this.label10.TabIndex = 23;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // txtMaxParallelASProcessingCommands
            // 
            this.txtMaxParallelASProcessingCommands.Location = new System.Drawing.Point(561, 167);
            this.txtMaxParallelASProcessingCommands.Name = "txtMaxParallelASProcessingCommands";
            this.txtMaxParallelASProcessingCommands.Size = new System.Drawing.Size(90, 20);
            this.txtMaxParallelASProcessingCommands.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(525, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "O tempo do dia, quando o processamento completo do cubo é iniciado. Por padrão, e" +
    "le é definido para 02:00.";
            // 
            // txtDailyFullProcessingTime
            // 
            this.txtDailyFullProcessingTime.Location = new System.Drawing.Point(561, 115);
            this.txtDailyFullProcessingTime.Name = "txtDailyFullProcessingTime";
            this.txtDailyFullProcessingTime.Size = new System.Drawing.Size(130, 20);
            this.txtDailyFullProcessingTime.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Frequência com que o banco de dados de analise é totalmente processado. Medido em" +
    " segundos.";
            // 
            // txtFullProcessIntervalSeconds
            // 
            this.txtFullProcessIntervalSeconds.Location = new System.Drawing.Point(561, 89);
            this.txtFullProcessIntervalSeconds.Name = "txtFullProcessIntervalSeconds";
            this.txtFullProcessIntervalSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtFullProcessIntervalSeconds.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Frequência com que o banco de dados de analise é atualizado. Medido em segundos.";
            // 
            // txtIncrementalProcessIntervalSeconds
            // 
            this.txtIncrementalProcessIntervalSeconds.Location = new System.Drawing.Point(561, 63);
            this.txtIncrementalProcessIntervalSeconds.Name = "txtIncrementalProcessIntervalSeconds";
            this.txtIncrementalProcessIntervalSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtIncrementalProcessIntervalSeconds.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frequência com que os trabalhos TFS Warehouse Data Sync estão em execução. Medido" +
    " em segundos.";
            // 
            // txtRunIntervalSeconds
            // 
            this.txtRunIntervalSeconds.Location = new System.Drawing.Point(561, 37);
            this.txtRunIntervalSeconds.Name = "txtRunIntervalSeconds";
            this.txtRunIntervalSeconds.Size = new System.Drawing.Size(90, 20);
            this.txtRunIntervalSeconds.TabIndex = 6;
            // 
            // frmConfiguracoesWsWhereHouseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 611);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.btnEfetivarAlteracoes);
            this.Controls.Add(this.btnBuscaConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracoesWsWhereHouseControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracao dos parametros do Wherehouse Control";
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbValoresDefault.ResumeLayout(false);
            this.gbValoresDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscaConfigs;
        private System.Windows.Forms.Button btnEfetivarAlteracoes;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRunIntervalSeconds;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAnalysisServicesProcessingTimeout;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWarehouseCommandSqlTimeout;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDataUpdateWaitSeconds;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSchemaUpdateWaitSeconds;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAnalysisSchemaUpdateWaitSeconds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxParallelASProcessingCommands;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDailyFullProcessingTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullProcessIntervalSeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIncrementalProcessIntervalSeconds;
        private System.Windows.Forms.GroupBox gbValoresDefault;
        private System.Windows.Forms.TextBox txtAnalysisServicesProcessingTimeoutDefault;
        private System.Windows.Forms.TextBox txtWarehouseCommandSqlTimeoutDefault;
        private System.Windows.Forms.TextBox txtDataUpdateWaitSecondsDefault;
        private System.Windows.Forms.TextBox txtSchemaUpdateWaitSecondsDefault;
        private System.Windows.Forms.TextBox txtAnalysisSchemaUpdateWaitSecondsDefault;
        private System.Windows.Forms.TextBox txtMaxParallelASProcessingCommandsDefault;
        private System.Windows.Forms.TextBox txtDailyFullProcessingTimeDefault;
        private System.Windows.Forms.TextBox txtFullProcessIntervalSecondsDefault;
        private System.Windows.Forms.TextBox txtIncrementalProcessIntervalSecondsDerfault;
        private System.Windows.Forms.TextBox txtRunIntervalSecondsDefault;
    }
}

