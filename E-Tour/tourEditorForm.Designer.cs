
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tourEditorForm));
            this.txbDeparture = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbDestination = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPaid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRemoveUnpaidTicket = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNotPaid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txbCustomerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.findPaid = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAvailableTour = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txbNumberOfTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTourDetail = new Guna.UI2.WinForms.Guna2TextBox();
            this.ckbSale = new Guna.UI.WinForms.GunaCheckBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.cbbTourType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTour)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDeparture
            // 
            this.txbDeparture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDeparture.DefaultText = "";
            this.txbDeparture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDeparture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDeparture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDeparture.DisabledState.Parent = this.txbDeparture;
            this.txbDeparture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDeparture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDeparture.FocusedState.Parent = this.txbDeparture;
            this.txbDeparture.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDeparture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDeparture.HoverState.Parent = this.txbDeparture;
            this.txbDeparture.Location = new System.Drawing.Point(192, 173);
            this.txbDeparture.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDeparture.Name = "txbDeparture";
            this.txbDeparture.PasswordChar = '\0';
            this.txbDeparture.PlaceholderText = "";
            this.txbDeparture.SelectedText = "";
            this.txbDeparture.ShadowDecoration.Parent = this.txbDeparture;
            this.txbDeparture.Size = new System.Drawing.Size(181, 36);
            this.txbDeparture.TabIndex = 19;
            // 
            // txbDestination
            // 
            this.txbDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDestination.DefaultText = "";
            this.txbDestination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDestination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDestination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDestination.DisabledState.Parent = this.txbDestination;
            this.txbDestination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDestination.FocusedState.Parent = this.txbDestination;
            this.txbDestination.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDestination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDestination.HoverState.Parent = this.txbDestination;
            this.txbDestination.Location = new System.Drawing.Point(192, 223);
            this.txbDestination.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDestination.Name = "txbDestination";
            this.txbDestination.PasswordChar = '\0';
            this.txbDestination.PlaceholderText = "";
            this.txbDestination.SelectedText = "";
            this.txbDestination.ShadowDecoration.Parent = this.txbDestination;
            this.txbDestination.Size = new System.Drawing.Size(181, 36);
            this.txbDestination.TabIndex = 20;
            // 
            // txbPrice
            // 
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.DefaultText = "";
            this.txbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPrice.DisabledState.Parent = this.txbPrice;
            this.txbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPrice.FocusedState.Parent = this.txbPrice;
            this.txbPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPrice.HoverState.Parent = this.txbPrice;
            this.txbPrice.Location = new System.Drawing.Point(542, 274);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.PasswordChar = '\0';
            this.txbPrice.PlaceholderText = "";
            this.txbPrice.SelectedText = "";
            this.txbPrice.ShadowDecoration.Parent = this.txbPrice;
            this.txbPrice.Size = new System.Drawing.Size(229, 36);
            this.txbPrice.TabIndex = 22;
            this.txbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrice_KeyPress);
            // 
            // txbDuration
            // 
            this.txbDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDuration.DefaultText = "";
            this.txbDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDuration.DisabledState.Parent = this.txbDuration;
            this.txbDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDuration.FocusedState.Parent = this.txbDuration;
            this.txbDuration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbDuration.HoverState.Parent = this.txbDuration;
            this.txbDuration.Location = new System.Drawing.Point(542, 223);
            this.txbDuration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbDuration.Name = "txbDuration";
            this.txbDuration.PasswordChar = '\0';
            this.txbDuration.PlaceholderText = "";
            this.txbDuration.SelectedText = "";
            this.txbDuration.ShadowDecoration.Parent = this.txbDuration;
            this.txbDuration.Size = new System.Drawing.Size(229, 36);
            this.txbDuration.TabIndex = 23;
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.AutoRoundedCorners = true;
            this.btnFind.BorderRadius = 16;
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(473, 319);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(70, 35);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 16;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(625, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 35);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 16;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(701, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(70, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dgvPaid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaid.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaid.EnableHeadersVisualStyles = false;
            this.dgvPaid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaid.Location = new System.Drawing.Point(832, 388);
            this.dgvPaid.Name = "dgvPaid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaid.RowHeadersVisible = false;
            this.dgvPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaid.Size = new System.Drawing.Size(436, 262);
            this.dgvPaid.TabIndex = 30;
            this.dgvPaid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPaid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPaid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPaid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPaid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPaid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPaid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPaid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPaid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPaid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPaid.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPaid.ThemeStyle.ReadOnly = false;
            this.dgvPaid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPaid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPaid.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPaid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnRemoveUnpaidTicket
            // 
            this.btnRemoveUnpaidTicket.Animated = true;
            this.btnRemoveUnpaidTicket.AutoRoundedCorners = true;
            this.btnRemoveUnpaidTicket.BorderRadius = 25;
            this.btnRemoveUnpaidTicket.CheckedState.Parent = this.btnRemoveUnpaidTicket;
            this.btnRemoveUnpaidTicket.CustomImages.Parent = this.btnRemoveUnpaidTicket;
            this.btnRemoveUnpaidTicket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRemoveUnpaidTicket.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUnpaidTicket.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUnpaidTicket.HoverState.Parent = this.btnRemoveUnpaidTicket;
            this.btnRemoveUnpaidTicket.Location = new System.Drawing.Point(1106, 656);
            this.btnRemoveUnpaidTicket.Name = "btnRemoveUnpaidTicket";
            this.btnRemoveUnpaidTicket.ShadowDecoration.Parent = this.btnRemoveUnpaidTicket;
            this.btnRemoveUnpaidTicket.Size = new System.Drawing.Size(153, 52);
            this.btnRemoveUnpaidTicket.TabIndex = 31;
            this.btnRemoveUnpaidTicket.Text = "Remove";
            this.btnRemoveUnpaidTicket.Visible = false;
            this.btnRemoveUnpaidTicket.Click += new System.EventHandler(this.btnRemoveUnpaidTicket_Click);
            // 
            // dgvNotPaid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvNotPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotPaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotPaid.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotPaid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotPaid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotPaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotPaid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotPaid.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNotPaid.EnableHeadersVisualStyles = false;
            this.dgvNotPaid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNotPaid.Location = new System.Drawing.Point(832, 141);
            this.dgvNotPaid.Name = "dgvNotPaid";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotPaid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNotPaid.RowHeadersVisible = false;
            this.dgvNotPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotPaid.Size = new System.Drawing.Size(436, 207);
            this.dgvNotPaid.TabIndex = 32;
            this.dgvNotPaid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvNotPaid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotPaid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNotPaid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNotPaid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNotPaid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNotPaid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotPaid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNotPaid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNotPaid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNotPaid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNotPaid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNotPaid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNotPaid.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvNotPaid.ThemeStyle.ReadOnly = false;
            this.dgvNotPaid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotPaid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotPaid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvNotPaid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNotPaid.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNotPaid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNotPaid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNotPaid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotPaid_CellMouseClick);
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerId.DefaultText = "";
            this.txbCustomerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCustomerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCustomerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerId.DisabledState.Parent = this.txbCustomerId;
            this.txbCustomerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCustomerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerId.FocusedState.Parent = this.txbCustomerId;
            this.txbCustomerId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCustomerId.HoverState.Parent = this.txbCustomerId;
            this.txbCustomerId.Location = new System.Drawing.Point(1000, 97);
            this.txbCustomerId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.PasswordChar = '\0';
            this.txbCustomerId.PlaceholderText = "";
            this.txbCustomerId.SelectedText = "";
            this.txbCustomerId.ShadowDecoration.Parent = this.txbCustomerId;
            this.txbCustomerId.Size = new System.Drawing.Size(180, 36);
            this.txbCustomerId.TabIndex = 33;
            this.txbCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCustomerId_KeyPress);
            // 
            // findPaid
            // 
            this.findPaid.Animated = true;
            this.findPaid.AutoRoundedCorners = true;
            this.findPaid.BorderRadius = 17;
            this.findPaid.CheckedState.Parent = this.findPaid;
            this.findPaid.CustomImages.Parent = this.findPaid;
            this.findPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.findPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPaid.ForeColor = System.Drawing.Color.White;
            this.findPaid.HoverState.Parent = this.findPaid;
            this.findPaid.Location = new System.Drawing.Point(1186, 97);
            this.findPaid.Name = "findPaid";
            this.findPaid.ShadowDecoration.Parent = this.findPaid;
            this.findPaid.Size = new System.Drawing.Size(73, 36);
            this.findPaid.TabIndex = 34;
            this.findPaid.Text = "Find";
            this.findPaid.Click += new System.EventHandler(this.findPaid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tour Type";
            // 
            // dgvAvailableTour
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvAvailableTour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAvailableTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailableTour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAvailableTour.ColumnHeadersHeight = 35;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableTour.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAvailableTour.EnableHeadersVisualStyles = false;
            this.dgvAvailableTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvailableTour.Location = new System.Drawing.Point(45, 388);
            this.dgvAvailableTour.Name = "dgvAvailableTour";
            this.dgvAvailableTour.RowHeadersVisible = false;
            this.dgvAvailableTour.RowHeadersWidth = 51;
            this.dgvAvailableTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableTour.Size = new System.Drawing.Size(726, 307);
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
            // dtpStartDate
            // 
            this.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.dtpStartDate.BorderRadius = 1;
            this.dtpStartDate.BorderThickness = 1;
            this.dtpStartDate.CheckedState.Parent = this.dtpStartDate;
            this.dtpStartDate.FillColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.HoverState.Parent = this.dtpStartDate;
            this.dtpStartDate.Location = new System.Drawing.Point(191, 274);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShadowDecoration.Parent = this.dtpStartDate;
            this.dtpStartDate.Size = new System.Drawing.Size(182, 36);
            this.dtpStartDate.TabIndex = 81;
            this.dtpStartDate.Value = new System.DateTime(2021, 5, 7, 8, 35, 4, 802);
            // 
            // txbNumberOfTicket
            // 
            this.txbNumberOfTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNumberOfTicket.DefaultText = "";
            this.txbNumberOfTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNumberOfTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNumberOfTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberOfTicket.DisabledState.Parent = this.txbNumberOfTicket;
            this.txbNumberOfTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberOfTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberOfTicket.FocusedState.Parent = this.txbNumberOfTicket;
            this.txbNumberOfTicket.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberOfTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberOfTicket.HoverState.Parent = this.txbNumberOfTicket;
            this.txbNumberOfTicket.Location = new System.Drawing.Point(236, 318);
            this.txbNumberOfTicket.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbNumberOfTicket.Name = "txbNumberOfTicket";
            this.txbNumberOfTicket.PasswordChar = '\0';
            this.txbNumberOfTicket.PlaceholderText = "";
            this.txbNumberOfTicket.SelectedText = "";
            this.txbNumberOfTicket.ShadowDecoration.Parent = this.txbNumberOfTicket;
            this.txbNumberOfTicket.Size = new System.Drawing.Size(137, 36);
            this.txbNumberOfTicket.TabIndex = 21;
            this.txbNumberOfTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumberOfTicket_KeyPress);
            // 
            // txbTourDetail
            // 
            this.txbTourDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTourDetail.DefaultText = "";
            this.txbTourDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTourDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTourDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTourDetail.DisabledState.Parent = this.txbTourDetail;
            this.txbTourDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTourDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTourDetail.FocusedState.Parent = this.txbTourDetail;
            this.txbTourDetail.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTourDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTourDetail.HoverState.Parent = this.txbTourDetail;
            this.txbTourDetail.Location = new System.Drawing.Point(542, 173);
            this.txbTourDetail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbTourDetail.Name = "txbTourDetail";
            this.txbTourDetail.PasswordChar = '\0';
            this.txbTourDetail.PlaceholderText = "";
            this.txbTourDetail.SelectedText = "";
            this.txbTourDetail.ShadowDecoration.Parent = this.txbTourDetail;
            this.txbTourDetail.Size = new System.Drawing.Size(229, 36);
            this.txbTourDetail.TabIndex = 86;
            // 
            // ckbSale
            // 
            this.ckbSale.BaseColor = System.Drawing.Color.White;
            this.ckbSale.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckbSale.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckbSale.FillColor = System.Drawing.Color.White;
            this.ckbSale.Location = new System.Drawing.Point(542, 131);
            this.ckbSale.Name = "ckbSale";
            this.ckbSale.Size = new System.Drawing.Size(20, 20);
            this.ckbSale.TabIndex = 88;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BorderRadius = 16;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(549, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(70, 35);
            this.btnReset.TabIndex = 91;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbbTourType
            // 
            this.cbbTourType.BackColor = System.Drawing.Color.Transparent;
            this.cbbTourType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTourType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTourType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTourType.FocusedState.Parent = this.cbbTourType;
            this.cbbTourType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTourType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTourType.HoverState.Parent = this.cbbTourType;
            this.cbbTourType.ItemHeight = 30;
            this.cbbTourType.Items.AddRange(new object[] {
            "Home",
            "Aboard"});
            this.cbbTourType.ItemsAppearance.Parent = this.cbbTourType;
            this.cbbTourType.Location = new System.Drawing.Point(191, 125);
            this.cbbTourType.Name = "cbbTourType";
            this.cbbTourType.ShadowDecoration.Parent = this.cbbTourType;
            this.cbbTourType.Size = new System.Drawing.Size(182, 36);
            this.cbbTourType.TabIndex = 92;
            // 
            // tourEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.cbbTourType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ckbSale);
            this.Controls.Add(this.txbTourDetail);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgvAvailableTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findPaid);
            this.Controls.Add(this.txbCustomerId);
            this.Controls.Add(this.dgvNotPaid);
            this.Controls.Add(this.btnRemoveUnpaidTicket);
            this.Controls.Add(this.dgvPaid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txbDuration);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbNumberOfTicket);
            this.Controls.Add(this.txbDestination);
            this.Controls.Add(this.txbDeparture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tourEditorForm";
            this.Text = "tourEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbDeparture;
        private Guna.UI2.WinForms.Guna2TextBox txbDestination;
        private Guna.UI2.WinForms.Guna2TextBox txbPrice;
        private Guna.UI2.WinForms.Guna2TextBox txbDuration;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPaid;
        private Guna.UI2.WinForms.Guna2Button btnRemoveUnpaidTicket;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNotPaid;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerId;
        private Guna.UI2.WinForms.Guna2Button findPaid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAvailableTour;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2TextBox txbNumberOfTicket;
        private Guna.UI2.WinForms.Guna2TextBox txbTourDetail;
        private Guna.UI.WinForms.GunaCheckBox ckbSale;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTourType;
    }
}