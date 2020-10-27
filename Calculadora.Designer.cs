namespace Calculadora
{
    partial class Calculadora
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
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.groupoperaciones = new System.Windows.Forms.GroupBox();
            this.groupoperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumero1.Location = new System.Drawing.Point(115, 32);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 0;
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtnumero2.Location = new System.Drawing.Point(115, 59);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResultado.Location = new System.Drawing.Point(115, 236);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero1.Location = new System.Drawing.Point(30, 32);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 3;
            this.lblnumero1.Text = "Numero 1";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(30, 59);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(53, 13);
            this.lblnumero2.TabIndex = 4;
            this.lblnumero2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(41, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSumar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSumar.Location = new System.Drawing.Point(0, 19);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(118, 61);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Use me or I\'ll die";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestar.Location = new System.Drawing.Point(168, 19);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(118, 61);
            this.btnRestar.TabIndex = 8;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmultiplicar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmultiplicar.Location = new System.Drawing.Point(0, 84);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(115, 61);
            this.btnmultiplicar.TabIndex = 9;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = false;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDividir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDividir.Location = new System.Drawing.Point(168, 87);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(115, 61);
            this.btnDividir.TabIndex = 10;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // groupoperaciones
            // 
            this.groupoperaciones.Controls.Add(this.btnSumar);
            this.groupoperaciones.Controls.Add(this.btnDividir);
            this.groupoperaciones.Controls.Add(this.btnmultiplicar);
            this.groupoperaciones.Controls.Add(this.btnRestar);
            this.groupoperaciones.Location = new System.Drawing.Point(15, 85);
            this.groupoperaciones.Name = "groupoperaciones";
            this.groupoperaciones.Size = new System.Drawing.Size(289, 148);
            this.groupoperaciones.TabIndex = 11;
            this.groupoperaciones.TabStop = false;
            this.groupoperaciones.Text = "Operaciones Matematicas";
            this.groupoperaciones.Enter += new System.EventHandler(this.groupoperaciones_Enter);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(313, 299);
            this.Controls.Add(this.groupoperaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupoperaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.GroupBox groupoperaciones;
    }
}