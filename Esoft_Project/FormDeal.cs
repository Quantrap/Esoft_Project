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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
            ShowDealSet();
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDealSet.SelectedItems.Count==1)
            {
                DealSet dealSet = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(dealSet.IdDemand.ToString());
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(dealSet.IdSupply.ToString());
            }
            else
            {
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }
        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.wtfDb.SupplySet)
            {
                string[] item = { supplySet.Id.ToString() + ". ", "Риелтор: " + supplySet.AgentSet.LastName, "Клиент: " + supplySet.ClientsSet.LastName };
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet supplySet in Program.wtfDb.DemandSet)
            {
                string[] item = { supplySet.Id.ToString() + ". ", "Риелтор: " + supplySet.AgentSet.LastName, "Клиент: " + supplySet.ClientsSet.LastName };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }
        void Deductions()
        {
            if(comboBoxSupply.SelectedItem!=null && comboBoxDemand.SelectedItem!=null)
            {
                SupplySet supplySet = Program.wtfDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.wtfDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                double customerCompanyDeductions=supplySet.Price*0.03;
                textCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");
                if(demandSet.AgentSet.DealShare!=null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToInt32(demandSet.AgentSet.DealShare) / 100.00;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentCustomerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxAgentCustomerDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
            }
            if(comboBoxSupply.SelectedItem!=null)
            {
                SupplySet supplySet = Program.wtfDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                double sellerCompanyDeductions;
                if(supplySet.RealEstateSet.Type==0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else if(supplySet.RealEstateSet.Type==1)
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                if(supplySet.AgentSet.DealShare!=null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentSet.DealShare) / 100.00;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
            }
            else
            {
                textBoxAgentCustomerDeductions.Text = "";
                textBoxAgentSellerDeductions.Text = "";
                textBoxSellerCompanyDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
            }
        }

        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }

        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach(DealSet deal in Program.wtfDb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                  {
                    deal.SupplySet.ClientsSet.LastName,
                    deal.SupplySet.AgentSet.LastName,
                    deal.DemandSet.ClientsSet.LastName,
                    deal.DemandSet.AgentSet.LastName,
                    "г. "+deal.SupplySet.RealEstateSet.Address_City+", ул. "+deal.SupplySet.RealEstateSet.Address_Street+", д. "+deal.SupplySet.RealEstateSet.Address_House+", кв. "+deal.SupplySet.RealEstateSet.Address_Number,
                    deal.SupplySet.Price.ToString()
                  });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxDemand.SelectedItem!=null && comboBoxSupply.SelectedItem!=null)
            {
                DealSet deal = new DealSet();
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wtfDb.DealSet.Add(deal);
                Program.wtfDb.SaveChanges();
                ShowDealSet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewDealSet.SelectedItems.Count==1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                deal.IdSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.IdDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wtfDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewDealSet.SelectedItems.Count==1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.wtfDb.DealSet.Remove(deal);
                    Program.wtfDb.SaveChanges();
                    ShowDealSet();
                }
                comboBoxDemand.SelectedItem = null;
                comboBoxSupply.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
