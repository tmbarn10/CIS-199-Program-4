namespace Program4
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
            this.shippingInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.originZipLbl = new System.Windows.Forms.Label();
            this.destinationZipLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.originZipInput = new System.Windows.Forms.TextBox();
            this.destinationZipInput = new System.Windows.Forms.TextBox();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.addListButton = new System.Windows.Forms.Button();
            this.packageGroupBox = new System.Windows.Forms.GroupBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToUofLButton = new System.Windows.Forms.Button();
            this.sendFromUofLButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shippingInfoGroupBox.SuspendLayout();
            this.packageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shippingInfoGroupBox
            // 
            this.shippingInfoGroupBox.Controls.Add(this.button1);
            this.shippingInfoGroupBox.Controls.Add(this.addListButton);
            this.shippingInfoGroupBox.Controls.Add(this.weightInput);
            this.shippingInfoGroupBox.Controls.Add(this.heightInput);
            this.shippingInfoGroupBox.Controls.Add(this.widthInput);
            this.shippingInfoGroupBox.Controls.Add(this.lengthInput);
            this.shippingInfoGroupBox.Controls.Add(this.destinationZipInput);
            this.shippingInfoGroupBox.Controls.Add(this.originZipInput);
            this.shippingInfoGroupBox.Controls.Add(this.weightLbl);
            this.shippingInfoGroupBox.Controls.Add(this.heightLbl);
            this.shippingInfoGroupBox.Controls.Add(this.widthLbl);
            this.shippingInfoGroupBox.Controls.Add(this.lengthLbl);
            this.shippingInfoGroupBox.Controls.Add(this.destinationZipLbl);
            this.shippingInfoGroupBox.Controls.Add(this.originZipLbl);
            this.shippingInfoGroupBox.Location = new System.Drawing.Point(26, 47);
            this.shippingInfoGroupBox.Name = "shippingInfoGroupBox";
            this.shippingInfoGroupBox.Size = new System.Drawing.Size(269, 276);
            this.shippingInfoGroupBox.TabIndex = 0;
            this.shippingInfoGroupBox.TabStop = false;
            this.shippingInfoGroupBox.Text = "Enter Shipping Information";
            // 
            // originZipLbl
            // 
            this.originZipLbl.AutoSize = true;
            this.originZipLbl.Location = new System.Drawing.Point(32, 38);
            this.originZipLbl.Name = "originZipLbl";
            this.originZipLbl.Size = new System.Drawing.Size(55, 13);
            this.originZipLbl.TabIndex = 0;
            this.originZipLbl.Text = "Origin Zip:";
            // 
            // destinationZipLbl
            // 
            this.destinationZipLbl.AutoSize = true;
            this.destinationZipLbl.Location = new System.Drawing.Point(6, 64);
            this.destinationZipLbl.Name = "destinationZipLbl";
            this.destinationZipLbl.Size = new System.Drawing.Size(81, 13);
            this.destinationZipLbl.TabIndex = 1;
            this.destinationZipLbl.Text = "Destination Zip:";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(44, 89);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(43, 13);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Length:";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(49, 115);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(38, 13);
            this.widthLbl.TabIndex = 3;
            this.widthLbl.Text = "Width:";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(46, 141);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(41, 13);
            this.heightLbl.TabIndex = 4;
            this.heightLbl.Text = "Height:";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(43, 167);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(44, 13);
            this.weightLbl.TabIndex = 5;
            this.weightLbl.Text = "Weight:";
            // 
            // originZipInput
            // 
            this.originZipInput.Location = new System.Drawing.Point(94, 35);
            this.originZipInput.Name = "originZipInput";
            this.originZipInput.Size = new System.Drawing.Size(100, 20);
            this.originZipInput.TabIndex = 6;
            // 
            // destinationZipInput
            // 
            this.destinationZipInput.Location = new System.Drawing.Point(94, 61);
            this.destinationZipInput.Name = "destinationZipInput";
            this.destinationZipInput.Size = new System.Drawing.Size(100, 20);
            this.destinationZipInput.TabIndex = 7;
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(94, 86);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(100, 20);
            this.lengthInput.TabIndex = 8;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(94, 112);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 9;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(94, 138);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 10;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(94, 164);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(100, 20);
            this.weightInput.TabIndex = 11;
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(94, 199);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(95, 23);
            this.addListButton.TabIndex = 12;
            this.addListButton.Text = "Add to List";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // packageGroupBox
            // 
            this.packageGroupBox.Controls.Add(this.clearButton);
            this.packageGroupBox.Controls.Add(this.sendFromUofLButton);
            this.packageGroupBox.Controls.Add(this.sendToUofLButton);
            this.packageGroupBox.Controls.Add(this.detailsButton);
            this.packageGroupBox.Controls.Add(this.orderListBox);
            this.packageGroupBox.Location = new System.Drawing.Point(329, 47);
            this.packageGroupBox.Name = "packageGroupBox";
            this.packageGroupBox.Size = new System.Drawing.Size(304, 276);
            this.packageGroupBox.TabIndex = 1;
            this.packageGroupBox.TabStop = false;
            this.packageGroupBox.Text = "Select Package Order";
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(17, 20);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(160, 238);
            this.orderListBox.TabIndex = 0;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(183, 61);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(95, 23);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToUofLButton
            // 
            this.sendToUofLButton.Location = new System.Drawing.Point(183, 128);
            this.sendToUofLButton.Name = "sendToUofLButton";
            this.sendToUofLButton.Size = new System.Drawing.Size(95, 23);
            this.sendToUofLButton.TabIndex = 2;
            this.sendToUofLButton.Text = "Send to UofL";
            this.sendToUofLButton.UseVisualStyleBackColor = true;
            this.sendToUofLButton.Click += new System.EventHandler(this.sendToUofLButton_Click);
            // 
            // sendFromUofLButton
            // 
            this.sendFromUofLButton.Location = new System.Drawing.Point(183, 157);
            this.sendFromUofLButton.Name = "sendFromUofLButton";
            this.sendFromUofLButton.Size = new System.Drawing.Size(95, 23);
            this.sendFromUofLButton.TabIndex = 3;
            this.sendFromUofLButton.Text = "Send from UofL";
            this.sendFromUofLButton.UseVisualStyleBackColor = true;
            this.sendFromUofLButton.Click += new System.EventHandler(this.sendFromUofLButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear Orders";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Shipping Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.Controls.Add(this.packageGroupBox);
            this.Controls.Add(this.shippingInfoGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.shippingInfoGroupBox.ResumeLayout(false);
            this.shippingInfoGroupBox.PerformLayout();
            this.packageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shippingInfoGroupBox;
        private System.Windows.Forms.Button addListButton;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.TextBox destinationZipInput;
        private System.Windows.Forms.TextBox originZipInput;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label destinationZipLbl;
        private System.Windows.Forms.Label originZipLbl;
        private System.Windows.Forms.GroupBox packageGroupBox;
        private System.Windows.Forms.Button sendFromUofLButton;
        private System.Windows.Forms.Button sendToUofLButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button1;
    }
}

