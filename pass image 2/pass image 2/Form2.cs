using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass_image_2
{
    public partial class Form2 : Form
    {
        
            private System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();

            public Form2()
            {
                InitializeComponent();
                this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);

                // 
                // pictureBox1
                // 
                this.pictureBox1.Location = new System.Drawing.Point(12, 12);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(260, 166);
                this.pictureBox1.TabIndex = 0;
                this.pictureBox1.TabStop = false;
                this.ClientSize = new System.Drawing.Size(284, 262);
                this.Controls.Add(this.pictureBox1);
            }

            void Form2_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (this.pictureBox1.Image != null)
                    this.pictureBox1.Image.Dispose();
            }

            internal void AddPicture(Image img)
            {
                Image iOld = this.pictureBox1.Image;
                this.pictureBox1.Image = (Image)img.Clone();

                if (iOld != null)
                    iOld.Dispose();
            }
        }
    }

