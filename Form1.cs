using System.Data;
using System.Xml;

namespace Note_Taking_Calculator_App
{
    public partial class Form1 : Form
    {
        private static string NoteDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Notes\WinFormsNotes\";
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        // FIXME: Refactor and cleanup (for tomorrow 1/23)
        // FIXME: Get Notes to say "Title" Instead of "Name"
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Accesses xmls but only works for 1 file at a time
            // DataSet xmlFiles = new DataSet();
            // xmlFiles.ReadXml(@"C:\Users\chris\OneDrive\Documents\Notes\Scratchpad.xml");
            // dataGridView1.DataSource = xmlFiles.Tables[0].DefaultView;

            string folderPath = @"C:\Users\chris\OneDrive\Documents\Notes\WinFormsNotes";
            dataGridView1.DataSource = new System.IO.DirectoryInfo(folderPath).GetFiles();

            // Hides unwanted columns
            // dataGridView1.Columns["Body"].Visible = false;
            // Length, DirectoryName, Directory, IsReadOnly, FullName, Extension, Exists, CreationTime, CreationTimeUTC
            // LastAccessTime, LastAccessTimeUTC, LastWriteTime, LastWriteTimeUTC, LinkTarget, Attributes

            string[] hiddenColumns = new string[] { "Length", "DirectoryName", "Directory", "IsReadOnly",
                                                    "FullName", "Extension", "Exists", "CreationTime",
                                                    "CreationTimeUTC", "LastAccessTime","LastAccessTimeUTC",
                                                    "LastWriteTime", "LastWriteTimeUTC", "LinkTarget", "Attributes"};

            foreach (string hiddenColumn in hiddenColumns)
            {
                dataGridView1.Columns[hiddenColumn].Visible = false;
            }

            // Adjust title column width
            dataGridView1.Columns["Name"].Width = 275;
        }

        // Creates a new file by clearing text displays (to create xml hit save button)
        private void newButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            bodyText.Clear();
        }

        // Save a note on save button press by creating a new xml file in the Note Directory
        // FIXME: Saving a new note does not update the notes displayed
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Create a new .xml file
            XmlWriterSettings NoteSettings = new XmlWriterSettings();

            NoteSettings.CheckCharacters = false;
            NoteSettings.ConformanceLevel = ConformanceLevel.Auto;
            NoteSettings.Indent = true;

            string fileName = titleText.Text + ".xml";

            using (XmlWriter NewNote = XmlWriter.Create(NoteDirectory + fileName, NoteSettings))
            {
                NewNote.WriteStartDocument();
                NewNote.WriteStartElement("Title");
                NewNote.WriteElementString("body", bodyText.Text);
                NewNote.WriteEndElement();
                NewNote.Flush();
                NewNote.Close();
            }

            // Update data table
            string folderPath = @"C:\Users\chris\OneDrive\Documents\Notes\WinFormsNotes";
            dataGridView1.DataSource = new System.IO.DirectoryInfo(folderPath).GetFiles();

            // Clear text
            titleText.Clear();
            bodyText.Clear();
        }

        // Read/Edit a note when read button clicked
        private void readButton_Click_1(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index >= 0)
            {
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                bodyText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        // Deletes a note when delete button is pressed
        // FIXME: Need an exception for when hitting delete button with nothing selected
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows.RemoveAt(index);
        }
    }
}