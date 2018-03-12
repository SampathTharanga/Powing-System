namespace Powing_System
{
    partial class ucPowingOfficer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_OfficerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_PowingOfficer = new System.Windows.Forms.DataGridView();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_avaUser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PowingOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.lbl_Date);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.txt_ConfirmPass);
            this.groupBox2.Controls.Add(this.txt_Password);
            this.groupBox2.Controls.Add(this.txt_OfficerID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(28, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Powing Officer";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(386, 89);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(117, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(137, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(35, 13);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date :";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(515, 89);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(117, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Location = new System.Drawing.Point(457, 51);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(175, 20);
            this.txt_ConfirmPass.TabIndex = 8;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(457, 20);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(175, 20);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_OfficerID
            // 
            this.txt_OfficerID.Location = new System.Drawing.Point(136, 51);
            this.txt_OfficerID.Name = "txt_OfficerID";
            this.txt_OfficerID.Size = new System.Drawing.Size(150, 20);
            this.txt_OfficerID.TabIndex = 6;
            this.txt_OfficerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OfficerID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Officer ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // dgv_PowingOfficer
            // 
            this.dgv_PowingOfficer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_PowingOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PowingOfficer.Location = new System.Drawing.Point(28, 191);
            this.dgv_PowingOfficer.Name = "dgv_PowingOfficer";
            this.dgv_PowingOfficer.Size = new System.Drawing.Size(681, 348);
            this.dgv_PowingOfficer.TabIndex = 2;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(634, 549);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit User";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Avalable User :";
            // 
            // lbl_avaUser
            // 
            this.lbl_avaUser.AutoSize = true;
            this.lbl_avaUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_avaUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_avaUser.Location = new System.Drawing.Point(174, 155);
            this.lbl_avaUser.Name = "lbl_avaUser";
            this.lbl_avaUser.Size = new System.Drawing.Size(60, 28);
            this.lbl_avaUser.TabIndex = 14;
            this.lbl_avaUser.Text = "label3";
            // 
            // ucPowingOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_avaUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dgv_PowingOfficer);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucPowingOfficer";
            this.Size = new System.Drawing.Size(736, 581);
            this.Load += new System.EventHandler(this.ucPowingOfficer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PowingOfficer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_OfficerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_PowingOfficer;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_avaUser;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
