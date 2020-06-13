using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1.Forms
{
    public partial class Medium_AlchololForm : Form
    {
        FMenu.UpdateMethod Add_Display;
        int ObjectIndex;
        public Medium_AlchololForm(FMenu.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Medium_Alcholol.TType)))
            {
                CMBType.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(Medium_Alcholol.TCooking_Method)))
            {
                CMBMethod.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(Medium_Alcholol.TColor)))
            {
                CMBColor.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(Medium_Alcholol.TShugar)))
            {
                CMBShugar.Items.Add(i);
            }

            foreach (Item Bottle in FMenu.Catalog)
            {
                if (Bottle.Category == Item.TCategories.Bottle)
                    CMBottle.Items.Add(Bottle.Name);
            }

            if (obj != null)
            {
                TBName.Text = (obj as Medium_Alcholol).Name;
                TBPrice.Text = (obj as Medium_Alcholol).Price.ToString();
                TBCount.Text = (obj as Medium_Alcholol).Count.ToString();
                TBCountry.Text = (obj as Medium_Alcholol).Country;
                TBYear.Text = (obj as Medium_Alcholol).Year.ToString();
                TBGr.Text = (obj as Medium_Alcholol).Degree.ToString();
                CMBMethod.SelectedItem = (obj as Medium_Alcholol).Cooking_Method.ToString();
                CMBShugar.SelectedItem = (obj as Medium_Alcholol).Shugar.ToString();
                CMBColor.SelectedItem = (obj as Medium_Alcholol).Color.ToString();
                CMBottle.SelectedItem = (obj as Medium_Alcholol).Bottle.Name;
                CMBType.SelectedItem = (obj as Medium_Alcholol).MType.ToString();
                TRecipe.Text= (obj as Medium_Alcholol).Recipe.ToString();

            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void BReady_Click(object sender, EventArgs e)
        {
            Medium_Alcholol.TCooking_Method cooking_method;
            Medium_Alcholol.TColor color;
            Medium_Alcholol.TType type;
            Medium_Alcholol.TShugar shugar;
            Bottle botle;
            string recipe;
            double degree;
            int year;
            try
            {
                degree = Convert.ToDouble(TBGr.Text);
                year = Convert.ToInt32(TBYear.Text);
                recipe = TRecipe.Text;
                type = (Medium_Alcholol.TType)Enum.Parse(typeof(Medium_Alcholol.TType), CMBType.SelectedItem.ToString());
                color = (Medium_Alcholol.TColor)Enum.Parse(typeof(Medium_Alcholol.TColor), CMBColor.SelectedItem.ToString());
                shugar = (Medium_Alcholol.TShugar)Enum.Parse(typeof(Medium_Alcholol.TShugar), CMBShugar.SelectedItem.ToString());
                cooking_method = (Medium_Alcholol.TCooking_Method)Enum.Parse(typeof(Medium_Alcholol.TCooking_Method), CMBMethod.SelectedItem.ToString());
                botle = (Bottle)FMenu.Catalog.Find(x => x.Name == CMBottle.SelectedItem.ToString() && x.Category == Item.TCategories.Bottle);
            }
            catch
            {
                MessageBox.Show("Перепроверьте ваши данные");
                return;
            }
           
            object[] value = FMenu.GetCommonData(TBName, TBPrice, TBCount, TBCountry);
            if (value != null)
            {
                Medium_Alcholol medium_alcholol = new Medium_Alcholol(botle,type,recipe,cooking_method,color,shugar,degree, year, (string)value[0], (double)value[1], (int)value[2], (string)value[3]);
                Add_Display(medium_alcholol, ObjectIndex);
                this.Close();
            }
        }
    }
}
    

