
namespace E_Tour
{
    partial class tourEditorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.passportTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.departureTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.destinationTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ticketTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.durationTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.datetime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.findBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.removeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tourShowData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bookedticketData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.updateticketBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tourShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedticketData)).BeginInit();
            this.SuspendLayout();
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
            this.passportTb.Location = new System.Drawing.Point(192, 125);
            this.passportTb.Name = "passportTb";
            this.passportTb.PasswordChar = '\0';
            this.passportTb.PlaceholderText = "";
            this.passportTb.SelectedText = "";
            this.passportTb.ShadowDecoration.Parent = this.passportTb;
            this.passportTb.Size = new System.Drawing.Size(181, 36);
            this.passportTb.TabIndex = 18;
            // 
            // departureTxb
            // 
            this.departureTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departureTxb.DefaultText = "";
            this.departureTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.departureTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.departureTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.departureTxb.DisabledState.Parent = this.departureTxb;
            this.departureTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.departureTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departureTxb.FocusedState.Parent = this.departureTxb;
            this.departureTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.departureTxb.HoverState.Parent = this.departureTxb;
            this.departureTxb.Location = new System.Drawing.Point(192, 173);
            this.departureTxb.Name = "departureTxb";
            this.departureTxb.PasswordChar = '\0';
            this.departureTxb.PlaceholderText = "";
            this.departureTxb.SelectedText = "";
            this.departureTxb.ShadowDecoration.Parent = this.departureTxb;
            this.departureTxb.Size = new System.Drawing.Size(181, 36);
            this.departureTxb.TabIndex = 19;
            // 
            // destinationTxb
            // 
            this.destinationTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.destinationTxb.DefaultText = "";
            this.destinationTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.destinationTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.destinationTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationTxb.DisabledState.Parent = this.destinationTxb;
            this.destinationTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.destinationTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTxb.FocusedState.Parent = this.destinationTxb;
            this.destinationTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.destinationTxb.HoverState.Parent = this.destinationTxb;
            this.destinationTxb.Location = new System.Drawing.Point(192, 223);
            this.destinationTxb.Name = "destinationTxb";
            this.destinationTxb.PasswordChar = '\0';
            this.destinationTxb.PlaceholderText = "";
            this.destinationTxb.SelectedText = "";
            this.destinationTxb.ShadowDecoration.Parent = this.destinationTxb;
            this.destinationTxb.Size = new System.Drawing.Size(181, 36);
            this.destinationTxb.TabIndex = 20;
            // 
            // ticketTxb
            // 
            this.ticketTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ticketTxb.DefaultText = "";
            this.ticketTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ticketTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ticketTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketTxb.DisabledState.Parent = this.ticketTxb;
            this.ticketTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketTxb.FocusedState.Parent = this.ticketTxb;
            this.ticketTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ticketTxb.HoverState.Parent = this.ticketTxb;
            this.ticketTxb.Location = new System.Drawing.Point(591, 125);
            this.ticketTxb.Name = "ticketTxb";
            this.ticketTxb.PasswordChar = '\0';
            this.ticketTxb.PlaceholderText = "";
            this.ticketTxb.SelectedText = "";
            this.ticketTxb.ShadowDecoration.Parent = this.ticketTxb;
            this.ticketTxb.Size = new System.Drawing.Size(180, 36);
            this.ticketTxb.TabIndex = 21;
            // 
            // priceTxb
            // 
            this.priceTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxb.DefaultText = "";
            this.priceTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxb.DisabledState.Parent = this.priceTxb;
            this.priceTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxb.FocusedState.Parent = this.priceTxb;
            this.priceTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxb.HoverState.Parent = this.priceTxb;
            this.priceTxb.Location = new System.Drawing.Point(591, 173);
            this.priceTxb.Name = "priceTxb";
            this.priceTxb.PasswordChar = '\0';
            this.priceTxb.PlaceholderText = "";
            this.priceTxb.SelectedText = "";
            this.priceTxb.ShadowDecoration.Parent = this.priceTxb;
            this.priceTxb.Size = new System.Drawing.Size(180, 36);
            this.priceTxb.TabIndex = 22;
            // 
            // durationTxb
            // 
            this.durationTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.durationTxb.DefaultText = "";
            this.durationTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.durationTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.durationTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationTxb.DisabledState.Parent = this.durationTxb;
            this.durationTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.durationTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationTxb.FocusedState.Parent = this.durationTxb;
            this.durationTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.durationTxb.HoverState.Parent = this.durationTxb;
            this.durationTxb.Location = new System.Drawing.Point(591, 223);
            this.durationTxb.Name = "durationTxb";
            this.durationTxb.PasswordChar = '\0';
            this.durationTxb.PlaceholderText = "";
            this.durationTxb.SelectedText = "";
            this.durationTxb.ShadowDecoration.Parent = this.durationTxb;
            this.durationTxb.Size = new System.Drawing.Size(180, 36);
            this.durationTxb.TabIndex = 23;
            // 
            // datetime
            // 
            this.datetime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.datetime.BorderRadius = 1;
            this.datetime.BorderThickness = 1;
            this.datetime.CheckedState.Parent = this.datetime;
            this.datetime.CustomFormat = "dd-MM-yyyy";
            this.datetime.FillColor = System.Drawing.Color.White;
            this.datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime.HoverState.Parent = this.datetime;
            this.datetime.Location = new System.Drawing.Point(192, 270);
            this.datetime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime.Name = "datetime";
            this.datetime.ShadowDecoration.Parent = this.datetime;
            this.datetime.Size = new System.Drawing.Size(181, 36);
            this.datetime.TabIndex = 24;
            this.datetime.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // findBtn
            // 
            this.findBtn.Animated = true;
            this.findBtn.AutoRoundedCorners = true;
            this.findBtn.BorderRadius = 17;
            this.findBtn.CheckedState.Parent = this.findBtn;
            this.findBtn.CustomImages.Parent = this.findBtn;
            this.findBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.HoverState.Parent = this.findBtn;
            this.findBtn.Location = new System.Drawing.Point(461, 285);
            this.findBtn.Name = "findBtn";
            this.findBtn.ShadowDecoration.Parent = this.findBtn;
            this.findBtn.Size = new System.Drawing.Size(73, 36);
            this.findBtn.TabIndex = 25;
            this.findBtn.Text = "Find";
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BorderRadius = 17;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(540, 285);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(73, 36);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Animated = true;
            this.removeBtn.AutoRoundedCorners = true;
            this.removeBtn.BorderRadius = 17;
            this.removeBtn.CheckedState.Parent = this.removeBtn;
            this.removeBtn.CustomImages.Parent = this.removeBtn;
            this.removeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.Parent = this.removeBtn;
            this.removeBtn.Location = new System.Drawing.Point(619, 285);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.ShadowDecoration.Parent = this.removeBtn;
            this.removeBtn.Size = new System.Drawing.Size(73, 36);
            this.removeBtn.TabIndex = 27;
            this.removeBtn.Text = "Remove";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Animated = true;
            this.updateBtn.AutoRoundedCorners = true;
            this.updateBtn.BorderRadius = 17;
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(698, 285);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(73, 36);
            this.updateBtn.TabIndex = 28;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tourShowData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tourShowData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tourShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tourShowData.BackgroundColor = System.Drawing.Color.White;
            this.tourShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourShowData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tourShowData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tourShowData.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tourShowData.DefaultCellStyle = dataGridViewCellStyle3;
            this.tourShowData.EnableHeadersVisualStyles = false;
            this.tourShowData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tourShowData.Location = new System.Drawing.Point(51, 404);
            this.tourShowData.Name = "tourShowData";
            this.tourShowData.RowHeadersVisible = false;
            this.tourShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tourShowData.Size = new System.Drawing.Size(706, 272);
            this.tourShowData.TabIndex = 29;
            this.tourShowData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tourShowData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tourShowData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tourShowData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tourShowData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tourShowData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tourShowData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tourShowData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tourShowData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tourShowData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tourShowData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tourShowData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tourShowData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tourShowData.ThemeStyle.HeaderStyle.Height = 4;
            this.tourShowData.ThemeStyle.ReadOnly = false;
            this.tourShowData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tourShowData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tourShowData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tourShowData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tourShowData.ThemeStyle.RowsStyle.Height = 22;
            this.tourShowData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tourShowData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tourShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourShowData_CellClick);
            // 
            // bookedticketData
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.bookedticketData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bookedticketData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookedticketData.BackgroundColor = System.Drawing.Color.White;
            this.bookedticketData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookedticketData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookedticketData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookedticketData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bookedticketData.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookedticketData.DefaultCellStyle = dataGridViewCellStyle6;
            this.bookedticketData.EnableHeadersVisualStyles = false;
            this.bookedticketData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookedticketData.Location = new System.Drawing.Point(844, 93);
            this.bookedticketData.Name = "bookedticketData";
            this.bookedticketData.RowHeadersVisible = false;
            this.bookedticketData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookedticketData.Size = new System.Drawing.Size(415, 544);
            this.bookedticketData.TabIndex = 30;
            this.bookedticketData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.bookedticketData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.bookedticketData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.bookedticketData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.bookedticketData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.bookedticketData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.bookedticketData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.bookedticketData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookedticketData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bookedticketData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookedticketData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bookedticketData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bookedticketData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookedticketData.ThemeStyle.HeaderStyle.Height = 4;
            this.bookedticketData.ThemeStyle.ReadOnly = false;
            this.bookedticketData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bookedticketData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookedticketData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.bookedticketData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.bookedticketData.ThemeStyle.RowsStyle.Height = 22;
            this.bookedticketData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.bookedticketData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // updateticketBtn
            // 
            this.updateticketBtn.Animated = true;
            this.updateticketBtn.AutoRoundedCorners = true;
            this.updateticketBtn.BorderRadius = 25;
            this.updateticketBtn.CheckedState.Parent = this.updateticketBtn;
            this.updateticketBtn.CustomImages.Parent = this.updateticketBtn;
            this.updateticketBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updateticketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.updateticketBtn.ForeColor = System.Drawing.Color.White;
            this.updateticketBtn.HoverState.Parent = this.updateticketBtn;
            this.updateticketBtn.Location = new System.Drawing.Point(1106, 643);
            this.updateticketBtn.Name = "updateticketBtn";
            this.updateticketBtn.ShadowDecoration.Parent = this.updateticketBtn;
            this.updateticketBtn.Size = new System.Drawing.Size(153, 52);
            this.updateticketBtn.TabIndex = 31;
            this.updateticketBtn.Text = "Update";
            this.updateticketBtn.Click += new System.EventHandler(this.updateticketBtn_Click);
            // 
            // tourEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::E_Tour.Properties.Resources.Artboard_2_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.updateticketBtn);
            this.Controls.Add(this.bookedticketData);
            this.Controls.Add(this.tourShowData);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.durationTxb);
            this.Controls.Add(this.priceTxb);
            this.Controls.Add(this.ticketTxb);
            this.Controls.Add(this.destinationTxb);
            this.Controls.Add(this.departureTxb);
            this.Controls.Add(this.passportTb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tourEditorForm";
            this.Text = "tourEditor";
            ((System.ComponentModel.ISupportInitialize)(this.tourShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedticketData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox passportTb;
        private Guna.UI2.WinForms.Guna2TextBox departureTxb;
        private Guna.UI2.WinForms.Guna2TextBox destinationTxb;
        private Guna.UI2.WinForms.Guna2TextBox ticketTxb;
        private Guna.UI2.WinForms.Guna2TextBox priceTxb;
        private Guna.UI2.WinForms.Guna2TextBox durationTxb;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime;
        private Guna.UI2.WinForms.Guna2Button findBtn;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button removeBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2DataGridView tourShowData;
        private Guna.UI2.WinForms.Guna2DataGridView bookedticketData;
        private Guna.UI2.WinForms.Guna2Button updateticketBtn;
    }
}