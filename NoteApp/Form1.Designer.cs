namespace NoteApp
{
    partial class NoteApp
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadNote = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            this.saveNote = new System.Windows.Forms.Button();
            this.newNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(390, 28);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(398, 23);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(390, 82);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(398, 356);
            this.noteBox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(392, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Title: ";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Note
            // 
            this.Note.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Note.Location = new System.Drawing.Point(392, 56);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(134, 23);
            this.Note.TabIndex = 3;
            this.Note.Text = "Note:";
            this.Note.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowTemplate.Height = 25;
            this.previousNotes.Size = new System.Drawing.Size(330, 344);
            this.previousNotes.TabIndex = 4;
            // 
            // loadNote
            // 
            this.loadNote.Location = new System.Drawing.Point(12, 362);
            this.loadNote.Name = "loadNote";
            this.loadNote.Size = new System.Drawing.Size(155, 39);
            this.loadNote.TabIndex = 5;
            this.loadNote.Text = "Load";
            this.loadNote.UseVisualStyleBackColor = true;
            this.loadNote.Click += new System.EventHandler(this.LoadNote_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.Location = new System.Drawing.Point(187, 362);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(155, 39);
            this.deleteNote.TabIndex = 6;
            this.deleteNote.Text = "Delete";
            this.deleteNote.UseVisualStyleBackColor = true;
            this.deleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // saveNote
            // 
            this.saveNote.Location = new System.Drawing.Point(187, 407);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(155, 39);
            this.saveNote.TabIndex = 7;
            this.saveNote.Text = "Save";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.SaveNote_Click);
            // 
            // newNote
            // 
            this.newNote.Location = new System.Drawing.Point(12, 407);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(155, 39);
            this.newNote.TabIndex = 8;
            this.newNote.Text = "New Note ";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.NewNote_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNote);
            this.Controls.Add(this.saveNote);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.loadNote);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteApp";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.NoteApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label Title;
        private Label Note;
        private DataGridView previousNotes;
        private Button loadNote;
        private Button deleteNote;
        private Button saveNote;
        private Button newNote;
    }
}