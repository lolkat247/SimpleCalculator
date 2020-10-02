namespace SimpleCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOp1 = new System.Windows.Forms.TextBox();
            this.tbOper = new System.Windows.Forms.TextBox();
            this.tbOp2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // tbOp1
            // 
            this.tbOp1.Location = new System.Drawing.Point(96, 6);
            this.tbOp1.Name = "tbOp1";
            this.tbOp1.Size = new System.Drawing.Size(100, 20);
            this.tbOp1.TabIndex = 0;
            // 
            // tbOper
            // 
            this.tbOper.Location = new System.Drawing.Point(96, 38);
            this.tbOper.Name = "tbOper";
            this.tbOper.Size = new System.Drawing.Size(21, 20);
            this.tbOper.TabIndex = 1;
            // 
            // tbOp2
            // 
            this.tbOp2.Location = new System.Drawing.Point(96, 76);
            this.tbOp2.Name = "tbOp2";
            this.tbOp2.Size = new System.Drawing.Size(100, 20);
            this.tbOp2.TabIndex = 2;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(96, 115);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 7;
            this.tbResult.TabStop = false;
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Location = new System.Drawing.Point(12, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(129, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(147, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(207, 187);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbOp2);
            this.Controls.Add(this.tbOper);
            this.Controls.Add(this.tbOp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOp1;
        private System.Windows.Forms.TextBox tbOper;
        private System.Windows.Forms.TextBox tbOp2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

