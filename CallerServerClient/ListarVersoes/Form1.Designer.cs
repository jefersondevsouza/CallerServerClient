namespace ListarVersoes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowPanelOlimpo = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelOlimpoWithServer = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowPanelOlimpo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowPanelOlimpoWithServer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowPanelOlimpo
            // 
            this.flowPanelOlimpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelOlimpo.Location = new System.Drawing.Point(3, 3);
            this.flowPanelOlimpo.Name = "flowPanelOlimpo";
            this.flowPanelOlimpo.Size = new System.Drawing.Size(189, 303);
            this.flowPanelOlimpo.TabIndex = 1;
            // 
            // flowPanelOlimpoWithServer
            // 
            this.flowPanelOlimpoWithServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelOlimpoWithServer.Location = new System.Drawing.Point(198, 3);
            this.flowPanelOlimpoWithServer.Name = "flowPanelOlimpoWithServer";
            this.flowPanelOlimpoWithServer.Size = new System.Drawing.Size(189, 303);
            this.flowPanelOlimpoWithServer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Olimpo Versão";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOlimpo;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOlimpoWithServer;
    }
}

