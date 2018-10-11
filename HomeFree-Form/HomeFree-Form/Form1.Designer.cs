namespace HomeFree_Form
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
            this.components = new System.ComponentModel.Container();
            this.principal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.yearsToPay = new System.Windows.Forms.TextBox();
            this.downPayment = new System.Windows.Forms.TextBox();
            this.insuranceUtilities = new System.Windows.Forms.TextBox();
            this.monthlyPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submitMonthlyPayment = new System.Windows.Forms.Button();
            this.submitTargetPrice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.creditScore = new System.Windows.Forms.TextBox();
            this.preparedDownPayment = new System.Windows.Forms.TextBox();
            this.budget = new System.Windows.Forms.TextBox();
            this.bonuses = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.targetHousePrice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.Location = new System.Drawing.Point(110, 33);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(202, 20);
            this.principal.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 54);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Principal";
            // 
            // interestRate
            // 
            this.interestRate.Location = new System.Drawing.Point(110, 95);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(202, 20);
            this.interestRate.TabIndex = 3;
            // 
            // yearsToPay
            // 
            this.yearsToPay.Location = new System.Drawing.Point(110, 159);
            this.yearsToPay.Name = "yearsToPay";
            this.yearsToPay.Size = new System.Drawing.Size(202, 20);
            this.yearsToPay.TabIndex = 4;
            // 
            // downPayment
            // 
            this.downPayment.Location = new System.Drawing.Point(110, 212);
            this.downPayment.Name = "downPayment";
            this.downPayment.Size = new System.Drawing.Size(202, 20);
            this.downPayment.TabIndex = 5;
            // 
            // insuranceUtilities
            // 
            this.insuranceUtilities.Location = new System.Drawing.Point(110, 266);
            this.insuranceUtilities.Name = "insuranceUtilities";
            this.insuranceUtilities.Size = new System.Drawing.Size(202, 20);
            this.insuranceUtilities.TabIndex = 6;
            // 
            // monthlyPayment
            // 
            this.monthlyPayment.BackColor = System.Drawing.SystemColors.Window;
            this.monthlyPayment.Enabled = false;
            this.monthlyPayment.Location = new System.Drawing.Point(110, 390);
            this.monthlyPayment.Name = "monthlyPayment";
            this.monthlyPayment.Size = new System.Drawing.Size(202, 20);
            this.monthlyPayment.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yearly Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Years to Pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Down Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insurance & Utilities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Monthly Payment";
            // 
            // submitMonthlyPayment
            // 
            this.submitMonthlyPayment.Location = new System.Drawing.Point(175, 307);
            this.submitMonthlyPayment.Name = "submitMonthlyPayment";
            this.submitMonthlyPayment.Size = new System.Drawing.Size(75, 23);
            this.submitMonthlyPayment.TabIndex = 13;
            this.submitMonthlyPayment.Text = "Submit";
            this.submitMonthlyPayment.UseVisualStyleBackColor = true;
            this.submitMonthlyPayment.Click += new System.EventHandler(this.submitMonthlyPayment_Click);
            // 
            // submitTargetPrice
            // 
            this.submitTargetPrice.Location = new System.Drawing.Point(546, 307);
            this.submitTargetPrice.Name = "submitTargetPrice";
            this.submitTargetPrice.Size = new System.Drawing.Size(75, 23);
            this.submitTargetPrice.TabIndex = 24;
            this.submitTargetPrice.Text = "Submit";
            this.submitTargetPrice.UseVisualStyleBackColor = true;
            this.submitTargetPrice.Click += new System.EventHandler(this.submitTargetPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Credit Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Down Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Budget";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bonuses";
            // 
            // creditScore
            // 
            this.creditScore.Location = new System.Drawing.Point(481, 266);
            this.creditScore.Name = "creditScore";
            this.creditScore.Size = new System.Drawing.Size(202, 20);
            this.creditScore.TabIndex = 19;
            // 
            // preparedDownPayment
            // 
            this.preparedDownPayment.Location = new System.Drawing.Point(481, 212);
            this.preparedDownPayment.Name = "preparedDownPayment";
            this.preparedDownPayment.Size = new System.Drawing.Size(202, 20);
            this.preparedDownPayment.TabIndex = 18;
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(481, 159);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(202, 20);
            this.budget.TabIndex = 17;
            this.budget.TextChanged += new System.EventHandler(this.budget_TextChanged);
            // 
            // bonuses
            // 
            this.bonuses.Location = new System.Drawing.Point(481, 95);
            this.bonuses.Name = "bonuses";
            this.bonuses.Size = new System.Drawing.Size(202, 20);
            this.bonuses.TabIndex = 16;
            this.bonuses.TextChanged += new System.EventHandler(this.bonuses_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Yearly Income";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(481, 33);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(202, 20);
            this.salary.TabIndex = 14;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "House we Can Afford";
            // 
            // targetHousePrice
            // 
            this.targetHousePrice.BackColor = System.Drawing.SystemColors.Window;
            this.targetHousePrice.Enabled = false;
            this.targetHousePrice.Location = new System.Drawing.Point(481, 390);
            this.targetHousePrice.Name = "targetHousePrice";
            this.targetHousePrice.Size = new System.Drawing.Size(202, 20);
            this.targetHousePrice.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.targetHousePrice);
            this.Controls.Add(this.submitTargetPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.creditScore);
            this.Controls.Add(this.preparedDownPayment);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.bonuses);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.submitMonthlyPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthlyPayment);
            this.Controls.Add(this.insuranceUtilities);
            this.Controls.Add(this.downPayment);
            this.Controls.Add(this.yearsToPay);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.principal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.TextBox yearsToPay;
        private System.Windows.Forms.TextBox downPayment;
        private System.Windows.Forms.TextBox insuranceUtilities;
        private System.Windows.Forms.TextBox monthlyPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitMonthlyPayment;
        private System.Windows.Forms.Button submitTargetPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox creditScore;
        private System.Windows.Forms.TextBox preparedDownPayment;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.TextBox bonuses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox targetHousePrice;
    }
}

