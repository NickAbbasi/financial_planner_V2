namespace finacialplanner
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.TextBox();
            this.monthlyAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(23, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(364, 483);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Years:";
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(612, 47);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(100, 20);
            this.years.TabIndex = 2;
            // 
            // monthlyAmount
            // 
            this.monthlyAmount.Location = new System.Drawing.Point(612, 127);
            this.monthlyAmount.Name = "monthlyAmount";
            this.monthlyAmount.Size = new System.Drawing.Size(100, 20);
            this.monthlyAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Monthly Contribution";
            // 
            // firstDeposit
            // 
            this.firstDeposit.Location = new System.Drawing.Point(612, 227);
            this.firstDeposit.Name = "firstDeposit";
            this.firstDeposit.Size = new System.Drawing.Size(100, 20);
            this.firstDeposit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Intial Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 510);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 545);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthlyAmount);
            this.Controls.Add(this.years);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.TextBox monthlyAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

