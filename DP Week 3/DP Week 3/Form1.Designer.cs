namespace DP_Week_3
{
    partial class Form1
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
            this.btnnext = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(116, 79);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(174, 45);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = "Next Station";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(21, 213);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(127, 33);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New Display";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 271);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnnext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnnew;
    }
}

