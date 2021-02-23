using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using System.IO;

//test

namespace NetworkMgr
{
    public partial class Main : Form
    {
        private ContactList pointerToContactList = new ContactList();
        private StorageManager pointerToStorageManager = new StorageManager();
        private ContactDetail pointerToContactDetail = null;
        private ContactLog pointerToContactLog = null;
        private const String APP_ID = "Network Manager";
        public Main()
        {
            InitializeComponent();
            
            pointerToStorageManager.getConfig();

            pointerToContactList.setStoragePointer(pointerToStorageManager);
            pointerToContactList.setMainPointer(this);
            pointerToStorageManager.mainList = pointerToStorageManager.storageLocation.load();

            pointerToContactList.initiateContactDetail();

        }
        public void setContactDetailPointer(ContactDetail contactDetail)
        {
            this.pointerToContactDetail = contactDetail;
        }
        public void setContactLogPointer(ContactLog contactLog)
        {
            this.pointerToContactLog = contactLog;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openContactList();

        }
        public void openContactList()
        {
            if (pointerToContactDetail != null && pointerToContactDetail.Visible)
            {
                pointerToContactDetail.Hide();
            }
            pointerToContactList.WindowState = FormWindowState.Maximized;
            pointerToContactList.MdiParent = this;
            pointerToContactList.Show();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pointerToContactList.WindowState = FormWindowState.Maximized;
            //pointerToContactList.MdiParent = this;
            //pointerToContactList.Show();
            pointerToContactList.addNewContact();
        }
        private void saveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void checkIfTodayNeedsANotification(string dateColumnName, string notificationMessage, string toastNotificationHeader)
        {
            DateTime date = DateTime.Today;
            string today = date.ToString("yyyy-MM-dd");

            string expression = String.Format("[{0}]='{1}'", dateColumnName,today);
            DataRow[] rows = pointerToStorageManager.mainList.Select(expression);

            foreach (DataRow row in rows)
            {
                string formattedNotification = String.Format(notificationMessage, row["Name"] + " " + row["Surname"]);
                sendNotification(toastNotificationHeader, formattedNotification);
            }


            
        }
        private void sendNotification(string header, string content)
        {
            var template = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            var textNodes = template.GetElementsByTagName("text");

            textNodes[0].AppendChild(template.CreateTextNode(header));
            textNodes[1].AppendChild(template.CreateTextNode(content));
            //textNodes[2].AppendChild(template.CreateTextNode(p1));

            XmlNodeList toastImageElements = template.GetElementsByTagName("image");


            string tempPath = Path.GetTempFileName();
            Image image = Icon.ToBitmap();
            image.Save(tempPath);

            ((XmlElement)toastImageElements[0]).SetAttribute("src", tempPath);

            
            IXmlNode toastNode = template.SelectSingleNode("/toast");
            ((XmlElement)toastNode).SetAttribute("duration", "long");

            var notifier = ToastNotificationManager.CreateToastNotifier(APP_ID);
            var notification = new ToastNotification(template);

            notifier.Show(notification);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            checkIfTodayNeedsANotification("Birthday", "It's {0}'s birthday!","Birthday Notification");
            checkIfTodayNeedsANotification("Next Contact", "You scheduled a meeting with {0} today.", "Meeting Notification");
            openContactList();
        }
    }
}
