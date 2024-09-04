namespace Excursion_Car_Rental
{
    partial class AddCarForm
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
            this.categoryComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.carNumberTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carBrandTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.noOfSeatsTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.driverNameTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.driverLicenseTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.driverPhNoTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.driverAddressTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.carRankTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car number";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoResize = false;
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryComboBox.Depth = 0;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categoryComboBox.DropDownHeight = 174;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.DropDownWidth = 121;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.IntegralHeight = false;
            this.categoryComboBox.ItemHeight = 43;
            this.categoryComboBox.Location = new System.Drawing.Point(239, 22);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryComboBox.MaxDropDownItems = 4;
            this.categoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(92, 49);
            this.categoryComboBox.StartIndex = 0;
            this.categoryComboBox.TabIndex = 2;
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.AllowPromptAsInput = true;
            this.carNumberTextBox.AnimateReadOnly = false;
            this.carNumberTextBox.AsciiOnly = false;
            this.carNumberTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carNumberTextBox.BeepOnError = false;
            this.carNumberTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carNumberTextBox.Depth = 0;
            this.carNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carNumberTextBox.HidePromptOnLeave = false;
            this.carNumberTextBox.HideSelection = true;
            this.carNumberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.carNumberTextBox.LeadingIcon = null;
            this.carNumberTextBox.Location = new System.Drawing.Point(239, 76);
            this.carNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carNumberTextBox.Mask = "";
            this.carNumberTextBox.MaxLength = 32767;
            this.carNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.PasswordChar = '\0';
            this.carNumberTextBox.PrefixSuffixText = null;
            this.carNumberTextBox.PromptChar = '_';
            this.carNumberTextBox.ReadOnly = false;
            this.carNumberTextBox.RejectInputOnFirstFailure = false;
            this.carNumberTextBox.ResetOnPrompt = true;
            this.carNumberTextBox.ResetOnSpace = true;
            this.carNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carNumberTextBox.SelectedText = "";
            this.carNumberTextBox.SelectionLength = 0;
            this.carNumberTextBox.SelectionStart = 0;
            this.carNumberTextBox.ShortcutsEnabled = true;
            this.carNumberTextBox.Size = new System.Drawing.Size(188, 48);
            this.carNumberTextBox.SkipLiterals = true;
            this.carNumberTextBox.TabIndex = 3;
            this.carNumberTextBox.TabStop = false;
            this.carNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carNumberTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carNumberTextBox.TrailingIcon = null;
            this.carNumberTextBox.UseSystemPasswordChar = false;
            this.carNumberTextBox.ValidatingType = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.AllowPromptAsInput = true;
            this.carBrandTextBox.AnimateReadOnly = false;
            this.carBrandTextBox.AsciiOnly = false;
            this.carBrandTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carBrandTextBox.BeepOnError = false;
            this.carBrandTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carBrandTextBox.Depth = 0;
            this.carBrandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carBrandTextBox.HidePromptOnLeave = false;
            this.carBrandTextBox.HideSelection = true;
            this.carBrandTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.carBrandTextBox.LeadingIcon = null;
            this.carBrandTextBox.Location = new System.Drawing.Point(239, 134);
            this.carBrandTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carBrandTextBox.Mask = "";
            this.carBrandTextBox.MaxLength = 32767;
            this.carBrandTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.PasswordChar = '\0';
            this.carBrandTextBox.PrefixSuffixText = null;
            this.carBrandTextBox.PromptChar = '_';
            this.carBrandTextBox.ReadOnly = false;
            this.carBrandTextBox.RejectInputOnFirstFailure = false;
            this.carBrandTextBox.ResetOnPrompt = true;
            this.carBrandTextBox.ResetOnSpace = true;
            this.carBrandTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carBrandTextBox.SelectedText = "";
            this.carBrandTextBox.SelectionLength = 0;
            this.carBrandTextBox.SelectionStart = 0;
            this.carBrandTextBox.ShortcutsEnabled = true;
            this.carBrandTextBox.Size = new System.Drawing.Size(188, 48);
            this.carBrandTextBox.SkipLiterals = true;
            this.carBrandTextBox.TabIndex = 5;
            this.carBrandTextBox.TabStop = false;
            this.carBrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carBrandTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carBrandTextBox.TrailingIcon = null;
            this.carBrandTextBox.UseSystemPasswordChar = false;
            this.carBrandTextBox.ValidatingType = null;
            // 
            // noOfSeatsTextBox
            // 
            this.noOfSeatsTextBox.AllowPromptAsInput = true;
            this.noOfSeatsTextBox.AnimateReadOnly = false;
            this.noOfSeatsTextBox.AsciiOnly = false;
            this.noOfSeatsTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.noOfSeatsTextBox.BeepOnError = false;
            this.noOfSeatsTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.noOfSeatsTextBox.Depth = 0;
            this.noOfSeatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noOfSeatsTextBox.HidePromptOnLeave = false;
            this.noOfSeatsTextBox.HideSelection = true;
            this.noOfSeatsTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.noOfSeatsTextBox.LeadingIcon = null;
            this.noOfSeatsTextBox.Location = new System.Drawing.Point(239, 194);
            this.noOfSeatsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noOfSeatsTextBox.Mask = "";
            this.noOfSeatsTextBox.MaxLength = 32767;
            this.noOfSeatsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.noOfSeatsTextBox.Name = "noOfSeatsTextBox";
            this.noOfSeatsTextBox.PasswordChar = '\0';
            this.noOfSeatsTextBox.PrefixSuffixText = null;
            this.noOfSeatsTextBox.PromptChar = '_';
            this.noOfSeatsTextBox.ReadOnly = false;
            this.noOfSeatsTextBox.RejectInputOnFirstFailure = false;
            this.noOfSeatsTextBox.ResetOnPrompt = true;
            this.noOfSeatsTextBox.ResetOnSpace = true;
            this.noOfSeatsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noOfSeatsTextBox.SelectedText = "";
            this.noOfSeatsTextBox.SelectionLength = 0;
            this.noOfSeatsTextBox.SelectionStart = 0;
            this.noOfSeatsTextBox.ShortcutsEnabled = true;
            this.noOfSeatsTextBox.Size = new System.Drawing.Size(188, 48);
            this.noOfSeatsTextBox.SkipLiterals = true;
            this.noOfSeatsTextBox.TabIndex = 6;
            this.noOfSeatsTextBox.TabStop = false;
            this.noOfSeatsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.noOfSeatsTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.noOfSeatsTextBox.TrailingIcon = null;
            this.noOfSeatsTextBox.UseSystemPasswordChar = false;
            this.noOfSeatsTextBox.ValidatingType = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Driver name";
            // 
            // driverNameTextBox
            // 
            this.driverNameTextBox.AllowPromptAsInput = true;
            this.driverNameTextBox.AnimateReadOnly = false;
            this.driverNameTextBox.AsciiOnly = false;
            this.driverNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.driverNameTextBox.BeepOnError = false;
            this.driverNameTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverNameTextBox.Depth = 0;
            this.driverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.driverNameTextBox.HidePromptOnLeave = false;
            this.driverNameTextBox.HideSelection = true;
            this.driverNameTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.driverNameTextBox.LeadingIcon = null;
            this.driverNameTextBox.Location = new System.Drawing.Point(239, 258);
            this.driverNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverNameTextBox.Mask = "";
            this.driverNameTextBox.MaxLength = 32767;
            this.driverNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.driverNameTextBox.Name = "driverNameTextBox";
            this.driverNameTextBox.PasswordChar = '\0';
            this.driverNameTextBox.PrefixSuffixText = null;
            this.driverNameTextBox.PromptChar = '_';
            this.driverNameTextBox.ReadOnly = false;
            this.driverNameTextBox.RejectInputOnFirstFailure = false;
            this.driverNameTextBox.ResetOnPrompt = true;
            this.driverNameTextBox.ResetOnSpace = true;
            this.driverNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverNameTextBox.SelectedText = "";
            this.driverNameTextBox.SelectionLength = 0;
            this.driverNameTextBox.SelectionStart = 0;
            this.driverNameTextBox.ShortcutsEnabled = true;
            this.driverNameTextBox.Size = new System.Drawing.Size(188, 48);
            this.driverNameTextBox.SkipLiterals = true;
            this.driverNameTextBox.TabIndex = 9;
            this.driverNameTextBox.TabStop = false;
            this.driverNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.driverNameTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverNameTextBox.TrailingIcon = null;
            this.driverNameTextBox.UseSystemPasswordChar = false;
            this.driverNameTextBox.ValidatingType = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Driver license";
            // 
            // driverLicenseTextBox
            // 
            this.driverLicenseTextBox.AllowPromptAsInput = true;
            this.driverLicenseTextBox.AnimateReadOnly = false;
            this.driverLicenseTextBox.AsciiOnly = false;
            this.driverLicenseTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.driverLicenseTextBox.BeepOnError = false;
            this.driverLicenseTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverLicenseTextBox.Depth = 0;
            this.driverLicenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.driverLicenseTextBox.HidePromptOnLeave = false;
            this.driverLicenseTextBox.HideSelection = true;
            this.driverLicenseTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.driverLicenseTextBox.LeadingIcon = null;
            this.driverLicenseTextBox.Location = new System.Drawing.Point(239, 322);
            this.driverLicenseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverLicenseTextBox.Mask = "";
            this.driverLicenseTextBox.MaxLength = 32767;
            this.driverLicenseTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.driverLicenseTextBox.Name = "driverLicenseTextBox";
            this.driverLicenseTextBox.PasswordChar = '\0';
            this.driverLicenseTextBox.PrefixSuffixText = null;
            this.driverLicenseTextBox.PromptChar = '_';
            this.driverLicenseTextBox.ReadOnly = false;
            this.driverLicenseTextBox.RejectInputOnFirstFailure = false;
            this.driverLicenseTextBox.ResetOnPrompt = true;
            this.driverLicenseTextBox.ResetOnSpace = true;
            this.driverLicenseTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverLicenseTextBox.SelectedText = "";
            this.driverLicenseTextBox.SelectionLength = 0;
            this.driverLicenseTextBox.SelectionStart = 0;
            this.driverLicenseTextBox.ShortcutsEnabled = true;
            this.driverLicenseTextBox.Size = new System.Drawing.Size(188, 48);
            this.driverLicenseTextBox.SkipLiterals = true;
            this.driverLicenseTextBox.TabIndex = 11;
            this.driverLicenseTextBox.TabStop = false;
            this.driverLicenseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.driverLicenseTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverLicenseTextBox.TrailingIcon = null;
            this.driverLicenseTextBox.UseSystemPasswordChar = false;
            this.driverLicenseTextBox.ValidatingType = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Driver phone number";
            // 
            // driverPhNoTextBox
            // 
            this.driverPhNoTextBox.AllowPromptAsInput = true;
            this.driverPhNoTextBox.AnimateReadOnly = false;
            this.driverPhNoTextBox.AsciiOnly = false;
            this.driverPhNoTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.driverPhNoTextBox.BeepOnError = false;
            this.driverPhNoTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverPhNoTextBox.Depth = 0;
            this.driverPhNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.driverPhNoTextBox.HidePromptOnLeave = false;
            this.driverPhNoTextBox.HideSelection = true;
            this.driverPhNoTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.driverPhNoTextBox.LeadingIcon = null;
            this.driverPhNoTextBox.Location = new System.Drawing.Point(239, 385);
            this.driverPhNoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverPhNoTextBox.Mask = "";
            this.driverPhNoTextBox.MaxLength = 32767;
            this.driverPhNoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.driverPhNoTextBox.Name = "driverPhNoTextBox";
            this.driverPhNoTextBox.PasswordChar = '\0';
            this.driverPhNoTextBox.PrefixSuffixText = null;
            this.driverPhNoTextBox.PromptChar = '_';
            this.driverPhNoTextBox.ReadOnly = false;
            this.driverPhNoTextBox.RejectInputOnFirstFailure = false;
            this.driverPhNoTextBox.ResetOnPrompt = true;
            this.driverPhNoTextBox.ResetOnSpace = true;
            this.driverPhNoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverPhNoTextBox.SelectedText = "";
            this.driverPhNoTextBox.SelectionLength = 0;
            this.driverPhNoTextBox.SelectionStart = 0;
            this.driverPhNoTextBox.ShortcutsEnabled = true;
            this.driverPhNoTextBox.Size = new System.Drawing.Size(188, 48);
            this.driverPhNoTextBox.SkipLiterals = true;
            this.driverPhNoTextBox.TabIndex = 13;
            this.driverPhNoTextBox.TabStop = false;
            this.driverPhNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.driverPhNoTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverPhNoTextBox.TrailingIcon = null;
            this.driverPhNoTextBox.UseSystemPasswordChar = false;
            this.driverPhNoTextBox.ValidatingType = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 461);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Driver address";
            // 
            // driverAddressTextBox
            // 
            this.driverAddressTextBox.AllowPromptAsInput = true;
            this.driverAddressTextBox.AnimateReadOnly = false;
            this.driverAddressTextBox.AsciiOnly = false;
            this.driverAddressTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.driverAddressTextBox.BeepOnError = false;
            this.driverAddressTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverAddressTextBox.Depth = 0;
            this.driverAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.driverAddressTextBox.HidePromptOnLeave = false;
            this.driverAddressTextBox.HideSelection = true;
            this.driverAddressTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.driverAddressTextBox.LeadingIcon = null;
            this.driverAddressTextBox.Location = new System.Drawing.Point(239, 449);
            this.driverAddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.driverAddressTextBox.Mask = "";
            this.driverAddressTextBox.MaxLength = 32767;
            this.driverAddressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.driverAddressTextBox.Name = "driverAddressTextBox";
            this.driverAddressTextBox.PasswordChar = '\0';
            this.driverAddressTextBox.PrefixSuffixText = null;
            this.driverAddressTextBox.PromptChar = '_';
            this.driverAddressTextBox.ReadOnly = false;
            this.driverAddressTextBox.RejectInputOnFirstFailure = false;
            this.driverAddressTextBox.ResetOnPrompt = true;
            this.driverAddressTextBox.ResetOnSpace = true;
            this.driverAddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverAddressTextBox.SelectedText = "";
            this.driverAddressTextBox.SelectionLength = 0;
            this.driverAddressTextBox.SelectionStart = 0;
            this.driverAddressTextBox.ShortcutsEnabled = true;
            this.driverAddressTextBox.Size = new System.Drawing.Size(188, 48);
            this.driverAddressTextBox.SkipLiterals = true;
            this.driverAddressTextBox.TabIndex = 15;
            this.driverAddressTextBox.TabStop = false;
            this.driverAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.driverAddressTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.driverAddressTextBox.TrailingIcon = null;
            this.driverAddressTextBox.UseSystemPasswordChar = false;
            this.driverAddressTextBox.ValidatingType = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(155, 591);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.carAddFormCloseBtn);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(329, 591);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // carRankTextBox
            // 
            this.carRankTextBox.AllowPromptAsInput = true;
            this.carRankTextBox.AnimateReadOnly = false;
            this.carRankTextBox.AsciiOnly = false;
            this.carRankTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carRankTextBox.BeepOnError = false;
            this.carRankTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carRankTextBox.Depth = 0;
            this.carRankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.carRankTextBox.HidePromptOnLeave = false;
            this.carRankTextBox.HideSelection = true;
            this.carRankTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.carRankTextBox.LeadingIcon = null;
            this.carRankTextBox.Location = new System.Drawing.Point(239, 510);
            this.carRankTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.carRankTextBox.Mask = "";
            this.carRankTextBox.MaxLength = 32767;
            this.carRankTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.carRankTextBox.Name = "carRankTextBox";
            this.carRankTextBox.PasswordChar = '\0';
            this.carRankTextBox.PrefixSuffixText = null;
            this.carRankTextBox.PromptChar = '_';
            this.carRankTextBox.ReadOnly = false;
            this.carRankTextBox.RejectInputOnFirstFailure = false;
            this.carRankTextBox.ResetOnPrompt = true;
            this.carRankTextBox.ResetOnSpace = true;
            this.carRankTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carRankTextBox.SelectedText = "";
            this.carRankTextBox.SelectionLength = 0;
            this.carRankTextBox.SelectionStart = 0;
            this.carRankTextBox.ShortcutsEnabled = true;
            this.carRankTextBox.Size = new System.Drawing.Size(188, 48);
            this.carRankTextBox.SkipLiterals = true;
            this.carRankTextBox.TabIndex = 18;
            this.carRankTextBox.TabStop = false;
            this.carRankTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carRankTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carRankTextBox.TrailingIcon = null;
            this.carRankTextBox.UseSystemPasswordChar = false;
            this.carRankTextBox.ValidatingType = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 520);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rank";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 670);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.carRankTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.driverAddressTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.driverPhNoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.driverLicenseTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.driverNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfSeatsTextBox);
            this.Controls.Add(this.carBrandTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox categoryComboBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox carNumberTextBox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMaskedTextBox carBrandTextBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox noOfSeatsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialMaskedTextBox driverNameTextBox;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialMaskedTextBox driverLicenseTextBox;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialMaskedTextBox driverPhNoTextBox;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialMaskedTextBox driverAddressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialMaskedTextBox carRankTextBox;
        private System.Windows.Forms.Label label9;
    }
}