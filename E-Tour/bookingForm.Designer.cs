
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.departureCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.destinationCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.startDtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.durationCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ticketsCb = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.durationCb.ItemsAppearance.Parent = this.durationCb;
            this.durationCb.Location = new System.Drawing.Point(188, 256);
            this.durationCb.Name = "durationCb";
            this.durationCb.ShadowDecoration.Parent = this.durationCb;
            this.durationCb.Size = new System.Drawing.Size(196, 36);
            this.durationCb.TabIndex = 3;
            // 
            // ticketsCb
            // 
            this.ticketsCb.BackColor = System.Drawing.Color.Transparent;
            this.ticketsCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ticketsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketsCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketsCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketsCb.FocusedState.Parent = this.ticketsCb;
            this.ticketsCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ticketsCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ticketsCb.HoverState.Parent = this.ticketsCb;
            this.ticketsCb.ItemHeight = 30;
            this.ticketsCb.ItemsAppearance.Parent = this.ticketsCb;
            this.ticketsCb.Location = new System.Drawing.Point(583, 119);
            this.ticketsCb.Name = "ticketsCb";
            this.ticketsCb.ShadowDecoration.Parent = this.ticketsCb;
            this.ticketsCb.Size = new System.Drawing.Size(169, 36);
            this.ticketsCb.TabIndex = 4;
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
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(46, 375);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.label5.Location = new System.Drawing.Point(1066, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of tickets:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aboard:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(841, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tour detail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(841, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Passport code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(841, 525);
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
            this.passportTb.Location = new System.Drawing.Point(1009, 463);
            this.passportTb.Name = "passportTb";
            this.passportTb.PasswordChar = '\0';
            this.passportTb.PlaceholderText = "";
            this.passportTb.SelectedText = "";
            this.passportTb.ShadowDecoration.Parent = this.passportTb;
            this.passportTb.Size = new System.Drawing.Size(215, 36);
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
            this.visaDtp.Location = new System.Drawing.Point(1009, 515);
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
            this.label11.Location = new System.Drawing.Point(841, 581);
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
            this.payBtn.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.HoverState.Parent = this.payBtn;
            this.payBtn.Location = new System.Drawing.Point(1071, 624);
            this.payBtn.Name = "payBtn";
            this.payBtn.ShadowDecoration.Parent = this.payBtn;
            this.payBtn.Size = new System.Drawing.Size(153, 45);
            this.payBtn.TabIndex = 20;
            this.payBtn.Text = "Book & Pay";
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
            this.bookBtn.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bookBtn.HoverState.Parent = this.bookBtn;
            this.bookBtn.Location = new System.Drawing.Point(846, 624);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.ShadowDecoration.Parent = this.bookBtn;
            this.bookBtn.Size = new System.Drawing.Size(153, 45);
            this.bookBtn.TabIndex = 21;
            this.bookBtn.Text = "Book";
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
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(618, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(170, 45);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Booked Tickets";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.Artboard_1_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.Controls.Add(this.ticketsCb);
            this.Controls.Add(this.durationCb);
            this.Controls.Add(this.startDtp);
            this.Controls.Add(this.destinationCb);
            this.Controls.Add(this.departureCb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookingForm";
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
        private Guna.UI2.WinForms.Guna2ComboBox ticketsCb;
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
    }
}