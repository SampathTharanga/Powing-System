namespace Powing_System
{
    partial class ucViewPowingOfficer
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
            this.dgv_ViewOfficer = new System.Windows.Forms.DataGridView();
            this.txt_searchOffi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_avalableOfficer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ViewOfficer
            // 
            this.dgv_ViewOfficer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_ViewOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewOfficer.Location = new System.Drawing.Point(37, 68);
            this.dgv_ViewOfficer.Name = "dgv_ViewOfficer";
            this.dgv_ViewOfficer.Size = new System.Drawing.Size(672, 463);
            this.dgv_ViewOfficer.TabIndex = 0;
            // 
            // txt_searchOffi
            // 
            this.txt_searchOffi.Location = new System.Drawing.Point(573, 22);
            this.txt_searchOffi.Name = "txt_searchOffi";
            this.txt_searchOffi.Size = new System.Drawing.Size(136, 20);
            this.txt_searchOffi.TabIndex = 6;
            this.txt_searchOffi.TextChanged += new System.EventHandler(this.txt_searchOffi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Officer ID :";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(634, 546);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit User";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avalable Officer ID is ";
            // 
            // lbl_avalableOfficer
            // 
            this.lbl_avalableOfficer.AutoSize = true;
            this.lbl_avalableOfficer.Location = new System.Drawing.Point(154, 26);
            this.lbl_avalableOfficer.Name = "lbl_avalableOfficer";
            this.lbl_avalableOfficer.Size = new System.Drawing.Size(35, 13);
            this.lbl_avalableOfficer.TabIndex = 1;
            this.lbl_avalableOfficer.Text = "label2";
            // 
            // ucViewPowingOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_avalableOfficer);
            this.Controls.Add(this.txt_searchOffi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.dgv_ViewOfficer);
            this.Name = "ucViewPowingOfficer";
            this.Size = new System.Drawing.Size(736, 581);
            this.Load += new System.EventHandler(this.ucViewPowingOfficer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOfficer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ViewOfficer;
        private System.Windows.Forms.TextBox txt_searchOffi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_avalableOfficer;
    }
}
