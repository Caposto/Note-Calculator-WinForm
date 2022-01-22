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
            //table.Columns.Add("Title", typeof(string));
            //table.Columns.Add("Body", typeof(string));

            DataSet xmlFiles = new DataSet();
            xmlFiles.ReadXml(@"C:\Users\chris\OneDrive\Documents\Notes");
            dataGridView1.DataSource = xmlFiles.Tables[0].DefaultView;

            // Hides the body column in table
            //dataGridView1.Columns["Body"].Visible = false;

            // Adjust title column width
            //dataGridView1.Columns["Title"].Width = 275;

            
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