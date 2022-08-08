namespace WindowsFormsAppCoffeeClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openStudentRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoCTRLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.groupNewCoffeOrder = new System.Windows.Forms.GroupBox();
            this.comboHotCold = new System.Windows.Forms.ComboBox();
            this.labelHotCold = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPump3 = new System.Windows.Forms.ComboBox();
            this.labelPump3Flavor = new System.Windows.Forms.Label();
            this.comboPump2 = new System.Windows.Forms.ComboBox();
            this.labelPump2Flavor = new System.Windows.Forms.Label();
            this.comboPump1 = new System.Windows.Forms.ComboBox();
            this.labelPump1Flavor = new System.Windows.Forms.Label();
            this.comboFlavorPumps = new System.Windows.Forms.ComboBox();
            this.labelPerPumpPrice = new System.Windows.Forms.Label();
            this.labelFlavorPumps = new System.Windows.Forms.Label();
            this.comboWhippedCream = new System.Windows.Forms.ComboBox();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboCoffeeType = new System.Windows.Forms.ComboBox();
            this.labelAddMessage = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.labelComplimentary = new System.Windows.Forms.Label();
            this.labelWhippedCream = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelCoffeeType = new System.Windows.Forms.Label();
            this.groupCurrentOrders = new System.Windows.Forms.GroupBox();
            this.groupDeleteOrders = new System.Windows.Forms.GroupBox();
            this.buttonOrderCompleted = new System.Windows.Forms.Button();
            this.labelDeleteMessage = new System.Windows.Forms.Label();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.groupNewCoffeOrder.SuspendLayout();
            this.groupCurrentOrders.SuspendLayout();
            this.groupDeleteOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStudentRecordsToolStripMenuItem,
            this.saveAllChangesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1486, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openStudentRecordsToolStripMenuItem
            // 
            this.openStudentRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.openStudentRecordsToolStripMenuItem.Name = "openStudentRecordsToolStripMenuItem";
            this.openStudentRecordsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openStudentRecordsToolStripMenuItem.Text = "File";
            // 
            // openAllToolStripMenuItem
            // 
            this.openAllToolStripMenuItem.Name = "openAllToolStripMenuItem";
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveAllChangesToolStripMenuItem
            // 
            this.saveAllChangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoCTRLYToolStripMenuItem});
            this.saveAllChangesToolStripMenuItem.Name = "saveAllChangesToolStripMenuItem";
            this.saveAllChangesToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.saveAllChangesToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.undoToolStripMenuItem.Text = "Undo             CTRL+Z";
            // 
            // redoCTRLYToolStripMenuItem
            // 
            this.redoCTRLYToolStripMenuItem.Enabled = false;
            this.redoCTRLYToolStripMenuItem.Name = "redoCTRLYToolStripMenuItem";
            this.redoCTRLYToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.redoCTRLYToolStripMenuItem.Text = "Redo              CTRL+Y";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gridOrders
            // 
            this.gridOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridOrders.Location = new System.Drawing.Point(0, 19);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(1130, 458);
            this.gridOrders.TabIndex = 20;
            // 
            // groupNewCoffeOrder
            // 
            this.groupNewCoffeOrder.Controls.Add(this.comboHotCold);
            this.groupNewCoffeOrder.Controls.Add(this.labelHotCold);
            this.groupNewCoffeOrder.Controls.Add(this.textBoxTotal);
            this.groupNewCoffeOrder.Controls.Add(this.label1);
            this.groupNewCoffeOrder.Controls.Add(this.comboPump3);
            this.groupNewCoffeOrder.Controls.Add(this.labelPump3Flavor);
            this.groupNewCoffeOrder.Controls.Add(this.comboPump2);
            this.groupNewCoffeOrder.Controls.Add(this.labelPump2Flavor);
            this.groupNewCoffeOrder.Controls.Add(this.comboPump1);
            this.groupNewCoffeOrder.Controls.Add(this.labelPump1Flavor);
            this.groupNewCoffeOrder.Controls.Add(this.comboFlavorPumps);
            this.groupNewCoffeOrder.Controls.Add(this.labelPerPumpPrice);
            this.groupNewCoffeOrder.Controls.Add(this.labelFlavorPumps);
            this.groupNewCoffeOrder.Controls.Add(this.comboWhippedCream);
            this.groupNewCoffeOrder.Controls.Add(this.comboSize);
            this.groupNewCoffeOrder.Controls.Add(this.comboCoffeeType);
            this.groupNewCoffeOrder.Controls.Add(this.labelAddMessage);
            this.groupNewCoffeOrder.Controls.Add(this.buttonAddOrder);
            this.groupNewCoffeOrder.Controls.Add(this.labelComplimentary);
            this.groupNewCoffeOrder.Controls.Add(this.labelWhippedCream);
            this.groupNewCoffeOrder.Controls.Add(this.labelSize);
            this.groupNewCoffeOrder.Controls.Add(this.labelCoffeeType);
            this.groupNewCoffeOrder.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupNewCoffeOrder.Location = new System.Drawing.Point(12, 56);
            this.groupNewCoffeOrder.Name = "groupNewCoffeOrder";
            this.groupNewCoffeOrder.Size = new System.Drawing.Size(326, 641);
            this.groupNewCoffeOrder.TabIndex = 3;
            this.groupNewCoffeOrder.TabStop = false;
            this.groupNewCoffeOrder.Text = "New Coffee Order";
            // 
            // comboHotCold
            // 
            this.comboHotCold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHotCold.FormattingEnabled = true;
            this.comboHotCold.Location = new System.Drawing.Point(113, 121);
            this.comboHotCold.Name = "comboHotCold";
            this.comboHotCold.Size = new System.Drawing.Size(207, 23);
            this.comboHotCold.TabIndex = 32;
            // 
            // labelHotCold
            // 
            this.labelHotCold.AutoSize = true;
            this.labelHotCold.Location = new System.Drawing.Point(8, 124);
            this.labelHotCold.Name = "labelHotCold";
            this.labelHotCold.Size = new System.Drawing.Size(101, 15);
            this.labelHotCold.TabIndex = 31;
            this.labelHotCold.Text = "Hot or Cold Type";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(139, 381);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(181, 23);
            this.textBoxTotal.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "TOTAL (Before Tax)";
            // 
            // comboPump3
            // 
            this.comboPump3.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.comboPump3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPump3.FormattingEnabled = true;
            this.comboPump3.Items.AddRange(new object[] {
            "No Additional Flavor Pumps",
            "1 Pump",
            "2 Pumps",
            "3 Pumps"});
            this.comboPump3.Location = new System.Drawing.Point(113, 331);
            this.comboPump3.Name = "comboPump3";
            this.comboPump3.Size = new System.Drawing.Size(207, 23);
            this.comboPump3.TabIndex = 28;
            // 
            // labelPump3Flavor
            // 
            this.labelPump3Flavor.AutoSize = true;
            this.labelPump3Flavor.Location = new System.Drawing.Point(8, 334);
            this.labelPump3Flavor.Name = "labelPump3Flavor";
            this.labelPump3Flavor.Size = new System.Drawing.Size(88, 15);
            this.labelPump3Flavor.TabIndex = 27;
            this.labelPump3Flavor.Text = "Pump 3 Flavor";
            this.labelPump3Flavor.Visible = false;
            // 
            // comboPump2
            // 
            this.comboPump2.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.comboPump2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPump2.FormattingEnabled = true;
            this.comboPump2.Items.AddRange(new object[] {
            "No Additional Flavor Pumps",
            "1 Pump",
            "2 Pumps",
            "3 Pumps"});
            this.comboPump2.Location = new System.Drawing.Point(113, 297);
            this.comboPump2.Name = "comboPump2";
            this.comboPump2.Size = new System.Drawing.Size(207, 23);
            this.comboPump2.TabIndex = 26;
            // 
            // labelPump2Flavor
            // 
            this.labelPump2Flavor.AutoSize = true;
            this.labelPump2Flavor.Location = new System.Drawing.Point(8, 300);
            this.labelPump2Flavor.Name = "labelPump2Flavor";
            this.labelPump2Flavor.Size = new System.Drawing.Size(88, 15);
            this.labelPump2Flavor.TabIndex = 25;
            this.labelPump2Flavor.Text = "Pump 2 Flavor";
            this.labelPump2Flavor.Visible = false;
            // 
            // comboPump1
            // 
            this.comboPump1.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.comboPump1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPump1.FormattingEnabled = true;
            this.comboPump1.Items.AddRange(new object[] {
            "No Additional Flavor Pumps",
            "1 Pump",
            "2 Pumps",
            "3 Pumps"});
            this.comboPump1.Location = new System.Drawing.Point(113, 264);
            this.comboPump1.Name = "comboPump1";
            this.comboPump1.Size = new System.Drawing.Size(207, 23);
            this.comboPump1.TabIndex = 24;
            // 
            // labelPump1Flavor
            // 
            this.labelPump1Flavor.AutoSize = true;
            this.labelPump1Flavor.Location = new System.Drawing.Point(8, 267);
            this.labelPump1Flavor.Name = "labelPump1Flavor";
            this.labelPump1Flavor.Size = new System.Drawing.Size(88, 15);
            this.labelPump1Flavor.TabIndex = 23;
            this.labelPump1Flavor.Text = "Pump 1 Flavor";
            this.labelPump1Flavor.Visible = false;
            // 
            // comboFlavorPumps
            // 
            this.comboFlavorPumps.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.comboFlavorPumps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFlavorPumps.FormattingEnabled = true;
            this.comboFlavorPumps.Items.AddRange(new object[] {
            "No Additional Flavor Pumps",
            "1 Pump",
            "2 Pumps",
            "3 Pumps"});
            this.comboFlavorPumps.Location = new System.Drawing.Point(139, 202);
            this.comboFlavorPumps.Name = "comboFlavorPumps";
            this.comboFlavorPumps.Size = new System.Drawing.Size(181, 23);
            this.comboFlavorPumps.TabIndex = 22;
            this.comboFlavorPumps.SelectedIndexChanged += new System.EventHandler(this.comboFlavorPumps_SelectedIndexChanged);
            // 
            // labelPerPumpPrice
            // 
            this.labelPerPumpPrice.AutoSize = true;
            this.labelPerPumpPrice.Location = new System.Drawing.Point(6, 225);
            this.labelPerPumpPrice.Name = "labelPerPumpPrice";
            this.labelPerPumpPrice.Size = new System.Drawing.Size(119, 15);
            this.labelPerPumpPrice.TabIndex = 21;
            this.labelPerPumpPrice.Text = "(75 cents per pump)";
            // 
            // labelFlavorPumps
            // 
            this.labelFlavorPumps.AutoSize = true;
            this.labelFlavorPumps.Location = new System.Drawing.Point(8, 210);
            this.labelFlavorPumps.Name = "labelFlavorPumps";
            this.labelFlavorPumps.Size = new System.Drawing.Size(114, 15);
            this.labelFlavorPumps.TabIndex = 20;
            this.labelFlavorPumps.Text = "Add Flavor Pumps?";
            // 
            // comboWhippedCream
            // 
            this.comboWhippedCream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWhippedCream.FormattingEnabled = true;
            this.comboWhippedCream.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboWhippedCream.Location = new System.Drawing.Point(139, 160);
            this.comboWhippedCream.Name = "comboWhippedCream";
            this.comboWhippedCream.Size = new System.Drawing.Size(181, 23);
            this.comboWhippedCream.TabIndex = 19;
            // 
            // comboSize
            // 
            this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Location = new System.Drawing.Point(113, 92);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(207, 23);
            this.comboSize.TabIndex = 18;
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.comboSize_SelectedIndexChanged);
            // 
            // comboCoffeeType
            // 
            this.comboCoffeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCoffeeType.FormattingEnabled = true;
            this.comboCoffeeType.Location = new System.Drawing.Point(113, 57);
            this.comboCoffeeType.Name = "comboCoffeeType";
            this.comboCoffeeType.Size = new System.Drawing.Size(207, 23);
            this.comboCoffeeType.TabIndex = 17;
            this.comboCoffeeType.SelectedIndexChanged += new System.EventHandler(this.comboCoffeeType_SelectedIndexChanged);
            // 
            // labelAddMessage
            // 
            this.labelAddMessage.AutoSize = true;
            this.labelAddMessage.Location = new System.Drawing.Point(8, 30);
            this.labelAddMessage.Name = "labelAddMessage";
            this.labelAddMessage.Size = new System.Drawing.Size(271, 15);
            this.labelAddMessage.TabIndex = 15;
            this.labelAddMessage.Text = "Please enter all fields and then click Add Record";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(80, 483);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(124, 23);
            this.buttonAddOrder.TabIndex = 16;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // labelComplimentary
            // 
            this.labelComplimentary.AutoSize = true;
            this.labelComplimentary.Location = new System.Drawing.Point(6, 178);
            this.labelComplimentary.Name = "labelComplimentary";
            this.labelComplimentary.Size = new System.Drawing.Size(103, 15);
            this.labelComplimentary.TabIndex = 5;
            this.labelComplimentary.Text = "(Complimentary)";
            // 
            // labelWhippedCream
            // 
            this.labelWhippedCream.AutoSize = true;
            this.labelWhippedCream.Location = new System.Drawing.Point(8, 163);
            this.labelWhippedCream.Name = "labelWhippedCream";
            this.labelWhippedCream.Size = new System.Drawing.Size(125, 15);
            this.labelWhippedCream.TabIndex = 4;
            this.labelWhippedCream.Text = "Add Whipped Cream?";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(8, 95);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(29, 15);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size";
            // 
            // labelCoffeeType
            // 
            this.labelCoffeeType.AutoSize = true;
            this.labelCoffeeType.Location = new System.Drawing.Point(8, 60);
            this.labelCoffeeType.Name = "labelCoffeeType";
            this.labelCoffeeType.Size = new System.Drawing.Size(72, 15);
            this.labelCoffeeType.TabIndex = 0;
            this.labelCoffeeType.Text = "Coffee Type\r\n";
            // 
            // groupCurrentOrders
            // 
            this.groupCurrentOrders.Controls.Add(this.gridOrders);
            this.groupCurrentOrders.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.groupCurrentOrders.Location = new System.Drawing.Point(344, 56);
            this.groupCurrentOrders.Name = "groupCurrentOrders";
            this.groupCurrentOrders.Size = new System.Drawing.Size(1130, 477);
            this.groupCurrentOrders.TabIndex = 5;
            this.groupCurrentOrders.TabStop = false;
            this.groupCurrentOrders.Text = "Current Orders";
            // 
            // groupDeleteOrders
            // 
            this.groupDeleteOrders.Controls.Add(this.buttonOrderCompleted);
            this.groupDeleteOrders.Controls.Add(this.labelDeleteMessage);
            this.groupDeleteOrders.Controls.Add(this.buttonCancelOrder);
            this.groupDeleteOrders.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeleteOrders.Location = new System.Drawing.Point(344, 539);
            this.groupDeleteOrders.Name = "groupDeleteOrders";
            this.groupDeleteOrders.Size = new System.Drawing.Size(1130, 158);
            this.groupDeleteOrders.TabIndex = 6;
            this.groupDeleteOrders.TabStop = false;
            this.groupDeleteOrders.Text = "Delete Orders";
            this.groupDeleteOrders.UseCompatibleTextRendering = true;
            // 
            // buttonOrderCompleted
            // 
            this.buttonOrderCompleted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOrderCompleted.Location = new System.Drawing.Point(179, 72);
            this.buttonOrderCompleted.Name = "buttonOrderCompleted";
            this.buttonOrderCompleted.Size = new System.Drawing.Size(123, 29);
            this.buttonOrderCompleted.TabIndex = 18;
            this.buttonOrderCompleted.Text = "Order Completed";
            this.buttonOrderCompleted.UseVisualStyleBackColor = true;
            this.buttonOrderCompleted.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // labelDeleteMessage
            // 
            this.labelDeleteMessage.AutoSize = true;
            this.labelDeleteMessage.Location = new System.Drawing.Point(18, 30);
            this.labelDeleteMessage.Name = "labelDeleteMessage";
            this.labelDeleteMessage.Size = new System.Drawing.Size(638, 15);
            this.labelDeleteMessage.TabIndex = 1;
            this.labelDeleteMessage.Text = "Please select the order to delete from top an then select the Cancel or Completed" +
    " button below (whichever applies):";
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelOrder.Location = new System.Drawing.Point(21, 72);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(123, 29);
            this.buttonCancelOrder.TabIndex = 17;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::WindowsFormsAppCoffeeClass.Properties.Resources.coffeewallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 713);
            this.Controls.Add(this.groupDeleteOrders);
            this.Controls.Add(this.groupCurrentOrders);
            this.Controls.Add(this.groupNewCoffeOrder);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ABC Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.groupNewCoffeOrder.ResumeLayout(false);
            this.groupNewCoffeOrder.PerformLayout();
            this.groupCurrentOrders.ResumeLayout(false);
            this.groupDeleteOrders.ResumeLayout(false);
            this.groupDeleteOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openStudentRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.GroupBox groupNewCoffeOrder;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelCoffeeType;
        private System.Windows.Forms.Label labelComplimentary;
        private System.Windows.Forms.Label labelWhippedCream;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.GroupBox groupCurrentOrders;
        private System.Windows.Forms.Label labelAddMessage;
        private System.Windows.Forms.GroupBox groupDeleteOrders;
        private System.Windows.Forms.Label labelDeleteMessage;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAllToolStripMenuItem;
        private System.Windows.Forms.Button buttonOrderCompleted;
        private System.Windows.Forms.ComboBox comboCoffeeType;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboWhippedCream;
        private System.Windows.Forms.ComboBox comboFlavorPumps;
        private System.Windows.Forms.Label labelPerPumpPrice;
        private System.Windows.Forms.Label labelFlavorPumps;
        private System.Windows.Forms.ComboBox comboPump3;
        private System.Windows.Forms.Label labelPump3Flavor;
        private System.Windows.Forms.ComboBox comboPump2;
        private System.Windows.Forms.Label labelPump2Flavor;
        private System.Windows.Forms.ComboBox comboPump1;
        private System.Windows.Forms.Label labelPump1Flavor;
        private System.Windows.Forms.ToolStripMenuItem redoCTRLYToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboHotCold;
        private System.Windows.Forms.Label labelHotCold;
    }
}

