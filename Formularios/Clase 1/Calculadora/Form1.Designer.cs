namespace Calculadora
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
            btnSuma = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            lblSimbolo = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.ControlDark;
            btnSuma.Location = new Point(97, 250);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 23);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += button1_Click;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = SystemColors.ControlDark;
            btnRestar.Location = new Point(268, 250);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = SystemColors.ControlDark;
            btnMultiplicar.Location = new Point(443, 250);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = SystemColors.ControlDark;
            btnDividir.Location = new Point(572, 250);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // txt1
            // 
            txt1.BackColor = SystemColors.ControlDark;
            txt1.Location = new Point(205, 101);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 4;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.BackColor = SystemColors.ControlDark;
            txt2.Location = new Point(443, 101);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 5;
            // 
            // lblSimbolo
            // 
            lblSimbolo.AutoSize = true;
            lblSimbolo.Location = new Point(356, 109);
            lblSimbolo.Name = "lblSimbolo";
            lblSimbolo.Size = new Size(15, 15);
            lblSimbolo.TabIndex = 6;
            lblSimbolo.Text = "+";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(356, 171);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblSimbolo);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSuma);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private TextBox txt1;
        private TextBox txt2;
        private Label lblSimbolo;
        private Label lblResultado;
    }
}
