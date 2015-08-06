namespace cryptography
{
    partial class frm_gcdandmi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gcdandmi));
            this.grp_main = new System.Windows.Forms.GroupBox();
            this.pb_data = new System.Windows.Forms.ProgressBar();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_userinput = new System.Windows.Forms.TextBox();
            this.txt_domain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_lyout_gcd = new System.Windows.Forms.TableLayoutPanel();
            this.grp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_main
            // 
            this.grp_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grp_main.Controls.Add(this.pb_data);
            this.grp_main.Controls.Add(this.btn_reset);
            this.grp_main.Controls.Add(this.btn_calc);
            this.grp_main.Controls.Add(this.txt_userinput);
            this.grp_main.Controls.Add(this.txt_domain);
            this.grp_main.Controls.Add(this.label2);
            this.grp_main.Controls.Add(this.label1);
            this.grp_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_main.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_main.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grp_main.Location = new System.Drawing.Point(10, 12);
            this.grp_main.Name = "grp_main";
            this.grp_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grp_main.Size = new System.Drawing.Size(387, 132);
            this.grp_main.TabIndex = 0;
            this.grp_main.TabStop = false;
            this.grp_main.Text = "Calculate GCD And MI";
            // 
            // pb_data
            // 
            this.pb_data.Location = new System.Drawing.Point(10, 96);
            this.pb_data.Name = "pb_data";
            this.pb_data.Size = new System.Drawing.Size(171, 30);
            this.pb_data.Step = 1;
            this.pb_data.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_reset.Location = new System.Drawing.Point(304, 96);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(76, 30);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_calc.Location = new System.Drawing.Point(187, 96);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(111, 30);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Find GCD And MI";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_userinput
            // 
            this.txt_userinput.BackColor = System.Drawing.SystemColors.Window;
            this.txt_userinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userinput.Location = new System.Drawing.Point(187, 59);
            this.txt_userinput.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userinput.Name = "txt_userinput";
            this.txt_userinput.Size = new System.Drawing.Size(193, 31);
            this.txt_userinput.TabIndex = 3;
            // 
            // txt_domain
            // 
            this.txt_domain.BackColor = System.Drawing.SystemColors.Window;
            this.txt_domain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_domain.Location = new System.Drawing.Point(187, 24);
            this.txt_domain.Margin = new System.Windows.Forms.Padding(2);
            this.txt_domain.Name = "txt_domain";
            this.txt_domain.Size = new System.Drawing.Size(193, 31);
            this.txt_domain.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Number <0 for All>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Domain";
            // 
            // tbl_lyout_gcd
            // 
            this.tbl_lyout_gcd.AutoScroll = true;
            this.tbl_lyout_gcd.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tbl_lyout_gcd.ColumnCount = 4;
            this.tbl_lyout_gcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.65116F));
            this.tbl_lyout_gcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.34884F));
            this.tbl_lyout_gcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tbl_lyout_gcd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tbl_lyout_gcd.Location = new System.Drawing.Point(10, 150);
            this.tbl_lyout_gcd.Name = "tbl_lyout_gcd";
            this.tbl_lyout_gcd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbl_lyout_gcd.RowCount = 2;
            this.tbl_lyout_gcd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_lyout_gcd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl_lyout_gcd.Size = new System.Drawing.Size(389, 239);
            this.tbl_lyout_gcd.TabIndex = 1;
            // 
            // frm_gcdandmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 401);
            this.Controls.Add(this.grp_main);
            this.Controls.Add(this.tbl_lyout_gcd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_gcdandmi";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "GCD And MI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_gcdandmi_Load);
            this.grp_main.ResumeLayout(false);
            this.grp_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_domain;
        private System.Windows.Forms.TextBox txt_userinput;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TableLayoutPanel tbl_lyout_gcd;
        private System.Windows.Forms.ProgressBar pb_data;
    }
}

