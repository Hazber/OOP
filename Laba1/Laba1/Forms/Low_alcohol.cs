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
    public partial class Low_alcoholForm : Form
    {
        FMenu.UpdateMethod Add_Display;
        int ObjectIndex;
        public Low_alcoholForm(FMenu.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Low_Alcholol.TCooking_Method)))
            {
                CMBMethod.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(Low_Alcholol.TFlavorin_additives)))
            {
                CMBDob.Items.Add(i);
            }
          
            foreach (Item Bottle in FMenu.Catalog)
            {
                if (Bottle.Category == Item.TCategories.Bottle)
                    CMBottle.Items.Add(Bottle.Name);
            }
            if (obj != null)
            {
                TBName.Text = (obj as Low_Alcholol).Name;
                TBPrice.Text = (obj as Low_Alcholol).Price.ToString();
                TBCount.Text = (obj as Low_Alcholol).Count.ToString();
                TBCountry.Text = (obj as Low_Alcholol).Country;
                TBYear.Text = (obj as Low_Alcholol).Year.ToString();
                TBGr.Text = (obj as Low_Alcholol).Degree.ToString();
                CMBDob.SelectedItem = (obj as Low_Alcholol).Flavorin_Additives.ToString();
                CMBottle.SelectedItem = (obj as Low_Alcholol).Bottle.Name;
                CMBMethod.SelectedItem = (obj as Low_Alcholol).Cooking_Method.ToString();
                TBRecipe.Text= (obj as Low_Alcholol).Recipe;
                TBIngr.Text= (obj as Low_Alcholol).Ingridients;
                CBAroma.Checked= (obj as Low_Alcholol).Aroma;
                CBFruit.Checked = (obj as Low_Alcholol).Fruit;
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void BReady_Click(object sender, EventArgs e)
        {
            Low_Alcholol.TFlavorin_additives flavorin_additives;
            Low_Alcholol.TCooking_Method cooking_method;
            string recipe= TBRecipe.Text;
            string ingr= TBIngr.Text;
            bool aroma= CBAroma.Checked;
            bool fruit= CBFruit.Checked;
            Bottle botle;
            double degree = Convert.ToDouble(TBGr.Text);
            int year = Convert.ToInt32(TBYear.Text);
            if (CMBMethod.SelectedItem != null)
            {
                cooking_method = (Low_Alcholol.TCooking_Method)Enum.Parse(typeof(Low_Alcholol.TCooking_Method), CMBMethod.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите тип приготовления");
                return;

            }
            if (CMBDob.SelectedItem != null)
            {
                flavorin_additives = (Low_Alcholol.TFlavorin_additives)Enum.Parse(typeof(Low_Alcholol.TFlavorin_additives), CMBDob.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите тип добавки");
                return;

            }
            if (CMBottle.SelectedItem != null)
            {
                botle = (Bottle)FMenu.Catalog.Find(x => x.Name == CMBottle.SelectedItem.ToString() && x.Category == Item.TCategories.Bottle);
            }
            else
            {
                MessageBox.Show("Выберите тип бутылки");
                return;
            }

            object[] value = FMenu.GetCommonData(TBName, TBPrice, TBCount, TBCountry);
            if (value != null)
            {
                Low_Alcholol Low_alcholol = new Low_Alcholol(flavorin_additives, cooking_method, ingr,recipe,aroma,fruit, degree, year, (string)value[0], (double)value[1], (int)value[2], (string)value[3], botle);
                Add_Display(Low_alcholol, ObjectIndex);
                this.Close();
            }
        }
    }
    
}
