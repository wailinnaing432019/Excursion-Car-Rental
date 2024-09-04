namespace Excursion_Car_Rental
{
    partial class OrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetail));
            this.labelForOrderId = new Guna.UI.WinForms.GunaLabel();
            this.labelForOrderDetialPage = new Guna.UI.WinForms.GunaLabel();
            this.labelForCarBrand = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_orderId = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tripRoute = new Guna.UI.WinForms.GunaTextBox();
            this.txt_carBrand = new Guna.UI.WinForms.GunaTextBox();
            this.labelForDateRange = new Guna.UI.WinForms.GunaLabel();
            this.labelForTripRoute = new Guna.UI.WinForms.GunaLabel();
            this.txt_dateRange = new Guna.UI.WinForms.GunaTextBox();
            this.txt_cusEmail = new Guna.UI.WinForms.GunaTextBox();
            this.labelForCusAddress = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_cusPhno = new Guna.UI.WinForms.GunaTextBox();
            this.txt_cusAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txt_cusName = new Guna.UI.WinForms.GunaTextBox();
            this.labelForCusPhno = new Guna.UI.WinForms.GunaLabel();
            this.labelForCusName = new Guna.UI.WinForms.GunaLabel();
            this.labelForStatus = new Guna.UI.WinForms.GunaLabel();
            this.orderStatusCombo = new Guna.UI.WinForms.GunaComboBox();
            this.updateStatusBtn = new Guna.UI.WinForms.GunaButton();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelForOrderId
            // 
            this.labelForOrderId.AutoSize = true;
            this.labelForOrderId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForOrderId.Location = new System.Drawing.Point(73, 139);
            this.labelForOrderId.Name = "labelForOrderId";
            this.labelForOrderId.Size = new System.Drawing.Size(67, 20);
            this.labelForOrderId.TabIndex = 1;
            this.labelForOrderId.Text = "OrderId :";
            // 
            // labelForOrderDetialPage
            // 
            this.labelForOrderDetialPage.AutoSize = true;
            this.labelForOrderDetialPage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForOrderDetialPage.Location = new System.Drawing.Point(140, 25);
            this.labelForOrderDetialPage.Name = "labelForOrderDetialPage";
            this.labelForOrderDetialPage.Size = new System.Drawing.Size(230, 32);
            this.labelForOrderDetialPage.TabIndex = 0;
            this.labelForOrderDetialPage.Text = "Order Detail Page";
            // 
            // labelForCarBrand
            // 
            this.labelForCarBrand.AutoSize = true;
            this.labelForCarBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCarBrand.Location = new System.Drawing.Point(73, 209);
            this.labelForCarBrand.Name = "labelForCarBrand";
            this.labelForCarBrand.Size = new System.Drawing.Size(74, 20);
            this.labelForCarBrand.TabIndex = 3;
            this.labelForCarBrand.Text = "Car Brand";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.updateStatusBtn);
            this.panel1.Controls.Add(this.orderStatusCombo);
            this.panel1.Controls.Add(this.labelForStatus);
            this.panel1.Controls.Add(this.txt_cusEmail);
            this.panel1.Controls.Add(this.labelForCusAddress);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.txt_cusPhno);
            this.panel1.Controls.Add(this.txt_cusAddress);
            this.panel1.Controls.Add(this.txt_cusName);
            this.panel1.Controls.Add(this.labelForCusPhno);
            this.panel1.Controls.Add(this.labelForCusName);
            this.panel1.Controls.Add(this.txt_dateRange);
            this.panel1.Controls.Add(this.labelForTripRoute);
            this.panel1.Controls.Add(this.labelForDateRange);
            this.panel1.Controls.Add(this.txt_carBrand);
            this.panel1.Controls.Add(this.txt_tripRoute);
            this.panel1.Controls.Add(this.txt_orderId);
            this.panel1.Controls.Add(this.labelForOrderDetialPage);
            this.panel1.Controls.Add(this.labelForCarBrand);
            this.panel1.Controls.Add(this.labelForOrderId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 853);
            this.panel1.TabIndex = 4;
            // 
            // txt_orderId
            // 
            this.txt_orderId.BaseColor = System.Drawing.Color.White;
            this.txt_orderId.BorderColor = System.Drawing.Color.Silver;
            this.txt_orderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_orderId.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_orderId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_orderId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_orderId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_orderId.Location = new System.Drawing.Point(198, 127);
            this.txt_orderId.Name = "txt_orderId";
            this.txt_orderId.PasswordChar = '\0';
            this.txt_orderId.ReadOnly = true;
            this.txt_orderId.SelectedText = "";
            this.txt_orderId.Size = new System.Drawing.Size(346, 32);
            this.txt_orderId.TabIndex = 4;
            this.txt_orderId.Text = "gunaTextBox1";
            // 
            // txt_tripRoute
            // 
            this.txt_tripRoute.BaseColor = System.Drawing.Color.White;
            this.txt_tripRoute.BorderColor = System.Drawing.Color.Silver;
            this.txt_tripRoute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tripRoute.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tripRoute.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tripRoute.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tripRoute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tripRoute.Location = new System.Drawing.Point(198, 280);
            this.txt_tripRoute.Name = "txt_tripRoute";
            this.txt_tripRoute.PasswordChar = '\0';
            this.txt_tripRoute.ReadOnly = true;
            this.txt_tripRoute.SelectedText = "";
            this.txt_tripRoute.Size = new System.Drawing.Size(346, 32);
            this.txt_tripRoute.TabIndex = 5;
            this.txt_tripRoute.Text = "gunaTextBox1";
            // 
            // txt_carBrand
            // 
            this.txt_carBrand.BaseColor = System.Drawing.Color.White;
            this.txt_carBrand.BorderColor = System.Drawing.Color.Silver;
            this.txt_carBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_carBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_carBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_carBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_carBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_carBrand.Location = new System.Drawing.Point(198, 197);
            this.txt_carBrand.Name = "txt_carBrand";
            this.txt_carBrand.PasswordChar = '\0';
            this.txt_carBrand.ReadOnly = true;
            this.txt_carBrand.SelectedText = "";
            this.txt_carBrand.Size = new System.Drawing.Size(346, 32);
            this.txt_carBrand.TabIndex = 6;
            this.txt_carBrand.Text = "gunaTextBox1";
            // 
            // labelForDateRange
            // 
            this.labelForDateRange.AutoSize = true;
            this.labelForDateRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForDateRange.Location = new System.Drawing.Point(73, 355);
            this.labelForDateRange.Name = "labelForDateRange";
            this.labelForDateRange.Size = new System.Drawing.Size(87, 20);
            this.labelForDateRange.TabIndex = 7;
            this.labelForDateRange.Text = "Date Range";
            // 
            // labelForTripRoute
            // 
            this.labelForTripRoute.AutoSize = true;
            this.labelForTripRoute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForTripRoute.Location = new System.Drawing.Point(73, 292);
            this.labelForTripRoute.Name = "labelForTripRoute";
            this.labelForTripRoute.Size = new System.Drawing.Size(34, 20);
            this.labelForTripRoute.TabIndex = 8;
            this.labelForTripRoute.Text = "Trip";
            // 
            // txt_dateRange
            // 
            this.txt_dateRange.BaseColor = System.Drawing.Color.White;
            this.txt_dateRange.BorderColor = System.Drawing.Color.Silver;
            this.txt_dateRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dateRange.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_dateRange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dateRange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_dateRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dateRange.Location = new System.Drawing.Point(198, 343);
            this.txt_dateRange.Name = "txt_dateRange";
            this.txt_dateRange.PasswordChar = '\0';
            this.txt_dateRange.ReadOnly = true;
            this.txt_dateRange.SelectedText = "";
            this.txt_dateRange.Size = new System.Drawing.Size(346, 32);
            this.txt_dateRange.TabIndex = 9;
            this.txt_dateRange.Text = "gunaTextBox1";
            // 
            // txt_cusEmail
            // 
            this.txt_cusEmail.BaseColor = System.Drawing.Color.White;
            this.txt_cusEmail.BorderColor = System.Drawing.Color.Silver;
            this.txt_cusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cusEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cusEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cusEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cusEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cusEmail.Location = new System.Drawing.Point(712, 343);
            this.txt_cusEmail.Name = "txt_cusEmail";
            this.txt_cusEmail.PasswordChar = '\0';
            this.txt_cusEmail.ReadOnly = true;
            this.txt_cusEmail.SelectedText = "";
            this.txt_cusEmail.Size = new System.Drawing.Size(346, 32);
            this.txt_cusEmail.TabIndex = 17;
            this.txt_cusEmail.Text = "gunaTextBox1";
            // 
            // labelForCusAddress
            // 
            this.labelForCusAddress.AutoSize = true;
            this.labelForCusAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusAddress.Location = new System.Drawing.Point(574, 292);
            this.labelForCusAddress.Name = "labelForCusAddress";
            this.labelForCusAddress.Size = new System.Drawing.Size(129, 20);
            this.labelForCusAddress.TabIndex = 16;
            this.labelForCusAddress.Text = "Customer Address";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(587, 355);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(113, 20);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Customer Email";
            // 
            // txt_cusPhno
            // 
            this.txt_cusPhno.BaseColor = System.Drawing.Color.White;
            this.txt_cusPhno.BorderColor = System.Drawing.Color.Silver;
            this.txt_cusPhno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cusPhno.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cusPhno.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cusPhno.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cusPhno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cusPhno.Location = new System.Drawing.Point(712, 197);
            this.txt_cusPhno.Name = "txt_cusPhno";
            this.txt_cusPhno.PasswordChar = '\0';
            this.txt_cusPhno.ReadOnly = true;
            this.txt_cusPhno.SelectedText = "";
            this.txt_cusPhno.Size = new System.Drawing.Size(346, 32);
            this.txt_cusPhno.TabIndex = 14;
            this.txt_cusPhno.Text = "gunaTextBox1";
            // 
            // txt_cusAddress
            // 
            this.txt_cusAddress.BaseColor = System.Drawing.Color.White;
            this.txt_cusAddress.BorderColor = System.Drawing.Color.Silver;
            this.txt_cusAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cusAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cusAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cusAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cusAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cusAddress.Location = new System.Drawing.Point(712, 280);
            this.txt_cusAddress.Name = "txt_cusAddress";
            this.txt_cusAddress.PasswordChar = '\0';
            this.txt_cusAddress.ReadOnly = true;
            this.txt_cusAddress.SelectedText = "";
            this.txt_cusAddress.Size = new System.Drawing.Size(346, 32);
            this.txt_cusAddress.TabIndex = 13;
            this.txt_cusAddress.Text = "gunaTextBox1";
            // 
            // txt_cusName
            // 
            this.txt_cusName.BaseColor = System.Drawing.Color.White;
            this.txt_cusName.BorderColor = System.Drawing.Color.Silver;
            this.txt_cusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cusName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cusName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cusName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cusName.Location = new System.Drawing.Point(712, 127);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.PasswordChar = '\0';
            this.txt_cusName.ReadOnly = true;
            this.txt_cusName.SelectedText = "";
            this.txt_cusName.Size = new System.Drawing.Size(346, 32);
            this.txt_cusName.TabIndex = 12;
            this.txt_cusName.Text = "gunaTextBox1";
            // 
            // labelForCusPhno
            // 
            this.labelForCusPhno.AutoSize = true;
            this.labelForCusPhno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusPhno.Location = new System.Drawing.Point(587, 209);
            this.labelForCusPhno.Name = "labelForCusPhno";
            this.labelForCusPhno.Size = new System.Drawing.Size(116, 20);
            this.labelForCusPhno.TabIndex = 11;
            this.labelForCusPhno.Text = "Customer Phno :";
            // 
            // labelForCusName
            // 
            this.labelForCusName.AutoSize = true;
            this.labelForCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForCusName.Location = new System.Drawing.Point(590, 139);
            this.labelForCusName.Name = "labelForCusName";
            this.labelForCusName.Size = new System.Drawing.Size(79, 20);
            this.labelForCusName.TabIndex = 10;
            this.labelForCusName.Text = "Customer :";
            // 
            // labelForStatus
            // 
            this.labelForStatus.AutoSize = true;
            this.labelForStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelForStatus.Location = new System.Drawing.Point(229, 429);
            this.labelForStatus.Name = "labelForStatus";
            this.labelForStatus.Size = new System.Drawing.Size(87, 20);
            this.labelForStatus.TabIndex = 18;
            this.labelForStatus.Text = "Date Range";
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
            this.orderStatusCombo.Location = new System.Drawing.Point(388, 418);
            this.orderStatusCombo.Name = "orderStatusCombo";
            this.orderStatusCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderStatusCombo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.orderStatusCombo.Size = new System.Drawing.Size(229, 31);
            this.orderStatusCombo.TabIndex = 19;
            // 
            // updateStatusBtn
            // 
            this.updateStatusBtn.AnimationHoverSpeed = 0.07F;
            this.updateStatusBtn.AnimationSpeed = 0.03F;
            this.updateStatusBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updateStatusBtn.BorderColor = System.Drawing.Color.Black;
            this.updateStatusBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateStatusBtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateStatusBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateStatusBtn.ForeColor = System.Drawing.Color.White;
            this.updateStatusBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateStatusBtn.Image")));
            this.updateStatusBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updateStatusBtn.Location = new System.Drawing.Point(847, 493);
            this.updateStatusBtn.Name = "updateStatusBtn";
            this.updateStatusBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateStatusBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateStatusBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateStatusBtn.OnHoverImage = null;
            this.updateStatusBtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateStatusBtn.Size = new System.Drawing.Size(276, 42);
            this.updateStatusBtn.TabIndex = 20;
            this.updateStatusBtn.Text = "Update Status And Send Mail";
            this.updateStatusBtn.Click += new System.EventHandler(this.updateStatusBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AnimationHoverSpeed = 0.07F;
            this.cancelBtn.AnimationSpeed = 0.03F;
            this.cancelBtn.BaseColor = System.Drawing.Color.Red;
            this.cancelBtn.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelBtn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(534, 493);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelBtn.Size = new System.Drawing.Size(276, 42);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel labelForOrderId;
        private Guna.UI.WinForms.GunaLabel labelForOrderDetialPage;
        private Guna.UI.WinForms.GunaLabel labelForCarBrand;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txt_orderId;
        private Guna.UI.WinForms.GunaTextBox txt_carBrand;
        private Guna.UI.WinForms.GunaTextBox txt_tripRoute;
        private Guna.UI.WinForms.GunaTextBox txt_dateRange;
        private Guna.UI.WinForms.GunaLabel labelForTripRoute;
        private Guna.UI.WinForms.GunaLabel labelForDateRange;
        private Guna.UI.WinForms.GunaTextBox txt_cusEmail;
        private Guna.UI.WinForms.GunaLabel labelForCusAddress;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_cusPhno;
        private Guna.UI.WinForms.GunaTextBox txt_cusAddress;
        private Guna.UI.WinForms.GunaTextBox txt_cusName;
        private Guna.UI.WinForms.GunaLabel labelForCusPhno;
        private Guna.UI.WinForms.GunaLabel labelForCusName;
        private Guna.UI.WinForms.GunaComboBox orderStatusCombo;
        private Guna.UI.WinForms.GunaLabel labelForStatus;
        private Guna.UI.WinForms.GunaButton updateStatusBtn;
        private Guna.UI.WinForms.GunaButton cancelBtn;
    }
}