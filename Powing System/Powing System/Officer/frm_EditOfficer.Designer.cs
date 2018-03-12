namespace Powing_System
{
    partial class frm_EditOfficer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_OfficerID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_curPass = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.txt_ReEnterNewPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Officer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Officer ID :";
            // 
            // lbl_OfficerID
            // 
            this.lbl_OfficerID.AutoSize = true;
            this.lbl_OfficerID.Location = new System.Drawing.Point(168, 60);
            this.lbl_OfficerID.Name = "lbl_OfficerID";
            this.lbl_OfficerID.Size = new System.Drawing.Size(0, 13);
            this.lbl_OfficerID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Password :";
            // 
            // txt_curPass
            // 
            this.txt_curPass.Location = new System.Drawing.Point(168, 83);
            this.txt_curPass.Name = "txt_curPass";
            this.txt_curPass.Size = new System.Drawing.Size(137, 20);
            this.txt_curPass.TabIndex = 4;
            this.txt_curPass.UseSystemPasswordChar = true;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Green;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ok.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ok.Location = new System.Drawing.Point(308, 81);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(34, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "New Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Reenter New Password :";
            // 
            // txt_newPass
            // 
            this.txt_newPass.Enabled = false;
            this.txt_newPass.Location = new System.Drawing.Point(168, 113);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(174, 20);
            this.txt_newPass.TabIndex = 8;
            this.txt_newPass.UseSystemPasswordChar = true;
            // 
            // txt_ReEnterNewPass
            // 
            this.txt_ReEnterNewPass.Enabled = false;
            this.txt_ReEnterNewPass.Location = new System.Drawing.Point(168, 143);
            this.txt_ReEnterNewPass.Name = "txt_ReEnterNewPass";
            this.txt_ReEnterNewPass.Size = new System.Drawing.Size(174, 20);
            this.txt_ReEnterNewPass.TabIndex = 9;
            this.txt_ReEnterNewPass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(185, 174);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // frm_EditOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(369, 207);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_ReEnterNewPass);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_curPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_OfficerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_EditOfficer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Officer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_OfficerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_curPass;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.TextBox txt_ReEnterNewPass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_update;
    }
}