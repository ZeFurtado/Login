namespace Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboxSexo = new System.Windows.Forms.ComboBox();
            this.lblDbConnectionStatus = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtSenhaLogin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(525, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 349);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 64);
            this.button1.TabIndex = 15;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(50, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(125, 123);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 27);
            this.txtUsuario.TabIndex = 15;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(125, 180);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(320, 27);
            this.txtSenhaLogin.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(35, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(200, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmboxSexo);
            this.panel2.Controls.Add(this.lblDbConnectionStatus);
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtRepSenha);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.txtSobrenome);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 546);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(82, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sexo";
            // 
            // cmboxSexo
            // 
            this.cmboxSexo.FormattingEnabled = true;
            this.cmboxSexo.Location = new System.Drawing.Point(145, 228);
            this.cmboxSexo.Name = "cmboxSexo";
            this.cmboxSexo.Size = new System.Drawing.Size(151, 28);
            this.cmboxSexo.TabIndex = 13;
            // 
            // lblDbConnectionStatus
            // 
            this.lblDbConnectionStatus.AutoSize = true;
            this.lblDbConnectionStatus.Location = new System.Drawing.Point(3, 510);
            this.lblDbConnectionStatus.Name = "lblDbConnectionStatus";
            this.lblDbConnectionStatus.Size = new System.Drawing.Size(50, 20);
            this.lblDbConnectionStatus.TabIndex = 12;
            this.lblDbConnectionStatus.Text = "label7";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(145, 365);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(199, 64);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Senha de novo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(70, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // txtRepSenha
            // 
            this.txtRepSenha.Location = new System.Drawing.Point(145, 318);
            this.txtRepSenha.Name = "txtRepSenha";
            this.txtRepSenha.Size = new System.Drawing.Size(235, 27);
            this.txtRepSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(145, 275);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(235, 27);
            this.txtSenha.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(145, 182);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(320, 27);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(145, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(156, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(386, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1030, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtRepSenha;
        private TextBox txtSenha;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Label label1;
        private Button btnCadastro;
        private Label lblDbConnectionStatus;
        private Label label7;
        private ComboBox cmboxSexo;
        private Button button1;
        private Label label9;
        private TextBox txtUsuario;
        private TextBox txtSenhaLogin;
        private Label label8;
        private Button button2;
    }
}