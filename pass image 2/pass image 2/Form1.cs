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
    public partial class Form1 : Form
    {
         private System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
       private System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();

        Form2 _form2 = null;
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            //Init usually done by the designer
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Load +=new EventHandler(Form1_Load);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.pictureBox1.Image != null)
                this.pictureBox1.Image.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            Image image;
            image = Image.FromFile(@"..\..\pic\1.jpg");
            //add a valid image here...
            this.pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_form2 == null || _form2.IsDisposed)
                _form2 = new Form2();

            _form2.Show();

            _form2.AddPicture(this.pictureBox1.Image);
        }
    }
    }