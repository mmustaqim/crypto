using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cryptography
{
    public partial class frm_gcdandmi_v2 : Form
    {
        public frm_gcdandmi_v2()
        {
            InitializeComponent();
        }

        private void frm_gcdandmi_v2_Load(object sender, EventArgs e)
        {
            DGV_gcd.Visible = false;
            DGV_gcd.RowHeadersVisible = false;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_gcd.Visible = true;
                controldata cd = new controldata();
                cd.dgv = DGV_gcd;
                int inputdomain = Convert.ToInt32(txt_domain.Text);
                int inputnumber = Convert.ToInt32(txt_userinput.Text);
                calcmethods calculate = new calcmethods();
                if (inputnumber != 0)
                {
                    gcd_mi domain = new gcd_mi();
                    domain = calculate.CalcGcdMi(inputdomain, inputnumber);
                    pb_data.Maximum = 10;
                    cd.NotOnZeroSetDatav2(domain);
                    pb_data.Value = 10;
                }
                else
                {
                    List<gcd_mi> gcdList = new List<gcd_mi>();
                    gcdList = calculate.CalcGcdMi(inputdomain);
                    pb_data.Maximum = gcdList.Count - 1;
                    for (int i = 0, n = 1; i < gcdList.Count; i++, n++)
                    {
                        pb_data.Value = i;
                        cd.SetDatav2(gcdList, i, n);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString(), "ERROR!!!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DGV_gcd.Visible = false;
            DGV_gcd.Rows.Clear();
            pb_data.Value = 0;
            txt_domain.Text = "";
            txt_userinput.Text = "";
        }
    }
}
