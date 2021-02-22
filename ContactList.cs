using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace NetworkMgr
{
    public partial class ContactList : Form
    {
        private Main pointerToMain = null;
        private StorageManager pointerToStorageManager = null;
        private ContactDetail pointerToContactDetail = new ContactDetail();
        public ContactList()
        {
            InitializeComponent();
        }
        public void initiateContactDetail()
        {
            //pointerToContactDetail =;
            pointerToContactDetail.setMainPointer(pointerToMain);
            pointerToContactDetail.setContactListPointer(this);
            pointerToContactDetail.setStoragePointer(pointerToStorageManager);

            pointerToContactDetail.WindowState = FormWindowState.Maximized;
            pointerToContactDetail.MdiParent = pointerToMain;
            pointerToMain.setContactDetailPointer(pointerToContactDetail);
            
        }
        public void addNewContact()
        {
            //initiateContactDetail();
            pointerToContactDetail.SuspendLayout();
            pointerToContactDetail.newContact();
        }
        public void setMainPointer(Main pointerToMain)
        {
            this.pointerToMain = pointerToMain;
        }
        public void setStoragePointer(StorageManager pointerToStorageManager)
        {
            this.pointerToStorageManager = pointerToStorageManager;
        }
        private void ContactList_Load(object sender, EventArgs e)
        {
            //initiateContactDetail();

            mainContactList.DataSource = pointerToStorageManager.mainList;
            mergeName();
            mainContactList.Columns["Full Name"].DisplayIndex = 0;

            mainContactList.Sort(mainContactList.Columns["Full Name"], ListSortDirection.Ascending);

            mainContactList.Columns["Full Name"].SortMode = DataGridViewColumnSortMode.Automatic;

            mainContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string columnsToParse = Config.myIni.Read("GENERAL", "hiddenColumns");
            string[] hiddenColumns = columnsToParse.Split(',');

            foreach (string column in hiddenColumns)
            {
                if (mainContactList.Columns.Contains(column))
                {
                    mainContactList.Columns[column].Visible = false;
                }
                
            }
           
            
        }
        private void mainContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRow = mainContactList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRow = e.RowIndex;
            
            if (selectedRow != -1)
            {
                DataGridViewRow row = mainContactList.Rows[selectedRow];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                pointerToContactDetail.SuspendLayout();
                pointerToContactDetail.loadDetail(id);
            }


        }
        public void mergeName()
        {
            pointerToStorageManager.mainList.Columns.Add("Full Name", typeof(string), "Name+' '+Surname");
            mainContactList.Columns["Name"].Visible = false;
            mainContactList.Columns["Surname"].Visible = false;
            mainContactList.Columns["Full Name"].DisplayIndex = 0;
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            
            string columnsToParse = Config.myIni.Read("GENERAL", "hiddenColumns");
            string[] hiddenColumns = columnsToParse.Split(',');
            hiddenColumns.Append("Full Name");
            string[] allColumns = new string[mainContactList.ColumnCount];
            for (int i = 0; i < mainContactList.ColumnCount; i++)
            {
                allColumns[i] = mainContactList.Columns[i].HeaderText.ToString() ;
            }
            string[] shownColumns = allColumns.Except(hiddenColumns).ToArray();

            //string[] shownColumns = mainContactList.Rows[-1];
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[mainContactList.DataSource];
            currencyManager1.SuspendBinding();

            for (int i = 0; i < mainContactList.Rows.Count; i++)
            {
                mainContactList.Rows[i].Visible = false;
                foreach(string x in shownColumns)
                {
                    DataGridViewRow row = mainContactList.Rows[i];
                    row.Cells[x].Value.ToString();
                    if (row.Cells[x].Value.ToString().ToLower().Contains(search.Text.ToLower()))
                    {
                        mainContactList.Rows[i].Visible = true;
                    }
                }
            }
            currencyManager1.ResumeBinding();

        }
    }
}

