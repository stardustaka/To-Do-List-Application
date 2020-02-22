using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace To_Do_List
{
    public partial class Main : Form
    {
        const string profileImageFile = @"ProfileImage";
        public Main()
        {
            InitializeComponent();
        }

        private void LearningButton_Click(object sender, EventArgs e)
        {
            learning1.BringToFront();
            BackPanel.Top = LearningButton.Top;
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            books1.BringToFront();
            BackPanel.Top = BooksButton.Top;
        }

        private void TargetsButton_Click(object sender, EventArgs e)
        {
            targets1.BringToFront();
            BackPanel.Top = TargetsButton.Top;
        }

        private void IdeasButton_Click(object sender, EventArgs e)
        {
            ideas1.BringToFront();
            BackPanel.Top = IdeasButton.Top;
        }

        private void DoneListButon_Click(object sender, EventArgs e)
        {
            done1.BringToFront();
            BackPanel.Top = DoneListButton.Top;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        string date;
        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToLongDateString();
            if (date == currentDate) return;
            Date.Text = date = currentDate;

        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SetTime();
            Date.Text = date = DateTime.Now.ToLongDateString();
            var dic = SavingSystem.LoadData();
            if(dic.ContainsKey("Name")) UserName.Text = dic["Name"][1];
            InsertName.Enabled = false;
            InsertName.Visible = false;
        }

        void SetTime()
        {
            int hour = DateTime.Now.Hour;
            hour -= (hour > 12) ? 12 : 0;
            Time.Text = string.Format("{0:" + hour + ":mm:ss tt}", DateTime.Now);
        }

        private void InsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                InitialDirectory = @"C:/",
                Title = "Browse Images",
                Filter = "(*.png;*.gif;*.jpg;*.jpeg)|*.png;*.gif;*.jpg;*.jpeg",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(profileImageFile))
                {
                    InsertImage.Image = InsertImage.BackgroundImage = Image.FromFile(fileDialog.FileName);
                    Image.FromFile(fileDialog.FileName).Dispose();
                    File.Delete(profileImageFile);
                }
                File.Copy(fileDialog.FileName, profileImageFile);
                InsertImage.Image = null;
            }
        }

        private void EnableInsertName_Click(object sender, EventArgs e)
        {
            if (InsertName.Visible)
            {
                InsertName.Visible = false;
                InsertName.Enabled = false;
            }
            else
            {
                InsertName.Visible = true;
                InsertName.Enabled = true;
            }
        }

        private void InsertName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                UserName.Text = InsertName.Text;
                InsertName.Text = "";
                InsertName.Enabled = false;
                InsertName.Visible = false;
            }
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, UserName.Text);
            SavingSystem.Save("Name", dic);
        }

        public void AddToDone(string text)
        {
            done1.AddItem(text);
        }
    }
}