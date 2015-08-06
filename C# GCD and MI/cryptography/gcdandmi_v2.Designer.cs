namespace cryptography
{
    partial class frm_gcdandmi_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gcdandmi_v2));
            this.grp_main = new System.Windows.Forms.GroupBox();
            this.pb_data = new System.Windows.Forms.ProgressBar();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_userinput = new System.Windows.Forms.TextBox();
            this.txt_domain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_gcd = new System.Windows.Forms.DataGridView();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_gcd)).BeginInit();
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
            this.grp_main.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.grp_main.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grp_main.Location = new System.Drawing.Point(12, 12);
            this.grp_main.Name = "grp_main";
            this.grp_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grp_main.Size = new System.Drawing.Size(387, 132);
            this.grp_main.TabIndex = 1;
            this.grp_main.TabStop = false;
            this.grp_main.Text = "Calculate GCD And MI Version 2";
            // 
            // pb_data
            // 
            this.pb_data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb_data.Location = new System.Drawing.Point(10, 96);
            this.pb_data.Name = "pb_data";
            this.pb_data.Size = new System.Drawing.Size(171, 30);
            this.pb_data.Step = 1;
            this.pb_data.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btn_calc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.btn_calc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_calc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Number <0 for All>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Domain";
            // 
            // DGV_gcd
            // 
            this.DGV_gcd.AllowUserToAddRows = false;
            this.DGV_gcd.AllowUserToDeleteRows = false;
            this.DGV_gcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_gcd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Domain,
            this.Number,
            this.GCD,
            this.MI});
            this.DGV_gcd.Location = new System.Drawing.Point(12, 150);
            this.DGV_gcd.Name = "DGV_gcd";
            this.DGV_gcd.ReadOnly = true;
            this.DGV_gcd.Size = new System.Drawing.Size(387, 239);
            this.DGV_gcd.TabIndex = 2;
            // 
            // Domain
            // 
            this.Domain.Frozen = true;
            this.Domain.HeaderText = "Domain";
            this.Domain.Name = "Domain";
            this.Domain.ReadOnly = true;
            this.Domain.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GCD
            // 
            this.GCD.Frozen = true;
            this.GCD.HeaderText = "GCD";
            this.GCD.Name = "GCD";
            this.GCD.ReadOnly = true;
            this.GCD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MI
            // 
            this.MI.Frozen = true;
            this.MI.HeaderText = "MI";
            this.MI.Name = "MI";
            this.MI.ReadOnly = true;
            this.MI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frm_gcdandmi_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 401);
            this.Controls.Add(this.DGV_gcd);
            this.Controls.Add(this.grp_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_gcdandmi_v2";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCD AND MI v2";
            this.Load += new System.EventHandler(this.frm_gcdandmi_v2_Load);
            this.grp_main.ResumeLayout(false);
            this.grp_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_gcd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.ProgressBar pb_data;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_userinput;
        private System.Windows.Forms.TextBox txt_domain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_gcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn GCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MI;
    }
}