using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Input;

namespace VagnerRealtor
{
    public partial class VagnerRealtor : Form
    {
        ListViewItem lviSelected;
        LinkedList<RealStateProperty> properties;

        public VagnerRealtor()
        {

            InitializeComponent();
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Vagner Realtor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }    
            
        }

        private void ShowProperties()
        {
            
            BinaryFormatter bfmProperty = new BinaryFormatter();
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";
            //MessageBox.Show("Showing Current Dir #2: " + strFileName);

            // Make sure the file exists
            if (File.Exists(strFileName) == true)
            {
                
                // if so, create a file stream
                using (FileStream stmProperties = new FileStream(strFileName,
                                                          FileMode.Open,
                                                          FileAccess.Read))
                {
                    // If some properties were created already,
                    // get them and store them in the collection
                    properties = (LinkedList<RealStateProperty>)bfmProperty.Deserialize(stmProperties);

                    // First, empty the list view
                    lvwProperty.Items.Clear();
                    ListViewItem lviProperty = null;

                    // Visit each property in the collection and add it to the list view
                    foreach (RealStateProperty house in properties)
                    {
                        if (house.PropertyType.Equals("Condominium"))
                            lviProperty = new ListViewItem(house.PropertyNumber, lvwProperty.Groups[0]);
                        else if (house.PropertyType.Equals("Townhouse"))
                            lviProperty = new ListViewItem(house.PropertyNumber, lvwProperty.Groups[1]);
                        else if (house.PropertyType.Equals("Single Family"))
                            lviProperty = new ListViewItem(house.PropertyNumber, lvwProperty.Groups[2]);
                        else
                            lviProperty = new ListViewItem(house.PropertyNumber, lvwProperty.Groups[3]);


                        //Load List View
                        lviProperty.SubItems.Add(house.City);
                        lviProperty.SubItems.Add(house.Stories.ToString());
                        lviProperty.SubItems.Add(house.YearBuilt.ToString());
                        lviProperty.SubItems.Add(house.Bedrooms.ToString());
                        lviProperty.SubItems.Add(house.Bathrooms.ToString());
                        lviProperty.SubItems.Add(house.Condition);
                        lviProperty.SubItems.Add(house.SaleStatus);
                        lviProperty.SubItems.Add(house.MarketValue.ToString("F"));
                        lvwProperty.Items.Add(lviProperty);

                        //Format List View
                        lvwProperty.Columns[8].TextAlign = HorizontalAlignment.Right;


                        string img = "E:\\VagnerRealtor\\VagnerRealtor\\" + house.PropertyNumber.ToString() + ".jpg";
                        pbxPicture.Image = Image.FromFile(img);
                    }

                } // Close the file stream
            }
            
        }

        private void VagnerRealtor_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("E:\\VagnerRealtor\\VagnerRealtor");
            properties = new LinkedList<RealStateProperty>();
            ShowProperties();
            lviSelected = new ListViewItem();
        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            PropertyEditor editor = new PropertyEditor();
            BinaryFormatter bfmProperty = new BinaryFormatter();

            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";
            

            Random rndNumber = new Random(DateTime.Now.Millisecond);
            int number1 = rndNumber.Next(100, 999);
            int number2 = rndNumber.Next(100, 999);
            string propNumber = number1 + "-" + number2;

            editor.txtPropertyNumber.Text = propNumber;

            // First check if the file was previously created
            if (File.Exists(strFileName) == true)
            {
                // If the list of properties exists already,
                // get it and store it in a file stream
                using (FileStream stmProperties = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read))
                {
                    // Store the list of properties in the collection
                    properties = (LinkedList<RealStateProperty>)bfmProperty.Deserialize(stmProperties);
                } // Close the file stream
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                RealStateProperty prop = new RealStateProperty();

