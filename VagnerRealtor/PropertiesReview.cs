using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VagnerRealtor
{
    public partial class PropertiesReview : Form
    {
        int index;
        LinkedList<RealStateProperty> properties;
        LinkedListNode<RealStateProperty> nodCurrent;

        public PropertiesReview()
        {
            InitializeComponent();
            
        }

        private void PropertiesReview_Load(object sender, EventArgs e)
        {
            index = 1;
            BinaryFormatter bfmProperty = new BinaryFormatter();
            //string strFileName = "C:\\Microsoft Visual C# Application Design\\Altair Realtors\\properties.ars";
            string strFileName = System.IO.Directory.GetCurrentDirectory() + "\\properties.ars";

            if (File.Exists(strFileName) == true)
            {
                using (FileStream stmProperties = new FileStream(strFileName,
                                                          FileMode.Open,
                                                          FileAccess.Read))
                {
                    properties = (LinkedList<RealStateProperty>)bfmProperty.Deserialize(stmProperties);

                    btnFirst_Click(sender, e);
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 1;
            nodCurrent = properties.First;

            txtPropertyNumber.Text = nodCurrent.Value.PropertyNumber;
            txtPropertyType.Text = nodCurrent.Value.PropertyType;
            txtAddress.Text = nodCurrent.Value.Address;
            txtCity.Text = nodCurrent.Value.City;
            txtState.Text = nodCurrent.Value.State;
            txtZipcode.Text = nodCurrent.Value.ZIPCode;
            txtStories.Text = nodCurrent.Value.Stories.ToString();
            txtYearBuilt.Text = nodCurrent.Value.YearBuilt.ToString();
            txtBedrooms.Text = nodCurrent.Value.Bedrooms.ToString();
            txtBathrooms.Text = nodCurrent.Value.Bathrooms.ToString("F");
            txtCondition.Text = nodCurrent.Value.Condition;
            txtSaleStatus.Text = nodCurrent.Value.SaleStatus;
            txtMarketValue.Text = nodCurrent.Value.MarketValue.ToString("F");

            //string strPictureFile = "C:\\Microsoft Visual C# Application Design\\Altair Realtors\\" + txtPropertyNumber.Text + ".jpg";
            //string strPictureFile = System.IO.Directory.GetCurrentDirectory() + txtPropertyNumber.Text + ".jpg";
            string strPictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" + txtPropertyNumber.Text + ".jpg";
            //MessageBox.Show(strPictureFile);
            if (File.Exists(strPictureFile))
                pbxProperty.Image = Image.FromFile(strPictureFile);
            else
                pbxProperty.Image = Image.FromFile("C:\\Microsoft Visual C# Application Design\\Altair Realtors\\000-000.jpg");

            lblRecordNumber.Text = "1 of " + properties.Count.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;

            if (index >= properties.Count)
                btnLast_Click(sender, e);
            else
            {
                nodCurrent = nodCurrent.Next;

                txtPropertyNumber.Text = nodCurrent.Value.PropertyNumber;
                txtPropertyType.Text = nodCurrent.Value.PropertyType;
                txtAddress.Text = nodCurrent.Value.Address;
                txtCity.Text = nodCurrent.Value.City;
                txtState.Text = nodCurrent.Value.State;
                txtZipcode.Text = nodCurrent.Value.ZIPCode;
                txtStories.Text = nodCurrent.Value.Stories.ToString();
                txtYearBuilt.Text = nodCurrent.Value.YearBuilt.ToString();
                txtBedrooms.Text = nodCurrent.Value.Bedrooms.ToString();
                txtBathrooms.Text = nodCurrent.Value.Bathrooms.ToString("F");
                txtCondition.Text = nodCurrent.Value.Condition;
                txtSaleStatus.Text = nodCurrent.Value.SaleStatus;
                txtMarketValue.Text = nodCurrent.Value.MarketValue.ToString("F");

                //string strPictureFile = "C:\\Microsoft Visual C# Application Design\\Altair Realtors\\" + txtPropertyNumber.Text + ".jpg";
                string strPictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" + txtPropertyNumber.Text + ".jpg";
                if (File.Exists(strPictureFile))
                    pbxProperty.Image = Image.FromFile(strPictureFile);
                else
                    pbxProperty.Image = Image.FromFile("E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg");

                lblRecordNumber.Text = index.ToString() + " of " + properties.Count.ToString();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = properties.Count;
            nodCurrent = properties.Last;

            txtPropertyNumber.Text = nodCurrent.Value.PropertyNumber;
            txtPropertyType.Text = nodCurrent.Value.PropertyType;
            txtAddress.Text = nodCurrent.Value.Address;
            txtCity.Text = nodCurrent.Value.City;
            txtState.Text = nodCurrent.Value.State;
            txtZipcode.Text = nodCurrent.Value.ZIPCode;
            txtStories.Text = nodCurrent.Value.Stories.ToString();
            txtYearBuilt.Text = nodCurrent.Value.YearBuilt.ToString();
            txtBedrooms.Text = nodCurrent.Value.Bedrooms.ToString();
            txtBathrooms.Text = nodCurrent.Value.Bathrooms.ToString("F");
            txtCondition.Text = nodCurrent.Value.Condition;
            txtSaleStatus.Text = nodCurrent.Value.SaleStatus;
            txtMarketValue.Text = nodCurrent.Value.MarketValue.ToString("F");

            //string strPictureFile = "C:\\Microsoft Visual C# Application Design\\Altair Realtors\\" + nodCurrent.Value.PropertyNumber + ".jpg";
            string strPictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" + txtPropertyNumber.Text + ".jpg";

            if (File.Exists(strPictureFile))
                pbxProperty.Image = Image.FromFile(strPictureFile);
            else
                pbxProperty.Image = Image.FromFile("E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg");

            lblRecordNumber.Text = properties.Count.ToString() + " of " + properties.Count.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;

            if (index <= 1)
                btnFirst_Click(sender, e);
            else
            {
                nodCurrent = nodCurrent.Previous;

                txtPropertyNumber.Text = nodCurrent.Value.PropertyNumber;
                txtPropertyType.Text = nodCurrent.Value.PropertyType;
                txtAddress.Text = nodCurrent.Value.Address;
                txtCity.Text = nodCurrent.Value.City;
                txtState.Text = nodCurrent.Value.State;
                txtZipcode.Text = nodCurrent.Value.ZIPCode;
                txtStories.Text = nodCurrent.Value.Stories.ToString();
                txtYearBuilt.Text = nodCurrent.Value.YearBuilt.ToString();
                txtBedrooms.Text = nodCurrent.Value.Bedrooms.ToString();
                txtBathrooms.Text = nodCurrent.Value.Bathrooms.ToString("F");
                txtCondition.Text = nodCurrent.Value.Condition;
                txtSaleStatus.Text = nodCurrent.Value.SaleStatus;
                txtMarketValue.Text = nodCurrent.Value.MarketValue.ToString("F");

                //string strPictureFile = "C:\\Microsoft Visual C# Application Design\\Altair Realtors\\" + txtPropertyNumber.Text + ".jpg";
                string strPictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\" + txtPropertyNumber.Text + ".jpg";
                
                if (File.Exists(strPictureFile))
                    pbxProperty.Image = Image.FromFile(strPictureFile);
                else
                    pbxProperty.Image = Image.FromFile("E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg");

                lblRecordNumber.Text = index.ToString() + " of " + properties.Count.ToString();
            }
        }
    }
        
}    
        

       

        

   
