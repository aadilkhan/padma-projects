﻿namespace ORS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.tabMakeReservation = new System.Windows.Forms.TabPage();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbPassengers = new System.Windows.Forms.ComboBox();
            this.cmbTranportation = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblReservationUpto = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabMakeReservation.SuspendLayout();
            this.tabReservations.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.transportaionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(924, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // transportaionToolStripMenuItem
            // 
            this.transportaionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.bussToolStripMenuItem,
            this.flightToolStripMenuItem});
            this.transportaionToolStripMenuItem.Name = "transportaionToolStripMenuItem";
            this.transportaionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transportaionToolStripMenuItem.Text = "Transportaion";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.trainToolStripMenuItem.Text = "Train";
            // 
            // bussToolStripMenuItem
            // 
            this.bussToolStripMenuItem.Name = "bussToolStripMenuItem";
            this.bussToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.bussToolStripMenuItem.Text = "Buss";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.flightToolStripMenuItem.Text = "Flight";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.addCustomerToolStripMenuItem.Text = "Add";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.updateToolStripMenuItem.Text = "Update ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tabMakeReservation);
            this.tabCustomers.Controls.Add(this.tabReservations);
            this.tabCustomers.Controls.Add(this.tabCustomer);
            this.tabCustomers.Location = new System.Drawing.Point(12, 27);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(899, 487);
            this.tabCustomers.TabIndex = 1;
            // 
            // tabMakeReservation
            // 
            this.tabMakeReservation.Controls.Add(this.cmbCustomer);
            this.tabMakeReservation.Controls.Add(this.label7);
            this.tabMakeReservation.Controls.Add(this.grpDetails);
            this.tabMakeReservation.Controls.Add(this.pictureBox);
            this.tabMakeReservation.Controls.Add(this.txtDate);
            this.tabMakeReservation.Controls.Add(this.cmbTranportation);
            this.tabMakeReservation.Controls.Add(this.cmbPassengers);
            this.tabMakeReservation.Controls.Add(this.cmbTo);
            this.tabMakeReservation.Controls.Add(this.cmbFrom);
            this.tabMakeReservation.Controls.Add(this.btnSubmit);
            this.tabMakeReservation.Controls.Add(this.label5);
            this.tabMakeReservation.Controls.Add(this.label4);
            this.tabMakeReservation.Controls.Add(this.label3);
            this.tabMakeReservation.Controls.Add(this.label2);
            this.tabMakeReservation.Controls.Add(this.label1);
            this.tabMakeReservation.Location = new System.Drawing.Point(4, 22);
            this.tabMakeReservation.Name = "tabMakeReservation";
            this.tabMakeReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabMakeReservation.Size = new System.Drawing.Size(891, 461);
            this.tabMakeReservation.TabIndex = 0;
            this.tabMakeReservation.Text = "Make Reservation";
            this.tabMakeReservation.UseVisualStyleBackColor = true;
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.label6);
            this.tabReservations.Controls.Add(this.lstReservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 22);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(891, 461);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Reservations";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.label8);
            this.tabCustomer.Controls.Add(this.lstCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(891, 461);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Of Passengers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select the means of Transportaion";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(190, 262);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(190, 49);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(179, 21);
            this.cmbFrom.TabIndex = 6;
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(190, 83);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(179, 21);
            this.cmbTo.TabIndex = 7;
            // 
            // cmbPassengers
            // 
            this.cmbPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPassengers.FormattingEnabled = true;
            this.cmbPassengers.Location = new System.Drawing.Point(190, 179);
            this.cmbPassengers.Name = "cmbPassengers";
            this.cmbPassengers.Size = new System.Drawing.Size(179, 21);
            this.cmbPassengers.TabIndex = 8;
            // 
            // cmbTranportation
            // 
            this.cmbTranportation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTranportation.FormattingEnabled = true;
            this.cmbTranportation.Location = new System.Drawing.Point(270, 216);
            this.cmbTranportation.Name = "cmbTranportation";
            this.cmbTranportation.Size = new System.Drawing.Size(179, 21);
            this.cmbTranportation.TabIndex = 9;
            this.cmbTranportation.SelectedIndexChanged += new System.EventHandler(this.cmbTranportation_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(190, 150);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(179, 20);
            this.txtDate.TabIndex = 10;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblPrice);
            this.grpDetails.Controls.Add(this.lblReservationUpto);
            this.grpDetails.Controls.Add(this.lblCustomerPhone);
            this.grpDetails.Controls.Add(this.lblCustomerName);
            this.grpDetails.Location = new System.Drawing.Point(85, 308);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(731, 135);
            this.grpDetails.TabIndex = 12;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Reservation Details";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(39, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(88, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "[Customer Name]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer Name";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(190, 117);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(179, 21);
            this.cmbCustomer.TabIndex = 14;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(364, 34);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(91, 13);
            this.lblCustomerPhone.TabIndex = 1;
            this.lblCustomerPhone.Text = "[Customer Phone]";
            // 
            // lblReservationUpto
            // 
            this.lblReservationUpto.AutoSize = true;
            this.lblReservationUpto.Location = new System.Drawing.Point(39, 65);
            this.lblReservationUpto.Name = "lblReservationUpto";
            this.lblReservationUpto.Size = new System.Drawing.Size(133, 13);
            this.lblReservationUpto.TabIndex = 2;
            this.lblReservationUpto.Text = "[Reservation From and To]";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(39, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "[Total Price]";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ORS.Properties.Resources.Flight;
            this.pictureBox.Location = new System.Drawing.Point(516, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(284, 262);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(15, 37);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(856, 394);
            this.lstReservations.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "List of Reservations";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(6, 32);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(869, 407);
            this.lstCustomers.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "List of Registered Customers";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Buss.gif");
            this.imgList.Images.SetKeyName(1, "Train.gif");
            this.imgList.Images.SetKeyName(2, "Flight.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabMakeReservation.ResumeLayout(false);
            this.tabMakeReservation.PerformLayout();
            this.tabReservations.ResumeLayout(false);
            this.tabReservations.PerformLayout();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportaionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCustomers;
        private System.Windows.Forms.TabPage tabMakeReservation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTranportation;
        private System.Windows.Forms.ComboBox cmbPassengers;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblReservationUpto;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ImageList imgList;
    }
}
