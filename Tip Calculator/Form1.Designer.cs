namespace Tip_Calculator
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
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalBeforeTip = new System.Windows.Forms.TextBox();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.txtTotalWithTip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip percent";
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(243, 44);
            this.txtRestaurantName.MaxLength = 50;
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(193, 31);
            this.txtRestaurantName.TabIndex = 4;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(243, 119);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(193, 31);
            this.txtBillAmount.TabIndex = 5;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(243, 195);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(193, 31);
            this.txtNumberOfPeople.TabIndex = 6;
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(243, 270);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(193, 31);
            this.txtTipPercent.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total each, before tip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total each with tip";
            // 
            // txtTotalBeforeTip
            // 
            this.txtTotalBeforeTip.Location = new System.Drawing.Point(717, 41);
            this.txtTotalBeforeTip.Name = "txtTotalBeforeTip";
            this.txtTotalBeforeTip.ReadOnly = true;
            this.txtTotalBeforeTip.Size = new System.Drawing.Size(170, 31);
            this.txtTotalBeforeTip.TabIndex = 11;
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(717, 113);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.ReadOnly = true;
            this.txtTipAmount.Size = new System.Drawing.Size(170, 31);
            this.txtTipAmount.TabIndex = 12;
            this.txtTipAmount.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtTotalWithTip
            // 
            this.txtTotalWithTip.Location = new System.Drawing.Point(717, 195);
            this.txtTotalWithTip.Name = "txtTotalWithTip";
            this.txtTotalWithTip.ReadOnly = true;
            this.txtTotalWithTip.Size = new System.Drawing.Size(170, 31);
            this.txtTotalWithTip.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(339, 29);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Rount tip to the nearest dollar?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 484);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalWithTip);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtTotalBeforeTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.txtRestaurantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtTipPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalBeforeTip;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.TextBox txtTotalWithTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

