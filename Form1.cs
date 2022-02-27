using System.Data;
using System.Xml;

namespace Note_Taking_Calculator_App
{
    public partial class Form1 : Form
    {
        private static string NoteDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Notes\WinFormsNotes\";
        private DirectoryInfo Dir = new DirectoryInfo(NoteDirectory);

        // For activating and deactivating lists
        private bool bulletList = false;

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
                // Initialize the Font Selection
                foreach (FontFamily Font in FontFamily.Families)
                {
                    fontBox.Items.Add(Font.Name.ToString());
                }

                // Get only .rtf files
                FileInfo[] rtfDocs = Dir.GetFiles("*.rtf");

                // Display the current notes
                if (rtfDocs.Count() != 0)
                {
                    dataGridView1.DataSource = rtfDocs;

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
                // If notes direcotry is empty prompt user to make a note
                else
                {
                    titleText.Text = "Press New to Make a Note!";
                }
            }
            // If no notes folder found, make one titled WinFormsNotes
            else
            {
                titleText.Text = "Created a new folder for your notes @" + NoteDirectory;
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
            if (!String.IsNullOrEmpty(titleText.Text))
            {
                string fileName = titleText.Text + ".rtf";
                if (File.Exists(NoteDirectory + fileName))
                {
                   if (MessageBox.Show("File Name Already Exists. Would you like to Overwrite?", "Important", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                        bodyText.SaveFile(NoteDirectory + fileName);
                        updateNotes();
                        clearText();
                   }
                }
                else
                {
                    bodyText.SaveFile(NoteDirectory + fileName);
                    updateNotes();
                    clearText();
                }
            }
            else
            {
                throwMsgBoxError("Need a title!");
            }
        }

        // Read/Edit a note when read button clicked
        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Index is equal to that of the cell selected
                int index = dataGridView1.CurrentCell.RowIndex;
                string selectedFileName = dataGridView1.Rows[index].Cells["Name"].Value.ToString();
                // -4 trims the ".rtf" part of the file
                titleText.Text = selectedFileName.Substring(0, selectedFileName.Length - 4);
                bodyText.LoadFile(NoteDirectory + selectedFileName);
            }
            // If read is clicked with no file selected
            catch (NullReferenceException)
            {
                throwMsgBoxError("Select a file to read!");
            }
            catch (IOException)
            {
                throwMsgBoxError("File is open in antoher application! Close to read.");
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
                clearText();
            }
            catch (NullReferenceException)
            {
                throwMsgBoxError("Select a file to delete.");
            }
        }

        // Bold
        private void boldButton_Click(object sender, EventArgs e)
        {
            if (bodyText.SelectionFont != null)
            {
                Font currentFont = bodyText.SelectionFont;
                FontStyle newFontStyle;
                if (bodyText.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                    underlineButton.BackColor = SystemColors.Control;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                    underlineButton.BackColor = SystemColors.ControlDark;
                }
                bodyText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // Italicize
        private void italicsButton_Click(object sender, EventArgs e)
        {
            if (bodyText.SelectionFont != null)
            {
                Font currentFont = bodyText.SelectionFont;
                FontStyle newFontStyle;
                if (bodyText.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                    underlineButton.BackColor = SystemColors.Control;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                    underlineButton.BackColor = SystemColors.ControlDark;
                }
                bodyText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // Underline
        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (bodyText.SelectionFont != null)
            {
                Font currentFont = bodyText.SelectionFont;
                FontStyle newFontStyle;
                if (bodyText.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                    underlineButton.BackColor = SystemColors.Control;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                    underlineButton.BackColor = SystemColors.ControlDark;
                }
                bodyText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // For changing the font type
        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodyText.SelectionFont != null)
            {
                bodyText.SelectionFont = new Font(fontBox.Text, fontBox.Font.Size);
            }
        }

        // For changing the font size
        private void fontSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodyText.SelectionFont != null)
            {
                Font currentFont = bodyText.SelectionFont;
                if (fontSizeBox.SelectedItem != null)
                {
                    float selectedSize = float.Parse(fontSizeBox.SelectedItem.ToString());
                    bodyText.SelectionFont = new Font(currentFont.FontFamily, selectedSize);
                }
            }
        }

        // Creates a bulleted list over selected text
        private void bulletButton_Click(object sender, EventArgs e)
        {
            if (!bulletList)
            {
                bodyText.SelectionBullet = true;
                bulletList = true;
            }
            else
            {
                bodyText.SelectionBullet = false;
                bulletList = false;
            }
        }

        // Used in the read and delete methods, updates the notes displayed gathering only .xml files
        private void updateNotes()
        {
            dataGridView1.DataSource = Dir.GetFiles("*.rtf");
        }

        // Used in the new and save methods, clear texts in both the title and body text boxes
        private void clearText()
        {
            titleText.Clear();
            bodyText.Clear();
        }

        private void throwMsgBoxError(String errorMsg)
        {
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
