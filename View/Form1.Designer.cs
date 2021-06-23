
namespace rocketpowers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.botaoEnter = new System.Windows.Forms.Button();
            this.painelCentral = new System.Windows.Forms.Panel();
            this.painelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(18, 98);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '#';
            this.txtsenha.Size = new System.Drawing.Size(215, 24);
            this.txtsenha.TabIndex = 4;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCad.Location = new System.Drawing.Point(18, 176);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(214, 24);
            this.btnCad.TabIndex = 5;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(18, 214);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(214, 24);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(18, 39);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(215, 24);
            this.txtlogin.TabIndex = 3;
            // 
            // botaoEnter
            // 
            this.botaoEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.botaoEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoEnter.Location = new System.Drawing.Point(18, 137);
            this.botaoEnter.Name = "botaoEnter";
            this.botaoEnter.Size = new System.Drawing.Size(214, 24);
            this.botaoEnter.TabIndex = 0;
            this.botaoEnter.Text = "Enter";
            this.botaoEnter.UseVisualStyleBackColor = false;
            this.botaoEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // painelCentral
            // 
            this.painelCentral.BackColor = System.Drawing.Color.Silver;
            this.painelCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painelCentral.BackgroundImage")));
            this.painelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painelCentral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painelCentral.Controls.Add(this.botaoEnter);
            this.painelCentral.Controls.Add(this.txtlogin);
            this.painelCentral.Controls.Add(this.btnSair);
            this.painelCentral.Controls.Add(this.btnCad);
            this.painelCentral.Controls.Add(this.txtsenha);
            this.painelCentral.Controls.Add(this.label2);
            this.painelCentral.Controls.Add(this.label1);
            this.painelCentral.Font = new System.Drawing.Font("Arial", 11F);
            this.painelCentral.Location = new System.Drawing.Point(557, 213);
            this.painelCentral.Name = "painelCentral";
            this.painelCentral.Size = new System.Drawing.Size(253, 273);
            this.painelCentral.TabIndex = 0;
            this.painelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 590);
            this.Controls.Add(this.painelCentral);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelCentral.ResumeLayout(false);
            this.painelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Button botaoEnter;
        private System.Windows.Forms.Panel painelCentral;
    }
}

