namespace CSCI463_TermProject
{
    partial class Form1
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
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.lblFloorNum = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listAlarmsFloor = new System.Windows.Forms.ListView();
            this.headStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headAlarms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDoorsFloor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAlarmsRoom = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDoorsRoom = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.lblEmergency2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.listAlarms = new System.Windows.Forms.ListView();
            this.Alarms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblRoom.Location = new System.Drawing.Point(23, 219);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(102, 37);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Room";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblFloor.Location = new System.Drawing.Point(23, 25);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(91, 37);
            this.lblFloor.TabIndex = 2;
            this.lblFloor.Text = "Floor";
            this.lblFloor.Click += new System.EventHandler(this.lblFloor_Click);
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3"});
            this.comboBoxFloor.Location = new System.Drawing.Point(30, 99);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFloor.TabIndex = 9;
            this.comboBoxFloor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFloor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a Floor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select a Room";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(30, 292);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoom.TabIndex = 12;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // lblFloorNum
            // 
            this.lblFloorNum.AutoSize = true;
            this.lblFloorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblFloorNum.Location = new System.Drawing.Point(111, 25);
            this.lblFloorNum.Name = "lblFloorNum";
            this.lblFloorNum.Size = new System.Drawing.Size(0, 37);
            this.lblFloorNum.TabIndex = 13;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblRoomNum.Location = new System.Drawing.Point(120, 219);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(0, 37);
            this.lblRoomNum.TabIndex = 14;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 431);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 37);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alarms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alarms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Doors";
            // 
            // listAlarmsFloor
            // 
            this.listAlarmsFloor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headStatus,
            this.headAlarms});
            this.listAlarmsFloor.GridLines = true;
            this.listAlarmsFloor.HideSelection = false;
            this.listAlarmsFloor.Location = new System.Drawing.Point(182, 25);
            this.listAlarmsFloor.Name = "listAlarmsFloor";
            this.listAlarmsFloor.Size = new System.Drawing.Size(150, 180);
            this.listAlarmsFloor.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAlarmsFloor.TabIndex = 24;
            this.listAlarmsFloor.UseCompatibleStateImageBehavior = false;
            this.listAlarmsFloor.View = System.Windows.Forms.View.Details;
            // 
            // headStatus
            // 
            this.headStatus.Text = "Alarms";
            // 
            // headAlarms
            // 
            this.headAlarms.Text = "Status";
            this.headAlarms.Width = 80;
            // 
            // listDoorsFloor
            // 
            this.listDoorsFloor.BackColor = System.Drawing.SystemColors.Window;
            this.listDoorsFloor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listDoorsFloor.GridLines = true;
            this.listDoorsFloor.HideSelection = false;
            this.listDoorsFloor.Location = new System.Drawing.Point(351, 25);
            this.listDoorsFloor.Name = "listDoorsFloor";
            this.listDoorsFloor.Size = new System.Drawing.Size(150, 180);
            this.listDoorsFloor.TabIndex = 25;
            this.listDoorsFloor.UseCompatibleStateImageBehavior = false;
            this.listDoorsFloor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doors";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 80;
            // 
            // listAlarmsRoom
            // 
            this.listAlarmsRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listAlarmsRoom.GridLines = true;
            this.listAlarmsRoom.HideSelection = false;
            this.listAlarmsRoom.Location = new System.Drawing.Point(182, 235);
            this.listAlarmsRoom.Name = "listAlarmsRoom";
            this.listAlarmsRoom.Size = new System.Drawing.Size(150, 180);
            this.listAlarmsRoom.TabIndex = 26;
            this.listAlarmsRoom.UseCompatibleStateImageBehavior = false;
            this.listAlarmsRoom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Alarms";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 80;
            // 
            // listDoorsRoom
            // 
            this.listDoorsRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listDoorsRoom.GridLines = true;
            this.listDoorsRoom.HideSelection = false;
            this.listDoorsRoom.Location = new System.Drawing.Point(351, 235);
            this.listDoorsRoom.Name = "listDoorsRoom";
            this.listDoorsRoom.Size = new System.Drawing.Size(150, 180);
            this.listDoorsRoom.TabIndex = 27;
            this.listDoorsRoom.UseCompatibleStateImageBehavior = false;
            this.listDoorsRoom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doors";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Doors";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Doors";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(12, 388);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 37);
            this.btnSim.TabIndex = 30;
            this.btnSim.Text = "Simulate Emergency";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Visible = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // lblEmergency
            // 
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.lblEmergency.ForeColor = System.Drawing.Color.Red;
            this.lblEmergency.Location = new System.Drawing.Point(507, 25);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(263, 51);
            this.lblEmergency.TabIndex = 33;
            this.lblEmergency.Text = "Emergency!";
            this.lblEmergency.Visible = false;
            this.lblEmergency.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblEmergency2
            // 
            this.lblEmergency2.AutoSize = true;
            this.lblEmergency2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergency2.ForeColor = System.Drawing.Color.Red;
            this.lblEmergency2.Location = new System.Drawing.Point(585, 97);
            this.lblEmergency2.Name = "lblEmergency2";
            this.lblEmergency2.Size = new System.Drawing.Size(107, 80);
            this.lblEmergency2.TabIndex = 34;
            this.lblEmergency2.Text = "Alarms active.\r\nSprinklers on.\r\nDoors closed.\r\nExit lights on.";
            this.lblEmergency2.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(614, 443);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset Alarms";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(695, 443);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 37);
            this.btnConfirm.TabIndex = 36;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // listAlarms
            // 
            this.listAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Alarms});
            this.listAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAlarms.ForeColor = System.Drawing.Color.Red;
            this.listAlarms.GridLines = true;
            this.listAlarms.HideSelection = false;
            this.listAlarms.Location = new System.Drawing.Point(541, 205);
            this.listAlarms.Name = "listAlarms";
            this.listAlarms.Size = new System.Drawing.Size(206, 210);
            this.listAlarms.TabIndex = 37;
            this.listAlarms.UseCompatibleStateImageBehavior = false;
            this.listAlarms.View = System.Windows.Forms.View.Details;
            // 
            // Alarms
            // 
            this.Alarms.Text = "Active Alarms";
            this.Alarms.Width = 201;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(93, 431);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 37);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblServices.ForeColor = System.Drawing.Color.Red;
            this.lblServices.Location = new System.Drawing.Point(212, 447);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(289, 24);
            this.lblServices.TabIndex = 39;
            this.lblServices.Text = "Contacting emergency services...";
            this.lblServices.Visible = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(93, 388);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 37);
            this.btnAddUser.TabIndex = 40;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 471);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 13);
            this.lblWelcome.TabIndex = 41;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.listAlarms);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblEmergency2);
            this.Controls.Add(this.lblEmergency);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listDoorsRoom);
            this.Controls.Add(this.listAlarmsRoom);
            this.Controls.Add(this.listDoorsFloor);
            this.Controls.Add(this.listAlarmsFloor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.lblFloorNum);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFloor);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblRoom);
            this.Name = "Form1";
            this.Text = "Emergency Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label lblFloorNum;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listAlarmsFloor;
        private System.Windows.Forms.ColumnHeader headAlarms;
        private System.Windows.Forms.ColumnHeader headStatus;
        private System.Windows.Forms.ListView listDoorsFloor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listAlarmsRoom;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listDoorsRoom;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label lblEmergency2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListView listAlarms;
        private System.Windows.Forms.ColumnHeader Alarms;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCancel;
    }
}

