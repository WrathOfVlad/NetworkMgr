//using Gnostice.Documents.Sheets;
using System.Drawing;
//using System.Windows.Controls;

namespace NetworkMgr
{
    partial class ContactDetail
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
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.companyURLEditable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStatusContact = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkFacebook = new System.Windows.Forms.LinkLabel();
            this.linkLinkedin = new System.Windows.Forms.LinkLabel();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.contactLogDataGridView = new System.Windows.Forms.DataGridView();
            this.toggleEdit = new System.Windows.Forms.Button();
            this.linkedinEditable = new System.Windows.Forms.TextBox();
            this.FacebookEditable = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateLastContact = new System.Windows.Forms.MaskedTextBox();
            this.dateNextContact = new System.Windows.Forms.MaskedTextBox();
            this.companyURL = new System.Windows.Forms.LinkLabel();
            this.dateBirthday = new System.Windows.Forms.MaskedTextBox();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePic.Location = new System.Drawing.Point(20, 10);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(125, 136);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            this.profilePic.Click += new System.EventHandler(this.profilePic_Click);
            this.profilePic.DoubleClick += new System.EventHandler(this.profilePic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Location = new System.Drawing.Point(410, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Location = new System.Drawing.Point(410, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Location = new System.Drawing.Point(410, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email 1:";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtName.Location = new System.Drawing.Point(510, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSurname.Location = new System.Drawing.Point(510, 100);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(173, 27);
            this.txtSurname.TabIndex = 2;
            // 
            // txtEmail1
            // 
            this.txtEmail1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmail1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail1.Location = new System.Drawing.Point(510, 130);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(173, 27);
            this.txtEmail1.TabIndex = 3;
            // 
            // txtEmail2
            // 
            this.txtEmail2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmail2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail2.Location = new System.Drawing.Point(510, 160);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(173, 27);
            this.txtEmail2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Location = new System.Drawing.Point(410, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email 2:";
            // 
            // txtEmail3
            // 
            this.txtEmail3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEmail3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail3.Location = new System.Drawing.Point(510, 190);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(173, 27);
            this.txtEmail3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Location = new System.Drawing.Point(410, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email 3:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhone1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone1.Location = new System.Drawing.Point(815, 70);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(173, 27);
            this.txtPhone1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Location = new System.Drawing.Point(710, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone 1:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhone2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone2.Location = new System.Drawing.Point(815, 100);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(173, 27);
            this.txtPhone2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Location = new System.Drawing.Point(710, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone 2:";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddress.Location = new System.Drawing.Point(510, 280);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 27);
            this.txtAddress.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Location = new System.Drawing.Point(410, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Address:";
            // 
            // companyURLEditable
            // 
            this.companyURLEditable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.companyURLEditable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.companyURLEditable.Location = new System.Drawing.Point(125, 250);
            this.companyURLEditable.Name = "companyURLEditable";
            this.companyURLEditable.Size = new System.Drawing.Size(284, 27);
            this.companyURLEditable.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Location = new System.Drawing.Point(20, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "Company URL:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1000, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Note:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Location = new System.Drawing.Point(410, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Next Contact:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label14.Location = new System.Drawing.Point(410, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Last Contact:";
            // 
            // txtStatusContact
            // 
            this.txtStatusContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStatusContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStatusContact.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatusContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusContact.Location = new System.Drawing.Point(815, 390);
            this.txtStatusContact.Name = "txtStatusContact";
            this.txtStatusContact.Size = new System.Drawing.Size(173, 20);
            this.txtStatusContact.TabIndex = 33;
            this.txtStatusContact.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label15.Location = new System.Drawing.Point(710, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Status Contact:";
            // 
            // txtLocation
            // 
            this.txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLocation.Location = new System.Drawing.Point(510, 250);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(173, 27);
            this.txtLocation.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label16.Location = new System.Drawing.Point(410, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Location:";
            // 
            // txtRole
            // 
            this.txtRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRole.Location = new System.Drawing.Point(815, 160);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(173, 27);
            this.txtRole.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label17.Location = new System.Drawing.Point(710, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Role:";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.Location = new System.Drawing.Point(510, 220);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(173, 27);
            this.txtCompany.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label18.Location = new System.Drawing.Point(410, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "Company:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label19.Location = new System.Drawing.Point(20, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Facebook";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label20.Location = new System.Drawing.Point(20, 190);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "Linkedin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Birthday:";
            // 
            // linkFacebook
            // 
            this.linkFacebook.AutoSize = true;
            this.linkFacebook.Location = new System.Drawing.Point(125, 220);
            this.linkFacebook.Name = "linkFacebook";
            this.linkFacebook.Size = new System.Drawing.Size(72, 20);
            this.linkFacebook.TabIndex = 11;
            this.linkFacebook.TabStop = true;
            this.linkFacebook.Text = "Facebook";
            this.linkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFacebook_LinkClicked);
            // 
            // linkLinkedin
            // 
            this.linkLinkedin.AutoSize = true;
            this.linkLinkedin.Location = new System.Drawing.Point(125, 190);
            this.linkLinkedin.Name = "linkLinkedin";
            this.linkLinkedin.Size = new System.Drawing.Size(64, 20);
            this.linkLinkedin.TabIndex = 10;
            this.linkLinkedin.TabStop = true;
            this.linkLinkedin.Text = "Linkedin";
            this.linkLinkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLinkedin_LinkClicked);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(1050, 70);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(850, 870);
            this.txtNotes.TabIndex = 17;
            this.txtNotes.Text = "";
            // 
            // contactLogDataGridView
            // 
            this.contactLogDataGridView.AllowUserToAddRows = false;
            this.contactLogDataGridView.AllowUserToDeleteRows = false;
            this.contactLogDataGridView.AllowUserToOrderColumns = true;
            this.contactLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactLogDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contactLogDataGridView.Location = new System.Drawing.Point(12, 441);
            this.contactLogDataGridView.Name = "contactLogDataGridView";
            this.contactLogDataGridView.RowHeadersWidth = 51;
            this.contactLogDataGridView.RowTemplate.Height = 24;
            this.contactLogDataGridView.Size = new System.Drawing.Size(1030, 500);
            this.contactLogDataGridView.TabIndex = 48;
            this.contactLogDataGridView.TabStop = false;
            // 
            // toggleEdit
            // 
            this.toggleEdit.Location = new System.Drawing.Point(170, 10);
            this.toggleEdit.Name = "toggleEdit";
            this.toggleEdit.Size = new System.Drawing.Size(75, 30);
            this.toggleEdit.TabIndex = 19;
            this.toggleEdit.Text = "Edit";
            this.toggleEdit.UseVisualStyleBackColor = true;
            this.toggleEdit.Click += new System.EventHandler(this.toggleEdit_Click);
            // 
            // linkedinEditable
            // 
            this.linkedinEditable.Location = new System.Drawing.Point(125, 190);
            this.linkedinEditable.Name = "linkedinEditable";
            this.linkedinEditable.Size = new System.Drawing.Size(284, 27);
            this.linkedinEditable.TabIndex = 10;
            // 
            // FacebookEditable
            // 
            this.FacebookEditable.Location = new System.Drawing.Point(125, 220);
            this.FacebookEditable.Name = "FacebookEditable";
            this.FacebookEditable.Size = new System.Drawing.Size(284, 27);
            this.FacebookEditable.TabIndex = 11;
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(23, 387);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 30);
            this.addNew.TabIndex = 21;
            this.addNew.TabStop = false;
            this.addNew.Text = "Add New";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(270, 10);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 30);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "File Explorer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLastContact
            // 
            this.dateLastContact.Location = new System.Drawing.Point(510, 360);
            this.dateLastContact.Mask = "0000-00-00";
            this.dateLastContact.Name = "dateLastContact";
            this.dateLastContact.ReadOnly = true;
            this.dateLastContact.Size = new System.Drawing.Size(100, 27);
            this.dateLastContact.TabIndex = 55;
            this.dateLastContact.TabStop = false;
            this.dateLastContact.ValidatingType = typeof(System.DateTime);
            // 
            // dateNextContact
            // 
            this.dateNextContact.Location = new System.Drawing.Point(510, 390);
            this.dateNextContact.Mask = "0000-00-00";
            this.dateNextContact.Name = "dateNextContact";
            this.dateNextContact.ReadOnly = true;
            this.dateNextContact.Size = new System.Drawing.Size(100, 27);
            this.dateNextContact.TabIndex = 56;
            this.dateNextContact.TabStop = false;
            this.dateNextContact.ValidatingType = typeof(System.DateTime);
            // 
            // companyURL
            // 
            this.companyURL.AutoSize = true;
            this.companyURL.Location = new System.Drawing.Point(125, 250);
            this.companyURL.Name = "companyURL";
            this.companyURL.Size = new System.Drawing.Size(102, 20);
            this.companyURL.TabIndex = 12;
            this.companyURL.TabStop = true;
            this.companyURL.Text = "Company URL";
            this.companyURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.companyURL_LinkClicked);
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(125, 160);
            this.dateBirthday.Mask = "0000-00-00";
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(100, 27);
            this.dateBirthday.TabIndex = 9;
            this.dateBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // txtSkype
            // 
            this.txtSkype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSkype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSkype.Location = new System.Drawing.Point(125, 280);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(284, 27);
            this.txtSkype.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Location = new System.Drawing.Point(20, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Skype:";
            // 
            // ContactDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.ControlBox = false;
            this.Controls.Add(this.txtSkype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.dateNextContact);
            this.Controls.Add(this.dateLastContact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.FacebookEditable);
            this.Controls.Add(this.linkedinEditable);
            this.Controls.Add(this.toggleEdit);
            this.Controls.Add(this.contactLogDataGridView);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.linkLinkedin);
            this.Controls.Add(this.linkFacebook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.companyURLEditable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtStatusContact);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.companyURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ContactDetail";
            this.Text = "Contact Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox companyURLEditable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStatusContact;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkFacebook;
        private System.Windows.Forms.LinkLabel linkLinkedin;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.DataGridView contactLogDataGridView;
        private System.Windows.Forms.Button toggleEdit;
        private System.Windows.Forms.TextBox linkedinEditable;
        private System.Windows.Forms.TextBox FacebookEditable;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox dateLastContact;
        private System.Windows.Forms.MaskedTextBox dateNextContact;
        private System.Windows.Forms.LinkLabel companyURL;
        private System.Windows.Forms.MaskedTextBox dateBirthday;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.Label label9;
    }
}