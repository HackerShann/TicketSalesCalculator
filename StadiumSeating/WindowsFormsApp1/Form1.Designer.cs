namespace WindowsFormsApp1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ticketsSold = new System.Windows.Forms.GroupBox();
            this.revGenerator = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soldA = new System.Windows.Forms.TextBox();
            this.soldB = new System.Windows.Forms.TextBox();
            this.soldC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.revClassA = new System.Windows.Forms.Label();
            this.revClassB = new System.Windows.Forms.Label();
            this.revClassC = new System.Windows.Forms.Label();
            this.revTotal = new System.Windows.Forms.Label();
            this.ticketsSold.SuspendLayout();
            this.revGenerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(460, 837);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(261, 95);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Revenue";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(756, 837);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 95);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1058, 837);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(261, 95);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ticketsSold
            // 
            this.ticketsSold.Controls.Add(this.soldC);
            this.ticketsSold.Controls.Add(this.soldB);
            this.ticketsSold.Controls.Add(this.soldA);
            this.ticketsSold.Controls.Add(this.label4);
            this.ticketsSold.Controls.Add(this.label3);
            this.ticketsSold.Controls.Add(this.label2);
            this.ticketsSold.Controls.Add(this.label1);
            this.ticketsSold.Location = new System.Drawing.Point(62, 65);
            this.ticketsSold.Name = "ticketsSold";
            this.ticketsSold.Size = new System.Drawing.Size(772, 652);
            this.ticketsSold.TabIndex = 13;
            this.ticketsSold.TabStop = false;
            this.ticketsSold.Text = "Tickets Sold";
            // 
            // revGenerator
            // 
            this.revGenerator.Controls.Add(this.revTotal);
            this.revGenerator.Controls.Add(this.revClassC);
            this.revGenerator.Controls.Add(this.revClassB);
            this.revGenerator.Controls.Add(this.revClassA);
            this.revGenerator.Controls.Add(this.label8);
            this.revGenerator.Controls.Add(this.label7);
            this.revGenerator.Controls.Add(this.label6);
            this.revGenerator.Controls.Add(this.label5);
            this.revGenerator.Location = new System.Drawing.Point(943, 65);
            this.revGenerator.Name = "revGenerator";
            this.revGenerator.Size = new System.Drawing.Size(772, 652);
            this.revGenerator.TabIndex = 14;
            this.revGenerator.TabStop = false;
            this.revGenerator.Text = "Revenue Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Tickets Sold for each Class of Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // soldA
            // 
            this.soldA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldA.Location = new System.Drawing.Point(411, 170);
            this.soldA.Name = "soldA";
            this.soldA.Size = new System.Drawing.Size(167, 31);
            this.soldA.TabIndex = 4;
            // 
            // soldB
            // 
            this.soldB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldB.Location = new System.Drawing.Point(411, 288);
            this.soldB.Name = "soldB";
            this.soldB.Size = new System.Drawing.Size(167, 31);
            this.soldB.TabIndex = 5;
            // 
            // soldC
            // 
            this.soldC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soldC.Location = new System.Drawing.Point(411, 410);
            this.soldC.Name = "soldC";
            this.soldC.Size = new System.Drawing.Size(167, 31);
            this.soldC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Class C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total:";
            // 
            // revClassA
            // 
            this.revClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revClassA.Location = new System.Drawing.Point(358, 74);
            this.revClassA.Name = "revClassA";
            this.revClassA.Size = new System.Drawing.Size(237, 41);
            this.revClassA.TabIndex = 4;
            this.revClassA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revClassB
            // 
            this.revClassB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revClassB.Location = new System.Drawing.Point(358, 154);
            this.revClassB.Name = "revClassB";
            this.revClassB.Size = new System.Drawing.Size(237, 41);
            this.revClassB.TabIndex = 5;
            this.revClassB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revClassC
            // 
            this.revClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revClassC.Location = new System.Drawing.Point(358, 260);
            this.revClassC.Name = "revClassC";
            this.revClassC.Size = new System.Drawing.Size(237, 41);
            this.revClassC.TabIndex = 6;
            this.revClassC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revTotal
            // 
            this.revTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revTotal.Location = new System.Drawing.Point(358, 366);
            this.revTotal.Name = "revTotal";
            this.revTotal.Size = new System.Drawing.Size(237, 41);
            this.revTotal.TabIndex = 7;
            this.revTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revTotal.Click += new System.EventHandler(this.revTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 1014);
            this.Controls.Add(this.revGenerator);
            this.Controls.Add(this.ticketsSold);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSold.ResumeLayout(false);
            this.ticketsSold.PerformLayout();
            this.revGenerator.ResumeLayout(false);
            this.revGenerator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox ticketsSold;
        private System.Windows.Forms.GroupBox revGenerator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soldC;
        private System.Windows.Forms.TextBox soldB;
        private System.Windows.Forms.TextBox soldA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label revTotal;
        private System.Windows.Forms.Label revClassC;
        private System.Windows.Forms.Label revClassB;
        private System.Windows.Forms.Label revClassA;
    }
}

