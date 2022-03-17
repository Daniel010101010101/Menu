namespace Project
{
    partial class calculator
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
            this.lblResultado = new System.Windows.Forms.GroupBox();
            this.numero3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdivision = new System.Windows.Forms.RadioButton();
            this.rdbmultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdbrestar = new System.Windows.Forms.RadioButton();
            this.rdbsumar = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.btnbackcalculator = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Controls.Add(this.numero3);
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(129, 349);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(542, 158);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.TabStop = false;
            this.lblResultado.Text = "Result";
            // 
            // numero3
            // 
            this.numero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero3.Location = new System.Drawing.Point(181, 57);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(187, 45);
            this.numero3.TabIndex = 7;
            this.numero3.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdivision);
            this.groupBox1.Controls.Add(this.rdbmultiplicacion);
            this.groupBox1.Controls.Add(this.rdbrestar);
            this.groupBox1.Controls.Add(this.rdbsumar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 158);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // rdbdivision
            // 
            this.rdbdivision.AutoSize = true;
            this.rdbdivision.Location = new System.Drawing.Point(407, 48);
            this.rdbdivision.Name = "rdbdivision";
            this.rdbdivision.Size = new System.Drawing.Size(93, 29);
            this.rdbdivision.TabIndex = 3;
            this.rdbdivision.TabStop = true;
            this.rdbdivision.Text = "Divide";
            this.rdbdivision.UseVisualStyleBackColor = true;
            // 
            // rdbmultiplicacion
            // 
            this.rdbmultiplicacion.AutoSize = true;
            this.rdbmultiplicacion.Location = new System.Drawing.Point(261, 48);
            this.rdbmultiplicacion.Name = "rdbmultiplicacion";
            this.rdbmultiplicacion.Size = new System.Drawing.Size(107, 29);
            this.rdbmultiplicacion.TabIndex = 2;
            this.rdbmultiplicacion.TabStop = true;
            this.rdbmultiplicacion.Text = "Multiply";
            this.rdbmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbrestar
            // 
            this.rdbrestar.AutoSize = true;
            this.rdbrestar.Location = new System.Drawing.Point(121, 48);
            this.rdbrestar.Name = "rdbrestar";
            this.rdbrestar.Size = new System.Drawing.Size(114, 29);
            this.rdbrestar.TabIndex = 1;
            this.rdbrestar.TabStop = true;
            this.rdbrestar.Text = "Subtract";
            this.rdbrestar.UseVisualStyleBackColor = true;
            // 
            // rdbsumar
            // 
            this.rdbsumar.AutoSize = true;
            this.rdbsumar.Location = new System.Drawing.Point(33, 48);
            this.rdbsumar.Name = "rdbsumar";
            this.rdbsumar.Size = new System.Drawing.Size(72, 29);
            this.rdbsumar.TabIndex = 0;
            this.rdbsumar.TabStop = true;
            this.rdbsumar.Text = "Add";
            this.rdbsumar.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalcular.Location = new System.Drawing.Point(310, 111);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(179, 44);
            this.btncalcular.TabIndex = 11;
            this.btncalcular.Text = "Calculate";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Value 2";
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(310, 64);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(187, 22);
            this.numero2.TabIndex = 9;
            this.numero2.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Value 1";
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(310, 12);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(187, 22);
            this.numero1.TabIndex = 7;
            this.numero1.Text = "0.00";
            // 
            // btnbackcalculator
            // 
            this.btnbackcalculator.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbackcalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackcalculator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbackcalculator.Location = new System.Drawing.Point(678, 534);
            this.btnbackcalculator.Name = "btnbackcalculator";
            this.btnbackcalculator.Size = new System.Drawing.Size(107, 60);
            this.btnbackcalculator.TabIndex = 14;
            this.btnbackcalculator.Text = "Back";
            this.btnbackcalculator.UseVisualStyleBackColor = false;
            this.btnbackcalculator.Click += new System.EventHandler(this.btnbackcalculator_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Copyright ©";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(873, 637);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbackcalculator);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero1);
            this.Name = "calculator";
            this.Text = "calculator";
            this.lblResultado.ResumeLayout(false);
            this.lblResultado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lblResultado;
        private System.Windows.Forms.TextBox numero3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdivision;
        private System.Windows.Forms.RadioButton rdbmultiplicacion;
        private System.Windows.Forms.RadioButton rdbrestar;
        private System.Windows.Forms.RadioButton rdbsumar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.Button btnbackcalculator;
        private System.Windows.Forms.Label label3;
    }
}