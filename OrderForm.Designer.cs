namespace Excursion_Car_Rental
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.firstStepPanel = new Guna.UI.WinForms.GunaShadowPanel();
            this.secPanelOrder = new Guna.UI.WinForms.GunaShadowPanel();
            this.labelForOrderStatus = new Guna.UI.WinForms.GunaLabel();
            this.orderStatusCombo = new Guna.UI.WinForms.GunaComboBox();
            this.createOrderBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.labelForCusEmail = new Guna.UI.WinForms.GunaLabel();
            this.txt_cus_email = new Guna.UI.WinForms.GunaTextBox();
            this.labelForCusAddress = new Guna.UI.WinForms.GunaLabel();
            this.txt_cus_address = new Guna.UI.WinForms.GunaTextBox();
            this.labelForCusPhone = new Guna.UI.WinForms.GunaLabel();
            this.txt_cus_phone = new Guna.UI.WinForms.GunaTextBox();
            this.labelForCusName = new Guna.UI.WinForms.GunaLabel();
            this.txt_cus_name = new Guna.UI.WinForms.GunaTextBox();
            this.totalAmount = new Guna.UI.WinForms.GunaTextBox();
            this.labelForTotalPrice = new Guna.UI.WinForms.GunaLabel();
            this.carList = new Guna.UI.WinForms.GunaComboBox();
            this.labelForAvailableCars = new Guna.UI.WinForms.GunaLabel();
            this.txt_totalDays = new Guna.UI.WinForms.GunaTextBox();
            this.labelForTotalDays = new Guna.UI.WinForms.GunaLabel();
            this.nextOrderPageBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.labelForEndDate = new Guna.UI.WinForms.GunaLabel();
            this.labelForStartDate = new Guna.UI.WinForms.GunaLabel();
            this.endDateForTrip = new Guna.UI.WinForms.GunaDateTimePicker();
            this.startDateForTrip = new Guna.UI.WinForms.GunaDateTimePicker();
            this.typeOfCarCombo = new Guna.UI.WinForms.GunaComboBox();
            this.destinationCombo = new Guna.UI.WinForms.GunaComboBox();
            this.sourceCombo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cancelBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.firstStepPanel.SuspendLayout();
            this.secPanelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstStepPanel
            // 
            this.firstStepPanel.BackColor = System.Drawing.Color.Transparent;
            this.firstStepPanel.BaseColor = System.Drawing.Color.White;
            this.firstStepPanel.Controls.Add(this.secPanelOrder);
            this.firstStepPanel.Controls.Add(this.txt_totalDays);
            this.firstStepPanel.Controls.Add(this.labelForTotalDays);
            this.firstStepPanel.Controls.Add(this.nextOrderPageBtn);
            this.firstStepPanel.Controls.Add(this.labelForEndDate);
            this.firstStepPanel.Controls.Add(this.labelForStartDate);
            this.firstStepPanel.Controls.Add(this.endDateForTrip);
            this.firstStepPanel.Controls.Add(this.startDateForTrip);
            this.firstStepPanel.Controls.Add(this.typeOfCarCombo);
            this.firstStepPanel.Controls.Add(this.destinationCombo);
            this.firstStepPanel.Controls.Add(this.sourceCombo);
            this.firstStepPanel.Controls.Add(this.gunaLabel3);
            this.firstStepPanel.Controls.Add(this.gunaLabel2);
            this.firstStepPanel.Controls.Add(this.gunaLabel1);
            this.firstStepPanel.Location = new System.Drawing.Point(27, 46);
            this.firstStepPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstStepPanel.Name = "firstStepPanel";
            this.firstStepPanel.ShadowColor = System.Drawing.Color.Black;
            this.firstStepPanel.Size = new System.Drawing.Size(1549, 1050);
            this.firstStepPanel.TabIndex = 0;
            // 
            // secPanelOrder
            // 
            this.secPanelOrder.BackColor = System.Drawing.Color.Transparent;
            this.secPanelOrder.BaseColor = System.Drawing.Color.White;
            this.secPanelOrder.Controls.Add(this.cancelBtn);
            this.secPanelOrder.Controls.Add(this.labelForOrderStatus);
            this.secPanelOrder.Controls.Add(this.orderStatusCombo);
            this.secPanelOrder.Controls.Add(this.createOrderBtn);
            this.secPanelOrder.Controls.Add(this.labelForCusEmail);
            this.secPanelOrder.Controls.Add(this.txt_cus_email);
            this.secPanelOrder.Controls.Add(this.labelForCusAddress);
            this.secPanelOrder.Controls.Add(this.txt_cus_address);
            this.secPanelOrder.Controls.Add(this.labelForCusPhone);
            this.secPanelOrder.Controls.Add(this.txt_cus_phone);
            this.secPanelOrder.Controls.Add(this.labelForCusName);
            this.secPanelOrder.Controls.Add(this.txt_cus_name);
            this.secPanelOrder.Controls.Add(this.totalAmount);
            this.secPanelOrder.Controls.Add(this.labelForTotalPrice);
            this.secPanelOrder.Controls.Add(this.carList);
            this.secPanelOrder.Controls.Add(this.labelForAvailableCars);
            this.secPanelOrder.Location = new System.Drawing.Point(81, 428);
            this.secPanelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secPanelOrder.Name = "secPanelOrder";
            this.secPanelOrder.ShadowColor = System.Drawing.Color.Black;
            this.secPanelOrder.Size = new System.Drawing.Size(1400, 566);
            this.secPanelOrder.TabIndex = 23;
            this.secPanelOrder.Visible = false;
            // 
            // labelForOrderStatus
            // 
            this.labelForOrderStatus.AutoSize = true;
            this.labelForOrderStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForOrderStatus.Location = new System.Drawing.Point(152, 426);
            this.labelForOrderStatus.Name = "labelForOrderStatus";
            this.labelForOrderStatus.Size = new System.Drawing.Size(91, 20);
            this.labelForOrderStatus.TabIndex = 37;
            this.labelForOrderStatus.Text = "Order Status";
            // 
            // orderStatusCombo
            // 
            this.orderStatusCombo.BackColor = System.Drawing.Color.Transparent;
            this.orderStatusCombo.BaseColor = System.Drawing.Color.White;
            this.orderStatusCombo.BorderColor = System.Drawing.Color.Silver;
            this.orderStatusCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.orderStatusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderStatusCombo.FocusedColor = System.Drawing.Color.Empty;
            this.orderStatusCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.orderStatusCombo.ForeColor = System.Drawing.Color.Black;
            this.orderStatusCombo.FormattingEnabled = true;
            this.orderStatusCombo.Location = new System.Drawing.Point(333, 415);
            this.orderStatusCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderStatusCombo.Name = "orderStatusCombo";
            this.orderStatusCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderStatusCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.orderStatusCombo.Size = new System.Drawing.Size(313, 31);
            this.orderStatusCombo.TabIndex = 36;
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.AnimationHoverSpeed = 0.07F;
            this.createOrderBtn.AnimationSpeed = 0.03F;
            this.createOrderBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.createOrderBtn.BorderColor = System.Drawing.Color.Black;
            this.createOrderBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.createOrderBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.createOrderBtn.CheckedForeColor = System.Drawing.Color.White;
            this.createOrderBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("createOrderBtn.CheckedImage")));
            this.createOrderBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.createOrderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createOrderBtn.FocusedColor = System.Drawing.Color.Empty;
            this.createOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createOrderBtn.ForeColor = System.Drawing.Color.White;
            this.createOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("createOrderBtn.Image")));
            this.createOrderBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.createOrderBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createOrderBtn.Location = new System.Drawing.Point(874, 467);
            this.createOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.createOrderBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.createOrderBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.createOrderBtn.OnHoverImage = null;
            this.createOrderBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createOrderBtn.OnPressedColor = System.Drawing.Color.Black;
            this.createOrderBtn.Size = new System.Drawing.Size(180, 42);
            this.createOrderBtn.TabIndex = 35;
            this.createOrderBtn.Text = "Create Order";
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // labelForCusEmail
            // 
            this.labelForCusEmail.AutoSize = true;
            this.labelForCusEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusEmail.Location = new System.Drawing.Point(588, 335);
            this.labelForCusEmail.Name = "labelForCusEmail";
            this.labelForCusEmail.Size = new System.Drawing.Size(113, 20);
            this.labelForCusEmail.TabIndex = 33;
            this.labelForCusEmail.Text = "Customer Email";
            // 
            // txt_cus_email
            // 
            this.txt_cus_email.BaseColor = System.Drawing.Color.White;
            this.txt_cus_email.BorderColor = System.Drawing.Color.Silver;
            this.txt_cus_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cus_email.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cus_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cus_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cus_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cus_email.Location = new System.Drawing.Point(732, 322);
            this.txt_cus_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_email.Name = "txt_cus_email";
            this.txt_cus_email.PasswordChar = '\0';
            this.txt_cus_email.SelectedText = "";
            this.txt_cus_email.Size = new System.Drawing.Size(313, 37);
            this.txt_cus_email.TabIndex = 32;
            // 
            // labelForCusAddress
            // 
            this.labelForCusAddress.AutoSize = true;
            this.labelForCusAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusAddress.Location = new System.Drawing.Point(83, 336);
            this.labelForCusAddress.Name = "labelForCusAddress";
            this.labelForCusAddress.Size = new System.Drawing.Size(129, 20);
            this.labelForCusAddress.TabIndex = 31;
            this.labelForCusAddress.Text = "Customer Address";
            // 
            // txt_cus_address
            // 
            this.txt_cus_address.BaseColor = System.Drawing.Color.White;
            this.txt_cus_address.BorderColor = System.Drawing.Color.Silver;
            this.txt_cus_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cus_address.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cus_address.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cus_address.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cus_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cus_address.Location = new System.Drawing.Point(240, 324);
            this.txt_cus_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_address.Name = "txt_cus_address";
            this.txt_cus_address.PasswordChar = '\0';
            this.txt_cus_address.SelectedText = "";
            this.txt_cus_address.Size = new System.Drawing.Size(313, 37);
            this.txt_cus_address.TabIndex = 30;
            // 
            // labelForCusPhone
            // 
            this.labelForCusPhone.AutoSize = true;
            this.labelForCusPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusPhone.Location = new System.Drawing.Point(588, 202);
            this.labelForCusPhone.Name = "labelForCusPhone";
            this.labelForCusPhone.Size = new System.Drawing.Size(117, 20);
            this.labelForCusPhone.TabIndex = 29;
            this.labelForCusPhone.Text = "Customer Phone";
            // 
            // txt_cus_phone
            // 
            this.txt_cus_phone.BaseColor = System.Drawing.Color.White;
            this.txt_cus_phone.BorderColor = System.Drawing.Color.Silver;
            this.txt_cus_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cus_phone.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cus_phone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cus_phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cus_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cus_phone.Location = new System.Drawing.Point(732, 190);
            this.txt_cus_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_phone.Name = "txt_cus_phone";
            this.txt_cus_phone.PasswordChar = '\0';
            this.txt_cus_phone.SelectedText = "";
            this.txt_cus_phone.Size = new System.Drawing.Size(313, 37);
            this.txt_cus_phone.TabIndex = 28;
            // 
            // labelForCusName
            // 
            this.labelForCusName.AutoSize = true;
            this.labelForCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusName.Location = new System.Drawing.Point(83, 203);
            this.labelForCusName.Name = "labelForCusName";
            this.labelForCusName.Size = new System.Drawing.Size(116, 20);
            this.labelForCusName.TabIndex = 27;
            this.labelForCusName.Text = "Customer Name";
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.BaseColor = System.Drawing.Color.White;
            this.txt_cus_name.BorderColor = System.Drawing.Color.Silver;
            this.txt_cus_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cus_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cus_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cus_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cus_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cus_name.Location = new System.Drawing.Point(240, 191);
            this.txt_cus_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.PasswordChar = '\0';
            this.txt_cus_name.SelectedText = "";
            this.txt_cus_name.Size = new System.Drawing.Size(313, 37);
            this.txt_cus_name.TabIndex = 24;
            // 
            // totalAmount
            // 
            this.totalAmount.BaseColor = System.Drawing.Color.White;
            this.totalAmount.BorderColor = System.Drawing.Color.Silver;
            this.totalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.totalAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.totalAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalAmount.Location = new System.Drawing.Point(732, 85);
            this.totalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.PasswordChar = '\0';
            this.totalAmount.ReadOnly = true;
            this.totalAmount.SelectedText = "";
            this.totalAmount.Size = new System.Drawing.Size(313, 37);
            this.totalAmount.TabIndex = 26;
            // 
            // labelForTotalPrice
            // 
            this.labelForTotalPrice.AutoSize = true;
            this.labelForTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForTotalPrice.Location = new System.Drawing.Point(589, 96);
            this.labelForTotalPrice.Name = "labelForTotalPrice";
            this.labelForTotalPrice.Size = new System.Drawing.Size(99, 20);
            this.labelForTotalPrice.TabIndex = 25;
            this.labelForTotalPrice.Text = "Total Amount";
            // 
            // carList
            // 
            this.carList.BackColor = System.Drawing.Color.Transparent;
            this.carList.BaseColor = System.Drawing.Color.White;
            this.carList.BorderColor = System.Drawing.Color.Silver;
            this.carList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carList.FocusedColor = System.Drawing.Color.Empty;
            this.carList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.carList.ForeColor = System.Drawing.Color.Black;
            this.carList.FormattingEnabled = true;
            this.carList.Location = new System.Drawing.Point(240, 85);
            this.carList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carList.Name = "carList";
            this.carList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.carList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.carList.Size = new System.Drawing.Size(313, 31);
            this.carList.TabIndex = 24;
            this.carList.SelectedIndexChanged += new System.EventHandler(this.carList_SelectedIndexChanged);
            // 
            // labelForAvailableCars
            // 
            this.labelForAvailableCars.AutoSize = true;
            this.labelForAvailableCars.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForAvailableCars.Location = new System.Drawing.Point(79, 90);
            this.labelForAvailableCars.Name = "labelForAvailableCars";
            this.labelForAvailableCars.Size = new System.Drawing.Size(103, 20);
            this.labelForAvailableCars.TabIndex = 23;
            this.labelForAvailableCars.Text = "Available Cars";
            // 
            // txt_totalDays
            // 
            this.txt_totalDays.BaseColor = System.Drawing.Color.White;
            this.txt_totalDays.BorderColor = System.Drawing.Color.Silver;
            this.txt_totalDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_totalDays.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_totalDays.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_totalDays.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_totalDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_totalDays.Location = new System.Drawing.Point(1043, 218);
            this.txt_totalDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_totalDays.Name = "txt_totalDays";
            this.txt_totalDays.PasswordChar = '\0';
            this.txt_totalDays.ReadOnly = true;
            this.txt_totalDays.SelectedText = "";
            this.txt_totalDays.Size = new System.Drawing.Size(160, 37);
            this.txt_totalDays.TabIndex = 13;
            // 
            // labelForTotalDays
            // 
            this.labelForTotalDays.AutoSize = true;
            this.labelForTotalDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForTotalDays.Location = new System.Drawing.Point(1037, 191);
            this.labelForTotalDays.Name = "labelForTotalDays";
            this.labelForTotalDays.Size = new System.Drawing.Size(78, 20);
            this.labelForTotalDays.TabIndex = 12;
            this.labelForTotalDays.Text = "Total Days";
            // 
            // nextOrderPageBtn
            // 
            this.nextOrderPageBtn.AnimationHoverSpeed = 0.07F;
            this.nextOrderPageBtn.AnimationSpeed = 0.03F;
            this.nextOrderPageBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nextOrderPageBtn.BorderColor = System.Drawing.Color.Black;
            this.nextOrderPageBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.nextOrderPageBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.nextOrderPageBtn.CheckedForeColor = System.Drawing.Color.White;
            this.nextOrderPageBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("nextOrderPageBtn.CheckedImage")));
            this.nextOrderPageBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.nextOrderPageBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nextOrderPageBtn.FocusedColor = System.Drawing.Color.Empty;
            this.nextOrderPageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nextOrderPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextOrderPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextOrderPageBtn.Image")));
            this.nextOrderPageBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.nextOrderPageBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nextOrderPageBtn.Location = new System.Drawing.Point(1020, 293);
            this.nextOrderPageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextOrderPageBtn.Name = "nextOrderPageBtn";
            this.nextOrderPageBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.nextOrderPageBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nextOrderPageBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.nextOrderPageBtn.OnHoverImage = null;
            this.nextOrderPageBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.nextOrderPageBtn.OnPressedColor = System.Drawing.Color.Black;
            this.nextOrderPageBtn.Size = new System.Drawing.Size(180, 42);
            this.nextOrderPageBtn.TabIndex = 10;
            this.nextOrderPageBtn.Text = "Next";
            this.nextOrderPageBtn.Click += new System.EventHandler(this.nextOrderPageBtn_Click);
            // 
            // labelForEndDate
            // 
            this.labelForEndDate.AutoSize = true;
            this.labelForEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForEndDate.Location = new System.Drawing.Point(700, 191);
            this.labelForEndDate.Name = "labelForEndDate";
            this.labelForEndDate.Size = new System.Drawing.Size(70, 20);
            this.labelForEndDate.TabIndex = 9;
            this.labelForEndDate.Text = "End Date";
            // 
            // labelForStartDate
            // 
            this.labelForStartDate.AutoSize = true;
            this.labelForStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForStartDate.Location = new System.Drawing.Point(260, 191);
            this.labelForStartDate.Name = "labelForStartDate";
            this.labelForStartDate.Size = new System.Drawing.Size(76, 20);
            this.labelForStartDate.TabIndex = 8;
            this.labelForStartDate.Text = "Start Date";
            // 
            // endDateForTrip
            // 
            this.endDateForTrip.BaseColor = System.Drawing.Color.White;
            this.endDateForTrip.BorderColor = System.Drawing.Color.Silver;
            this.endDateForTrip.CustomFormat = null;
            this.endDateForTrip.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endDateForTrip.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.endDateForTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endDateForTrip.ForeColor = System.Drawing.Color.Black;
            this.endDateForTrip.Location = new System.Drawing.Point(756, 220);
            this.endDateForTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateForTrip.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDateForTrip.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDateForTrip.Name = "endDateForTrip";
            this.endDateForTrip.OnHoverBaseColor = System.Drawing.Color.White;
            this.endDateForTrip.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.endDateForTrip.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.endDateForTrip.OnPressedColor = System.Drawing.Color.Black;
            this.endDateForTrip.Size = new System.Drawing.Size(223, 30);
            this.endDateForTrip.TabIndex = 7;
            this.endDateForTrip.Text = "Wednesday, August 28, 2024";
            this.endDateForTrip.Value = new System.DateTime(2024, 8, 28, 15, 48, 21, 609);
            this.endDateForTrip.ValueChanged += new System.EventHandler(this.endDateForTrip_ValueChanged);
            // 
            // startDateForTrip
            // 
            this.startDateForTrip.BaseColor = System.Drawing.Color.White;
            this.startDateForTrip.BorderColor = System.Drawing.Color.Silver;
            this.startDateForTrip.CustomFormat = null;
            this.startDateForTrip.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDateForTrip.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startDateForTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startDateForTrip.ForeColor = System.Drawing.Color.Black;
            this.startDateForTrip.Location = new System.Drawing.Point(331, 220);
            this.startDateForTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateForTrip.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDateForTrip.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDateForTrip.Name = "startDateForTrip";
            this.startDateForTrip.OnHoverBaseColor = System.Drawing.Color.White;
            this.startDateForTrip.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startDateForTrip.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startDateForTrip.OnPressedColor = System.Drawing.Color.Black;
            this.startDateForTrip.Size = new System.Drawing.Size(223, 30);
            this.startDateForTrip.TabIndex = 6;
            this.startDateForTrip.Text = "Wednesday, August 28, 2024";
            this.startDateForTrip.Value = new System.DateTime(2024, 8, 28, 15, 48, 21, 609);
            this.startDateForTrip.ValueChanged += new System.EventHandler(this.startDateForTrip_ValueChanged);
            // 
            // typeOfCarCombo
            // 
            this.typeOfCarCombo.BackColor = System.Drawing.Color.Transparent;
            this.typeOfCarCombo.BaseColor = System.Drawing.Color.White;
            this.typeOfCarCombo.BorderColor = System.Drawing.Color.Silver;
            this.typeOfCarCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeOfCarCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfCarCombo.FocusedColor = System.Drawing.Color.Empty;
            this.typeOfCarCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeOfCarCombo.ForeColor = System.Drawing.Color.Black;
            this.typeOfCarCombo.FormattingEnabled = true;
            this.typeOfCarCombo.Location = new System.Drawing.Point(955, 103);
            this.typeOfCarCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfCarCombo.Name = "typeOfCarCombo";
            this.typeOfCarCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.typeOfCarCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.typeOfCarCombo.Size = new System.Drawing.Size(283, 31);
            this.typeOfCarCombo.TabIndex = 5;
            this.typeOfCarCombo.SelectedIndexChanged += new System.EventHandler(this.typeOfCarCombo_SelectedIndexChanged);
            // 
            // destinationCombo
            // 
            this.destinationCombo.BackColor = System.Drawing.Color.Transparent;
            this.destinationCombo.BaseColor = System.Drawing.Color.White;
            this.destinationCombo.BorderColor = System.Drawing.Color.Silver;
            this.destinationCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destinationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationCombo.FocusedColor = System.Drawing.Color.Empty;
            this.destinationCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.destinationCombo.ForeColor = System.Drawing.Color.Black;
            this.destinationCombo.FormattingEnabled = true;
            this.destinationCombo.Location = new System.Drawing.Point(547, 103);
            this.destinationCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationCombo.Name = "destinationCombo";
            this.destinationCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.destinationCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.destinationCombo.Size = new System.Drawing.Size(276, 31);
            this.destinationCombo.TabIndex = 4;
            this.destinationCombo.SelectedIndexChanged += new System.EventHandler(this.destinationCombo_SelectedIndexChanged);
            // 
            // sourceCombo
            // 
            this.sourceCombo.BackColor = System.Drawing.Color.Transparent;
            this.sourceCombo.BaseColor = System.Drawing.Color.White;
            this.sourceCombo.BorderColor = System.Drawing.Color.Silver;
            this.sourceCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sourceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceCombo.FocusedColor = System.Drawing.Color.Empty;
            this.sourceCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sourceCombo.ForeColor = System.Drawing.Color.Black;
            this.sourceCombo.FormattingEnabled = true;
            this.sourceCombo.Items.AddRange(new object[] {
            "Meikhtila"});
            this.sourceCombo.Location = new System.Drawing.Point(255, 103);
            this.sourceCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sourceCombo.Name = "sourceCombo";
            this.sourceCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sourceCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sourceCombo.Size = new System.Drawing.Size(196, 31);
            this.sourceCombo.StartIndex = 0;
            this.sourceCombo.TabIndex = 3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(989, 57);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Type Of Car";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(564, 57);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Destination";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(251, 57);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Source";
            // 
            // cancelBtn
            // 
            this.cancelBtn.AnimationHoverSpeed = 0.07F;
            this.cancelBtn.AnimationSpeed = 0.03F;
            this.cancelBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cancelBtn.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.cancelBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.cancelBtn.CheckedForeColor = System.Drawing.Color.White;
            this.cancelBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.CheckedImage")));
            this.cancelBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelBtn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cancelBtn.Location = new System.Drawing.Point(638, 467);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cancelBtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelBtn.Size = new System.Drawing.Size(180, 42);
            this.cancelBtn.TabIndex = 38;
            this.cancelBtn.Text = "Go Back";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1088);
            this.ControlBox = false;
            this.Controls.Add(this.firstStepPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.firstStepPanel.ResumeLayout(false);
            this.firstStepPanel.PerformLayout();
            this.secPanelOrder.ResumeLayout(false);
            this.secPanelOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel firstStepPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox typeOfCarCombo;
        private Guna.UI.WinForms.GunaComboBox destinationCombo;
        private Guna.UI.WinForms.GunaComboBox sourceCombo;
        private Guna.UI.WinForms.GunaLabel labelForEndDate;
        private Guna.UI.WinForms.GunaLabel labelForStartDate;
        private Guna.UI.WinForms.GunaDateTimePicker endDateForTrip;
        private Guna.UI.WinForms.GunaDateTimePicker startDateForTrip;
        private Guna.UI.WinForms.GunaAdvenceButton nextOrderPageBtn;
        private Guna.UI.WinForms.GunaTextBox txt_totalDays;
        private Guna.UI.WinForms.GunaLabel labelForTotalDays;
        private Guna.UI.WinForms.GunaShadowPanel secPanelOrder;
        private Guna.UI.WinForms.GunaTextBox totalAmount;
        private Guna.UI.WinForms.GunaLabel labelForTotalPrice;
        private Guna.UI.WinForms.GunaComboBox carList;
        private Guna.UI.WinForms.GunaLabel labelForAvailableCars;
        private Guna.UI.WinForms.GunaTextBox txt_cus_name;
        private Guna.UI.WinForms.GunaLabel labelForCusName;
        private Guna.UI.WinForms.GunaLabel labelForCusEmail;
        private Guna.UI.WinForms.GunaTextBox txt_cus_email;
        private Guna.UI.WinForms.GunaLabel labelForCusAddress;
        private Guna.UI.WinForms.GunaTextBox txt_cus_address;
        private Guna.UI.WinForms.GunaLabel labelForCusPhone;
        private Guna.UI.WinForms.GunaTextBox txt_cus_phone;
        private Guna.UI.WinForms.GunaAdvenceButton createOrderBtn;
        private Guna.UI.WinForms.GunaLabel labelForOrderStatus;
        private Guna.UI.WinForms.GunaComboBox orderStatusCombo;
        private Guna.UI.WinForms.GunaAdvenceButton cancelBtn;
    }
}