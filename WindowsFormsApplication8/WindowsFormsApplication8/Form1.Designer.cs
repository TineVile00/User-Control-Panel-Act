namespace WindowsFormsApplication8
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datainput1Box = new System.Windows.Forms.TextBox();
            this.dataInput2Box = new System.Windows.Forms.TextBox();
            this.Panel1Btn = new System.Windows.Forms.Button();
            this.Panel2Btn = new System.Windows.Forms.Button();
            this.panel21 = new WindowsFormsApplication8.panel2();
            this.panel11 = new WindowsFormsApplication8.panel1();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.Panel2Btn);
            this.leftpanel.Controls.Add(this.Panel1Btn);
            this.leftpanel.Location = new System.Drawing.Point(0, -1);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(206, 394);
            this.leftpanel.TabIndex = 0;
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataInput2Box);
            this.rightpanel.Controls.Add(this.datainput1Box);
            this.rightpanel.Controls.Add(this.label4);
            this.rightpanel.Controls.Add(this.label2);
            this.rightpanel.Controls.Add(this.label3);
            this.rightpanel.Location = new System.Drawing.Point(550, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(206, 390);
            this.rightpanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Control Panel Application";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data:";
            // 
            // datainput1Box
            // 
            this.datainput1Box.Location = new System.Drawing.Point(17, 137);
            this.datainput1Box.Name = "datainput1Box";
            this.datainput1Box.Size = new System.Drawing.Size(145, 20);
            this.datainput1Box.TabIndex = 8;
            // 
            // dataInput2Box
            // 
            this.dataInput2Box.Location = new System.Drawing.Point(17, 199);
            this.dataInput2Box.Name = "dataInput2Box";
            this.dataInput2Box.Size = new System.Drawing.Size(145, 20);
            this.dataInput2Box.TabIndex = 9;
            // 
            // Panel1Btn
            // 
            this.Panel1Btn.Location = new System.Drawing.Point(52, 139);
            this.Panel1Btn.Name = "Panel1Btn";
            this.Panel1Btn.Size = new System.Drawing.Size(93, 36);
            this.Panel1Btn.TabIndex = 0;
            this.Panel1Btn.Text = "Panel 1";
            this.Panel1Btn.UseVisualStyleBackColor = true;
            this.Panel1Btn.Click += new System.EventHandler(this.Panel1Btn_Click);
            // 
            // Panel2Btn
            // 
            this.Panel2Btn.Location = new System.Drawing.Point(52, 194);
            this.Panel2Btn.Name = "Panel2Btn";
            this.Panel2Btn.Size = new System.Drawing.Size(95, 36);
            this.Panel2Btn.TabIndex = 1;
            this.Panel2Btn.Text = "Panel 2";
            this.Panel2Btn.UseVisualStyleBackColor = true;
            this.Panel2Btn.Click += new System.EventHandler(this.Panel2Btn_Click);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel21.Location = new System.Drawing.Point(212, 100);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(332, 279);
            this.panel21.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel11.Location = new System.Drawing.Point(212, 100);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(332, 278);
            this.panel11.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.leftpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.leftpanel.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.rightpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Panel2Btn;
        private System.Windows.Forms.Button Panel1Btn;
        private System.Windows.Forms.TextBox dataInput2Box;
        private System.Windows.Forms.TextBox datainput1Box;
        private panel1 panel11;
        private panel2 panel21;
    }
}

