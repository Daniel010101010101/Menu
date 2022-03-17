namespace Project
{
    partial class bodymass
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
            this.lblweight = new System.Windows.Forms.Label();
            this.lblheight = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.lblbmi = new System.Windows.Forms.Label();
            this.txtbmi = new System.Windows.Forms.TextBox();
            this.btnbmi = new System.Windows.Forms.Button();
            this.btnbackBmi = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(86, 29);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(118, 32);
            this.lblweight.TabIndex = 0;
            this.lblweight.Text = "Weight:";
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(86, 119);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(112, 32);
            this.lblheight.TabIndex = 1;
            this.lblheight.Text = "Height:";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(256, 39);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(250, 22);
            this.txtweight.TabIndex = 2;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(256, 129);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(250, 22);
            this.txtheight.TabIndex = 3;
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbmi.Location = new System.Drawing.Point(86, 222);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(75, 32);
            this.lblbmi.TabIndex = 4;
            this.lblbmi.Text = "BMI:";
            // 
            // txtbmi
            // 
            this.txtbmi.Location = new System.Drawing.Point(256, 222);
            this.txtbmi.Name = "txtbmi";
            this.txtbmi.Size = new System.Drawing.Size(250, 22);
            this.txtbmi.TabIndex = 5;
            // 
            // btnbmi
            // 
            this.btnbmi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbmi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbmi.Location = new System.Drawing.Point(601, 129);
            this.btnbmi.Name = "btnbmi";
            this.btnbmi.Size = new System.Drawing.Size(138, 60);
            this.btnbmi.TabIndex = 6;
            this.btnbmi.Text = "Calculate";
            this.btnbmi.UseVisualStyleBackColor = false;
            this.btnbmi.Click += new System.EventHandler(this.btnbmi_Click);
            // 
            // btnbackBmi
            // 
            this.btnbackBmi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbackBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackBmi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbackBmi.Location = new System.Drawing.Point(613, 350);
            this.btnbackBmi.Name = "btnbackBmi";
            this.btnbackBmi.Size = new System.Drawing.Size(107, 60);
            this.btnbackBmi.TabIndex = 7;
            this.btnbackBmi.Text = "Back";
            this.btnbackBmi.UseVisualStyleBackColor = false;
            this.btnbackBmi.Click += new System.EventHandler(this.btnbackBmi_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(86, 324);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(110, 32);
            this.lblresult.TabIndex = 8;
            this.lblresult.Text = "Result:";
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblr.Location = new System.Drawing.Point(250, 324);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(23, 32);
            this.lblr.TabIndex = 9;
            this.lblr.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Copyright ©";
            // 
            // bodymass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnbackBmi);
            this.Controls.Add(this.btnbmi);
            this.Controls.Add(this.txtbmi);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.lblweight);
            this.Name = "bodymass";
            this.Text = "bodymass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.TextBox txtbmi;
        private System.Windows.Forms.Button btnbmi;
        private System.Windows.Forms.Button btnbackBmi;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label label2;
    }
}