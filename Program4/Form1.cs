// Timothy Mahan
// Program 4
// Due 4/24/2016
// Section 01
// This program takes the input from the user, validates it, and then creates an object called a ground package from the input. 
// Next the object is moved into a list, and the objects price is calculated and store in a parallel list inside of a lsit box. 
// Should the user hit the details button after selecting a package from the list, all of the packages details will be displayed on screen.
// The user is also able to change the package's destination and location by selecting the package from the list and pressing either the send to U of L 
// or the send from U of L buttons.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<GroundPackage> packageList = new List<GroundPackage>();
        private int index = -1;

        private void createPackageBttn_Click(object sender, EventArgs e)
        {
            int originZip;//zip code of package origin
            int destZip;//zip code of package destination
            double weight;//weight of package (lbs)
            double length;//length of package (in.)
            double width;//Width of package (in.)
            double height;//height of package (in.)

            if (int.TryParse(originZipTxtBox.Text, out originZip) && originZip >=0 && originZip <=99999)//Try to parse originZip and make sure it's value is between 0 and 99999
            {
                if (int.TryParse(destZipTxtBox.Text, out destZip) && destZip >= 0 && destZip <= 99999)//Try to parse destZip and ensure it's value is between 0 and 99999
                {
                    if (double.TryParse(weightTxtBox.Text, out weight) && weight > 0)//Try to parse weight and ensure value >0
                    {
                        if (double.TryParse(lengthTxtBox.Text, out length) && length > 0)//Try to parse length and ensure value >0
                        {
                            if (double.TryParse(widthTxtBox.Text, out width) && width > 0)// Try to parse width and ensure value >0
                            {
                                if (double.TryParse(heightTxtBox.Text, out height) && height > 0)//Try to parse height and ensure value >0
                                {
                                    GroundPackage newPackage = new GroundPackage(originZip, destZip, weight, length, width, height);//create new ground package with appropriate vaiables
                                    packagesListBox.Items.Add(newPackage.CalcCost().ToString("c"));//Calculate cost and display in list box
                                    packageList.Add(newPackage);//add the new package to the package list.
                                }
                            }
                        }
                    }
                }
            }
            //Clear text boxes for next package
            originZipTxtBox.Clear();
            destZipTxtBox.Clear();
            weightTxtBox.Clear();
            lengthTxtBox.Clear();
            widthTxtBox.Clear();
            heightTxtBox.Clear();
        }

        private void detailsBttn_Click(object sender, EventArgs e)
        {
            if (packagesListBox.SelectedIndex == -1)//if an item is not selected
            {
                MessageBox.Show("Please select a package from the list");//Tell user to pick a package
            }
            else
            {
                MessageBox.Show(packageList[packagesListBox.SelectedIndex].ToString());//show details of package
            }
        }

        private void sendToBttn_Click(object sender, EventArgs e)
        {
            index = packagesListBox.SelectedIndex; //set index variable to index of selected item
            packageList[index].DestZip = 40292;//change destination zip code to 40292
            packagesListBox.Items[index] = packageList[index].CalcCost().ToString("c");//update change of cost in list box
        }

        private void sendFromBttn_Click(object sender, EventArgs e)
        {
            index = packagesListBox.SelectedIndex;//set index variable to index of selected item
            packageList[index].OriginZip = 40292;//change origin zip to 40292
            packagesListBox.Items[index] = packageList[index].CalcCost().ToString("c");//update change of cost in list box
        }
    }
}
