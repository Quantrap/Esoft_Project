using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class DemandForm : Form
    {
        public DemandForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowClients();
            ShowAgents();
            ShowDemandSet();
        }



        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewApartament.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMaxFloor.Visible = true;


                listViewHouse.Visible = false;
                listViewLand.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewHouse.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                listViewApartament.Visible = false;
                listViewLand.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinFloors.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;

            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewLand.Visible = true;

                listViewHouse.Visible = false;
                listViewApartament.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
            ShowDemandSet();
        }

        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
            }
            else
            {
                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
        }
        void ShowDemandSet()
        {
            listViewApartament.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();
            foreach (DemandSet demandSet in Program.wtfDb.DemandSet)
            {
                if (demandSet.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id:"+demandSet.ClientsSet.Id.ToString()+", "+demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        "Id:"+demandSet.AgentSet.Id.ToString()+", "+demandSet.AgentSet.LastName+" "+demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,
                        demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString(),demandSet.MinArea.ToString(),demandSet.MaxArea.ToString(),demandSet.MinRooms.ToString(),
                        demandSet.MaxRooms.ToString(),demandSet.MinFloor.ToString(),demandSet.MaxFloor.ToString()
                    });
                    item.Tag = demandSet;
                    listViewApartament.Items.Add(item);
                }
                else if (demandSet.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id:"+demandSet.ClientsSet.Id.ToString()+", "+demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        "Id:"+demandSet.AgentSet.Id.ToString()+", "+demandSet.AgentSet.LastName+" "+demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,
                        demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString(),demandSet.MinArea.ToString(),demandSet.MaxArea.ToString(),
                        demandSet.MinFloors.ToString(),demandSet.MaxFloors.ToString()
                    });
                    item.Tag = demandSet;
                    listViewHouse.Items.Add(item);
                }
                else if (demandSet.Type == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        "Id:"+demandSet.ClientsSet.Id.ToString()+", "+demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                        "Id:"+demandSet.AgentSet.Id.ToString()+", "+demandSet.AgentSet.LastName+" "+demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,
                        demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString(),demandSet.MinArea.ToString(),demandSet.MaxArea.ToString()
                    });
                    item.Tag = demandSet;
                    listViewLand.Items.Add(item);
                }
                listViewApartament.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wtfDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName, clientsSet.Phone };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.wtfDb.AgentSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName, agentSet.DealShare.ToString() };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
            }
            else
            {
                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinFloors.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DemandSet demandSet = new DemandSet();
            demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
            demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
            demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
            demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
            demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text);
            demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
            if (comboBoxType.SelectedIndex == 0)
            {
                demandSet.Type = 0;
                demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                demandSet.Type = 1;
                demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                demandSet.Type = 2;
            }
            Program.wtfDb.DemandSet.Add(demandSet);
            Program.wtfDb.SaveChanges();
            ShowDemandSet();
        }

        private void listViewApartament_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewApartament.SelectedItems.Count == 1)
            {
                DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(demandSet.IdAgent.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(demandSet.IdClient.ToString());
                textBoxMinRooms.Text = demandSet.MinRooms.ToString();
                textBoxMaxRooms.Text = demandSet.MaxRooms.ToString();
                textBoxMinFloor.Text = demandSet.MinFloor.ToString();
                textBoxMaxFloor.Text = demandSet.MaxFloor.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
            }
            else
            {
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinPrice.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewApartament.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    Program.wtfDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewHouse.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.wtfDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                if (listViewLand.SelectedItems.Count == 1)
                {
                    DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                    demandSet.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demandSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    Program.wtfDb.SaveChanges();
                    ShowDemandSet();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewApartament.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewApartament.SelectedItems[0].Tag as DemandSet;
                        Program.wtfDb.DemandSet.Remove(demandSet);
                        Program.wtfDb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinPrice.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewHouse.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                        Program.wtfDb.DemandSet.Remove(demandSet);
                        Program.wtfDb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMaxArea.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxFloors.Text = "";
                    textBoxMinFloors.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    if (listViewLand.SelectedItems.Count == 1)
                    {
                        DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                        Program.wtfDb.DemandSet.Remove(demandSet);
                        Program.wtfDb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMaxArea.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinPrice.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
