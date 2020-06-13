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

    public partial class High_AlchololForm : Form
    {
        FMenu.UpdateMethod Add_Display;
        int ObjectIndex;
        public High_AlchololForm(FMenu.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(High_Alcholol.TType)))
            {
                CMBType.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(High_Alcholol.TRaw_Materials)))
            {
                CMBMaterial.Items.Add(i);
            }
            foreach (string i in Enum.GetNames(typeof(High_Alcholol.TFlavorin_additives)))
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
                TBName.Text = (obj as High_Alcholol).Name;
                TBPrice.Text = (obj as High_Alcholol).Price.ToString();
                TBCount.Text = (obj as High_Alcholol).Count.ToString();
                TBCountry.Text = (obj as High_Alcholol).Country;
                TBYear.Text = (obj as High_Alcholol).Year.ToString();
                TBGr.Text = (obj as High_Alcholol).Degree.ToString();
                CMBDob.SelectedItem = (obj as High_Alcholol).Flavorin_additives.ToString();
                CMBMaterial.SelectedItem= (obj as High_Alcholol).Raw_Materials.ToString();
                CMBottle.SelectedItem= (obj as High_Alcholol).Bottle.Name;
                CMBType.SelectedItem= (obj as High_Alcholol).HAType.ToString();
            }
            Add_Display = method;
            ObjectIndex = index;
        }

        private void BReady_Click(object sender, EventArgs e)
        {
            High_Alcholol.TFlavorin_additives flavorin_additives;
            High_Alcholol.TRaw_Materials raw_materials;
            High_Alcholol.TType type;
            Bottle botle;
            double degree=Convert.ToDouble(TBGr.Text);
            int year=Convert.ToInt32(TBYear.Text);
            if (CMBMaterial.SelectedItem != null)
            {
                raw_materials = (High_Alcholol.TRaw_Materials)Enum.Parse(typeof(High_Alcholol.TRaw_Materials), CMBMaterial.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите тип добавки");
                return;

            }
            if (CMBDob.SelectedItem != null)
            {
                flavorin_additives = (High_Alcholol.TFlavorin_additives)Enum.Parse(typeof(High_Alcholol.TFlavorin_additives), CMBDob.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите тип добавки");
                return;

            }
            if (CMBType.SelectedItem != null)
            {
                type = (High_Alcholol.TType)Enum.Parse(typeof(High_Alcholol.TType), CMBType.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Выберите тип алкоголя");
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
                High_Alcholol high_alcholol = new High_Alcholol(botle,flavorin_additives,raw_materials,type,degree,year,(string)value[0], (double)value[1], (int)value[2], (string)value[3]);
                Add_Display(high_alcholol, ObjectIndex);
                this.Close();
            }
        }
    }
}
