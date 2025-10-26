namespace ContactPhone
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgContacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نمایش لیست";
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.firstName,
            this.lastName,
            this.address,
            this.mobile,
            this.telephon});
            this.dgContacts.Location = new System.Drawing.Point(22, 36);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.RowTemplate.Height = 24;
            this.dgContacts.Size = new System.Drawing.Size(716, 266);
            this.dgContacts.TabIndex = 0;
            this.dgContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContacts_CellContentClick);
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "contactId";
            this.ContactId.HeaderText = "شماره";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "firstName";
            this.firstName.HeaderText = "نام";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "نام خانوادگی";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "نشانی";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "شماره همراه";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // telephon
            // 
            this.telephon.DataPropertyName = "telephon";
            this.telephon.HeaderText = "تلفن";
            this.telephon.Name = "telephon";
            this.telephon.ReadOnly = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 1);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(91, 39);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "افزودن";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(120, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 39);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "به روز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(136, 474);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(362, 17);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(297, 27);
            this.textSearch.TabIndex = 1;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephon;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
    }
}

