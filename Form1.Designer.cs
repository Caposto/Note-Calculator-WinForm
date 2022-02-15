﻿namespace Note_Taking_Calculator_App
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
            this.bodyText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titleButton = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicsButton = new System.Windows.Forms.Button();
            this.underlineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(138, 112);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(456, 269);
            this.bodyText.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteButton.Location = new System.Drawing.Point(381, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // titleButton
            // 
            this.titleButton.AutoSize = true;
            this.titleButton.Location = new System.Drawing.Point(79, 71);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(29, 15);
            this.titleButton.TabIndex = 9;
            this.titleButton.Text = "Title";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(300, 404);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 16;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.AutoSize = true;
            this.noteButton.Location = new System.Drawing.Point(79, 120);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(34, 15);
            this.noteButton.TabIndex = 10;
            this.noteButton.Text = "Body";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(219, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(138, 68);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(456, 23);
            this.titleText.TabIndex = 11;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(138, 404);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 14;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(629, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(277, 313);
            this.dataGridView1.TabIndex = 13;
            // 
            // boldButton
            // 
            this.boldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldButton.Location = new System.Drawing.Point(79, 149);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(29, 23);
            this.boldButton.TabIndex = 18;
            this.boldButton.Text = "B";
            this.boldButton.UseVisualStyleBackColor = true;
            // 
            // italicsButton
            // 
            this.italicsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicsButton.Location = new System.Drawing.Point(79, 178);
            this.italicsButton.Name = "italicsButton";
            this.italicsButton.Size = new System.Drawing.Size(29, 23);
            this.italicsButton.TabIndex = 19;
            this.italicsButton.Text = "I";
            this.italicsButton.UseVisualStyleBackColor = true;
            // 
            // underlineButton
            // 
            this.underlineButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underlineButton.Location = new System.Drawing.Point(79, 207);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(29, 23);
            this.underlineButton.TabIndex = 20;
            this.underlineButton.Text = "U";
            this.underlineButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.underlineButton);
            this.Controls.Add(this.italicsButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox bodyText;
        private Button deleteButton;
        private Label titleButton;
        private Button readButton;
        private Label noteButton;
        private Button saveButton;
        private TextBox titleText;
        private Button newButton;
        private DataGridView dataGridView1;
        private Button boldButton;
        private Button italicsButton;
        private Button underlineButton;
    }
}