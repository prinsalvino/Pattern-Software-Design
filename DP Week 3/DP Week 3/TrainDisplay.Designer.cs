namespace DP_Week_3
{
    partial class TrainDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbltrack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Railway Track";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(267, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(43, 17);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "name";
            // 
            // lbltrack
            // 
            this.lbltrack.AutoSize = true;
            this.lbltrack.Location = new System.Drawing.Point(267, 162);
            this.lbltrack.Name = "lbltrack";
            this.lbltrack.Size = new System.Drawing.Size(56, 17);
            this.lbltrack.TabIndex = 3;
            this.lbltrack.Text = "number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrival Time";
            // 
            // lblat
            // 
            this.lblat.AutoSize = true;
            this.lblat.Location = new System.Drawing.Point(267, 221);
            this.lblat.Name = "lblat";
            this.lblat.Size = new System.Drawing.Size(39, 17);
            this.lblat.TabIndex = 5;
            this.lblat.Text = "TIme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Departure Time";
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.Location = new System.Drawing.Point(267, 263);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(39, 17);
            this.lbldt.TabIndex = 7;
            this.lbldt.Text = "TIme";
            this.lbldt.Click += new System.EventHandler(this.Label6_Click);
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltrack);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.Load += new System.EventHandler(this.TrainDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldt;
    }
}