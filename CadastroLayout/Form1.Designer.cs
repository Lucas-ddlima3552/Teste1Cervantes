namespace CadastroLayout
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
            label1 = new Label();
            label2 = new Label();
            textBoxCPF = new TextBox();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 93);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 176);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite seu CPF:";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(572, 213);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(125, 27);
            textBoxCPF.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(572, 125);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(125, 27);
            textBoxNome.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(585, 278);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 4;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 450);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxCPF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBoxCPF;
        private TextBox textBoxNome;
        private Button buttonSalvar;
    }
}
