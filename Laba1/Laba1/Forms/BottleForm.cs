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
    public partial class BottleForm : Form
    {
        FMenu.UpdateMethod Add_Display;
        int ObjectIndex;
        public BottleForm(FMenu.UpdateMethod method, object obj, int index)
        {
            InitializeComponent();
            foreach (string i in Enum.GetNames(typeof(Bottle.TType)))
            {
                CMBType.Items.Add(i);
            }
            if (obj != null)
            {
                TBName.Text = (obj as Bottle).Name;
                TBPrice.Text = (obj as Bottle).Price.ToString();
                TBCount.Text = (obj as Bottle).Count.ToString();
                TBCountry.Text = (obj as Bottle).Country;
                TBVolume.Text = (obj as Bottle).Volume.ToString();
                CMBType.SelectedItem = (obj as Bottle).BType.ToString();
               
            }
            Add_Display = method;
            ObjectIndex = index;
        }




        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BottleForm_Activated(object sender, EventArgs e)
        {

        }

        private void BReady_Click(object sender, EventArgs e)
        {
            double volume;
            Bottle.TType btype;
            if (TBPrice.Text != "" && CMBType.SelectedItem !=null)
            {
                volume = Convert.ToDouble(TBPrice.Text);
                btype = (Bottle.TType)Enum.Parse(typeof(Bottle.TType), CMBType.SelectedItem.ToString()); 
            }
            else
            {
                MessageBox.Show("Проверьте значения");
                return;
            }
            object[] value = FMenu.GetCommonData(TBName, TBPrice, TBCount, TBCountry);
            if (value != null)
            {
                Bottle bottle = new Bottle(volume,btype,(string)value[0], (double)value[1], (int)value[2], (string)value[3]);
                Add_Display(bottle, ObjectIndex);
                this.Close();
            }
        }
    }
}
