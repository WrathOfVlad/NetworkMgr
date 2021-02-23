using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
//using System.IO.Packaging;
using System.Diagnostics;

namespace NetworkMgr
{
    public partial class ContactDetail : Form
    {
        private Main pointerToMain = null;
        private ContactList pointerToContactList = null;
        private StorageManager pointerToStorageManager = null;
        private ContactLog pointerToContactLog = null;

        private bool isEditable = true;


        private int id = 0;
        private DataTable contactLogDataTable = new System.Data.DataTable();
        public ContactDetail()
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();
            InitializeComponent();

        }
        public void setMainPointer(Main pointerToMain)
        {
            this.pointerToMain = pointerToMain;
        }
        public void setStoragePointer(StorageManager pointerToStorage)
        {
            this.pointerToStorageManager = pointerToStorage;
        }
        public void setContactListPointer(ContactList pointerToContactList)
        {
            this.pointerToContactList = pointerToContactList;
        }
        public void start()
        {
            loadImage();
            Show();
            ResumeLayout();
        }
        public void save()
        {
            pointerToStorageManager.storageLocation.saveBackup(id);
            DataRow newRow = pointerToStorageManager.mainList.NewRow();
            newRow["Name"] = txtName.Text;
            newRow["Surname"] = txtSurname.Text;
            newRow["Email 1"] = txtEmail1.Text;
            newRow["Email 2"] = txtEmail2.Text;
            newRow["Email 3"] = txtEmail3.Text;
            newRow["Phone 1"] = txtPhone1.Text;
            newRow["Phone 2"] = txtPhone2.Text;
            newRow["Birthday"] = dateBirthday.Text.ToString();
            newRow["Address"] = txtAddress.Text;
            newRow["Company"] = txtCompany.Text;
            newRow["Role"] = txtRole.Text;
            newRow["Location"] = txtLocation.Text;
            newRow["Contact Status"] = txtStatusContact.Text;
            newRow["Last Contact"] = dateLastContact.Text.ToString();
            newRow["Next Contact"] = dateNextContact.Text.ToString();
            newRow["Company URL"] = companyURLEditable.Text;
            newRow["Linkedin"] = linkedinEditable.Text;
            newRow["Facebook"] = FacebookEditable.Text;
            newRow["Skype"] = txtSkype.Text;

            if ( id == 0)
            { 
                int maxId = 0;
                foreach (DataRow dr in pointerToStorageManager.mainList.Rows)
                {

                    int currentId = Int32.Parse(dr["Id"].ToString());
                    maxId = Math.Max(currentId, maxId);
                }
                id = maxId + 1;

                //int maxId =Int32.Parse(pointerToStorageManager.mainList.Select("Id = MAX(Id)")["id"]);
                newRow["Id"] = Config.getIdDirectory(id);
                pointerToStorageManager.mainList.Rows.Add(newRow);
                pointerToStorageManager.storageLocation.addNewContact(id);
            }
            else
            {
                newRow["Id"] = Config.getIdDirectory(id);
                //string getIdRow = String.Format("Id = '{0}'", id.ToString());
                DataRow rowOfChosenId = pointerToStorageManager.mainList.Select("Convert(Id, 'System.Int32') =" + id)[0];
                int indexOfChosenId = pointerToStorageManager.mainList.Rows.IndexOf(rowOfChosenId);

                foreach (DataColumn column in newRow.Table.Columns)
                {
                    try
                    { 
                        pointerToStorageManager.mainList.Rows[indexOfChosenId][column] = newRow[column];
                    }
                    catch { }
                    
                }
            }
            if (pointerToStorageManager.contactLogStorageLocation != null)
            {
                
            }
            else
            {
                fillDataGridView();
            }

            pointerToStorageManager.storageLocation.saveNotes(id, txtNotes.Text);

            pointerToStorageManager.storageLocation.save(pointerToStorageManager.mainList);
            pointerToContactList.mergeName();
            //toggleEditable();
        }
        public void loadImage()
        { 
            profilePic.Image = pointerToStorageManager.storageLocation.getImage(id);
            
        }
        private void fillDataGridView()
        {

            contactLogDataTable = pointerToStorageManager.getContactLog(this.id);

            contactLogDataGridView.DataSource = contactLogDataTable;
            contactLogDataGridView.Columns["Notes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            contactLogDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            contactLogDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        private void linkLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickedLink(linkedinEditable.Text);

        }
        private void linkFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickedLink(FacebookEditable.Text);
            
        }
        private void companyURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clickedLink(companyURLEditable.Text);
        } 
        private void clickedLink(string url)
        {
            try
            {
                var ps = new ProcessStartInfo(url)
                {
                    UseShellExecute = true,
                    Verb = "open"
                };
                Process.Start(ps);
            }
            catch
            {
                MessageBox.Show("Invalid or missing Link. Please toggle edit to edit the link to a valid one");
            }
        }
        public void newContact()
        {
            isEditable = false;
            id = 0;
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail1.Text = "";
            txtEmail2.Text = "";
            txtEmail3.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            dateBirthday.Text = "";
            txtAddress.Text = "";
            txtCompany.Text = "";
            txtRole.Text = "";
            txtLocation.Text = "";
            txtStatusContact.Text = "";
            dateLastContact.Text = "";
            dateNextContact.Text = "";
            companyURLEditable.Text = "";
            FacebookEditable.Text = "";
            linkedinEditable.Text = "";
            txtSkype.Text = "";
            txtNotes.Text = "";


            //fillDataGridView();
            toggleEditable();
            start();
            txtName.Focus();
            
            //loadNotes();
        }
        public void loadDetail(int id)
        {
            isEditable = true;
            DataRow[] rows = pointerToStorageManager.mainList.Select("Convert(Id, 'System.Int32') =" + id);
            DataRow row = rows[0];
            this.id = int.Parse(row["Id"].ToString());
            txtName.Text = row["Name"].ToString();
            txtSurname.Text = row["Surname"].ToString();
            txtEmail1.Text = row["Email 1"].ToString();
            txtEmail2.Text = row["Email 2"].ToString();
            txtEmail3.Text = row["Email 3"].ToString();
            txtPhone1.Text = row["Phone 1"].ToString();
            txtPhone2.Text = row["Phone 2"].ToString();
            dateBirthday.Text = row["Birthday"].ToString();
            txtAddress.Text = row["Address"].ToString();
            txtCompany.Text = row["Company"].ToString();
            txtRole.Text = row["Role"].ToString();
            txtLocation.Text = row["Location"].ToString();
            txtStatusContact.Text = row["Contact Status"].ToString();
            dateLastContact.Text = row["Last Contact"].ToString();
            dateNextContact.Text = row["Next Contact"].ToString();
            companyURLEditable.Text = row["Company URL"].ToString();
            FacebookEditable.Text = row["Facebook"].ToString();
            linkedinEditable.Text = row["Linkedin"].ToString();
            txtSkype.Text = row["Skype"].ToString();

            fillDataGridView();
            toggleEditable();
            loadNotes();
            start();
            toggleEdit.Focus();
        }
        private void loadNotes()
        {
            //pointerToStorageManager.getNotes(id);
            txtNotes.Text = pointerToStorageManager.storageLocation.loadNotes(id);

        }
        private void toggleEditable()
        {
            if (isEditable)
            {
                foreach (Control x in this.Controls)
                {
                    if ((x is TextBox && x.Name != "txtStatusContact")) 
                    {
                        TextBox text = ((TextBox)x);
                        text.BackColor = this.BackColor;
                        text.ReadOnly = true;
                        text.BorderStyle = BorderStyle.None;
                        //HideCaret(text.Handle);
                        //text.TabStop = false;
                        
                    }
                }
                dateBirthday.ReadOnly = true;
                txtNotes.ReadOnly = true;

                linkedinEditable.Visible = false;
                FacebookEditable.Visible = false;
                companyURLEditable.Visible = false;

                linkedinEditable.TabStop = false;
                FacebookEditable.TabStop = false;
                companyURLEditable.TabStop = false;

                linkLinkedin.TabStop = true;
                linkFacebook.TabStop = true;
                companyURL.TabStop = true;


                saveBtn.Visible = false;
                toggleEdit.Visible = true;
                isEditable = false;
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if ((x is TextBox && x.Name != "txtStatusContact"))
                    {
                        TextBox text = ((TextBox)x);
                        text.ReadOnly = false;
                        text.BackColor = Color.White;
                        text.BorderStyle = BorderStyle.FixedSingle;
                        //text.TabStop = true;
                    }
                }
                dateBirthday.ReadOnly = false;
                txtNotes.ReadOnly = false;

                linkedinEditable.Visible = true;
                FacebookEditable.Visible = true;
                companyURLEditable.Visible = true;

                linkedinEditable.TabStop = true;
                FacebookEditable.TabStop = true;
                companyURLEditable.TabStop = true;

                linkLinkedin.TabStop = false;
                linkFacebook.TabStop = false;
                companyURL.TabStop = false;

                saveBtn.Visible = true;
                toggleEdit.Visible = false;


                isEditable = true;
            }
            
        }
        private void toggleEdit_Click(object sender, EventArgs e)
        {
            toggleEditable();
        }
        private void profilePic_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.Filter = ("png|*.png") ;

            filename = openFileDialog.FileName;
            if (filename != null && filename != "")
            {
                try
                {
                    profilePic.Image.Dispose();
                }
                catch { }
                
                Image img = Image.FromFile(filename);
                if (id == 0)
                {
                    save();
                }
                pointerToStorageManager.storageLocation.saveImage(id, img);
            }
            loadImage();
            
        }
        private void addNew_Click(object sender, EventArgs e)
        {
            pointerToContactLog = new ContactLog(contactLogDataTable);
            pointerToMain.setContactLogPointer(pointerToContactLog);

            pointerToContactLog.WindowState = FormWindowState.Maximized;
            pointerToContactLog.MdiParent = pointerToMain;
            
            pointerToContactLog.setContactDetailPointer(this);
            pointerToContactLog.setMainPointer(pointerToMain);
            pointerToContactLog.setStorageManagerPointer(pointerToStorageManager);
            pointerToContactLog.Show();
        }
        private void save_Click(object sender, EventArgs e)
        {
            save();
            toggleEditable();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pointerToStorageManager.storageLocation.openFileExplorer(id);

        }
        public void loadContactStatusFromContactLog()
        {
            //DateTime lastDate = Convert.ToDateTime("0000/00/00");
            object lastDate = contactLogDataTable.Compute("MAX(Date)", null);

            string expression = "Date = '" + lastDate.ToString() + "'";
            DataRow[] rows = contactLogDataTable.Select(expression);
            if (rows.Length == 1)
            {
                DataRow row = rows[0];

                dateLastContact.Text = lastDate.ToString();
                dateNextContact.Text = row["Next Time"].ToString();
                txtStatusContact.Text = row["Status"].ToString();
            }
            save();
        }
        
    }

}

