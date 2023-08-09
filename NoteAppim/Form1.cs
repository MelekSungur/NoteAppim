using System.Data;

namespace NoteAppim
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool edditing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            PreviousNotes.DataSource = notes;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yükle butonu
            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            edditing = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete button
            try
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception) { Console.WriteLine("Silinece Notu Seçin!"); }
            {

            }
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NoteBox.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (edditing)
            {
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNotes.CurrentCell.RowIndex]["Notes"] = TitleBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text
                    );
            }
            TitleBox.Text = "";
            NoteBox.Text = "";
            edditing = false;
        }

        private void PreviousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TitleBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            edditing = true;
        }
    }
}