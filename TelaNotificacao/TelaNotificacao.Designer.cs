namespace TelaNotificacao
{
    partial class TelaNotificacao
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNotificacao));
            this.txtNotificacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNotificacao
            // 
            this.txtNotificacao.AutoSize = true;
            this.txtNotificacao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotificacao.Location = new System.Drawing.Point(12, 9);
            this.txtNotificacao.Name = "txtNotificacao";
            this.txtNotificacao.Size = new System.Drawing.Size(50, 20);
            this.txtNotificacao.TabIndex = 0;
            this.txtNotificacao.Text = "label1";
            this.txtNotificacao.Click += new System.EventHandler(this.txtNotificacao_Click);
            // 
            // TelaNotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 139);
            this.Controls.Add(this.txtNotificacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.AutoSize = false;
            FormProgress();
            this.Name = "TelaNotificacao";
            this.Text = "Atenção!";
            this.Load += new System.EventHandler(this.TelaNotificacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void FormProgress()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        #endregion

        private Label txtNotificacao;
    }
}