namespace WindowsFormsApplication8
{
    partial class panel2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2txtBox = new System.Windows.Forms.TextBox();
            this.panel22txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Two";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Panel Two!";
            // 
            // panel2txtBox
            // 
            this.panel2txtBox.Location = new System.Drawing.Point(25, 105);
            this.panel2txtBox.Name = "panel2txtBox";
            this.panel2txtBox.Size = new System.Drawing.Size(146, 20);
            this.panel2txtBox.TabIndex = 11;
            this.panel2txtBox.TextChanged += new System.EventHandler(this.panel2txtBox_TextChanged);
            // 
            // panel22txtBox
            // 
            this.panel22txtBox.Location = new System.Drawing.Point(25, 172);
            this.panel22txtBox.Name = "panel22txtBox";
            this.panel22txtBox.Size = new System.Drawing.Size(146, 20);
            this.panel22txtBox.TabIndex = 12;
            this.panel22txtBox.TextChanged += new System.EventHandler(this.panel22txtBox_TextChanged);
            // 
            // panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel22txtBox);
            this.Controls.Add(this.panel2txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(356, 279);
            this.Load += new System.EventHandler(this.panel2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox panel2txtBox;
        private System.Windows.Forms.TextBox panel22txtBox;
    }
}
