using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avatar
{
    public partial class avatar_juego : UserControl
    {
      
        private bool active;

        public avatar_juego()
        {
            this.Anchor = AnchorStyles.None;
            InitializeComponent();
        }


        public string getNameAvatar()
        {
           
            return lblNameAvatar.Text;
        }

        public PictureBox getPictureBox()
        {
            return pbAvatar;
        }

        public Label getLabel()
        {
            return lblNameAvatar;
        }

        public void setActive(bool active)
        {
            this.active = active;
            if (this.active == true)
            {
                pbAvatar.BackColor = Color.LightGreen;
                lblNameAvatar.BackColor = Color.DarkGreen;
                lblNameAvatar.ForeColor = Color.White;
                
              
            } else
            if (this.active==false)
            {
                pbAvatar.BackColor = Color.LightSalmon;
                lblNameAvatar.BackColor = Color.MistyRose;
                lblNameAvatar.ForeColor = Color.Black;

            }
       
        }

        public bool getActive()
        {
            return active;
        }


        public void setImage(Bitmap image)
        {
            pbAvatar.Image = image;
        }

        public void setName(string name)
        {
            lblNameAvatar.Text = name;
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