                prop.PropertyNumber = editor.txtPropertyNumber.Text;
                prop.PropertyType = editor.cbxPropertyTypes.Text;
                prop.Address = editor.txtAddress.Text;
                prop.City = editor.txtCity.Text;
                prop.State = editor.cbxStates.Text;
                prop.ZIPCode = editor.txtZIPCode.Text;
                prop.Stories = short.Parse(editor.txtStories.Text);
                prop.YearBuilt = int.Parse(editor.txtYearBuilt.Text);
                prop.Bedrooms = short.Parse(editor.txtBedrooms.Text);
                prop.Bathrooms = float.Parse(editor.txtBathrooms.Text);
                prop.Condition = editor.cbxCondition.Text;
                prop.SaleStatus = editor.cbxSaleStatus.Text;
                prop.MarketValue = double.Parse(editor.txtMarketValue.Text);
                if (!editor.pictureFile.Equals(""))
                {
                   // MessageBox.Show("#6");
                    FileInfo flePicture = new FileInfo(editor.pictureFile);
                    MessageBox.Show("#7");
                    flePicture.CopyTo("E:\\VagnerRealtor\\VagnerRealtor\\" +
                                      editor.txtPropertyNumber.Text + flePicture.Extension, true);
                    //MessageBox.Show("#8");
                    prop.PictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" +
                                        editor.txtPropertyNumber.Text + flePicture.Extension;

                }
                else
                {
                    //MessageBox.Show("#1");
                    prop.PictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg";
                    //MessageBox.Show("#2");
                }

                

                // Add the property in the collection
                properties.AddFirst(prop);

                

                // Create a file stream to hold the list of properties
                using (FileStream stmProperties = new FileStream(strFileName,
                                                                 FileMode.Create,
                                                                 FileAccess.Write))
                {
                    // Serialize the list of properties
                    bfmProperty.Serialize(stmProperties, properties);
                    
                } // Close the file stream

                // Show the list of properties
                
