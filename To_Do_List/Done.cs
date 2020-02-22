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
    public partial class Done : UserControl, IItemSummoner
    {
        int itemsIndex = 1;
        Dictionary<int, string> itemsDic = new Dictionary<int, string>();
        List<ToDoItem> itemsList = new List<ToDoItem>();
        public Done()
        {
            InitializeComponent();
        }

        private void Done_Load(object sender, EventArgs e)
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
        public void AddItem(string text)
        {
            ToDoItem item = new ToDoItem(text)
            {
                Parent = ItemsParent,
                Top = (itemsIndex == 1) ? 10 : itemsList[itemsIndex - 2].Bottom + 10,
                Summoner = this,
            };
            item.DisableDoneButton();
            ItemsParent.Controls.Add(item);
            itemsDic.Add(itemsIndex, text);
            itemsIndex++;
            itemsList.Add(item);
            SavingSystem.Save(this.Name, itemsDic);
        }
        public void ResetItemsIndexes(ToDoItem item)
        {
            int index = itemsList.IndexOf(item) + 1;
            for (int i = index; i < itemsDic.Count; i++)
            {
                itemsDic[i] = itemsDic[i++];
            }
            itemsList.RemoveAt(index - 1);
            for (int i = index; i <= itemsList.Count; i++)
            {
                var item_ = itemsList[i - 1];
                if (i == 1) item_.Top = 10;
                else item_.Top = itemsList[i - 2].Bottom + 10;
            }
            itemsDic.Remove(itemsDic.Count);
            itemsIndex--;
            SavingSystem.Save(this.Name, itemsDic);
        }
    }
}
