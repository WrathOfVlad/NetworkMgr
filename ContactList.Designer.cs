namespace NetworkMgr
{
    partial class ContactList
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
            this.mainContactList = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContactList
            // 
            this.mainContactList.AllowUserToAddRows = false;
            this.mainContactList.AllowUserToDeleteRows = false;
            this.mainContactList.AllowUserToOrderColumns = true;
            this.mainContactList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainContactList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainContactList.Location = new System.Drawing.Point(0, 34);
            this.mainContactList.Name = "mainContactList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainContactList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainContactList.RowHeadersWidth = 51;
            this.mainContactList.RowTemplate.Height = 24;
            this.mainContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainContactList.Size = new System.Drawing.Size(799, 331);
            this.mainContactList.TabIndex = 3;
            this.mainContactList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainContactList_CellDoubleClick);
            // 
            // search
            // 
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search.Location = new System.Drawing.Point(12, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(237, 22);
            this.search.TabIndex = 4;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // ContactList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(799, 365);
            this.ControlBox = false;
            this.Controls.Add(this.search);
            this.Controls.Add(this.mainContactList);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Contact List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView mainContactList;
        private System.Windows.Forms.TextBox search;
    }
}