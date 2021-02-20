using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;  
using CsvHelper;
using System.Globalization;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace NetworkMgr
{
    public static class Config
    {
        //private static string testPath = @"C:\Network Management\config.ini";
        private static string directory = Directory.GetCurrentDirectory();
        public static Ini.IniFile myIni = new Ini.IniFile(directory + @"\config.ini");
        public static string getIdDirectory(int id)
        {
            string stringId = id.ToString();
            int neededZeroes = 5 - stringId.Length;

            string dirName = "";
            for (int i = 0; i < neededZeroes; i++)
            {
                dirName += "0";

            }
            dirName += stringId;
            return dirName;
        }
    }
    public class StorageManager
    {
        //public DataTable mainList = new DataTable();
        public System.Data.DataTable mainList{get;set;}
        public ProductBase storageLocation = null;
        public ProductBase contactLogStorageLocation = null;
        public ProductBase notesStorageLocation = null;

        public void getConfig()
        {
            string storageType = Config.myIni.Read("GENERAL", "storageType");

            FactoryBase storage = new StorageSelectorFactory();
            storageLocation = storage.FactoryMethod(storageType);

            if (storageType == "csv"){
                string path = Config.myIni.Read("CSV", "path");
                path += "Main.csv";
                CSVManager csvlocator = (CSVManager)storageLocation;
                csvlocator.path = path;
            }
        }

        public System.Data.DataTable getContactLog(int id)
        {
            string storageType = Config.myIni.Read("GENERAL", "storageType");

            FactoryBase tempStorage = new StorageSelectorFactory();
            contactLogStorageLocation = tempStorage.FactoryMethod(storageType);

            if (storageType == "csv")
            {
                string path = Config.myIni.Read("CSV", "path");
                CSVManager csvlocator = (CSVManager)contactLogStorageLocation;

                string dirName = Config.getIdDirectory(id);
                csvlocator.path = path + dirName + @"\contactLog.csv";
            }
            System.Data.DataTable contactLog;
            //contactLog = contactLogStorageLocation.load();
            try
            {
                contactLog = contactLogStorageLocation.load();
            }
            catch
            {
                contactLog = new System.Data.DataTable();
                contactLog.Columns.Add("Date");
                contactLog.Columns.Add("Type");
                contactLog.Columns.Add("Notes");
                contactLog.Columns.Add("Next Time");
                contactLog.Columns.Add("Actions");
                contactLog.Columns.Add("Status");
                contactLog.Rows.Add();
                contactLogStorageLocation.save(contactLog);
            }
            return contactLog;
        }
        public void getNotes(int id)
        {
            string storageType = Config.myIni.Read("GENERAL", "storageType");

            FactoryBase tempStorage = new StorageSelectorFactory();
            notesStorageLocation = tempStorage.FactoryMethod(storageType);
            if (storageType == "csv")
            {
                string path = Config.myIni.Read("CSV", "path");
                CSVManager notesLocator = (CSVManager)notesStorageLocation;

                string dirName = Config.getIdDirectory(id);
                notesLocator.path = path + dirName + @"\notes.docx";
            }
        }


    }
    public class ContactLogManager
    {
    }
    public abstract class FactoryBase
    {
        public abstract ProductBase FactoryMethod(string type);
    }
    public class StorageSelectorFactory : FactoryBase
    {
        public string storageType { get; set; }
        public override ProductBase FactoryMethod(string storageType)
        {
            switch (storageType)
            {
                case "csv": return new CSVManager();
                //case "sql lite": return new sqlLiteManager();
                default: throw new ArgumentException("Invalid Storage Selection");
            }
        }
        

    }
    public abstract class ProductBase
    { 
        public string storageType; //default
        public abstract void save(System.Data.DataTable dtDataTable);
        public abstract System.Data.DataTable load();
        public abstract Image getImage(int id);
        public abstract void saveImage(int id, Image image);
        public abstract void addNewContact(int id);
        //public abstract string loadNotes();
        public abstract void openFileExplorer(int id);
    }
    public class CSVManager : ProductBase
    {
        public string path{ get; set; }
        public CSVManager()
        {
            this.storageType = "csv";
        }
        public override System.Data.DataTable load()
        {
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    csv.Read();
                    csv.ReadHeader();
                    foreach (var header in csv.Context.Reader.HeaderRecord)
                    {
                        table.Columns.Add(header);
                    }
                    while (csv.Read())
                    {
                        var row = table.NewRow();
                        foreach (DataColumn column in table.Columns)
                        {
                            row[column.ColumnName] = csv.GetField(column.DataType, column.ColumnName);
                        }
                        table.Rows.Add(row);
                    }
                    return table;
                }
            }
        }
        /*
        public override string loadNotes()
        {
            using(MemoryStream ms = new MemoryStream())
            {
                object readOnly = false;
                object visibility = true;
                object fileName = path;
                object newTemplate = false;
                object docType = 0;
                object missing = Type.Missing;
                string notes;
                if (File.Exists(path))
                {
                    Document document;
                    _Application application = new Word.Application() { Visible = false };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visibility, ref missing, ref missing, ref missing, ref missing);

                    
                    document.Save(ms, FormatType.Rtf);

                    return ms.ToString();
                    /*
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    notes = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                    
                }
                else
                {
                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    //Set animation status for word application  
                    winword.ShowAnimation = false;

                    //Set status for word application is to be visible or not.  
                    winword.Visible = false;

                    //Create a new document  
                    Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    notes = dataObject.GetData(DataFormats.Rtf).ToString();
                    document.SaveAs2(ref fileName);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    //winword.Quit(ref missing, ref missing, ref missing);

                }
                return (ms.ToString());
            }

            
            //return notes;

        }
        */
        public override void save(System.Data.DataTable table)
        {
            if (table.Columns["Full Name"] != null)
            {
                table.Columns.Remove("Full Name");
            }
            using (var textWriter = File.CreateText(path))
            using (var csv = new CsvWriter(textWriter,CultureInfo.InvariantCulture))
            {
                // Write columns
                foreach (DataColumn column in table.Columns)
                {
                    csv.WriteField(column.ColumnName);
                }
                csv.NextRecord();

                // Write row values
                foreach (DataRow row in table.Rows)
                {
                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        csv.WriteField(row[i]);
                    }
                    csv.NextRecord();
                }
            }
        }
        public override void addNewContact(int id)
        {
            string newPath = Config.myIni.Read("CSV", "path");
            string dirName = Config.getIdDirectory(id);


            System.IO.Directory.CreateDirectory(newPath + dirName);
        }
        public override Image getImage(int id)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                string newPath = Config.myIni.Read("CSV", "path");
                string dirName = newPath;
                dirName += Config.getIdDirectory(id);
                Image image;
                try
                {
                    DirectoryInfo directory = new DirectoryInfo(dirName);

                //Using Union

                    FileInfo[] files = directory.GetFiles("*.jpg")
                                                .Union(directory
                                                .GetFiles("*.png"))
                                                .ToArray();

                    string imagePath = files[0].FullName;

                        image = Image.FromFile(imagePath);
                }
                catch
                {
                    image = Image.FromFile(newPath + "NoProfilePicture.png");
                }
                return image;
                
                
            }
        }
        public override void saveImage(int id, Image image)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {

                string newPath = Config.myIni.Read("CSV", "path");
                string dirName = Config.getIdDirectory(id);
                dirName = newPath + dirName;
                dirName += @"\picture.png";
                //try
                //{
                    if (File.Exists(dirName))
                    {
                        File.Delete(dirName);
                    }
                    image.Save(dirName);
                //}
                //catch{ MessageBox.Show("Failure to load"); }
            }
        }
        public override void openFileExplorer(int id)
        {
            string path = Config.myIni.Read("CSV", "path");
            path += Config.getIdDirectory(id);
            Process.Start("explorer.exe", path);
        }
    }
}
namespace Ini
{
    /// <summary>
    /// Create a New INI file to store or load data
    /// </summary>
    public class IniFile
    {
        public string path;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
                 string key, string def, StringBuilder retVal,
            int size, string filePath);

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <PARAM name="INIPath"></PARAM>
        public IniFile(string INIPath)
        {
            path = INIPath;
        }
        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// Section name
        /// <PARAM name="Key"></PARAM>
        /// Key Name
        /// <PARAM name="Value"></PARAM>
        /// Value Name
        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <PARAM name="Section"></PARAM>
        /// <PARAM name="Key"></PARAM>
        /// <PARAM name="Path"></PARAM>
        /// <returns></returns>
        public string Read(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp,
                                            255, this.path);
            return temp.ToString();

        }
    }
}