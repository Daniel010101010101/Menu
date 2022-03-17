namespace Project
{
    partial class DateTime
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
            this.components = new System.ComponentModel.Container();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblhour = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.labelhour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnbackdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4hou = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(269, 45);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 32);
            this.lbldate.TabIndex = 0;
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblhour
            // 
            this.lblhour.AutoSize = true;
            this.lblhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhour.Location = new System.Drawing.Point(269, 128);
            this.lblhour.Name = "lblhour";
            this.lblhour.Size = new System.Drawing.Size(0, 32);
            this.lblhour.TabIndex = 1;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.Location = new System.Drawing.Point(48, 45);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(0, 32);
            this.labeldate.TabIndex = 2;
            // 
            // labelhour
            // 
            this.labelhour.AutoSize = true;
            this.labelhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhour.Location = new System.Drawing.Point(48, 128);
            this.labelhour.Name = "labelhour";
            this.labelhour.Size = new System.Drawing.Size(0, 32);
            this.labelhour.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnbackdate
            // 
            this.btnbackdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbackdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbackdate.Location = new System.Drawing.Point(662, 359);
            this.btnbackdate.Name = "btnbackdate";
            this.btnbackdate.Size = new System.Drawing.Size(107, 60);
            this.btnbackdate.TabIndex = 15;
            this.btnbackdate.Text = "Back";
            this.btnbackdate.UseVisualStyleBackColor = false;
            this.btnbackdate.Click += new System.EventHandler(this.btnbackdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Copyright ©";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(656, 45);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hour";
            // 
            // label4hou
            // 
            this.label4hou.AutoSize = true;
            this.label4hou.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4hou.Location = new System.Drawing.Point(365, 253);
            this.label4hou.Name = "label4hou";
            this.label4hou.Size = new System.Drawing.Size(91, 32);
            this.label4hou.TabIndex = 20;
            this.label4hou.Text = "00:00";
            this.label4hou.Click += new System.EventHandler(this.label4_Click);
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.SystemColors.Highlight;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hour.Location = new System.Drawing.Point(347, 310);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(128, 52);
            this.hour.TabIndex = 21;
            this.hour.Text = "Show";
            this.hour.UseVisualStyleBackColor = false;
            this.hour.Click += new System.EventHandler(this.hour_Click);
            // 
            // DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.label4hou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbackdate);
            this.Controls.Add(this.labelhour);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.lblhour);
            this.Controls.Add(this.lbldate);
            this.Name = "DateTime";
            this.Text = "DateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblhour;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelhour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnbackdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4hou;
        private System.Windows.Forms.Button hour;
    }
}