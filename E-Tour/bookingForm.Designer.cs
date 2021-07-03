
namespace E_Tour
{
    partial class bookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingForm));
            this.cbbDeparture = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbbDuration = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvAvailableTour = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTimeConsumed = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTourType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTourId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTourDetail = new Guna.UI.WinForms.GunaTextBox();
            this.cbbNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTour)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDeparture
            // 
            this.cbbDeparture.BackColor = System.Drawing.Color.Transparent;
            this.cbbDeparture.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeparture.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDeparture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDeparture.FocusedState.Parent = this.cbbDeparture;
            this.cbbDeparture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbDeparture.HoverState.Parent = this.cbbDeparture;
            this.cbbDeparture.ItemHeight = 30;
            this.cbbDeparture.ItemsAppearance.Parent = this.cbbDeparture;
            this.cbbDeparture.Location = new System.Drawing.Point(188, 119);
            this.cbbDeparture.Name = "cbbDeparture";
            this.cbbDeparture.ShadowDecoration.Parent = this.cbbDeparture;
            this.cbbDeparture.Size = new System.Drawing.Size(578, 36);
            this.cbbDeparture.TabIndex = 0;
            // 
            // cbbDestination
            // 
            this.cbbDestination.BackColor = System.Drawing.Color.Transparent;
            this.cbbDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDestination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDestination.FocusedState.Parent = this.cbbDestination;
            this.cbbDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbDestination.HoverState.Parent = this.cbbDestination;
            this.cbbDestination.ItemHeight = 30;
            this.cbbDestination.ItemsAppearance.Parent = this.cbbDestination;
            this.cbbDestination.Location = new System.Drawing.Point(188, 165);
            this.cbbDestination.Name = "cbbDestination";
            this.cbbDestination.ShadowDecoration.Parent = this.cbbDestination;
            this.cbbDestination.Size = new System.Drawing.Size(578, 36);
            this.cbbDestination.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dtpStartDate.BorderRadius = 1;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.CheckedState.Parent = this.dtpStartDate;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.HoverState.Parent = this.dtpStartDate;
            this.dtpStartDate.Location = new System.Drawing.Point(188, 210);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShadowDecoration.Parent = this.dtpStartDate;
            this.dtpStartDate.Size = new System.Drawing.Size(196, 36);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // cbbDuration
            // 
            this.cbbDuration.BackColor = System.Drawing.Color.Transparent;
            this.cbbDuration.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDuration.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbDuration.FocusedState.Parent = this.cbbDuration;
            this.cbbDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbDuration.HoverState.Parent = this.cbbDuration;
            this.cbbDuration.ItemHeight = 30;
            this.cbbDuration.Items.AddRange(new object[] {
            "1 day",
            "2 days +1 night",
            "3 days + 2 nights",
            "4 days + 3 nights",
            "5 days + 4 nights"});
            this.cbbDuration.ItemsAppearance.Parent = this.cbbDuration;
            this.cbbDuration.Location = new System.Drawing.Point(188, 256);
            this.cbbDuration.Name = "cbbDuration";
            this.cbbDuration.ShadowDecoration.Parent = this.cbbDuration;
            this.cbbDuration.Size = new System.Drawing.Size(196, 36);
            this.cbbDuration.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 21;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Location = new System.Drawing.Point(1071, 624);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(153, 45);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "Book & Pay";
            this.btnPay.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // btnBook
            // 
            this.btnBook.Animated = true;
            this.btnBook.AutoRoundedCorners = true;
            this.btnBook.BorderColor = System.Drawing.Color.Blue;
            this.btnBook.BorderRadius = 21;
            this.btnBook.BorderThickness = 1;
            this.btnBook.CheckedState.Parent = this.btnBook;
            this.btnBook.CustomImages.Parent = this.btnBook;
            this.btnBook.FillColor = System.Drawing.Color.White;
            this.btnBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBook.HoverState.Parent = this.btnBook;
            this.btnBook.Location = new System.Drawing.Point(846, 624);
            this.btnBook.Name = "btnBook";
            this.btnBook.ShadowDecoration.Parent = this.btnBook;
            this.btnBook.Size = new System.Drawing.Size(153, 45);
            this.btnBook.TabIndex = 21;
            this.btnBook.Text = "Book";
            this.btnBook.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(618, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(170, 45);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Booked Tickets";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dgvAvailableTour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAvailableTour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailableTour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableTour.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableTour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvailableTour.EnableHeadersVisualStyles = false;
            this.dgvAvailableTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableTour.Location = new System.Drawing.Point(46, 367);
            this.dgvAvailableTour.Name = "dgvAvailableTour";
            this.dgvAvailableTour.RowHeadersVisible = false;
            this.dgvAvailableTour.RowHeadersWidth = 51;
            this.dgvAvailableTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableTour.Size = new System.Drawing.Size(720, 276);
            this.dgvAvailableTour.TabIndex = 80;
            this.dgvAvailableTour.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAvailableTour.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableTour.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAvailableTour.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAvailableTour.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAvailableTour.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAvailableTour.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableTour.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAvailableTour.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAvailableTour.ThemeStyle.ReadOnly = false;
            this.dgvAvailableTour.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvailableTour.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailableTour.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAvailableTour.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAvailableTour.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAvailableTour.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableTour.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAvailableTour.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAvailableTour_CellMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(842, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 23);
            this.label13.TabIndex = 100;
            this.label13.Text = "Tour Detail ";
            // 
            // lblTimeConsumed
            // 
            this.lblTimeConsumed.AutoSize = true;
            this.lblTimeConsumed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeConsumed.Location = new System.Drawing.Point(1024, 275);
            this.lblTimeConsumed.Name = "lblTimeConsumed";
            this.lblTimeConsumed.Size = new System.Drawing.Size(73, 23);
            this.lblTimeConsumed.TabIndex = 99;
            this.lblTimeConsumed.Text = "Waiting";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(842, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 23);
            this.label14.TabIndex = 98;
            this.label14.Text = "Time Consumed :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(842, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 96;
            this.label6.Text = "Number :";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(986, 320);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(73, 23);
            this.lblStartDay.TabIndex = 95;
            this.lblStartDay.Text = "Waiting";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(842, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 94;
            this.label11.Text = "Start Day:";
            // 
            // lblTourType
            // 
            this.lblTourType.AutoSize = true;
            this.lblTourType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourType.Location = new System.Drawing.Point(986, 230);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(73, 23);
            this.lblTourType.TabIndex = 93;
            this.lblTourType.Text = "Waiting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(842, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 92;
            this.label9.Text = "Tour Type :";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(986, 185);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(73, 23);
            this.lblDestination.TabIndex = 91;
            this.lblDestination.Text = "Waiting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(842, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 90;
            this.label7.Text = "Destination :";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(986, 140);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(73, 23);
            this.lblDeparture.TabIndex = 89;
            this.lblDeparture.Text = "Waiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(842, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 88;
            this.label5.Text = "Departure :";
            // 
            // lblTourId
            // 
            this.lblTourId.AutoSize = true;
            this.lblTourId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourId.Location = new System.Drawing.Point(986, 95);
            this.lblTourId.Name = "lblTourId";
            this.lblTourId.Size = new System.Drawing.Size(73, 23);
            this.lblTourId.TabIndex = 87;
            this.lblTourId.Text = "Waiting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "Tour ID :";
            // 
            // txbTourDetail
            // 
            this.txbTourDetail.BaseColor = System.Drawing.Color.White;
            this.txbTourDetail.BorderColor = System.Drawing.Color.Silver;
            this.txbTourDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTourDetail.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTourDetail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTourDetail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTourDetail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTourDetail.Location = new System.Drawing.Point(990, 365);
            this.txbTourDetail.Name = "txbTourDetail";
            this.txbTourDetail.PasswordChar = '\0';
            this.txbTourDetail.ReadOnly = true;
            this.txbTourDetail.SelectedText = "";
            this.txbTourDetail.Size = new System.Drawing.Size(262, 84);
            this.txbTourDetail.TabIndex = 102;
            // 
            // cbbNumber
            // 
            this.cbbNumber.BackColor = System.Drawing.Color.Transparent;
            this.cbbNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNumber.DropDownHeight = 120;
            this.cbbNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNumber.FocusedState.Parent = this.cbbNumber;
            this.cbbNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNumber.HoverState.Parent = this.cbbNumber;
            this.cbbNumber.IntegralHeight = false;
            this.cbbNumber.ItemHeight = 30;
            this.cbbNumber.ItemsAppearance.Parent = this.cbbNumber;
            this.cbbNumber.Location = new System.Drawing.Point(990, 455);
            this.cbbNumber.Name = "cbbNumber";
            this.cbbNumber.ShadowDecoration.Parent = this.cbbNumber;
            this.cbbNumber.Size = new System.Drawing.Size(262, 36);
            this.cbbNumber.TabIndex = 103;
            this.cbbNumber.SelectedIndexChanged += new System.EventHandler(this.cbbNumber_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(986, 500);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 23);
            this.lblPrice.TabIndex = 107;
            this.lblPrice.Text = "Waiting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(842, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Price :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(986, 545);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 23);
            this.lblTotal.TabIndex = 105;
            this.lblTotal.Text = "Waiting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(842, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 104;
            this.label10.Text = "Total :";
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.AutoRoundedCorners = true;
            this.btnFind.BorderRadius = 21;
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(613, 256);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(153, 45);
            this.btnFind.TabIndex = 108;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderColor = System.Drawing.Color.Blue;
            this.btnReset.BorderRadius = 21;
            this.btnReset.BorderThickness = 1;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(439, 256);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(153, 45);
            this.btnReset.TabIndex = 109;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageRotate = 0F;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(1203, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogout.PressedState.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(49, 45);
            this.btnLogout.TabIndex = 110;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.Artboard_1_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbNumber);
            this.Controls.Add(this.txbTourDetail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTimeConsumed);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTourType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTourId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAvailableTour);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbDuration);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbbDestination);
            this.Controls.Add(this.cbbDeparture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbbDeparture;
        private Guna.UI2.WinForms.Guna2ComboBox cbbDestination;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbbDuration;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAvailableTour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTimeConsumed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTourType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTourId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNumber;
        private Guna.UI.WinForms.GunaTextBox txbTourDetail;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogout;
    }
}