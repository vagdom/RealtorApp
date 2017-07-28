using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VagnerRealtor
{
    public partial class PropertyEditor : Form
    {

        public bool pictureChanged;
        public string pictureFile;

        public PropertyEditor()
        {
            InitializeComponent();
        }

        private void PropertyEditor_Load(object sender, EventArgs e)
        {
            pictureChanged = false;
            //MessageBox.Show("#5");
            pictureFile = "E:\\VagnerRealtor\\VagnerRealtor\\000-000.jpg";
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {                     
                pbxProperty.Image = Image.FromFile(dlgPicture.FileName);
                pictureFile = dlgPicture.FileName;
                pictureChanged = true;                
            }
        }
    }
}
