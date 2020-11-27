using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HyperSpace.Form1;

namespace HyperSpace
{
    public partial class Form1 : Form
    {
        //public class HyperSpaceClothing
        //{
        //    public int Price_Shirt; //= 35;
        //    public int Price_Pants; //= 55;
        //    public int Price_Shoes; //= 85;
        //    public string Shirt_I; //= "HyperSpace Pants";
        //    public string Pants_I; //= "HyperSpace Pants";
        //    public string Shoes_I; //= "HyperSpace Shoes";

        //    public HyperSpaceClothing() { }

        //    public HyperSpaceClothing(int price_shirt, int price_pants, int price_shoes, string shirt_i, string pants_i, string shoes_i)
        //    {
        //        this.Price_Shirt = 35;
        //        this.Price_Pants = 55;
        //        this.Price_Shoes = 85;
        //    }
        //}

        public class HyperSpaceClothing
        {
            public int shirtsm_p;
            public int pantsm_p;
            public int shoesm_p;
            public string shirtn_item;
            public string pantn_item;
            public string shoen_item;
        }
        class fit
        {
            public static void Main(string[] args)
            {
                HyperSpaceClothing hyperspaceclothing = new HyperSpaceClothing();

                hyperspaceclothing.shirtsm_p = 35;
                hyperspaceclothing.pantsm_p = 55;
                hyperspaceclothing.shoesm_p = 85;
                hyperspaceclothing.shirtn_item = "HyperSpace Shirt";
                hyperspaceclothing.pantn_item = "HyperSpace Pants";
                hyperspaceclothing.shoen_item = "HyperSpace Shoes";

            }


            }


            int shirts = 0;
            int pants = 0;
            int shoes = 0;
            //int HyperSpaceClothingtotal;
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {

            }

            private void totalprice_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void exitbotton_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void resetListbox1()
            {
                shirts = 0;
                pants = 0;
                shoes = 0;
                textshirt.Text = "Shirts: " + shirts;
                textpants.Text = "Pants: " + pants;
                textshoes.Text = "Shoes: " + shoes;

            }
            private void resetTotalpricebox()
            {

            }
            private void resetCheckboxes()
            {
                shirtbox.Checked = false;
                pantsbox.Checked = false;
                shoebox.Checked = false;
            }
            //public string Shirt_I
            //{
            //    get { return this.Shirt_I; }
            //}
            //public int Price_Shirt => Price_Shirt.ToString("c");

            private void listitems()
            {

            }

            private void clearbutton_Click(object sender, EventArgs e)
            {
                resetListbox1();
                resetTotalpricebox();
                resetCheckboxes();

            }

            private void shirtbox_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void pantsbox_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void shoebox_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void enterbutton_Click(object sender, EventArgs e)
            {

                if (((CheckBox)shirtbox).Checked)
                {
                    shirts++;
                    textshirt.Text = "Shirts: " + shirts;
                //totalprice.Items.Add("Shirt $35");
                }

                if (((CheckBox)pantsbox).Checked)
                {
                    pants++;
                    textpants.Text = "Pants: " + pants;
                }

                if (((CheckBox)shoebox).Checked)
                {
                    shoes++;
                    textshoes.Text = "Shoes: " + shoes;
                }
                resetCheckboxes();
            // listitems();





        }

            private void textpants_TextChanged(object sender, EventArgs e)
            {

            }

            private void textshoes_TextChanged(object sender, EventArgs e)
            {

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

            private void textshirt_TextChanged_1(object sender, EventArgs e)
            {

            }
        }
    }

