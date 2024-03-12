using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class CustomerButtons : PictureBox
    {
        public CustomerButtons()
        {
            InitializeComponent();
        }

        private Image NormalImage;
        private Image HoverImage;

        public Image ImageNormal
        {
            get { return NormalImage; }
            set { NormalImage = value; }

        }

        public Image ImageHover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }

        private void CustomerButtons_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomerButtons_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
