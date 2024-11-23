namespace WinFormsAppTablaMultiplicar
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
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            txtNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 220, 255);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(txtNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(8, 9);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(784, 436);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxResultados.Location = new Point(405, 126);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(224, 260);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.FromArgb(255, 190, 255);
            buttonVer.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVer.Location = new Point(149, 216);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(160, 27);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(149, 171);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(160, 23);
            txtNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BorderStyle = BorderStyle.FixedSingle;
            labelNumero.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.Location = new Point(137, 126);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(191, 21);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(255, 190, 255);
            labelTitulo.BorderStyle = BorderStyle.Fixed3D;
            labelTitulo.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(266, 31);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(274, 30);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button buttonVer;
        private TextBox txtNum;
        private Label labelNumero;
        private Label labelTitulo;
        private RichTextBox richTextBoxResultados;
    }
}
