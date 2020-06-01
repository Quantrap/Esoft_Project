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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate.SelectedItem != null && textBoxPrice.Text != "")
            {
                SupplySet supplySet = new SupplySet();
                supplySet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supplySet.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wtfDb.SupplySet.Add(supplySet);
                Program.wtfDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach(AgentSet agentSet in Program.wtfDb.AgentSet)
            {
                string[] item = { agentSet.Id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName,agentSet.DealShare.ToString() };
                comboBoxAgents.Items.Add(string.Join(" ",item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wtfDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName,clientsSet.Phone};
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wtfDb.RealEstateSet)
            {
                string[] item = {realEstateSet.Id.ToString()+".",realEstateSet.Address_City+",",realEstateSet.Address_Street+",",
                "д. "+realEstateSet.Address_House+",","кв. "+realEstateSet.Address_Number+",","площадь: "+realEstateSet.TotalArea.ToString()+"кв.м ,","Тип: "+realEstateSet.Type.ToString()};
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewSupplySet.SelectedItems.Count==1)
            {
                SupplySet supplySet = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supplySet.IdAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supplySet.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supplySet.IdRealEstate.ToString());
                textBoxPrice.Text = supplySet.Price.ToString();
            }
            else
            {
                comboBoxAgents.SelectedItem= null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach(SupplySet supplySet in Program.wtfDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    
                    supplySet.IdAgent.ToString(),
                    supplySet.AgentSet.LastName+" "+supplySet.AgentSet.FirstName+" "+supplySet.AgentSet.MiddleName,
                    supplySet.IdClient.ToString(),
                    supplySet.ClientsSet.LastName+" "+supplySet.ClientsSet.FirstName+" "+supplySet.ClientsSet.MiddleName,
                    supplySet.RealEstateSet.Id.ToString(),
                    "г. "+supplySet.RealEstateSet.Address_City+", ул. "+supplySet.RealEstateSet.Address_Street+", д. "+supplySet.RealEstateSet.Address_House+", кв. "+supplySet.RealEstateSet.Address_Number,
                    supplySet.Price.ToString()
                    }); 
                item.Tag = supplySet;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewSupplySet.SelectedItems.Count==1)
            {
                SupplySet supplySet = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supplySet.IdAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supplySet.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supplySet.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wtfDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewSupplySet.SelectedItems.Count==1)
                {
                    SupplySet supplySet = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wtfDb.SupplySet.Remove(supplySet);
                    Program.wtfDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