                ShowProperties();
                
               

            }
        }

        private void lvwProperty_DoubleClick(object sender, EventArgs e)
        {
            PropertyEditor editor = new PropertyEditor();
            RealStateProperty house = new RealStateProperty();
            BinaryFormatter bfmProperties = new BinaryFormatter();
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";

            if ((lvwProperty.SelectedItems.Count == 0) || (lvwProperty.SelectedItems.Count > 1))
                return;

            using (FileStream stmProperties = new FileStream(strFileName,
                                                             FileMode.Open,
                                                             FileAccess.Read))
            {
                properties = (LinkedList<RealStateProperty>)bfmProperties.Deserialize(stmProperties);
            }

            // Get the property that the user double-clicked
            ListViewItem lviProperty = lvwProperty.SelectedItems[0];
            foreach (RealStateProperty prop in properties)
                if (prop.PropertyNumber == lviProperty.Text)
                    house = prop;

            // Prepare to fill the editor with the values of the property the user double-clicked
            editor.txtPropertyNumber.Text = house.PropertyNumber;
            editor.cbxPropertyTypes.Text = house.PropertyType;
            editor.txtAddress.Text = house.Address;
            editor.txtCity.Text = house.City;
            editor.cbxStates.Text = house.State;
            editor.txtZIPCode.Text = house.ZIPCode;
            editor.txtStories.Text = house.Stories.ToString();
            editor.txtYearBuilt.Text = house.YearBuilt.ToString();
            editor.txtBedrooms.Text = house.Bedrooms.ToString();
            editor.txtBathrooms.Text = house.Bathrooms.ToString("F");
            editor.cbxCondition.Text = house.Condition;
            editor.cbxSaleStatus.Text = house.SaleStatus;
            editor.txtMarketValue.Text = house.MarketValue.ToString("F");

            string strPictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" + house.PropertyNumber + ".jpg";


            //MessageBox.Show("#3");
            if (File.Exists(strPictureFile))
            {
                editor.pbxProperty.Image = Image.FromFile(strPictureFile);
            }
            else
                editor.pbxProperty.Image = Image.FromFile("E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg");

            // Disable the property number so the user cannot change it
            editor.txtPropertyNumber.Enabled = false;

            //Update File
            if (editor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // For each value that has changed in the property, update its node
                house.PropertyType = editor.cbxPropertyTypes.Text;
                house.Address = editor.txtAddress.Text;
                house.City = editor.txtCity.Text;
                house.State = editor.cbxStates.Text;
                house.ZIPCode = editor.txtZIPCode.Text;
                house.Stories = short.Parse(editor.txtStories.Text);
                house.YearBuilt = int.Parse(editor.txtYearBuilt.Text);
                house.Bedrooms = short.Parse(editor.txtBedrooms.Text);
                house.Bathrooms = float.Parse(editor.txtBathrooms.Text);
                house.Condition = editor.cbxCondition.Text;
                house.SaleStatus = editor.cbxSaleStatus.Text;
                house.MarketValue = double.Parse(editor.txtMarketValue.Text);
                house.PictureFile = editor.pictureFile;

                using (FileStream stmProperties = new FileStream(strFileName,
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite))
                {
                    bfmProperties.Serialize(stmProperties, properties);
                }
            }

            // Show the list of properties
            ShowProperties();
        }

        private void lvwProperty_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RealStateProperty currentProperty = new RealStateProperty();
            string strFileName = "E:\\VagnerRealtor\\VagnerRealtor\\" + e.Item.SubItems[0].Text + ".jpg";

            if (lvwProperty.SelectedItems.Count == 1)
                lviSelected = lvwProperty.SelectedItems[0];

            //MessageBox.Show("#4");
            if (File.Exists(strFileName))
                pbxPicture.Image = Image.FromFile(strFileName);
            else
                pbxPicture.Image = Image.FromFile("E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg");

            if (lvwProperty.SelectedItems.Count == 1)
            {
                mnuInsertBefore.Enabled = true;
                mnuEditProperty.Enabled = true;
                mnuInsertAfter.Enabled = true;
                mnuDeleteProperty.Enabled = true;
            }
            else
            {
                mnuInsertBefore.Enabled = false;
                mnuEditProperty.Enabled = false;
                mnuInsertAfter.Enabled = false;
                mnuDeleteProperty.Enabled = false;
            }

        }

        private void mnuNewProperty_Click(object sender, EventArgs e)
        {
            btnNewProperty_Click(sender, e);
        }

        private void mnuEditProperty_Click(object sender, EventArgs e)
        {
            lvwProperty_DoubleClick(sender, e);
        }

        private void lvwProperty_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            //e.Item.BackColor = Color.Lime;
        }

        private void mnuDeleteProperty_Click(object sender, EventArgs e)
        {
            PropertyEditor editor = new PropertyEditor();
            RealStateProperty rep = new RealStateProperty();
            BinaryFormatter bfProperties = new BinaryFormatter();
            //string strFileName = "E:\\VagnerRealtor\\VagnerRealtor\\properties.ars";
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";

            // Open the file that holds the properties
            if (File.Exists(strFileName))
            {
                using (FileStream stmProperties = new FileStream(strFileName,
                                                            FileMode.Open,
                                                            FileAccess.Read))
                {
                    properties = (LinkedList<RealStateProperty>)bfProperties.Deserialize(stmProperties);
                }
            }

            // Create a real estate property using the property number that the user double-clicked
            string strPropertyNumber = lvwProperty.SelectedItems[0].Text;
            rep.PropertyNumber = lvwProperty.SelectedItems[0].Text;

            // Ask the compiler to locate that property
            LinkedListNode<RealStateProperty> nodProperty = properties.Find(rep);

            // Just in case, make sure the property was found
            if (nodProperty != null)
            {
                // Present a warning message to the user
                if (MessageBox.Show("Are you sure you want to delete this property?",
                                    "Vagner's Realtors",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    // If the user clicks yes, delete the property
                    properties.Remove(nodProperty);

                    // Save the list of properties
                    using (FileStream stmProperties = new FileStream(strFileName,
                                                                FileMode.Create,
                                                                FileAccess.Write))
                    {
                        bfProperties.Serialize(stmProperties, properties);
                    }
                }
            }

            // Show the new list of properties
            ShowProperties();

            MessageBox.Show("Exit Delete");
        }

        private void btnReviewProperties_Click(object sender, EventArgs e)
        {
            PropertiesReview pr = new PropertiesReview();
            pr.Show();
        }

        /*
        private void lvwProperty_MouseLeave(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Set the Color you want the list Item to be when mouse is over
            Color oItemColor = Color.Lime;
            Color oOriginalColor = Color.White; //Original color
            MessageBox.Show("Hover...");

            //get the Item the Mouse is currently hover
            ListViewItem lvCurrentItem = lvwProperty.GetItemAt(e.X, e.Y);


            if ((lvCurrentItem != null) && (lvCurrentItem != lviSelected))
            {
                lvCurrentItem.BackColor = oItemColor;

                if (lviSelected != null)
                {
                    lviSelected.BackColor = oOriginalColor;
                }

                lviSelected = lvCurrentItem;
                return;

            }


            if (lvCurrentItem == null)
            {
                if (lviSelected != null)
                {
                    lviSelected.BackColor = oOriginalColor;
                }
            }
        } */
    }
}
