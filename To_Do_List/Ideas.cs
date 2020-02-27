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
    public partial class Ideas : UserControl, IItemSummoner
    {
        int itemsIndex = 1;
        Dictionary<int, string> itemsDic = new Dictionary<int, string>();
        List<ToDoItem> itemsList = new List<ToDoItem>();
        public Ideas()
        {
            InitializeComponent();
        }
        private void Ideas_Load(object sender, EventArgs e)
        {
            var data = SavingSystem.LoadData();
            if (data.ContainsKey(this.Name))
            {
                for (int i = 1; i <= data[this.Name].Count; i++)
                {
                    AddItem(data[this.Name][i]);
                }
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            EnterText();
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterText();
                e.SuppressKeyPress = true;
            }
        }
        private void EnterText()
        {
            string text = TextBox.Text;
            if (text.Trim() == "") return;
            AddItem(text);
            SavingSystem.Save(this.Name, itemsDic);
            TextBox.Text = "";
        }
        void AddItem(string text)
        {
            ToDoItem item = new ToDoItem(text);
            item.Parent = ItemsParent;
            ItemsParent.Controls.Add(item);
            item.Top = (itemsIndex == 1) ? 10 : itemsList[itemsIndex - 2].Bottom + 10;
            item.Summoner = this;
            itemsDic.Add(itemsIndex, text);
            itemsIndex++;
            itemsList.Add(item);

        }
        public void ResetItemsIndexes(ToDoItem item)
        {
            int index = itemsList.IndexOf(item) + 1;
            for (int i = index; i < itemsDic.Count; i++)
            {
                itemsDic[i] = itemsDic[i + 1];
            }
            itemsList.RemoveAt(index - 1);
            itemsDic.Remove(itemsDic.Count);
            for (int i = index; i <= itemsList.Count; i++)
            {
                var item_ = itemsList[i - 1];
                item_.Top = (i == 1) ? 10 : itemsList[i - 2].Bottom + 10;
            }
            itemsIndex--;
            SavingSystem.Save(this.Name, itemsDic);
        }

        private void TextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}