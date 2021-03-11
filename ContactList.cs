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
using System.Timers;

namespace NetworkMgr
{
    public partial class ContactList : Form
    {
        private Main pointerToMain = null;
        private StorageManager pointerToStorageManager = null;
        private ContactDetail pointerToContactDetail = new ContactDetail();
        private string[] shownColumns;
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
        private void getHiddenAndShownColumns()
        {
            string columnsToParse = Config.myIni.Read("GENERAL", "hiddenColumns");
            string[] hiddenColumns = columnsToParse.Split(',');

            foreach (string column in hiddenColumns)
            {
                if (mainContactList.Columns.Contains(column))
                {
                    mainContactList.Columns[column].Visible = false;
                }

            }

            hiddenColumns.Append("Full Name");
            string[] allColumns = new string[mainContactList.ColumnCount];
            for (int i = 0; i < mainContactList.ColumnCount; i++)
            {
                allColumns[i] = mainContactList.Columns[i].HeaderText.ToString();
            }
            shownColumns = allColumns.Except(hiddenColumns).ToArray();
        }
        private void ContactList_Load(object sender, EventArgs e)
        {
            initialDataGridViewSetup();
            getHiddenAndShownColumns();

        }
        private void initialDataGridViewSetup()
        {
            mainContactList.DataSource = pointerToStorageManager.mainList;
            mergeName();

            mainContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            mainContactList.Sort(mainContactList.Columns["Full Name"], ListSortDirection.Ascending);
            mainContactList.Columns["Full Name"].SortMode = DataGridViewColumnSortMode.Automatic;

            if (mainContactList.Columns["Id"].Visible)
            {
                mainContactList.Columns["Id"].DisplayIndex = 0;
            }
            mainContactList.DoubleBuffered(true);

        }
        private void mainContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int selectedRow = mainContactList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //int selectedRow = e.RowIndex;
            enterDetail();
        }
        private void enterDetail()
        {
            int selectedRow = mainContactList.CurrentCell.RowIndex;


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

            if (mainContactList.Columns["Id"].Visible)
            {
                mainContactList.Columns["Full Name"].DisplayIndex = 1;
            }
            else
            {
                mainContactList.Columns["Full Name"].DisplayIndex = 0;
            }
            
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            searchInList();
        }

        private void searchInList()
        {
            //string[] shownColumns = mainContactList.Rows[-1];
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[mainContactList.DataSource];
            currencyManager1.SuspendBinding();

            mainContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            string searchFilter = search.Text.ToLower().Trim();
            int count = mainContactList.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = mainContactList.Rows[i];
                string rowContent = "";
                foreach (string x in shownColumns)
                {
                    rowContent += row.Cells[x].Value;
                }

                if (rowContent.ToLower().Contains(searchFilter))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            currencyManager1.ResumeBinding();
            mainContactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void lostFocus(object sender, EventArgs e)
        {
            mainContactList.ClearSelection();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && mainContactList.CurrentCell != null)
            {
                if(mainContactList.SelectedCells.Count == 1)
                {
                    enterDetail();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void columnSorted(object sender, DataGridViewColumnEventArgs e)
        {
            mainContactList.ClearSelection(); 
        }

        private void mainContactList_Sorted(object sender, EventArgs e)
        {
            mainContactList.ClearSelection();
        }
    }
}

