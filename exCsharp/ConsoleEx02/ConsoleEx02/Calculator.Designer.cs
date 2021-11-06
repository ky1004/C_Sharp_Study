
namespace ConsoleEx02
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLabel = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.SumNum = new System.Windows.Forms.Button();
            this.resultnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TLabel
            // 
            this.TLabel.AutoSize = true;
            this.TLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TLabel.Location = new System.Drawing.Point(93, 82);
            this.TLabel.Name = "TLabel";
            this.TLabel.Size = new System.Drawing.Size(107, 15);
            this.TLabel.TabIndex = 0;
            this.TLabel.Text = "여기를 클릭하세요";
            this.TLabel.Click += new System.EventHandler(this.TLabel_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(253, 139);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 23);
            this.number2.TabIndex = 1;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(100, 139);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 23);
            this.number1.TabIndex = 2;
            // 
            // SumNum
            // 
            this.SumNum.Location = new System.Drawing.Point(188, 197);
            this.SumNum.Name = "SumNum";
            this.SumNum.Size = new System.Drawing.Size(75, 23);
            this.SumNum.TabIndex = 3;
            this.SumNum.Text = "=";
            this.SumNum.UseVisualStyleBackColor = true;
            this.SumNum.Click += new System.EventHandler(this.SumNum_Click);
            // 
            // resultnum
            // 
            this.resultnum.Location = new System.Drawing.Point(176, 254);
            this.resultnum.Name = "resultnum";
            this.resultnum.Size = new System.Drawing.Size(100, 23);
            this.resultnum.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 350);
            this.Controls.Add(this.resultnum);
            this.Controls.Add(this.SumNum);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.TLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TLabel;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Button SumNum;
        private System.Windows.Forms.TextBox resultnum;
    }
}

