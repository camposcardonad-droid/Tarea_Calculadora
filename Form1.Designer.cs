namespace Calculadora2
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
            txtPantalla = new TextBox();
            lblResultado = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnBorrar = new Button();
            btnDivision = new Button();
            btnSiete = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicacion = new Button();
            btnCuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnMenos = new Button();
            btnUno = new Button();
            btn2 = new Button();
            btnTres = new Button();
            btnMas = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(22, 31);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(450, 23);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(420, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 1;
            lblResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(31, 60);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(100, 100);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(140, 60);
            btnC.Name = "btnC";
            btnC.Size = new Size(100, 100);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(246, 60);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 100);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "⌫";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(372, 60);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(100, 100);
            btnDivision.TabIndex = 2;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            btnSiete.Location = new Point(34, 166);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(100, 100);
            btnSiete.TabIndex = 2;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += numero_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(140, 166);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += numero_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(246, 166);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += numero_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(372, 166);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(100, 100);
            btnMultiplicacion.TabIndex = 2;
            btnMultiplicacion.Text = "*";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnCuatro
            // 
            btnCuatro.Location = new Point(31, 272);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(100, 100);
            btnCuatro.TabIndex = 2;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += numero_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(140, 272);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(100, 100);
            btnCinco.TabIndex = 2;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += numero_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(246, 272);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(100, 100);
            btnSeis.TabIndex = 2;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += numero_Click;
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(372, 272);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(100, 100);
            btnMenos.TabIndex = 2;
            btnMenos.Text = "- ";
            btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(31, 378);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(100, 100);
            btnUno.TabIndex = 2;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += numero_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(140, 378);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += numero_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(246, 378);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(100, 100);
            btnTres.TabIndex = 2;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += numero_Click;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(372, 378);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(100, 100);
            btnMas.TabIndex = 2;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(31, 484);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(100, 100);
            btnPunto.TabIndex = 2;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += numero_Click;
            // 
            // btnCero
            // 
            btnCero.Location = new Point(140, 484);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(100, 100);
            btnCero.TabIndex = 2;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += numero_Click;
            // 
            // btnSigno
            // 
            btnSigno.Location = new Point(246, 484);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(100, 100);
            btnSigno.TabIndex = 2;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += signo_click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(372, 484);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(100, 100);
            btnIgual.TabIndex = 2;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 611);
            Controls.Add(btnIgual);
            Controls.Add(btnMas);
            Controls.Add(btnMenos);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnDivision);
            Controls.Add(btnSigno);
            Controls.Add(btnTres);
            Controls.Add(btnSeis);
            Controls.Add(btnCero);
            Controls.Add(btn2);
            Controls.Add(btnCinco);
            Controls.Add(btn9);
            Controls.Add(btnPunto);
            Controls.Add(btnUno);
            Controls.Add(btn8);
            Controls.Add(btnCuatro);
            Controls.Add(btnBorrar);
            Controls.Add(btnSiete);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblResultado);
            Controls.Add(txtPantalla);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Label lblResultado;
        private Button btnCE;
        private Button btnC;
        private Button btnBorrar;
        private Button btnDivision;
        private Button btnSiete;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacion;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnMenos;
        private Button btnUno;
        private Button btn2;
        private Button btnTres;
        private Button btnMas;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
        private Button btnIgual;
    }
}
