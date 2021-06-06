
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.departureCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.destinationCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.startDtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.durationCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.aboardCb = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.passportTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.visaDtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.payBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bookBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.aboardcheck = new System.Windows.Forms.Label();
            this.numberticket = new System.Windows.Forms.Label();
            this.ticketTb = new System.Windows.Forms.TextBox();
            this.IDLb = new System.Windows.Forms.Label();
            this.departureLb = new System.Windows.Forms.Label();
            this.destinationLb = new System.Windows.Forms.Label();
            this.startdateLb = new System.Windows.Forms.Label();
            this.durationLb = new System.Windows.Forms.Label();
            this.priceTb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PassportExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departureCb
            // 
            this.departureCb.BackColor = System.Drawing.Color.Transparent;
            this.departureCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departureCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departureCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departureCb.FocusedState.Parent = this.departureCb;
            this.departureCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departureCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.departureCb.HoverState.Parent = this.departureCb;
            this.departureCb.ItemHeight = 30;
            this.departureCb.ItemsAppearance.Parent = this.departureCb;
            this.departureCb.Location = new System.Drawing.Point(188, 119);
            this.departureCb.Name = "departureCb";
            this.departureCb.ShadowDecoration.Parent = this.departureCb;
            this.departureCb.Size = new System.Drawing.Size(196, 36);
            this.departureCb.TabIndex = 0;
            this.departureCb.SelectedIndexChanged += new System.EventHandler(this.departureCb_SelectedIndexChanged);
            // 
            // destinationCb
            // 
            this.destinationCb.BackColor = System.Drawing.Color.Transparent;
            this.destinationCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destinationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationCb.FocusedState.Parent = this.destinationCb;
            this.destinationCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.destinationCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.destinationCb.HoverState.Parent = this.destinationCb;
            this.destinationCb.ItemHeight = 30;
            this.destinationCb.ItemsAppearance.Parent = this.destinationCb;
            this.destinationCb.Location = new System.Drawing.Point(188, 165);
            this.destinationCb.Name = "destinationCb";
            this.destinationCb.ShadowDecoration.Parent = this.destinationCb;
            this.destinationCb.Size = new System.Drawing.Size(196, 36);
            this.destinationCb.TabIndex = 1;
            this.destinationCb.SelectedIndexChanged += new System.EventHandler(this.destinationCb_SelectedIndexChanged);
            // 
            // startDtp
            // 
            this.startDtp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.startDtp.BorderRadius = 1;
            this.startDtp.BorderThickness = 1;
            this.startDtp.CheckedState.Parent = this.startDtp;
            this.startDtp.FillColor = System.Drawing.Color.White;
            this.startDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDtp.HoverState.Parent = this.startDtp;
            this.startDtp.Location = new System.Drawing.Point(188, 210);
            this.startDtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDtp.Name = "startDtp";
            this.startDtp.ShadowDecoration.Parent = this.startDtp;
            this.startDtp.Size = new System.Drawing.Size(196, 36);
            this.startDtp.TabIndex = 2;
            this.startDtp.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // durationCb
            // 
            this.durationCb.BackColor = System.Drawing.Color.Transparent;
            this.durationCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.durationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationCb.FocusedState.Parent = this.durationCb;
            this.durationCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.durationCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.durationCb.HoverState.Parent = this.durationCb;
            this.durationCb.ItemHeight = 30;
            this.durationCb.Items.AddRange(new object[] {
            "1 day",
            "2 days +1 night",
            "3 days + 2 nights",
            "4 days + 3 nights",
            "5 days + 4 nights"});
            this.durationCb.ItemsAppearance.Parent = this.durationCb;
            this.durationCb.Location = new System.Drawing.Point(188, 256);
            this.durationCb.Name = "durationCb";
            this.durationCb.ShadowDecoration.Parent = this.durationCb;
            this.durationCb.Size = new System.Drawing.Size(196, 36);
            this.durationCb.TabIndex = 3;
            // 
            // aboardCb
            // 
            this.aboardCb.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aboardCb.CheckedState.BorderRadius = 2;
            this.aboardCb.CheckedState.BorderThickness = 0;
            this.aboardCb.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.aboardCb.CheckedState.Parent = this.aboardCb;
            this.aboardCb.Location = new System.Drawing.Point(583, 171);
            this.aboardCb.Name = "aboardCb";
            this.aboardCb.ShadowDecoration.Parent = this.aboardCb;
            this.aboardCb.Size = new System.Drawing.Size(20, 20);
            this.aboardCb.TabIndex = 5;
            this.aboardCb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.aboardCb.UncheckedState.BorderRadius = 2;
            this.aboardCb.UncheckedState.BorderThickness = 0;
            this.aboardCb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.aboardCb.UncheckedState.Parent = this.aboardCb;
            this.aboardCb.CheckedChanged += new System.EventHandler(this.aboardCb_CheckedChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(46, 375);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(706, 272);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(841, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Departure:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(841, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(841, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(841, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of tickets:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aboard:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(841, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tour detail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Passport code :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(840, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "Visa date:";
            // 
            // passportTb
            // 
            this.passportTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passportTb.DefaultText = "";
            this.passportTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passportTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportTb.DisabledState.Parent = this.passportTb;
            this.passportTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passportTb.FocusedState.Parent = this.passportTb;
            this.passportTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passportTb.HoverState.Parent = this.passportTb;
            this.passportTb.Location = new System.Drawing.Point(585, 200);
            this.passportTb.Margin = new System.Windows.Forms.Padding(4);
            this.passportTb.Name = "passportTb";
            this.passportTb.PasswordChar = '\0';
            this.passportTb.PlaceholderText = "";
            this.passportTb.SelectedText = "";
            this.passportTb.ShadowDecoration.Parent = this.passportTb;
            this.passportTb.Size = new System.Drawing.Size(196, 36);
            this.passportTb.TabIndex = 17;
            // 
            // visaDtp
            // 
            this.visaDtp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.visaDtp.BorderRadius = 1;
            this.visaDtp.BorderThickness = 1;
            this.visaDtp.CheckedState.Parent = this.visaDtp;
            this.visaDtp.FillColor = System.Drawing.Color.White;
            this.visaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.visaDtp.HoverState.Parent = this.visaDtp;
            this.visaDtp.Location = new System.Drawing.Point(1009, 517);
            this.visaDtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.visaDtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.visaDtp.Name = "visaDtp";
            this.visaDtp.ShadowDecoration.Parent = this.visaDtp;
            this.visaDtp.Size = new System.Drawing.Size(215, 36);
            this.visaDtp.TabIndex = 18;
            this.visaDtp.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(840, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tickets price:";
            // 
            // payBtn
            // 
            this.payBtn.Animated = true;
            this.payBtn.AutoRoundedCorners = true;
            this.payBtn.BorderRadius = 21;
            this.payBtn.CheckedState.Parent = this.payBtn;
            this.payBtn.CustomImages.Parent = this.payBtn;
            this.payBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.HoverState.Parent = this.payBtn;
            this.payBtn.Location = new System.Drawing.Point(1071, 624);
            this.payBtn.Name = "payBtn";
            this.payBtn.ShadowDecoration.Parent = this.payBtn;
            this.payBtn.Size = new System.Drawing.Size(153, 45);
            this.payBtn.TabIndex = 20;
            this.payBtn.Text = "Book & Pay";
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Animated = true;
            this.bookBtn.AutoRoundedCorners = true;
            this.bookBtn.BorderColor = System.Drawing.Color.Blue;
            this.bookBtn.BorderRadius = 21;
            this.bookBtn.BorderThickness = 1;
            this.bookBtn.CheckedState.Parent = this.bookBtn;
            this.bookBtn.CustomImages.Parent = this.bookBtn;
            this.bookBtn.FillColor = System.Drawing.Color.White;
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bookBtn.HoverState.Parent = this.bookBtn;
            this.bookBtn.Location = new System.Drawing.Point(846, 624);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.ShadowDecoration.Parent = this.bookBtn;
            this.bookBtn.Size = new System.Drawing.Size(153, 45);
            this.bookBtn.TabIndex = 21;
            this.bookBtn.Text = "Book";
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
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
            // aboardcheck
            // 
            this.aboardcheck.AutoSize = true;
            this.aboardcheck.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboardcheck.Location = new System.Drawing.Point(971, 471);
            this.aboardcheck.Name = "aboardcheck";
            this.aboardcheck.Size = new System.Drawing.Size(40, 26);
            this.aboardcheck.TabIndex = 23;
            this.aboardcheck.Text = "No";
            // 
            // numberticket
            // 
            this.numberticket.AutoSize = true;
            this.numberticket.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberticket.Location = new System.Drawing.Point(1066, 322);
            this.numberticket.Name = "numberticket";
            this.numberticket.Size = new System.Drawing.Size(88, 26);
            this.numberticket.TabIndex = 24;
            this.numberticket.Text = "Waiting";
            // 
            // ticketTb
            // 
            this.ticketTb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTb.Location = new System.Drawing.Point(583, 119);
            this.ticketTb.Multiline = true;
            this.ticketTb.Name = "ticketTb";
            this.ticketTb.Size = new System.Drawing.Size(169, 36);
            this.ticketTb.TabIndex = 25;
            this.ticketTb.TextChanged += new System.EventHandler(this.ticketTb_TextChanged);
            // 
            // IDLb
            // 
            this.IDLb.AutoSize = true;
            this.IDLb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLb.Location = new System.Drawing.Point(1066, 82);
            this.IDLb.Name = "IDLb";
            this.IDLb.Size = new System.Drawing.Size(88, 26);
            this.IDLb.TabIndex = 26;
            this.IDLb.Text = "Waiting";
            // 
            // departureLb
            // 
            this.departureLb.AutoSize = true;
            this.departureLb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLb.Location = new System.Drawing.Point(1066, 129);
            this.departureLb.Name = "departureLb";
            this.departureLb.Size = new System.Drawing.Size(88, 26);
            this.departureLb.TabIndex = 27;
            this.departureLb.Text = "Waiting";
            // 
            // destinationLb
            // 
            this.destinationLb.AutoSize = true;
            this.destinationLb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLb.Location = new System.Drawing.Point(1066, 182);
            this.destinationLb.Name = "destinationLb";
            this.destinationLb.Size = new System.Drawing.Size(88, 26);
            this.destinationLb.TabIndex = 28;
            this.destinationLb.Text = "Waiting";
            // 
            // startdateLb
            // 
            this.startdateLb.AutoSize = true;
            this.startdateLb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateLb.Location = new System.Drawing.Point(1066, 233);
            this.startdateLb.Name = "startdateLb";
            this.startdateLb.Size = new System.Drawing.Size(88, 26);
            this.startdateLb.TabIndex = 29;
            this.startdateLb.Text = "Waiting";
            // 
            // durationLb
            // 
            this.durationLb.AutoSize = true;
            this.durationLb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLb.Location = new System.Drawing.Point(1066, 281);
            this.durationLb.Name = "durationLb";
            this.durationLb.Size = new System.Drawing.Size(88, 26);
            this.durationLb.TabIndex = 30;
            this.durationLb.Text = "Waiting";
            // 
            // priceTb
            // 
            this.priceTb.AutoSize = true;
            this.priceTb.Font = new System.Drawing.Font("Yu Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTb.Location = new System.Drawing.Point(1004, 582);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(88, 26);
            this.priceTb.TabIndex = 31;
            this.priceTb.Text = "Waiting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "Expiration :";
            // 
            // PassportExpiration
            // 
            this.PassportExpiration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.PassportExpiration.BorderRadius = 1;
            this.PassportExpiration.BorderThickness = 1;
            this.PassportExpiration.CheckedState.Parent = this.PassportExpiration;
            this.PassportExpiration.FillColor = System.Drawing.Color.White;
            this.PassportExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PassportExpiration.HoverState.Parent = this.PassportExpiration;
            this.PassportExpiration.Location = new System.Drawing.Point(583, 243);
            this.PassportExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PassportExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PassportExpiration.Name = "PassportExpiration";
            this.PassportExpiration.ShadowDecoration.Parent = this.PassportExpiration;
            this.PassportExpiration.Size = new System.Drawing.Size(196, 36);
            this.PassportExpiration.TabIndex = 33;
            this.PassportExpiration.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.Artboard_1_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PassportExpiration);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.durationLb);
            this.Controls.Add(this.startdateLb);
            this.Controls.Add(this.destinationLb);
            this.Controls.Add(this.departureLb);
            this.Controls.Add(this.IDLb);
            this.Controls.Add(this.ticketTb);
            this.Controls.Add(this.numberticket);
            this.Controls.Add(this.aboardcheck);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.visaDtp);
            this.Controls.Add(this.passportTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.aboardCb);
            this.Controls.Add(this.durationCb);
            this.Controls.Add(this.startDtp);
            this.Controls.Add(this.destinationCb);
            this.Controls.Add(this.departureCb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox departureCb;
        private Guna.UI2.WinForms.Guna2ComboBox destinationCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDtp;
        private Guna.UI2.WinForms.Guna2ComboBox durationCb;
        private Guna.UI2.WinForms.Guna2CustomCheckBox aboardCb;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox passportTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker visaDtp;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button payBtn;
        private Guna.UI2.WinForms.Guna2Button bookBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label aboardcheck;
        private System.Windows.Forms.Label numberticket;
        private System.Windows.Forms.TextBox ticketTb;
        private System.Windows.Forms.Label destinationLb;
        private System.Windows.Forms.Label departureLb;
        private System.Windows.Forms.Label IDLb;
        private System.Windows.Forms.Label durationLb;
        private System.Windows.Forms.Label startdateLb;
        private System.Windows.Forms.Label priceTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker PassportExpiration;
        private System.Windows.Forms.Label label12;
    }
}