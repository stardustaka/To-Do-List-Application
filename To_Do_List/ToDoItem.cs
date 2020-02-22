using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class ToDoItem : UserControl
    {
        IItemSummoner summoner;
        internal IItemSummoner Summoner { get => summoner; set => summoner = value; }
        public ToDoItem()
        {
            InitializeComponent();
        }
        public ToDoItem(string text)
        {
            InitializeComponent();
            Label.Text = text;
            bool condition = Label.Width < System.Windows.Forms.TextRenderer.MeasureText(Label.Text, new Font(Label.Font.FontFamily, Label.Font.Size, Label.Font.Style)).Width;
            if (condition && Label.Font.Size > 9)
            {
               while (condition && Label.Font.Size > 9f)
                {
                    Label.Font = new Font(Label.Font.FontFamily, Label.Font.Size - 0.5f, Label.Font.Style);
                }
            }
            else if (condition)
            {
                string[] lines = Label.Text.Split('\n');
                string lastLine = lines[lines.Length - 1];
                if (lastLine != "")
                {
                    lastLine.Insert((lastLine.Length - 1) / 2, "\n");
                    string newText = "";
                    for(int i = 0; i < lines.Length - 1; i++)
                    {
                        newText += lines[i];
                    }
                    newText += lastLine;
                    Label.Text = newText;
                }
                else
                {
                    Label.Text.Insert((Label.Text.Length - 1) / 2, "\n");
                }
            }
        }
        public void DisableDoneButton()
        {
            DoneButton.Enabled = false;
            DoneButton.Visible = false;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Delete();
            Main main = (Main)FindForm();
            main.AddToDone(Label.Text);
        }
        private void Delete()
        {
            summoner.ResetItemsIndexes(this);
            this.Visible = false;
            this.Enabled = false;
        }
    }
}