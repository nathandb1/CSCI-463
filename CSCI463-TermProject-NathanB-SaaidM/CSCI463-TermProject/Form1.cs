using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI463_TermProject
{
    public partial class Form1 : Form
    {
        System.Random random = new System.Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblFloorNum_Click(object sender, EventArgs e)
        {

        }

        private void lblFloor_Click(object sender, EventArgs e)
        {

        }

        private void listAlarmsRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logins.Add("username", "password");
            logins.Add("userAdmin", "adminPass");
            admins.Add("userAdmin");
        }

        public static bool loggedIn = false;
        public static bool loggedInAdmin = false;


        public static Dictionary<String, String> logins = new Dictionary<String, String>();

        public static List<String> admins = new List<String>();
        public static List<String> ongoingAlarms = new List<String>();

        private void CheckForAlarms()
        {
            if (ongoingAlarms.Count != 0)
            {
                lblEmergency.Visible = true;
                lblEmergency2.Visible = true;
                lblServices.Visible = true;
                int i = 0;
                while (i < ongoingAlarms.Count)
                {
                    if (listAlarmsFloor.Items.Count > 0)
                    {
                        int floorIndex = listAlarmsFloor.Items.IndexOf(listAlarmsFloor.FindItemWithText(ongoingAlarms[i], false, 0, false));
                        int roomIndex = listAlarmsRoom.Items.IndexOf(listAlarmsRoom.FindItemWithText(ongoingAlarms[i]));
                    
                        if (floorIndex != -1)
                        {
                            listAlarmsFloor.Items.Remove(listAlarmsFloor.FindItemWithText(ongoingAlarms[i]));
                            listAlarmsFloor.Items.Insert(floorIndex, new ListViewItem(new string[] {ongoingAlarms[i], "EMERGENCY" }));
                            for (int j = 0; j < 20; j++)
                            {
                                int doorIndex = listDoorsFloor.Items.IndexOf(listDoorsFloor.FindItemWithText("Door " + j, false, 0, false));
                                if (doorIndex != -1)
                                {
                                    listDoorsFloor.Items.Remove(listDoorsFloor.FindItemWithText("Door " + j));
                                    listDoorsFloor.Items.Insert(doorIndex, new ListViewItem(new string[] { "Door " + j, "CLOSED" }));
                                    if (listAlarmsRoom.Items.Count != 0)
                                    {
                                        int doorIndex2 = listDoorsRoom.Items.IndexOf(listDoorsRoom.FindItemWithText("Door " + j, false, 0, false));
                                        if (doorIndex2 != -1)
                                        {
                                            listDoorsRoom.Items.Remove(listDoorsRoom.FindItemWithText("Door " + j));
                                            listDoorsRoom.Items.Insert(doorIndex2, new ListViewItem(new string[] { "Door " + j, "CLOSED" }));
                                        }
                                    }
                                }
                            }
                        
                        }
                    
                        if (roomIndex != -1)
                        {
                            listAlarmsRoom.Items.Remove(listAlarmsRoom.FindItemWithText(ongoingAlarms[i]));
                            listAlarmsRoom.Items.Insert(roomIndex, new ListViewItem(new string[] { ongoingAlarms[i], "EMERGENCY" }));
                        }
                    }
                    i++;
                }
            }
            else
            {
                lblEmergency.Visible = false;
                lblEmergency2.Visible = false;
                lblServices.Visible = false;
                populateFloorLists();
                populateRoomLists();
            }
            
        }

        private void ToggleAlarms()
        {
            ongoingAlarms.Add("Alarm 1");
            CheckForAlarms();
        }

        private void populateFloorLists()
        {

            listAlarmsFloor.Items.Clear();
            listDoorsFloor.Items.Clear();
            if (comboBoxFloor.SelectedIndex == 0)
            {
                comboBoxRoom.Items.Clear();
                comboBoxRoom.Items.Insert(0, "Room 1");
                comboBoxRoom.Items.Insert(1, "Room 2");
                comboBoxRoom.Items.Insert(2, "Room 3");
                comboBoxRoom.Items.Insert(3, "Room 4");

                for (int i = 0; i < 4; i++)
                {
                    listAlarmsFloor.Items.Add(new ListViewItem(new string[] { "Alarm " + (i + 1), "All Clear" }));
                }
                for (int i = 0; i < 10; i++)
                {
                    listDoorsFloor.Items.Add(new ListViewItem(new string[] { "Door " + (i + 1), "Open" }));
                }
            }
            else if (comboBoxFloor.SelectedIndex == 1)
            {
                comboBoxRoom.Items.Clear();
                comboBoxRoom.Items.Add(("Room 1"));
                comboBoxRoom.Items.Add(("Room 2"));
                comboBoxRoom.Items.Add(("Room 3"));

                for (int i = 4; i < 10; i++)
                {
                    listAlarmsFloor.Items.Add(new ListViewItem(new string[] { "Alarm " + (i + 1), "All Clear" }));
                }
                for (int i = 10; i < 16; i++)
                {
                    listDoorsFloor.Items.Add(new ListViewItem(new string[] { "Door " + (i + 1), "Open" }));
                }
            }
            else if (comboBoxFloor.SelectedIndex == 2)
            {
                comboBoxRoom.Items.Clear();
                comboBoxRoom.Items.Add(("Room 1"));
                comboBoxRoom.Items.Add(("Room 2"));

                for (int i = 10; i < 16; i++)
                {
                    //listAlarmsFloor.Items.Insert(i-11, "Alarm " + (i + 1));

                    listAlarmsFloor.Items.Add(new ListViewItem(new string[] { "Alarm " + (i + 1), "All Clear" }));
                }
                for (int i = 16; i < 19; i++)
                {
                    listDoorsFloor.Items.Add(new ListViewItem(new string[] { "Door " + (i + 1), "Open" }));
                }
            }
            listAlarmsFloor.Sort();
        }

        private void populateRoomLists()
        {
            listAlarmsRoom.Items.Clear();
            listDoorsRoom.Items.Clear();
            if (lblFloorNum.Text == "1")
            {
                if (lblRoomNum.Text == "1")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 1", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 1", "Open" }));
                }
                else if (lblRoomNum.Text == "2")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 2", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 2", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 3", "Open" }));
                }
                else if (lblRoomNum.Text == "3")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 3", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 4", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 5", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 6", "Open" }));
                }
                else if (lblRoomNum.Text == "4")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 4", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 7", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 8", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 9", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 10", "Open" }));
                }
            }
            else if (lblFloorNum.Text == "2")
            {
                if (lblRoomNum.Text == "1")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 5", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 6", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 11", "Open" }));
                }
                else if (lblRoomNum.Text == "2")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 7", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 8", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 12", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 13", "Open" }));
                }
                else if (lblRoomNum.Text == "3")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 9", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 10", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 14", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 15", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 16", "Open" }));
                }
            }
            else if (lblFloorNum.Text == "3")
            {
                if (lblRoomNum.Text == "1")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 11", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 12", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 13", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 17", "Open" }));
                }
                else if (lblRoomNum.Text == "2")
                {
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 14", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 15", "All Clear" }));
                    listAlarmsRoom.Items.Add(new ListViewItem(new string[] { "Alarm 16", "All Clear" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 18", "Open" }));
                    listDoorsRoom.Items.Add(new ListViewItem(new string[] { "Door 19", "Open" }));
                }
            }
            
        }

        private void ComboBoxFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFloorNum.Text = (comboBoxFloor.SelectedIndex + 1).ToString();
            comboBoxRoom.SelectedItem = null;
            lblRoomNum.Text = "";
            listAlarmsRoom.Enabled = false;
            listDoorsRoom.Enabled = false;
            
            populateFloorLists();
            CheckForAlarms();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRoomNum.Text = (comboBoxRoom.SelectedIndex + 1).ToString();
            listAlarmsRoom.Enabled = true;
            listDoorsRoom.Enabled = true;

            populateRoomLists();
            CheckForAlarms();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            confirmLogin();
        }
        private void confirmLogin()
        {
            if (loggedIn)
            {
                btnLogout.Visible = true;
                btnSim.Visible = true;
                lblWelcome.Text = "Welcome!";
                if (ongoingAlarms.Count != 0)
                {
                    btnReset.Visible = true;
                }
                if (loggedInAdmin)
                {
                    lblWelcome.Text += " Logged in as admin.";
                    btnAddUser.Visible = true;
                }
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            String alarmName = "Alarm " + random.Next(1, 17);
            btnReset.Visible = true;
            if (!ongoingAlarms.Contains(alarmName))
            {
                ongoingAlarms.Add(alarmName);
                listAlarms.Items.Add(alarmName);
            }
            CheckForAlarms();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ongoingAlarms.Clear();
            listAlarms.Items.Clear();
            btnReset.Visible = false;
            btnCancel.Visible = false;
            CheckForAlarms();
            btnConfirm.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "Successfully logged out.";
            btnCancel.Visible = false;
            btnAddUser.Visible = false;
            btnLogout.Visible = false;
            btnSim.Visible = false;
            loggedIn = false;
            loggedInAdmin = false;
            btnReset.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
