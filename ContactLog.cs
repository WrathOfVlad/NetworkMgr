using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NetworkMgr
{
    public partial class ContactLog : Form
    {
        public DataTable contactLogManager = null;
        private ContactDetail pointerToContactDetail = null;
        private StorageManager pointerToStorageManager = null;
        private Main pointerToMain = null;
        public ContactLog(DataTable contactLogManager)
        {
            this.contactLogManager = contactLogManager;
            //this.SetStyle(ControlStyles.BackColor, true);
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();
            InitializeComponent();
        }

        public void setMainPointer(Main pointerToMain)
        {
            this.pointerToMain = pointerToMain;
        }
        public void setStorageManagerPointer(StorageManager storageManager)
        {
            this.pointerToStorageManager = storageManager;
        }
        public void setContactDetailPointer(ContactDetail contactDetail)
        {
            this.pointerToContactDetail = contactDetail;
        }

        public void saveButton(object sender, EventArgs e)
        {
            save();

        }
        public void save()
        {
            DataRow row = contactLogManager.NewRow();
            row["Date"] = pointerToContactDetail.changeDateFormatting("yyyy/MM/dd", dateDate.Text);
            row["Actions"] = txtActions.Text;
            row["Next Time"] = pointerToContactDetail.changeDateFormatting("yyyy/MM/dd", dateNextTime.Text);
            row["Status"] = txtStatus.Text;
            row["Type"] = txtType.Text;
            row["Notes"] = txtNotes.Text;
            contactLogManager.Rows.Add(row);
            pointerToStorageManager.contactLogStorageLocation.save(contactLogManager);
            exit();
        }

        private void exit()
        {
            pointerToContactDetail.WindowState = FormWindowState.Maximized;
            pointerToContactDetail.MdiParent = pointerToMain;
            pointerToContactDetail.loadContactStatusFromContactLog();
            pointerToContactDetail.Show();
            pointerToMain.setContactLogPointer(null);
            //pointerToMain.pointerToContactLog = null;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
