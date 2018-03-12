namespace Powing_System
{
    partial class ucPowingDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_CaratDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NewRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddRate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CaratType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CaratPrice = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.dgv_insterestRate = new System.Windows.Forms.DataGridView();
            this.btn_EditRate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaratDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insterestRate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CaratDetails
            // 
            this.dgv_CaratDetails.AllowUserToAddRows = false;
            this.dgv_CaratDetails.AllowUserToDeleteRows = false;
            this.dgv_CaratDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CaratDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CaratDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CaratDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CaratDetails.Location = new System.Drawing.Point(12, 22);
            this.dgv_CaratDetails.Name = "dgv_CaratDetails";
            this.dgv_CaratDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CaratDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CaratDetails.Size = new System.Drawing.Size(657, 149);
            this.dgv_CaratDetails.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_NewRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_Rate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_AddRate);
            this.groupBox1.Location = new System.Drawing.Point(28, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Interest Rate Details";
            // 
            // txt_NewRate
            // 
            this.txt_NewRate.Location = new System.Drawing.Point(155, 58);
            this.txt_NewRate.MaxLength = 5;
            this.txt_NewRate.Name = "txt_NewRate";
            this.txt_NewRate.Size = new System.Drawing.Size(121, 20);
            this.txt_NewRate.TabIndex = 9;
            this.txt_NewRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NewRate_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "New Rate :";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.AutoSize = true;
            this.lbl_Rate.Location = new System.Drawing.Point(152, 27);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(35, 13);
            this.lbl_Rate.TabIndex = 7;
            this.lbl_Rate.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rate No :";
            // 
            // btn_AddRate
            // 
            this.btn_AddRate.Location = new System.Drawing.Point(201, 93);
            this.btn_AddRate.Name = "btn_AddRate";
            this.btn_AddRate.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRate.TabIndex = 5;
            this.btn_AddRate.Text = "Add";
            this.btn_AddRate.UseVisualStyleBackColor = true;
            this.btn_AddRate.Click += new System.EventHandler(this.btn_AddRate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txt_CaratType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_CaratPrice);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(382, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new carat Details";
            // 
            // txt_CaratType
            // 
            this.txt_CaratType.Location = new System.Drawing.Point(169, 29);
            this.txt_CaratType.MaxLength = 4;
            this.txt_CaratType.Name = "txt_CaratType";
            this.txt_CaratType.Size = new System.Drawing.Size(121, 20);
            this.txt_CaratType.TabIndex = 9;
            this.txt_CaratType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CaratType_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price of Carat for 1 Pawn :";
            // 
            // txt_CaratPrice
            // 
            this.txt_CaratPrice.Location = new System.Drawing.Point(170, 58);
            this.txt_CaratPrice.MaxLength = 4;
            this.txt_CaratPrice.Name = "txt_CaratPrice";
            this.txt_CaratPrice.Size = new System.Drawing.Size(121, 20);
            this.txt_CaratPrice.TabIndex = 7;
            this.txt_CaratPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CaratPrice_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(215, 93);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carat Type :";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(593, 177);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Edit Carat";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // dgv_insterestRate
            // 
            this.dgv_insterestRate.AllowUserToAddRows = false;
            this.dgv_insterestRate.AllowUserToDeleteRows = false;
            this.dgv_insterestRate.BackgroundColor = System.Drawing.Color.White;
            this.dgv_insterestRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_insterestRate.Location = new System.Drawing.Point(11, 19);
            this.dgv_insterestRate.Name = "dgv_insterestRate";
            this.dgv_insterestRate.ReadOnly = true;
            this.dgv_insterestRate.Size = new System.Drawing.Size(657, 139);
            this.dgv_insterestRate.TabIndex = 6;
            // 
            // btn_EditRate
            // 
            this.btn_EditRate.Location = new System.Drawing.Point(593, 166);
            this.btn_EditRate.Name = "btn_EditRate";
            this.btn_EditRate.Size = new System.Drawing.Size(75, 23);
            this.btn_EditRate.TabIndex = 8;
            this.btn_EditRate.Text = "Edit Rate";
            this.btn_EditRate.UseVisualStyleBackColor = true;
            this.btn_EditRate.Click += new System.EventHandler(this.btn_EditRate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.dgv_CaratDetails);
            this.groupBox3.Controls.Add(this.btn_Edit);
            this.groupBox3.Location = new System.Drawing.Point(28, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 210);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carat Details";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.dgv_insterestRate);
            this.groupBox4.Controls.Add(this.btn_EditRate);
            this.groupBox4.Location = new System.Drawing.Point(28, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 196);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insterest Details";
            // 
            // ucPowingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPowingDetails";
            this.Size = new System.Drawing.Size(736, 581);
            this.Load += new System.EventHandler(this.ucPowingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaratDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insterestRate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CaratDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CaratPrice;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_NewRate;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_insterestRate;
        private System.Windows.Forms.Button btn_EditRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_CaratType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}
