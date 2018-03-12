namespace Powing_System
{
    partial class ucViewCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCusView = new System.Windows.Forms.DataGridView();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_CusNo = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCusView
            // 
            this.dgvCusView.AllowUserToAddRows = false;
            this.dgvCusView.AllowUserToDeleteRows = false;
            this.dgvCusView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusView.Location = new System.Drawing.Point(30, 156);
            this.dgvCusView.Name = "dgvCusView";
            this.dgvCusView.ReadOnly = true;
            this.dgvCusView.Size = new System.Drawing.Size(677, 372);
            this.dgvCusView.TabIndex = 0;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(632, 545);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 2;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(536, 545);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_NIC);
            this.groupBox1.Controls.Add(this.txt_CusNo);
            this.groupBox1.Controls.Add(this.txt_Tel);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customer";
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(484, 28);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(159, 23);
            this.txt_NIC.TabIndex = 25;
            this.txt_NIC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_NIC_MouseClick);
            this.txt_NIC.TextChanged += new System.EventHandler(this.txt_NIC_TextChanged);
            // 
            // txt_CusNo
            // 
            this.txt_CusNo.Location = new System.Drawing.Point(484, 62);
            this.txt_CusNo.Name = "txt_CusNo";
            this.txt_CusNo.Size = new System.Drawing.Size(159, 23);
            this.txt_CusNo.TabIndex = 25;
            this.txt_CusNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_CusNo_MouseClick);
            this.txt_CusNo.TextChanged += new System.EventHandler(this.txt_CusNo_TextChanged);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(110, 62);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(159, 23);
            this.txt_Tel.TabIndex = 24;
            this.txt_Tel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Tel_MouseClick);
            this.txt_Tel.TextChanged += new System.EventHandler(this.txt_Tel_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(110, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(159, 23);
            this.txt_Name.TabIndex = 23;
            this.txt_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Name_MouseClick);
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "NIC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tel :";
            // 
            // ucViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.dgvCusView);
            this.Name = "ucViewCustomer";
            this.Size = new System.Drawing.Size(736, 581);
            this.Load += new System.EventHandler(this.ucViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCusView;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_CusNo;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_Name;
    }
}
