namespace Billing_App
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Date = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            CustomerName = new TextBox();
            mobileNo = new TextBox();
            BillNo = new TextBox();
            saveButton = new Button();
            itemName1 = new ComboBox();
            QtyList1 = new ComboBox();
            Amt = new TextBox();
            label11 = new Label();
            priceList1 = new ComboBox();
            itemName2 = new ComboBox();
            itemName3 = new ComboBox();
            QtyList2 = new ComboBox();
            QtyList3 = new ComboBox();
            priceList2 = new ComboBox();
            priceList3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 0;
            label1.Text = "Coffee Shop";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 59);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Address1 , Address2 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 92);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Sales Invoice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 135);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Customer Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 170);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Mobile No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 203);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Bill No:";
            // 
            // Date
            // 
            Date.Location = new Point(649, 56);
            Date.Name = "Date";
            Date.Size = new Size(125, 27);
            Date.TabIndex = 6;
            Date.Text = "3/22/2023 1:45:52 PM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(593, 59);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 7;
            label7.Text = "Date: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(271, 231);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 11;
            label8.Text = "Items ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(430, 231);
            label9.Name = "label9";
            label9.Size = new Size(46, 28);
            label9.TabIndex = 12;
            label9.Text = "Qty";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(593, 231);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 13;
            label10.Text = "Amount";
            // 
            // CustomerName
            // 
            CustomerName.Location = new Point(182, 135);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(178, 27);
            CustomerName.TabIndex = 14;
            // 
            // mobileNo
            // 
            mobileNo.Location = new Point(147, 168);
            mobileNo.Name = "mobileNo";
            mobileNo.Size = new Size(178, 27);
            mobileNo.TabIndex = 15;
            // 
            // BillNo
            // 
            BillNo.Location = new Point(121, 200);
            BillNo.Name = "BillNo";
            BillNo.Size = new Size(47, 27);
            BillNo.TabIndex = 16;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(308, 418);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // itemName1
            // 
            itemName1.FormattingEnabled = true;
            itemName1.Items.AddRange(new object[] { " ","Coffee", "Tea", "Juice" });
            itemName1.Location = new Point(217, 262);
            itemName1.Name = "itemName1";
            itemName1.Size = new Size(196, 28);
            itemName1.TabIndex = 18;
            // 
            // QtyList1
            // 
            QtyList1.FormattingEnabled = true;
            QtyList1.Items.AddRange(new object[] { "0","1", "2", "3", "4", "5" });
            QtyList1.Location = new Point(430, 262);
            QtyList1.Name = "QtyList1";
            QtyList1.Size = new Size(60, 28);
            QtyList1.TabIndex = 19;
            // 
            // Amt
            // 
            Amt.Location = new Point(593, 309);
            Amt.Name = "Amt";
            Amt.Size = new Size(90, 27);
            Amt.TabIndex = 20;
            Amt.Click += Amt_TextChanged;
            Amt.TextChanged += Amt_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(510, 231);
            label11.Name = "label11";
            label11.Size = new Size(59, 28);
            label11.TabIndex = 22;
            label11.Text = "Price";
            // 
            // priceList1
            // 
            priceList1.FormattingEnabled = true;
            priceList1.Items.AddRange(new object[] { "0","12", "15", "30" });
            priceList1.Location = new Point(510, 262);
            priceList1.Name = "priceList1";
            priceList1.Size = new Size(60, 28);
            priceList1.TabIndex = 24;
            // 
            // itemName2
            // 
            itemName2.FormattingEnabled = true;
            itemName2.Items.AddRange(new object[] { "Coffee", "Tea", "Juice" });
            itemName2.Location = new Point(217, 308);
            itemName2.Name = "itemName2";
            itemName2.Size = new Size(196, 28);
            itemName2.TabIndex = 25;
            // 
            // itemName3
            // 
            itemName3.FormattingEnabled = true;
            itemName3.Items.AddRange(new object[] { "Coffee", "Tea", "Juice" });
            itemName3.Location = new Point(217, 364);
            itemName3.Name = "itemName3";
            itemName3.Size = new Size(196, 28);
            itemName3.TabIndex = 26;
            // 
            // QtyList2
            // 
            QtyList2.FormattingEnabled = true;
            QtyList2.Items.AddRange(new object[] {"0", "1", "2", "3", "4", "5" });
            QtyList2.Location = new Point(430, 308);
            QtyList2.Name = "QtyList2";
            QtyList2.Size = new Size(60, 28);
            QtyList2.TabIndex = 27;
            // 
            // QtyList3
            // 
            QtyList3.FormattingEnabled = true;
            QtyList3.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            QtyList3.Location = new Point(430, 364);
            QtyList3.Name = "QtyList3";
            QtyList3.Size = new Size(60, 28);
            QtyList3.TabIndex = 28;
            // 
            // priceList2
            // 
            priceList2.FormattingEnabled = true;
            priceList2.Items.AddRange(new object[] { "0", "12", "15", "30" });
            priceList2.Location = new Point(510, 308);
            priceList2.Name = "priceList2";
            priceList2.Size = new Size(60, 28);
            priceList2.TabIndex = 29;
            // 
            // priceList3
            // 
            priceList3.FormattingEnabled = true;
            priceList3.Items.AddRange(new object[] { "0", "12", "15", "30" });
            priceList3.Location = new Point(510, 364);
            priceList3.Name = "priceList3";
            priceList3.Size = new Size(60, 28);
            priceList3.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(priceList3);
            Controls.Add(priceList2);
            Controls.Add(QtyList3);
            Controls.Add(QtyList2);
            Controls.Add(itemName3);
            Controls.Add(itemName2);
            Controls.Add(priceList1);
            Controls.Add(label11);
            Controls.Add(Amt);
            Controls.Add(QtyList1);
            Controls.Add(itemName1);
            Controls.Add(saveButton);
            Controls.Add(BillNo);
            Controls.Add(mobileNo);
            Controls.Add(CustomerName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Date);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Date;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox CustomerName;
        private TextBox mobileNo;
        private TextBox BillNo;
        private Button saveButton;
        private ComboBox itemName1;
        private ComboBox QtyList1;
        private TextBox Amt;
        private Label label11;
        private ComboBox priceList1;
        private ComboBox itemName2;
        private ComboBox itemName3;
        private ComboBox QtyList2;
        private ComboBox QtyList3;
        private ComboBox priceList2;
        private ComboBox priceList3;
    }
}