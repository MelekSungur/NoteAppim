namespace NoteAppim
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
            PreviousNotes = new DataGridView();
            label1 = new Label();
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            saveButton = new Button();
            NewNote = new Button();
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).BeginInit();
            SuspendLayout();
            // 
            // PreviousNotes
            // 
            PreviousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNotes.BackgroundColor = SystemColors.ButtonHighlight;
            PreviousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNotes.Location = new Point(12, 12);
            PreviousNotes.Name = "PreviousNotes";
            PreviousNotes.RowHeadersWidth = 51;
            PreviousNotes.RowTemplate.Height = 29;
            PreviousNotes.Size = new Size(528, 361);
            PreviousNotes.TabIndex = 0;
            PreviousNotes.CellDoubleClick += PreviousNotes_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Başlık";
            label1.Click += label1_Click;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(562, 30);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(362, 27);
            TitleBox.TabIndex = 2;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(562, 92);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(362, 281);
            NoteBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "Not";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(12, 393);
            button1.Name = "button1";
            button1.Size = new Size(218, 54);
            button1.TabIndex = 5;
            button1.Text = "Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 393);
            button2.Name = "button2";
            button2.Size = new Size(218, 54);
            button2.TabIndex = 6;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(322, 464);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(218, 54);
            saveButton.TabIndex = 7;
            saveButton.Text = "Kaydet";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // NewNote
            // 
            NewNote.Location = new Point(12, 464);
            NewNote.Name = "NewNote";
            NewNote.Size = new Size(218, 54);
            NewNote.TabIndex = 8;
            NewNote.Text = "YEni Not";
            NewNote.UseVisualStyleBackColor = true;
            NewNote.Click += NewNote_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1032, 530);
            Controls.Add(NewNote);
            Controls.Add(saveButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            Controls.Add(label1);
            Controls.Add(PreviousNotes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PreviousNotes;
        private Label label1;
        private TextBox TitleBox;
        private TextBox NoteBox;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button saveButton;
        private Button NewNote;
    }
}