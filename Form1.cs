using System.Data;

namespace Note_Taking_Calculator_App
{
    public partial class Form1 : Form
    {
        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Body", typeof(string));
            dataGridView1.DataSource = table;
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
        private void readButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            // Any file that is selectable will have an index >= 0
            if (index > -1)
            {
                titleText.Text = table.Rows[index].ItemArray[0].ToString();
                bodyText.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        // Deletes a note when delete button is pressed
        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            // table.Rows.RemoveAt(index);

            table.Rows[index].Delete();
        }
    }
}