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
    class controldata
    {
        public TableLayoutPanel tbl;
        public DataGridView dgv;
        public int NumRow;

        public void settableheader(TableLayoutPanel tblheader)
        {
            Label hcol1 = new Label();
            hcol1.Text = "Domain";
            hcol1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label hcol2 = new Label();
            hcol2.Text = "Number";
            hcol2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label hcol3 = new Label();
            hcol3.Text = "GCD";
            hcol3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label hcol4 = new Label();
            hcol4.Text = "MI";
            hcol4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            tblheader.Controls.Add(hcol1, 0, 0);
            tblheader.Controls.Add(hcol2, 1, 0);
            tblheader.Controls.Add(hcol3, 2, 0);
            tblheader.Controls.Add(hcol4, 3, 0);
        }

        
        public void NotOnZeroSetDatav2(gcd_mi domain)
        {
            this.NumRow = this.dgv.Rows.Add();
            this.dgv.Rows[NumRow].Cells[0].Value = domain.Domain.ToString();
            this.dgv.Rows[NumRow].Cells[1].Value = domain.Number.ToString();
            this.dgv.Rows[NumRow].Cells[2].Value = domain.Gcd.ToString();
            this.dgv.Rows[NumRow].Cells[3].Value = domain.Mi.ToString();
        }

        public void SetDatav2(List<gcd_mi> gcdList, int i, int n)
        {
            this.NumRow = this.dgv.Rows.Add();
            this.dgv.Rows[NumRow].Cells[0].Value = gcdList[i].Domain.ToString();
            this.dgv.Rows[NumRow].Cells[1].Value = gcdList[i].Number.ToString();
            this.dgv.Rows[NumRow].Cells[2].Value = gcdList[i].Gcd.ToString();
            this.dgv.Rows[NumRow].Cells[3].Value = gcdList[i].Mi.ToString();
        }

    }
}
