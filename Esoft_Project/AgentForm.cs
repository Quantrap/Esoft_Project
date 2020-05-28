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
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
            ShowClient();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {

        }
        void ShowClient()
        {
            listViewAgents.Items.Clear();
            foreach (AgentSet clientsSet in Program.wtfDb.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        clientsSet.Id.ToString(),clientsSet.FirstName,clientsSet.MiddleName,
                        clientsSet.LastName,Convert.ToString(clientsSet.DealShare)
                    });
                item.Tag = clientsSet;
                listViewAgents.Items.Add(item);


            }
        }

        private void textBoxDealShare_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDealShare.Text != "" || textBoxDealShare.Text != "-" || textBoxDealShare.Text != "+")
            { if (Convert.ToInt32(textBoxDealShare.Text) > 100 || Convert.ToInt32(textBoxDealShare.Text) < 0) textBoxDealShare.Text = "100"; }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1 )
            {
                AgentSet clientSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wtfDb.SaveChanges();
                ShowClient();
            }
        }

        private void textBoxDealShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentSet clientSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                    Program.wtfDb.AgentSet.Remove(clientSet);
                    Program.wtfDb.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentSet clientSet = new AgentSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            Program.wtfDb.AgentSet.Add(clientSet);
            Program.wtfDb.SaveChanges();
            ShowClient();
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1 && textBoxDealShare.Text!="")
            {
                AgentSet clientSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wtfDb.SaveChanges();
                ShowClient();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }
    }
}