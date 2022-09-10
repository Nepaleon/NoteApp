using System.Data;
using System.Windows.Forms; 

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        DataTable notes = new DataTable(); //going to act as BackandTable for the DataGridView 
        bool editing = false;
        public NoteApp()
        {
            InitializeComponent();
        }
        private void NoteApp_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void DeleteNote_Click(object sender, EventArgs e)
        {

        }

        private void SaveNote_Click(object sender, EventArgs e)
        {

        }

        private void NewNote_Click(object sender, EventArgs e)
        {

        }

        private void LoadNote_Click(object sender, EventArgs e)
        {

        }
    }
}