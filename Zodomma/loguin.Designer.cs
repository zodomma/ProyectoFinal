namespace Zodomma
{
    partial class loguin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.btnloguin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // txtusu
            // 
            this.txtusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusu.ForeColor = System.Drawing.Color.DimGray;
            this.txtusu.Location = new System.Drawing.Point(351, 83);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(320, 13);
            this.txtusu.TabIndex = 1;
            this.txtusu.Text = "USUARIO";
            this.txtusu.Enter += new System.EventHandler(this.txtusu_Enter);
            this.txtusu.Leave += new System.EventHandler(this.txtusu_Leave);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.ForeColor = System.Drawing.Color.DimGray;
            this.txtcontra.Location = new System.Drawing.Point(351, 131);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(320, 13);
            this.txtcontra.TabIndex = 2;
            this.txtcontra.Text = "CONTRASEÑA";
            this.txtcontra.Enter += new System.EventHandler(this.txtcontra_Enter);
            this.txtcontra.Leave += new System.EventHandler(this.txtcontra_Leave);
            // 
            // btnloguin
            // 
            this.btnloguin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnloguin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnloguin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnloguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloguin.ForeColor = System.Drawing.Color.LightGray;
            this.btnloguin.Location = new System.Drawing.Point(351, 216);
            this.btnloguin.Name = "btnloguin";
            this.btnloguin.Size = new System.Drawing.Size(291, 39);
            this.btnloguin.TabIndex = 3;
            this.btnloguin.Text = "ACCEDER";
            this.btnloguin.UseVisualStyleBackColor = false;
            this.btnloguin.Click += new System.EventHandler(this.btnloguin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(428, 276);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Has olvidado la contraseña?";
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnloguin);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loguin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loguin";
            this.Load += new System.EventHandler(this.loguin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button btnloguin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}