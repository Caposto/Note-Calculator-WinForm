using System.Data;
using System.Xml;

namespace Note_Taking_Calculator_App
{
    public partial class Form1 : Form
    {
        private static string NoteDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Notes\WinFormsNotes\";
        private DirectoryInfo Dir = new DirectoryInfo(NoteDirectory);

        public Form1()
        {
            InitializeComponent();
        }

        // Load Form and connect or create notes folder on local machine to the application
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Check to see if user has a notes folder
            if (Directory.Exists(NoteDirectory))
            {
                // Get only .xml files
                FileInfo[] xmlDocs = Dir.GetFiles("*.xml");

                if (xmlDocs.Count() != 0)
                {
                    dataGridView1.DataSource = xmlDocs;

                    // Hide unwanted columns
                    string[] hiddenColumns = new string[] { "Length", "DirectoryName", "Directory", "IsReadOnly",
                                                    "FullName", "Extension", "Exists", "CreationTime",
                                                    "CreationTimeUTC", "LastAccessTime","LastAccessTimeUTC",
                                                    "LastWriteTime", "LastWriteTimeUTC", "LinkTarget", "Attributes"};

                    foreach (string hiddenColumn in hiddenColumns)
                    {
                        dataGridView1.Columns[hiddenColumn].Visible = false;
                    }

                    // Adjust title column width and change the name of the column
                    dataGridView1.Columns["Name"].HeaderText = "Title";
                    dataGridView1.Columns["Name"].Width = 275;
                }
                else
                {
                    titleText.Text = "Press New to Make a Note!";
                }
            }
            // If no notes folder found, make one title WinFormsNotes
            else
            {
                titleText.Text = "Created a new folder for your Notes!";
                Directory.CreateDirectory(NoteDirectory);
            }
        }

        // Creates a new file by clearing text displays (to actually create xml hit save button)
        private void newButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        // Save a note on save button press by creating a new xml file in the Note Directory
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

            updateNotes();
            clearText();
        }

        // Read/Edit a note when read button clicked
        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Index is equal to that of the cell selected
                int index = dataGridView1.CurrentCell.RowIndex;
                string selectedFileName = dataGridView1.Rows[index].Cells["Name"].Value.ToString();
                // -4 trims the ".xml" part of the file
                titleText.Text = selectedFileName.Substring(0, selectedFileName.Length - 4);
                XmlDocument doc = new XmlDocument();

                doc.Load(NoteDirectory + selectedFileName);
                bodyText.Text = doc.SelectSingleNode("//body").InnerText;
            }
            catch (NullReferenceException)
            {
                titleText.Text = "Select a file to read!";
            }
        }

        // Deletes a note when delete button is pressed
        private void deleteButton_Click(object sender, EventArgs e)
        { 
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                string selectedFileName = dataGridView1.Rows[index].Cells["Name"].Value.ToString();
                File.Delete(NoteDirectory + selectedFileName);
                updateNotes();
            }
            catch (NullReferenceException)
            {
                titleText.Text = "Cannot delete nothing!";
            }

        }

        // Used in the read and delete methods, updates the notes displayed gathering only .xml files
        private void updateNotes()
        {
            dataGridView1.DataSource = Dir.GetFiles("*.xml");
        }

        // Used in the new and save methods, clear texts in both the title and body text boxes
        private void clearText()
        {
            titleText.Clear();
            bodyText.Clear();
        }
    }
}