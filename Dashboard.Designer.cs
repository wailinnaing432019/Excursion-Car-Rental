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
       /* private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.totalAvailableCarForDashboard = new MaterialSkin.Controls.MaterialLabel();
           // this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.totalCarForDashboard = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.currenOordersForDashboard = new MaterialSkin.Controls.MaterialLabel();
           // this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.revenueForDashboard = new MaterialSkin.Controls.MaterialLabel();
           // this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateInfoBtn = new Guna.UI.WinForms.GunaButton();
            this.txt_gate_description = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_gate_phone = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_gate_gmail = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_gate_location = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_gate_name = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.carBrandTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
           // this.label3 = new System.Windows.Forms.Label();
            this.carNumberTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
           // this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelForSearchTrip = new MaterialSkin.Controls.MaterialLabel();
            this.txt_search_trip = new MaterialSkin.Controls.MaterialTextBox2();
            this.tripGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.cancelTripUpdateBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_id_trip = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteTripBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.updateTripBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.labelForTripForm = new Guna.UI.WinForms.GunaLabel();
            this.createTripBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_description_trip = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.labelDescriptionForTrip = new Guna.UI.WinForms.GunaLabel();
            this.destinationError = new System.Windows.Forms.Label();
            this.txt_destination_trip = new MaterialSkin.Controls.MaterialTextBox();
            this.labelDestinationForTrip = new Guna.UI.WinForms.GunaLabel();
            this.txt_source_trip = new MaterialSkin.Controls.MaterialTextBox();
            this.labelSourceForTrip = new Guna.UI.WinForms.GunaLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView_CarList = new System.Windows.Forms.DataGridView();
            this.noColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
          //  this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripGridView)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1894, 733);
            this.materialTabControl1.TabIndex = 0;
          
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage5_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard5);
            this.tabPage1.Controls.Add(this.materialCard3);
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "icons8-home-26.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1886, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialCard6);
            this.materialCard5.Controls.Add(this.materialLabel16);
            this.materialCard5.Controls.Add(this.materialLabel17);
            this.materialCard5.Controls.Add(this.materialLabel18);
            this.materialCard5.Controls.Add(this.materialLabel19);
            this.materialCard5.Controls.Add(this.materialLabel20);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(936, 33);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(250, 131);
            this.materialCard5.TabIndex = 7;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel11);
            this.materialCard6.Controls.Add(this.materialLabel12);
            this.materialCard6.Controls.Add(this.materialLabel13);
            this.materialCard6.Controls.Add(this.materialLabel14);
            this.materialCard6.Controls.Add(this.materialLabel15);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(278, 8);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(250, 131);
            this.materialCard6.TabIndex = 6;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(36, 49);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(74, 19);
            this.materialLabel11.TabIndex = 5;
            this.materialLabel11.Text = "Total Cars";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(36, 98);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(102, 19);
            this.materialLabel12.TabIndex = 4;
            this.materialLabel12.Text = "Available Cars";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(162, 98);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(19, 19);
            this.materialLabel13.TabIndex = 3;
            this.materialLabel13.Text = "25";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(36, 14);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(33, 19);
            this.materialLabel14.TabIndex = 2;
            this.materialLabel14.Text = "Cars";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(162, 49);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(19, 19);
            this.materialLabel15.TabIndex = 1;
            this.materialLabel15.Text = "25";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(36, 49);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(74, 19);
            this.materialLabel16.TabIndex = 5;
            this.materialLabel16.Text = "Total Cars";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(36, 98);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(102, 19);
            this.materialLabel17.TabIndex = 4;
            this.materialLabel17.Text = "Available Cars";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(162, 98);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(19, 19);
            this.materialLabel18.TabIndex = 3;
            this.materialLabel18.Text = "25";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.Location = new System.Drawing.Point(36, 14);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(77, 19);
            this.materialLabel19.TabIndex = 2;
            this.materialLabel19.Text = "Customers";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.Location = new System.Drawing.Point(162, 49);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(19, 19);
            this.materialLabel20.TabIndex = 1;
            this.materialLabel20.Text = "25";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialCard4);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Controls.Add(this.materialLabel4);
            this.materialCard3.Controls.Add(this.totalAvailableCarForDashboard);
            this.materialCard3.Controls.Add(this.label3);
            this.materialCard3.Controls.Add(this.totalCarForDashboard);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(619, 33);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(250, 131);
            this.materialCard3.TabIndex = 3;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel5);
            this.materialCard4.Controls.Add(this.materialLabel6);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.materialLabel9);
            this.materialCard4.Controls.Add(this.materialLabel10);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(278, 8);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(250, 131);
            this.materialCard4.TabIndex = 6;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(36, 49);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Total Cars";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(36, 98);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(102, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Available Cars";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(162, 98);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(19, 19);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "25";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(36, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(33, 19);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = "Cars";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(162, 49);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(19, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "25";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(36, 49);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(74, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Total Cars";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(36, 98);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Available Cars";
            // 
            // totalAvailableCarForDashboard
            // 
            this.totalAvailableCarForDashboard.AutoSize = true;
            this.totalAvailableCarForDashboard.Depth = 0;
            this.totalAvailableCarForDashboard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalAvailableCarForDashboard.Location = new System.Drawing.Point(162, 98);
            this.totalAvailableCarForDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalAvailableCarForDashboard.Name = "totalAvailableCarForDashboard";
            this.totalAvailableCarForDashboard.Size = new System.Drawing.Size(19, 19);
            this.totalAvailableCarForDashboard.TabIndex = 3;
            this.totalAvailableCarForDashboard.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cars";
            // 
            // totalCarForDashboard
            // 
            this.totalCarForDashboard.AutoSize = true;
            this.totalCarForDashboard.Depth = 0;
            this.totalCarForDashboard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.totalCarForDashboard.Location = new System.Drawing.Point(162, 49);
            this.totalCarForDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalCarForDashboard.Name = "totalCarForDashboard";
            this.totalCarForDashboard.Size = new System.Drawing.Size(19, 19);
            this.totalCarForDashboard.TabIndex = 1;
            this.totalCarForDashboard.Text = "25";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.currenOordersForDashboard);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(325, 33);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(250, 131);
            this.materialCard2.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(29, 98);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(102, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Current Orders";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(155, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(19, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "10";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 49);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Current Orders";
            // 
            // currenOordersForDashboard
            // 
            this.currenOordersForDashboard.AutoSize = true;
            this.currenOordersForDashboard.Depth = 0;
            this.currenOordersForDashboard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.currenOordersForDashboard.Location = new System.Drawing.Point(155, 49);
            this.currenOordersForDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.currenOordersForDashboard.Name = "currenOordersForDashboard";
            this.currenOordersForDashboard.Size = new System.Drawing.Size(19, 19);
            this.currenOordersForDashboard.TabIndex = 1;
            this.currenOordersForDashboard.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(58, 14);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.revenueForDashboard);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(47, 33);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(250, 131);
            this.materialCard1.TabIndex = 0;
            // 
            // revenueForDashboard
            // 
            this.revenueForDashboard.AutoSize = true;
            this.revenueForDashboard.Depth = 0;
            this.revenueForDashboard.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.revenueForDashboard.Location = new System.Drawing.Point(72, 49);
            this.revenueForDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.revenueForDashboard.Name = "revenueForDashboard";
            this.revenueForDashboard.Size = new System.Drawing.Size(112, 19);
            this.revenueForDashboard.TabIndex = 1;
            this.revenueForDashboard.Text = "MMK 1,000,000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenues";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ImageKey = "icons8-trip-26.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1886, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Gate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateInfoBtn);
            this.panel1.Controls.Add(this.txt_gate_description);
            this.panel1.Controls.Add(this.materialLabel28);
            this.panel1.Controls.Add(this.materialLabel26);
            this.panel1.Controls.Add(this.materialLabel25);
            this.panel1.Controls.Add(this.txt_gate_phone);
            this.panel1.Controls.Add(this.materialLabel23);
            this.panel1.Controls.Add(this.txt_gate_gmail);
            this.panel1.Controls.Add(this.materialLabel22);
            this.panel1.Controls.Add(this.txt_gate_location);
            this.panel1.Controls.Add(this.materialLabel21);
            this.panel1.Controls.Add(this.txt_gate_name);
            this.panel1.Location = new System.Drawing.Point(43, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 673);
            this.panel1.TabIndex = 0;
            // 
            // updateInfoBtn
            // 
            this.updateInfoBtn.AnimationHoverSpeed = 0.07F;
            this.updateInfoBtn.AnimationSpeed = 0.03F;
            this.updateInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateInfoBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updateInfoBtn.BorderColor = System.Drawing.Color.Black;
            this.updateInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateInfoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateInfoBtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateInfoBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfoBtn.ForeColor = System.Drawing.Color.White;
            this.updateInfoBtn.Image = null;
            this.updateInfoBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updateInfoBtn.Location = new System.Drawing.Point(601, 595);
            this.updateInfoBtn.Name = "updateInfoBtn";
            this.updateInfoBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateInfoBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateInfoBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateInfoBtn.OnHoverImage = null;
            this.updateInfoBtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateInfoBtn.Radius = 10;
            this.updateInfoBtn.Size = new System.Drawing.Size(187, 50);
            this.updateInfoBtn.TabIndex = 17;
            this.updateInfoBtn.Text = "Update Info";
            this.updateInfoBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateInfoBtn.Click += new System.EventHandler(this.updateInfoBtn_Click);
            // 
            // txt_gate_description
            // 
            this.txt_gate_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_gate_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gate_description.Depth = 0;
            this.txt_gate_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_gate_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_gate_description.Location = new System.Drawing.Point(324, 443);
            this.txt_gate_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_gate_description.Name = "txt_gate_description";
            this.txt_gate_description.Size = new System.Drawing.Size(467, 96);
            this.txt_gate_description.TabIndex = 16;
            this.txt_gate_description.Text = "";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.Location = new System.Drawing.Point(111, 460);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(81, 19);
            this.materialLabel28.TabIndex = 14;
            this.materialLabel28.Text = "Description";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.BackColor = System.Drawing.Color.DimGray;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(226, 28);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(230, 19);
            this.materialLabel26.TabIndex = 10;
            this.materialLabel26.Text = "Details of Your Gate Information";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(113, 299);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(46, 19);
            this.materialLabel25.TabIndex = 9;
            this.materialLabel25.Text = "Phone";
            // 
            // txt_gate_phone
            // 
            this.txt_gate_phone.AnimateReadOnly = false;
            this.txt_gate_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gate_phone.Depth = 0;
            this.txt_gate_phone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_gate_phone.LeadingIcon = null;
            this.txt_gate_phone.Location = new System.Drawing.Point(324, 268);
            this.txt_gate_phone.MaxLength = 50;
            this.txt_gate_phone.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_gate_phone.Multiline = false;
            this.txt_gate_phone.Name = "txt_gate_phone";
            this.txt_gate_phone.Size = new System.Drawing.Size(467, 50);
            this.txt_gate_phone.TabIndex = 8;
            this.txt_gate_phone.Text = "";
            this.txt_gate_phone.TrailingIcon = null;
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.Location = new System.Drawing.Point(113, 373);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(43, 19);
            this.materialLabel23.TabIndex = 5;
            this.materialLabel23.Text = "Gmail";
            // 
            // txt_gate_gmail
            // 
            this.txt_gate_gmail.AnimateReadOnly = false;
            this.txt_gate_gmail.BackColor = System.Drawing.SystemColors.Window;
            this.txt_gate_gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gate_gmail.Depth = 0;
            this.txt_gate_gmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_gate_gmail.LeadingIcon = null;
            this.txt_gate_gmail.Location = new System.Drawing.Point(324, 342);
            this.txt_gate_gmail.MaxLength = 50;
            this.txt_gate_gmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_gate_gmail.Multiline = false;
            this.txt_gate_gmail.Name = "txt_gate_gmail";
            this.txt_gate_gmail.Size = new System.Drawing.Size(467, 50);
            this.txt_gate_gmail.TabIndex = 4;
            this.txt_gate_gmail.Text = "";
            this.txt_gate_gmail.TrailingIcon = null;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.Location = new System.Drawing.Point(113, 200);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(63, 19);
            this.materialLabel22.TabIndex = 3;
            this.materialLabel22.Text = "Location";
            // 
            // txt_gate_location
            // 
            this.txt_gate_location.AnimateReadOnly = false;
            this.txt_gate_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gate_location.Depth = 0;
            this.txt_gate_location.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_gate_location.LeadingIcon = null;
            this.txt_gate_location.Location = new System.Drawing.Point(324, 169);
            this.txt_gate_location.MaxLength = 50;
            this.txt_gate_location.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_gate_location.Multiline = false;
            this.txt_gate_location.Name = "txt_gate_location";
            this.txt_gate_location.Size = new System.Drawing.Size(467, 50);
            this.txt_gate_location.TabIndex = 2;
            this.txt_gate_location.Text = "";
            this.txt_gate_location.TrailingIcon = null;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.Location = new System.Drawing.Point(113, 99);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(34, 19);
            this.materialLabel21.TabIndex = 1;
            this.materialLabel21.Text = "Gate";
            // 
            // txt_gate_name
            // 
            this.txt_gate_name.AnimateReadOnly = false;
            this.txt_gate_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gate_name.Depth = 0;
            this.txt_gate_name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_gate_name.LeadingIcon = null;
            this.txt_gate_name.Location = new System.Drawing.Point(324, 68);
            this.txt_gate_name.MaxLength = 50;
            this.txt_gate_name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_gate_name.Multiline = false;
            this.txt_gate_name.Name = "txt_gate_name";
            this.txt_gate_name.Size = new System.Drawing.Size(467, 50);
            this.txt_gate_name.TabIndex = 0;
            this.txt_gate_name.Text = "";
            this.txt_gate_name.TrailingIcon = null;
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
            this.tabPage3.Size = new System.Drawing.Size(1886, 698);
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
            this.tabPage4.Controls.Add(this.labelForSearchTrip);
            this.tabPage4.Controls.Add(this.txt_search_trip);
            this.tabPage4.Controls.Add(this.tripGridView);
            this.tabPage4.Controls.Add(this.gunaShadowPanel1);
            this.tabPage4.ImageKey = "icons8-report-26.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1886, 698);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Trip";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelForSearchTrip
            // 
            this.labelForSearchTrip.AutoSize = true;
            this.labelForSearchTrip.Depth = 0;
            this.labelForSearchTrip.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelForSearchTrip.Location = new System.Drawing.Point(623, 69);
            this.labelForSearchTrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelForSearchTrip.Name = "labelForSearchTrip";
            this.labelForSearchTrip.Size = new System.Drawing.Size(58, 19);
            this.labelForSearchTrip.TabIndex = 3;
            this.labelForSearchTrip.Text = "Search :";
            // 
            // txt_search_trip
            // 
            this.txt_search_trip.AnimateReadOnly = false;
            this.txt_search_trip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_search_trip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search_trip.Depth = 0;
            this.txt_search_trip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search_trip.HideSelection = true;
            this.txt_search_trip.LeadingIcon = null;
            this.txt_search_trip.Location = new System.Drawing.Point(760, 38);
            this.txt_search_trip.MaxLength = 32767;
            this.txt_search_trip.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_search_trip.Name = "txt_search_trip";
            this.txt_search_trip.PasswordChar = '\0';
            this.txt_search_trip.PrefixSuffixText = null;
            this.txt_search_trip.ReadOnly = false;
            this.txt_search_trip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_search_trip.SelectedText = "";
            this.txt_search_trip.SelectionLength = 0;
            this.txt_search_trip.SelectionStart = 0;
            this.txt_search_trip.ShortcutsEnabled = true;
            this.txt_search_trip.Size = new System.Drawing.Size(323, 48);
            this.txt_search_trip.TabIndex = 2;
            this.txt_search_trip.TabStop = false;
            this.txt_search_trip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search_trip.TrailingIcon = null;
            this.txt_search_trip.UseSystemPasswordChar = false;
            this.txt_search_trip.TextChanged += new System.EventHandler(this.txt_search_trip_TextChanged);
            // 
            // tripGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.tripGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tripGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tripGridView.BackgroundColor = System.Drawing.Color.White;
            this.tripGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tripGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tripGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tripGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tripGridView.ColumnHeadersHeight = 27;
            this.tripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tripGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.tripGridView.EnableHeadersVisualStyles = false;
            this.tripGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tripGridView.Location = new System.Drawing.Point(597, 105);
            this.tripGridView.Name = "tripGridView";
            this.tripGridView.RowHeadersVisible = false;
            this.tripGridView.RowHeadersWidth = 51;
            this.tripGridView.RowTemplate.Height = 24;
            this.tripGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tripGridView.Size = new System.Drawing.Size(965, 354);
            this.tripGridView.TabIndex = 1;
            this.tripGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tripGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tripGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tripGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tripGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tripGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tripGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tripGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tripGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tripGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tripGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tripGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tripGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tripGridView.ThemeStyle.HeaderStyle.Height = 27;
            this.tripGridView.ThemeStyle.ReadOnly = false;
            this.tripGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tripGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tripGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tripGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tripGridView.ThemeStyle.RowsStyle.Height = 24;
            this.tripGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tripGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tripGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Source";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            dataGridViewCellStyle15.Format = "D";
            dataGridViewCellStyle15.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column6.HeaderText = "Created_at";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.cancelTripUpdateBtn);
            this.gunaShadowPanel1.Controls.Add(this.txt_id_trip);
            this.gunaShadowPanel1.Controls.Add(this.deleteTripBtn);
            this.gunaShadowPanel1.Controls.Add(this.updateTripBtn);
            this.gunaShadowPanel1.Controls.Add(this.labelForTripForm);
            this.gunaShadowPanel1.Controls.Add(this.createTripBtn);
            this.gunaShadowPanel1.Controls.Add(this.txt_description_trip);
            this.gunaShadowPanel1.Controls.Add(this.labelDescriptionForTrip);
            this.gunaShadowPanel1.Controls.Add(this.destinationError);
            this.gunaShadowPanel1.Controls.Add(this.txt_destination_trip);
            this.gunaShadowPanel1.Controls.Add(this.labelDestinationForTrip);
            this.gunaShadowPanel1.Controls.Add(this.txt_source_trip);
            this.gunaShadowPanel1.Controls.Add(this.labelSourceForTrip);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(14, 22);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(556, 531);
            this.gunaShadowPanel1.TabIndex = 0;
            // 
            // cancelTripUpdateBtn
            // 
            this.cancelTripUpdateBtn.AnimationHoverSpeed = 0.07F;
            this.cancelTripUpdateBtn.AnimationSpeed = 0.03F;
            this.cancelTripUpdateBtn.BaseColor = System.Drawing.Color.Yellow;
            this.cancelTripUpdateBtn.BorderColor = System.Drawing.Color.Black;
            this.cancelTripUpdateBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.cancelTripUpdateBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.cancelTripUpdateBtn.CheckedForeColor = System.Drawing.Color.White;
            this.cancelTripUpdateBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("cancelTripUpdateBtn.CheckedImage")));
            this.cancelTripUpdateBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.cancelTripUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelTripUpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelTripUpdateBtn.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.cancelTripUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelTripUpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelTripUpdateBtn.Image = null;
            this.cancelTripUpdateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelTripUpdateBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cancelTripUpdateBtn.Location = new System.Drawing.Point(13, 395);
            this.cancelTripUpdateBtn.Name = "cancelTripUpdateBtn";
            this.cancelTripUpdateBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cancelTripUpdateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelTripUpdateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelTripUpdateBtn.OnHoverImage = null;
            this.cancelTripUpdateBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.cancelTripUpdateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelTripUpdateBtn.Size = new System.Drawing.Size(113, 42);
            this.cancelTripUpdateBtn.TabIndex = 12;
            this.cancelTripUpdateBtn.Text = "Cancel";
            this.cancelTripUpdateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelTripUpdateBtn.UseTransfarantBackground = true;
            this.cancelTripUpdateBtn.Click += new System.EventHandler(this.cancelTripUpdateBtn_Click);
            // 
            // txt_id_trip
            // 
            this.txt_id_trip.AnimateReadOnly = false;
            this.txt_id_trip.BackColor = System.Drawing.Color.White;
            this.txt_id_trip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_trip.Depth = 0;
            this.txt_id_trip.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id_trip.LeadingIcon = null;
            this.txt_id_trip.Location = new System.Drawing.Point(164, 129);
            this.txt_id_trip.MaxLength = 50;
            this.txt_id_trip.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id_trip.Multiline = false;
            this.txt_id_trip.Name = "txt_id_trip";
            this.txt_id_trip.ReadOnly = true;
            this.txt_id_trip.Size = new System.Drawing.Size(340, 50);
            this.txt_id_trip.TabIndex = 11;
            this.txt_id_trip.Text = "";
            this.txt_id_trip.TrailingIcon = null;
            this.txt_id_trip.Visible = false;
            // 
            // deleteTripBtn
            // 
            this.deleteTripBtn.AnimationHoverSpeed = 0.07F;
            this.deleteTripBtn.AnimationSpeed = 0.03F;
            this.deleteTripBtn.BaseColor = System.Drawing.Color.Red;
            this.deleteTripBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteTripBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteTripBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteTripBtn.CheckedForeColor = System.Drawing.Color.White;
            this.deleteTripBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteTripBtn.CheckedImage")));
            this.deleteTripBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteTripBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTripBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteTripBtn.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.deleteTripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTripBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteTripBtn.Image = null;
            this.deleteTripBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteTripBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteTripBtn.Location = new System.Drawing.Point(141, 395);
            this.deleteTripBtn.Name = "deleteTripBtn";
            this.deleteTripBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deleteTripBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteTripBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteTripBtn.OnHoverImage = null;
            this.deleteTripBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteTripBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteTripBtn.Size = new System.Drawing.Size(180, 42);
            this.deleteTripBtn.TabIndex = 10;
            this.deleteTripBtn.Text = "Delete";
            this.deleteTripBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteTripBtn.UseTransfarantBackground = true;
            this.deleteTripBtn.Click += new System.EventHandler(this.deleteTripBtn_Click);
            // 
            // updateTripBtn
            // 
            this.updateTripBtn.AnimationHoverSpeed = 0.07F;
            this.updateTripBtn.AnimationSpeed = 0.03F;
            this.updateTripBtn.BaseColor = System.Drawing.Color.Aqua;
            this.updateTripBtn.BorderColor = System.Drawing.Color.Black;
            this.updateTripBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.updateTripBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.updateTripBtn.CheckedForeColor = System.Drawing.Color.White;
            this.updateTripBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("updateTripBtn.CheckedImage")));
            this.updateTripBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.updateTripBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTripBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateTripBtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateTripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTripBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.updateTripBtn.Image = null;
            this.updateTripBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updateTripBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateTripBtn.Location = new System.Drawing.Point(337, 396);
            this.updateTripBtn.Name = "updateTripBtn";
            this.updateTripBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateTripBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateTripBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateTripBtn.OnHoverImage = null;
            this.updateTripBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.updateTripBtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateTripBtn.Size = new System.Drawing.Size(180, 42);
            this.updateTripBtn.TabIndex = 9;
            this.updateTripBtn.Text = "Update";
            this.updateTripBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateTripBtn.UseTransfarantBackground = true;
            this.updateTripBtn.Click += new System.EventHandler(this.updateTripBtn_Click);
            // 
            // labelForTripForm
            // 
            this.labelForTripForm.AutoSize = true;
            this.labelForTripForm.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForTripForm.Location = new System.Drawing.Point(136, 16);
            this.labelForTripForm.Name = "labelForTripForm";
            this.labelForTripForm.Size = new System.Drawing.Size(228, 46);
            this.labelForTripForm.TabIndex = 1;
            this.labelForTripForm.Text = "Create Trip";
            // 
            // createTripBtn
            // 
            this.createTripBtn.AnimationHoverSpeed = 0.07F;
            this.createTripBtn.AnimationSpeed = 0.03F;
            this.createTripBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.createTripBtn.BorderColor = System.Drawing.Color.Black;
            this.createTripBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.createTripBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.createTripBtn.CheckedForeColor = System.Drawing.Color.White;
            this.createTripBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("createTripBtn.CheckedImage")));
            this.createTripBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.createTripBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTripBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createTripBtn.FocusedColor = System.Drawing.Color.Empty;
            this.createTripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTripBtn.ForeColor = System.Drawing.Color.White;
            this.createTripBtn.Image = null;
            this.createTripBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.createTripBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createTripBtn.Location = new System.Drawing.Point(337, 395);
            this.createTripBtn.Name = "createTripBtn";
            this.createTripBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.createTripBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.createTripBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.createTripBtn.OnHoverImage = null;
            this.createTripBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.createTripBtn.OnPressedColor = System.Drawing.Color.Black;
            this.createTripBtn.Size = new System.Drawing.Size(180, 42);
            this.createTripBtn.TabIndex = 1;
            this.createTripBtn.Text = "Create";
            this.createTripBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.createTripBtn.UseTransfarantBackground = true;
            this.createTripBtn.Click += new System.EventHandler(this.createTripBtn_Click);
            // 
            // txt_description_trip
            // 
            this.txt_description_trip.AnimateReadOnly = false;
            this.txt_description_trip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_description_trip.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_description_trip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description_trip.Depth = 0;
            this.txt_description_trip.HideSelection = true;
            this.txt_description_trip.Location = new System.Drawing.Point(166, 250);
            this.txt_description_trip.MaxLength = 32767;
            this.txt_description_trip.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_description_trip.Name = "txt_description_trip";
            this.txt_description_trip.PasswordChar = '\0';
            this.txt_description_trip.ReadOnly = false;
            this.txt_description_trip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description_trip.SelectedText = "";
            this.txt_description_trip.SelectionLength = 0;
            this.txt_description_trip.SelectionStart = 0;
            this.txt_description_trip.ShortcutsEnabled = true;
            this.txt_description_trip.Size = new System.Drawing.Size(338, 100);
            this.txt_description_trip.TabIndex = 8;
            this.txt_description_trip.TabStop = false;
            this.txt_description_trip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_description_trip.UseSystemPasswordChar = false;
            // 
            // labelDescriptionForTrip
            // 
            this.labelDescriptionForTrip.AutoSize = true;
            this.labelDescriptionForTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDescriptionForTrip.Location = new System.Drawing.Point(41, 283);
            this.labelDescriptionForTrip.Name = "labelDescriptionForTrip";
            this.labelDescriptionForTrip.Size = new System.Drawing.Size(85, 20);
            this.labelDescriptionForTrip.TabIndex = 7;
            this.labelDescriptionForTrip.Text = "Description";
            // 
            // destinationError
            // 
            this.destinationError.AutoSize = true;
            this.destinationError.BackColor = System.Drawing.Color.IndianRed;
            this.destinationError.Enabled = false;
            this.destinationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationError.ForeColor = System.Drawing.Color.Red;
            this.destinationError.Location = new System.Drawing.Point(185, 218);
            this.destinationError.Name = "destinationError";
            this.destinationError.Size = new System.Drawing.Size(0, 16);
            this.destinationError.TabIndex = 6;
            // 
            // txt_destination_trip
            // 
            this.txt_destination_trip.AnimateReadOnly = false;
            this.txt_destination_trip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_destination_trip.Depth = 0;
            this.txt_destination_trip.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_destination_trip.LeadingIcon = null;
            this.txt_destination_trip.Location = new System.Drawing.Point(166, 161);
            this.txt_destination_trip.MaxLength = 50;
            this.txt_destination_trip.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_destination_trip.Multiline = false;
            this.txt_destination_trip.Name = "txt_destination_trip";
            this.txt_destination_trip.Size = new System.Drawing.Size(338, 50);
            this.txt_destination_trip.TabIndex = 5;
            this.txt_destination_trip.Text = "";
            this.txt_destination_trip.TrailingIcon = null;
            // 
            // labelDestinationForTrip
            // 
            this.labelDestinationForTrip.AutoSize = true;
            this.labelDestinationForTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDestinationForTrip.Location = new System.Drawing.Point(41, 191);
            this.labelDestinationForTrip.Name = "labelDestinationForTrip";
            this.labelDestinationForTrip.Size = new System.Drawing.Size(85, 20);
            this.labelDestinationForTrip.TabIndex = 4;
            this.labelDestinationForTrip.Text = "Destination";
            // 
            // txt_source_trip
            // 
            this.txt_source_trip.AnimateReadOnly = false;
            this.txt_source_trip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_source_trip.Depth = 0;
            this.txt_source_trip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txt_source_trip.LeadingIcon = null;
            this.txt_source_trip.Location = new System.Drawing.Point(164, 73);
            this.txt_source_trip.MaxLength = 50;
            this.txt_source_trip.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_source_trip.Multiline = false;
            this.txt_source_trip.Name = "txt_source_trip";
            this.txt_source_trip.ReadOnly = true;
            this.txt_source_trip.Size = new System.Drawing.Size(340, 50);
            this.txt_source_trip.TabIndex = 2;
            this.txt_source_trip.Text = "Meikhtila";
            this.txt_source_trip.TrailingIcon = null;
            // 
            // labelSourceForTrip
            // 
            this.labelSourceForTrip.AutoSize = true;
            this.labelSourceForTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSourceForTrip.Location = new System.Drawing.Point(39, 103);
            this.labelSourceForTrip.Name = "labelSourceForTrip";
            this.labelSourceForTrip.Size = new System.Drawing.Size(54, 20);
            this.labelSourceForTrip.TabIndex = 1;
            this.labelSourceForTrip.Text = "Source";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView_CarList);
            this.tabPage5.Controls.Add(this.materialButton1);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.ImageKey = "icons8-car-26.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1886, 698);
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
            this.tabPage6.Size = new System.Drawing.Size(1886, 698);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Manage Order";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.ImageKey = "icons8-users-26.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1886, 698);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "View Customers";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.ImageKey = "icons8-category-26.png";
            this.tabPage8.Location = new System.Drawing.Point(4, 31);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1886, 698);
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
            this.ClientSize = new System.Drawing.Size(1900, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoHide = false;
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excursion Car Rental Service";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tripGridView)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CarList)).EndInit();
            this.ResumeLayout(false);

        }
*/
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel revenueForDashboard;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel totalCarForDashboard;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel currenOordersForDashboard;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel totalAvailableCarForDashboard;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialTextBox txt_gate_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialTextBox txt_gate_phone;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialTextBox txt_gate_gmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialTextBox txt_gate_location;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_gate_description;
        private Guna.UI.WinForms.GunaButton updateInfoBtn;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaLabel labelSourceForTrip;
        private System.Windows.Forms.Label destinationError;
        private MaterialSkin.Controls.MaterialTextBox txt_destination_trip;
        private Guna.UI.WinForms.GunaLabel labelDestinationForTrip;
        private MaterialSkin.Controls.MaterialTextBox txt_source_trip;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_description_trip;
        private Guna.UI.WinForms.GunaLabel labelDescriptionForTrip;
        private Guna.UI.WinForms.GunaAdvenceButton createTripBtn;
        private Guna.UI.WinForms.GunaLabel labelForTripForm;
        private MaterialSkin.Controls.MaterialLabel labelForSearchTrip;
        private MaterialSkin.Controls.MaterialTextBox2 txt_search_trip;
        private Guna.UI.WinForms.GunaDataGridView tripGridView;
        private Guna.UI.WinForms.GunaAdvenceButton updateTripBtn;
        private Guna.UI.WinForms.GunaAdvenceButton deleteTripBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MaterialSkin.Controls.MaterialTextBox txt_id_trip;
        private Guna.UI.WinForms.GunaAdvenceButton cancelTripUpdateBtn;
       // private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView_CarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn noColumn;
        private System.Windows.Forms.DataGridView categoryDataGridView;
       // private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialMaskedTextBox carBrandTextBox;
      //  private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialMaskedTextBox carNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

