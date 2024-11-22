namespace SumadedosNumeros
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
            label3 = new Label();
            label4 = new Label();
            TxtN1 = new TextBox();
            TxtN2 = new TextBox();
            TxtNr = new TextBox();
            Limpiar = new Button();
            Calcular = new Button();
            Salir = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(615, 33);
            label1.Name = "label1";
            label1.Size = new Size(274, 35);
            label1.TabIndex = 0;
            label1.Text = "Suma de Dos Números ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(318, 141);
            label2.Name = "label2";
            label2.Size = new Size(207, 28);
            label2.TabIndex = 1;
            label2.Text = "Primer Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Thistle;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(307, 216);
            label3.Name = "label3";
            label3.Size = new Size(232, 28);
            label3.TabIndex = 2;
            label3.Text = "Segundo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(358, 386);
            label4.Name = "label4";
            label4.Size = new Size(217, 36);
            label4.TabIndex = 3;
            label4.Text = "RESULTADO";
            // 
            // TxtN1
            // 
            TxtN1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtN1.Location = new Point(615, 132);
            TxtN1.Multiline = true;
            TxtN1.Name = "TxtN1";
            TxtN1.Size = new Size(189, 37);
            TxtN1.TabIndex = 4;
            // 
            // TxtN2
            // 
            TxtN2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtN2.Location = new Point(615, 207);
            TxtN2.Multiline = true;
            TxtN2.Name = "TxtN2";
            TxtN2.Size = new Size(189, 37);
            TxtN2.TabIndex = 5;
            // 
            // TxtNr
            // 
            TxtNr.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNr.Location = new Point(626, 386);
            TxtNr.Multiline = true;
            TxtNr.Name = "TxtNr";
            TxtNr.Size = new Size(150, 47);
            TxtNr.TabIndex = 6;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = Color.FromArgb(255, 128, 128);
            Limpiar.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Limpiar.Location = new Point(706, 522);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(135, 41);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = false;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.FromArgb(255, 128, 128);
            Calcular.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location = new Point(517, 522);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(135, 41);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.BackColor = Color.FromArgb(255, 128, 128);
            Salir.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Salir.Location = new Point(626, 593);
            Salir.Name = "Salir";
            Salir.Size = new Size(135, 41);
            Salir.TabIndex = 9;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = false;
            Salir.Click += Salir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Chocolate;
            label5.Location = new Point(37, 700);
            label5.Name = "label5";
            label5.Size = new Size(326, 24);
            label5.TabIndex = 10;
            label5.Text = "ANGEL DANIEL GARCIA DE LARA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1419, 763);
            Controls.Add(label5);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(Limpiar);
            Controls.Add(TxtNr);
            Controls.Add(TxtN2);
            Controls.Add(TxtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtN1;
        private TextBox TxtN2;
        private TextBox TxtNr;
        private Button Limpiar;
        private Button Calcular;
        private Button Salir;
        private Label label5;
    }
}
