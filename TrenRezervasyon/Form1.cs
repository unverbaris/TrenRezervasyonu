using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenRezervasyon
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
          

        }
     

        private void btn_rezervasyon_Click(object sender, EventArgs e)
        {
            int kapasite = Convert.ToInt32(txtKisiSay.Text);
            if(kapasite < 20)
            {
                lblSonuc.Visible = true;
                lblSonuc.Text = "Rezervasyon Yapilabilir: " +rdnEvet.Text + "\n" +"Yerlesim Ayrinti: VagonAdi: Vagon 1" + "\n" +  "KisiSayisi: " + kapasite;
                lblSonuc.ForeColor = Color.Green; ;
            }
            else
            {
                lblSonuc.Visible = true;
                lblSonuc.Text = "YerlesimAyrinti:[    ]";
                lblSonuc.ForeColor = Color.Red; ;
            }
            
        }

        private void txtKisiSay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Visible = false;
        }
    }







}
