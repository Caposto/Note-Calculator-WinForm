using System.Data;

namespace Note_Taking_Calculator_App
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        // FIXME: Can only read one xml file at a time due to accessibility
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Accesses xmls but only works for 1 file at a time
            // DataSet xmlFiles = new DataSet();
            // xmlFiles.ReadXml(@"C:\Users\chris\OneDrive\Documents\Notes\Scratchpad.xml");
            // dataGridView1.DataSource = xmlFiles.Tables[0].DefaultView;

            string folderPath = @"C:\Users\chris\OneDrive\Documents\Notes";
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

        // Creates a new note by clearing text in the title and body text boxes
        private void newButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            bodyText.Clear();
        }

        // Save a note on save button press by adding it to data table
        private void saveButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titleText.Text, bodyText.Text);

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