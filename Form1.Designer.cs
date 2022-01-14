namespace Note_Taking_Calculator_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleButton = new System.Windows.Forms.Label();
            this.noteButton = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleButton
            // 
            this.titleButton.AutoSize = true;
            this.titleButton.Location = new System.Drawing.Point(41, 47);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(29, 15);
            this.titleButton.TabIndex = 0;
            this.titleButton.Text = "Title";
            // 
            // noteButton
            // 
            this.noteButton.AutoSize = true;
            this.noteButton.Location = new System.Drawing.Point(41, 96);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(34, 15);
            this.noteButton.TabIndex = 1;
            this.noteButton.Text = "Body";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(100, 44);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(456, 23);
            this.titleText.TabIndex = 2;
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(100, 88);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(456, 269);
            this.bodyText.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(590, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(278, 318);
            this.dataGridView1.TabIndex = 4;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(100, 380);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(181, 380);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(262, 380);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 7;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.Location = new System.Drawing.Point(343, 380);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 476);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.titleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleButton;
        private Label noteButton;
        private TextBox titleText;
        private TextBox bodyText;
        private DataGridView dataGridView1;
        private Button newButton;
        private Button saveButton;
        private Button readButton;
        private Button deleteButton;
    }
}