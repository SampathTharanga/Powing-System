namespace Powing_System
{
    partial class ucCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Passport = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_AddLine2 = new System.Windows.Forms.TextBox();
            this.txt_AddLine1 = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_CusNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.cbx_Carat = new System.Windows.Forms.ComboBox();
            this.cbx_Type = new System.Windows.Forms.ComboBox();
            this.lbl_JeweNo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.dgv_customerAdd = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Paying = new System.Windows.Forms.TextBox();
            this.lbl_saving = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_inerestRate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.toolTip_Name = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Address1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_address2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_city = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_tel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_NIC = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_pasport = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_weight = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Paying = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_Passport);
            this.groupBox1.Controls.Add(this.txt_NIC);
            this.groupBox1.Controls.Add(this.txt_Tel);
            this.groupBox1.Controls.Add(this.txt_City);
            this.groupBox1.Controls.Add(this.txt_AddLine2);
            this.groupBox1.Controls.Add(this.txt_AddLine1);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.lbl_CusNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details of Customer";
            // 
            // txt_Passport
            // 
            this.txt_Passport.Location = new System.Drawing.Point(435, 103);
            this.txt_Passport.MaxLength = 15;
            this.txt_Passport.Name = "txt_Passport";
            this.txt_Passport.Size = new System.Drawing.Size(204, 20);
            this.txt_Passport.TabIndex = 7;
            this.txt_Passport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Passport_KeyPress);
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(435, 74);
            this.txt_NIC.MaxLength = 10;
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(204, 20);
            this.txt_NIC.TabIndex = 6;
            this.txt_NIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NIC_KeyPress);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(435, 46);
            this.txt_Tel.MaxLength = 10;
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(204, 20);
            this.txt_Tel.TabIndex = 5;
            this.txt_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tel_KeyPress);
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(435, 18);
            this.txt_City.MaxLength = 20;
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(204, 20);
            this.txt_City.TabIndex = 4;
            this.txt_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_City_KeyPress);
            // 
            // txt_AddLine2
            // 
            this.txt_AddLine2.Location = new System.Drawing.Point(128, 106);
            this.txt_AddLine2.MaxLength = 20;
            this.txt_AddLine2.Name = "txt_AddLine2";
            this.txt_AddLine2.Size = new System.Drawing.Size(204, 20);
            this.txt_AddLine2.TabIndex = 3;
            this.txt_AddLine2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AddLine2_KeyPress);
            // 
            // txt_AddLine1
            // 
            this.txt_AddLine1.Location = new System.Drawing.Point(128, 77);
            this.txt_AddLine1.MaxLength = 20;
            this.txt_AddLine1.Name = "txt_AddLine1";
            this.txt_AddLine1.Size = new System.Drawing.Size(204, 20);
            this.txt_AddLine1.TabIndex = 2;
            this.txt_AddLine1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AddLine1_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(128, 49);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(204, 20);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // lbl_CusNo
            // 
            this.lbl_CusNo.AutoSize = true;
            this.lbl_CusNo.Location = new System.Drawing.Point(128, 25);
            this.lbl_CusNo.Name = "lbl_CusNo";
            this.lbl_CusNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_CusNo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Passport :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "NIC        :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tel         :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address Line 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address Line 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name               :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer No    :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.btn_Add);
            this.groupBox4.Controls.Add(this.txt_Weight);
            this.groupBox4.Controls.Add(this.cbx_Carat);
            this.groupBox4.Controls.Add(this.cbx_Type);
            this.groupBox4.Controls.Add(this.lbl_JeweNo);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(36, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(665, 93);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details of Pown Jewellery";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(524, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 21;
            this.label29.Text = "K";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::Powing_System.Properties.Resources.ADDx64;
            this.btn_Add.Location = new System.Drawing.Point(575, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(67, 69);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(405, 54);
            this.txt_Weight.MaxLength = 4;
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(119, 20);
            this.txt_Weight.TabIndex = 10;
            this.txt_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Weight_KeyPress);
            // 
            // cbx_Carat
            // 
            this.cbx_Carat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Carat.FormattingEnabled = true;
            this.cbx_Carat.Location = new System.Drawing.Point(405, 23);
            this.cbx_Carat.Name = "cbx_Carat";
            this.cbx_Carat.Size = new System.Drawing.Size(119, 21);
            this.cbx_Carat.TabIndex = 9;
            // 
            // cbx_Type
            // 
            this.cbx_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Type.FormattingEnabled = true;
            this.cbx_Type.Location = new System.Drawing.Point(141, 54);
            this.cbx_Type.Name = "cbx_Type";
            this.cbx_Type.Size = new System.Drawing.Size(119, 21);
            this.cbx_Type.TabIndex = 8;
            // 
            // lbl_JeweNo
            // 
            this.lbl_JeweNo.AutoSize = true;
            this.lbl_JeweNo.Location = new System.Drawing.Point(141, 27);
            this.lbl_JeweNo.Name = "lbl_JeweNo";
            this.lbl_JeweNo.Size = new System.Drawing.Size(41, 13);
            this.lbl_JeweNo.TabIndex = 8;
            this.lbl_JeweNo.Text = "label20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Weight (Pawn)      :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(287, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Type of Carat      :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Type of Jewellery ;";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Jewellery No        :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(74, 13);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 13);
            this.lbl_Date.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(570, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 10;
            this.label27.Text = "Officer ID :";
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(634, 13);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(41, 13);
            this.lbl_UserId.TabIndex = 11;
            this.lbl_UserId.Text = "label28";
            // 
            // dgv_customerAdd
            // 
            this.dgv_customerAdd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_customerAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerAdd.Location = new System.Drawing.Point(36, 296);
            this.dgv_customerAdd.Name = "dgv_customerAdd";
            this.dgv_customerAdd.Size = new System.Drawing.Size(665, 159);
            this.dgv_customerAdd.TabIndex = 12;
            this.dgv_customerAdd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customerAdd_CellValueChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(627, 544);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Reset";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(546, 544);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "Add";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Paying);
            this.groupBox2.Controls.Add(this.lbl_saving);
            this.groupBox2.Controls.Add(this.lbl_amount);
            this.groupBox2.Controls.Add(this.lbl_inerestRate);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Location = new System.Drawing.Point(35, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 76);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate";
            // 
            // txt_Paying
            // 
            this.txt_Paying.Location = new System.Drawing.Point(506, 16);
            this.txt_Paying.Name = "txt_Paying";
            this.txt_Paying.Size = new System.Drawing.Size(125, 20);
            this.txt_Paying.TabIndex = 33;
            this.txt_Paying.Text = "0.0";
            this.txt_Paying.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Paying_MouseClick);
            this.txt_Paying.TextChanged += new System.EventHandler(this.txt_Paying_TextChanged);
            this.txt_Paying.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Paying_KeyPress);
            this.txt_Paying.MouseLeave += new System.EventHandler(this.txt_Paying_MouseLeave);
            // 
            // lbl_saving
            // 
            this.lbl_saving.AutoSize = true;
            this.lbl_saving.Location = new System.Drawing.Point(504, 46);
            this.lbl_saving.Name = "lbl_saving";
            this.lbl_saving.Size = new System.Drawing.Size(0, 13);
            this.lbl_saving.TabIndex = 32;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(196, 46);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(0, 13);
            this.lbl_amount.TabIndex = 31;
            // 
            // lbl_inerestRate
            // 
            this.lbl_inerestRate.AutoSize = true;
            this.lbl_inerestRate.Location = new System.Drawing.Point(196, 20);
            this.lbl_inerestRate.Name = "lbl_inerestRate";
            this.lbl_inerestRate.Size = new System.Drawing.Size(0, 13);
            this.lbl_inerestRate.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Amount :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Interest Rate                    :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(355, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Paying                              :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(355, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(132, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Savings                            :";
            // 
            // toolTip_Name
            // 
            this.toolTip_Name.BackColor = System.Drawing.Color.Red;
            this.toolTip_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolTip_Name.IsBalloon = true;
            // 
            // toolTip_Address1
            // 
            this.toolTip_Address1.IsBalloon = true;
            // 
            // toolTip_address2
            // 
            this.toolTip_address2.IsBalloon = true;
            // 
            // toolTip_city
            // 
            this.toolTip_city.IsBalloon = true;
            // 
            // toolTip_tel
            // 
            this.toolTip_tel.IsBalloon = true;
            // 
            // toolTip_NIC
            // 
            this.toolTip_NIC.IsBalloon = true;
            // 
            // toolTip_pasport
            // 
            this.toolTip_pasport.IsBalloon = true;
            // 
            // toolTip_weight
            // 
            this.toolTip_weight.IsBalloon = true;
            // 
            // toolTip_Paying
            // 
            this.toolTip_Paying.IsBalloon = true;
            // 
            // ucCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dgv_customerAdd);
            this.Controls.Add(this.lbl_UserId);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Date);
            this.Name = "ucCustomer";
            this.Size = new System.Drawing.Size(736, 581);
            this.Load += new System.EventHandler(this.ucCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_CusNo;
        private System.Windows.Forms.TextBox txt_Passport;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_AddLine2;
        private System.Windows.Forms.TextBox txt_AddLine1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.ComboBox cbx_Carat;
        private System.Windows.Forms.ComboBox cbx_Type;
        private System.Windows.Forms.Label lbl_JeweNo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.DataGridView dgv_customerAdd;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_Paying;
        private System.Windows.Forms.Label lbl_saving;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_inerestRate;
        private System.Windows.Forms.ToolTip toolTip_Name;
        private System.Windows.Forms.ToolTip toolTip_Address1;
        private System.Windows.Forms.ToolTip toolTip_address2;
        private System.Windows.Forms.ToolTip toolTip_city;
        private System.Windows.Forms.ToolTip toolTip_tel;
        private System.Windows.Forms.ToolTip toolTip_NIC;
        private System.Windows.Forms.ToolTip toolTip_pasport;
        private System.Windows.Forms.ToolTip toolTip_weight;
        private System.Windows.Forms.ToolTip toolTip_Paying;
    }
}
