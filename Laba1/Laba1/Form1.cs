using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class FMenu : Form
    {
        public static Plugin _curr_Plugin = null;
        public static FMenu window = null;
        public static List<Item> Catalog = new List<Item>();
        public delegate void UpdateMethod(object obj, int index);
        private static string[] Names = { "Name",  "Category","Price", "Count", "Country" };
        private static int[] Length = { 200, 160, 120, 150, 150 };
        public static Creator[] Creators = { new BottleCreator(), new High_AlchololCreator(), new Low_AlchololCreator(), new Medium_AlchololCreator(), new UserDrinkCreator() };
        public static FileCreator[] FileCreators = { new BinaryFileCreator(), new JsonFileCreator(), new AuthorFileCreator() };
        public FMenu()
        {
            InitializeComponent();
            window = this;
           
            ColumnHeader header;
            for (int index = 0; index < 5; index++)
            {
                header = new ColumnHeader();
                header.Text = Names[index];
                header.Width = Length[index];
                Orders.Columns.Add(header);
            }
            Orders.View = View.Details;
            foreach (string index in Enum.GetNames(typeof(Item.TCategories)))
            {
               CBType.Items.Add(index);
            }
            SVD.Filter = "Binary file|*.bin|Json file|*.json|Lehason|*.lehason";
            OFD.Filter = "Binary file|*.bin|Json file|*.json|Lehason|*.lehason";
        }
        public void AddObject(object Obj, int index)
        {
            if (index == -1)
            {
                Catalog.Add((Item)Obj);
            }
            else
            {
                Catalog.RemoveAt(index);
                Catalog.Insert(index, (Item)Obj);
            }
            ShowListView();
        }
      
        private void ShowListView()
        {
            int index = 0;
            Orders.Items.Clear();
            foreach (Item item in Catalog)
            {
                    AddLinetoListView();
                    Orders.Items[index].SubItems[0].Text = item.Name;
                    Orders.Items[index].SubItems[1].Text = item.Category.ToString();
                    Orders.Items[index].SubItems[2].Text = item.Price.ToString();
                    Orders.Items[index].SubItems[3].Text = item.Count.ToString();
                    Orders.Items[index].SubItems[4].Text = item.Country;
                    index++;
            }
        }

        public static void AddLinetoListView()
        {
            ListViewItem LVI = new ListViewItem();
            for (int index = 0; index < 5; index++)
            {
                ListViewItem.ListViewSubItem LVSI = new ListViewItem.ListViewSubItem();
                LVI.SubItems.Add(LVSI);
            }
            FMenu.window.Orders.Items.Add(LVI);
        }

        public static void Browse(object obj, int ind)
        {

        }

        public static object[] GetCommonData(TextBox Name, TextBox Price, TextBox Count, TextBox Country)
        {
            object[] values = new object[5];
            if (Name.Text != "" && Country.Text!="")
            {
                values[0] = (string)Name.Text;
                values[3] = (string)Country.Text;
            }
            else
            {
                MessageBox.Show("В одном из текстовых полей нет данных!");
                return null;
            }

            try
            {
                values[1] = Convert.ToDouble(Price.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введена стоимость");
                return null;
            }
            try
            {
                values[2] = Convert.ToInt32(Count.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Не введено количество");
                return null;
            }
            return values;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (CBType.SelectedIndex != -1)
             {
                 object obj = null;
                 Form form = Creators[CBType.SelectedIndex].Create(AddObject, obj, -1);
                 form.Show();
               }
        }

        private void BDel_Click(object sender, EventArgs e)
        {
            int jindex = 0;
            for (int index = 0; index <= Catalog.Count - 1; index++)
            {
 
                    if (Orders.Items[jindex].Selected)
                    {
                        Catalog.RemoveAt(index);
                        Orders.Items.RemoveAt(jindex);
                    }
                    jindex++;
            }
        }

        private void BInfo_Click(object sender, EventArgs e)
        {

            int jindex = 0;
            for (int index = 0; index <= Catalog.Count - 1; index++)
            {

                    if (Orders.Items[jindex].Selected)
                    {
                        int ind = CBType.Items.IndexOf(Orders.Items[jindex].SubItems[1].Text);
                        Form form = Creators[ind].Create(Browse, Catalog[index], index);
                        form.Show();
                    }
                    jindex++;
            }

        }

        private void BChange_Click(object sender, EventArgs e)
        {
            int jindex = 0;
            for (int index = 0; index <= Catalog.Count - 1; index++)
            {
                    if (Orders.Items[jindex].Selected)
                    {
                        int ind = CBType.Items.IndexOf(Orders.Items[jindex].SubItems[1].Text);
                        Form form = Creators[ind].Create(AddObject, Catalog[index], index);
                        form.Show();
                    }
                    jindex++;
            }
        }

        private void ПососатьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /*   if (SVD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SVD.FileName;
            byte[] data = FileCreators[SVD.FilterIndex - 1].FileSave(Catalog);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                fs.Write(data, 0, data.Length);
            }*/

            if (SVD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SVD.FileName;
            byte[] data = FileCreators[SVD.FilterIndex - 1].FileSave(Catalog);
            PluginForm pluginForm = new PluginForm(data, filename);
            pluginForm.Show();
        }

        private void РаздвинутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  if (OFD.ShowDialog() == DialogResult.Cancel)
                  return;
              string filename = OFD.FileName;
              byte[] data = null;
              using (FileStream fs = new FileStream(filename, FileMode.Open))
              {
                  data = new byte[(int)fs.Length];
                  fs.Read(data, 0, data.Length);
              }
              Catalog = FileCreators[OFD.FilterIndex - 1].FileOpen(data);
              ShowListView();
  */
            if (OFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OFD.FileName;
            byte[] serialized = null;
            byte[] data = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                serialized = new byte[(int)fs.Length];
                fs.Read(serialized, 0, serialized.Length);
            }
            int res = Plugin.FindPlugin(filename);

            switch (res)
            {
                case -1:
                    MessageBox.Show("Соответствующий плагин отсутствует!!!");
                    return;
                case 1:
                    data = Plugin.ActivatePlugin(FMenu._curr_Plugin, serialized, false);
                    break;
                case 0:
                    data = serialized;
                    break;
            }
            Catalog = FileCreators[OFD.FilterIndex - 1].FileOpen(data);
            ShowListView();

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
