using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Tela_de_Splash
{
    public partial class frm_Principal : Form
    {
        private IconButton btncolor;
        private Panel leftborderbtn;

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 84);
            panelMenu.Controls.Add(leftborderbtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 130, 12);

        }
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn!=null)
            {
                DisableButton();
                btncolor = (IconButton)senderBtn;
                btncolor.BackColor = Color.FromArgb(40, 40, 40);
                btncolor.ForeColor = color;
                btncolor.TextAlign = ContentAlignment.MiddleCenter;
                btncolor.IconColor = color;
                btncolor.TextImageRelation = TextImageRelation.TextBeforeImage;
                btncolor.ImageAlign = ContentAlignment.MiddleRight;

                leftborderbtn.BackColor = color;
                leftborderbtn.Location = new Point(0, btncolor.Location.Y);
                leftborderbtn.Visible = true;
                leftborderbtn.BringToFront();

            }

        }
        private void DisableButton()
        { if(btncolor != null)
            {
                btncolor.BackColor = Color.FromArgb(55, 55, 55);
                btncolor.ForeColor = Color.Gainsboro;
                btncolor.TextAlign = ContentAlignment.MiddleCenter;
                btncolor.IconColor = Color.Gainsboro;
                btncolor.TextImageRelation = TextImageRelation.ImageBeforeText;
                btncolor.ImageAlign = ContentAlignment.MiddleCenter;
              
            } 

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftborderbtn.Visible = false;

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }
    }
}
