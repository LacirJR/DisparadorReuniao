namespace Notificacao
{
    partial class DisparadorNotificacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisparadorNotificacao));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIrParaLink = new System.Windows.Forms.Button();
            this.txtIncluirLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o link para reunião:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIrParaLink
            // 
            this.btnIrParaLink.Location = new System.Drawing.Point(297, 83);
            this.btnIrParaLink.Name = "btnIrParaLink";
            this.btnIrParaLink.Size = new System.Drawing.Size(75, 23);
            this.btnIrParaLink.TabIndex = 2;
            this.btnIrParaLink.Text = "Ir";
            this.btnIrParaLink.UseVisualStyleBackColor = true;
            this.btnIrParaLink.Click += new System.EventHandler(this.btnIrParaLink_Click);
            // 
            // txtIncluirLink
            // 
            this.txtIncluirLink.Location = new System.Drawing.Point(12, 83);
            this.txtIncluirLink.Name = "txtIncluirLink";
            this.txtIncluirLink.Size = new System.Drawing.Size(279, 23);
            this.txtIncluirLink.TabIndex = 3;
            this.txtIncluirLink.TextChanged += new System.EventHandler(this.txtIncluirLink_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = " Versão 1.0";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(13, 109);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(209, 15);
            this.lblErro.TabIndex = 5;
            this.lblErro.Text = "Insira um link correto do google meet!";
            this.lblErro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Não feche a aplicação antes de terminar a reunião!";
            // 
            // DisparadorNotificacao
            // 
            this.AcceptButton = this.btnIrParaLink;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIncluirLink);
            this.Controls.Add(this.btnIrParaLink);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DisparadorNotificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disparar Notificação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnIrParaLink;
        private TextBox txtIncluirLink;
        private Label label2;
        private Label lblErro;
        private Label label3;
    }
}