namespace Excursion_Car_Rental
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.carBrandTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carNumberTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView_CarList = new System.Windows.Forms.DataGridView();
            this.noColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarList)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Controls.Add(this.tabPage8);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1394, 733);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "icons8-home-26.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1386, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "icons8-trip-26.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1386, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Gate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.carBrandTextBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.carNumberTextBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.categoryDataGridView);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.ImageKey = "icons8-list-26.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1386, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Category";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(459, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(308, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.categoryAddBtn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(612, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
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
            this.carBrandTextBox.Location = new System.Drawing.Point(408, 209);
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
            this.carBrandTextBox.Size = new System.Drawing.Size(250, 48);
            this.carBrandTextBox.SkipLiterals = true;
            this.carBrandTextBox.TabIndex = 13;
            this.carBrandTextBox.TabStop = false;
            this.carBrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carBrandTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carBrandTextBox.TrailingIcon = null;
            this.carBrandTextBox.UseSystemPasswordChar = false;
            this.carBrandTextBox.ValidatingType = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
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
            this.carNumberTextBox.Location = new System.Drawing.Point(408, 137);
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
            this.carNumberTextBox.Size = new System.Drawing.Size(250, 48);
            this.carNumberTextBox.SkipLiterals = true;
            this.carNumberTextBox.TabIndex = 11;
            this.carNumberTextBox.TabStop = false;
            this.carNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.carNumberTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.carNumberTextBox.TrailingIcon = null;
            this.carNumberTextBox.UseSystemPasswordChar = false;
            this.carNumberTextBox.ValidatingType = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type of car";
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Location = new System.Drawing.Point(835, 137);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersWidth = 51;
            this.categoryDataGridView.RowTemplate.Height = 24;
            this.categoryDataGridView.Size = new System.Drawing.Size(353, 159);
            this.categoryDataGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category list";
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-report-26.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1386, 698);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Trip";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView_CarList);
            this.tabPage5.Controls.Add(this.materialButton1);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.ImageKey = "icons8-car-26.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1386, 698);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Manage Car";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // dataGridView_CarList
            // 
            this.dataGridView_CarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noColumn});
            this.dataGridView_CarList.Location = new System.Drawing.Point(111, 97);
            this.dataGridView_CarList.Name = "dataGridView_CarList";
            this.dataGridView_CarList.RowHeadersWidth = 51;
            this.dataGridView_CarList.RowTemplate.Height = 24;
            this.dataGridView_CarList.Size = new System.Drawing.Size(1129, 348);
            this.dataGridView_CarList.TabIndex = 2;
            this.dataGridView_CarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CarList_CellContentClick);
            this.dataGridView_CarList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_CarList_RowPostPaint);
            // 
            // noColumn
            // 
            this.noColumn.HeaderText = "No.";
            this.noColumn.MinimumWidth = 6;
            this.noColumn.Name = "noColumn";
            this.noColumn.Width = 50;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton1.Location = new System.Drawing.Point(1108, 24);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(78, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Add";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.carAddBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Availabe Car List";
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "icons8-order-26.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1386, 698);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Manage Order";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.ImageKey = "icons8-users-26.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1386, 698);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "View Customers";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.ImageKey = "icons8-category-26.png";
            this.tabPage8.Location = new System.Drawing.Point(4, 31);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1386, 698);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "View Report";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-purchase-order-26.png");
            this.imageList1.Images.SetKeyName(1, "icons8-report-26.png");
            this.imageList1.Images.SetKeyName(2, "icons8-users-26.png");
            this.imageList1.Images.SetKeyName(3, "icons8-list-26.png");
            this.imageList1.Images.SetKeyName(4, "icons8-order-26.png");
            this.imageList1.Images.SetKeyName(5, "icons8-trip-26.png");
            this.imageList1.Images.SetKeyName(6, "icons8-category-26.png");
            this.imageList1.Images.SetKeyName(7, "icons8-car-rental-26.png");
            this.imageList1.Images.SetKeyName(8, "icons8-home-26.png");
            this.imageList1.Images.SetKeyName(9, "icons8-car-26.png");
            this.imageList1.Images.SetKeyName(10, "icons8-menu-26.png");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excursion Car Rental Service";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView_CarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn noColumn;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialMaskedTextBox carBrandTextBox;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMaskedTextBox carNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

