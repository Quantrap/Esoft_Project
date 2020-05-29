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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            showRealEstateSet();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex==0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                ;listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxFloor.Text = "";
                textBoxRooms.Text = "";
                textBoxTotalArea.Text = "";
            }
            else if(comboBoxType.SelectedIndex==1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";

            }
            else if(comboBoxType.SelectedIndex==2)
            {
                listViewRealEstateSet_Land.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                textBoxTotalFloors.Visible = false;
                labelTotalFloors.Visible = false;

                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
            showRealEstateSet();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RealEstateSet realEstateSet = new RealEstateSet();
            realEstateSet.Address_City = textBoxAddress_City.Text;
            realEstateSet.Address_House = textBoxAddress_House.Text;
            realEstateSet.Address_Number = textBoxAddress_Number.Text;
            realEstateSet.Address_Street = textBoxAddress_Street.Text;
            realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
            realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
            realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
            if(comboBoxType.SelectedIndex==0)
            {
                realEstateSet.Type = 0;
                realEstateSet.Floor = Convert.ToInt32(textBoxFloor.Text);
                realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text);
            }
            else if(comboBoxType.SelectedIndex==1)
            {
                realEstateSet.Type = 1;
                realEstateSet.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);

            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                realEstateSet.Type = 2;
            }
            Program.wtfDb.RealEstateSet.Add(realEstateSet);
            Program.wtfDb.SaveChanges();
            showRealEstateSet();
        }
        void showRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();
            foreach(RealEstateSet realEstateSet in Program.wtfDb.RealEstateSet)
            {
                if(realEstateSet.Type==0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstateSet.Address_City,realEstateSet.Address_Street,realEstateSet.Address_House,realEstateSet.Address_Number,
                        realEstateSet.Coordinate_latitude.ToString(),realEstateSet.Coordinate_longitude.ToString(),realEstateSet.TotalArea.ToString(),
                        realEstateSet.Rooms.ToString(),realEstateSet.Floor.ToString()
                    }) ;
                    item.Tag = realEstateSet;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if(realEstateSet.Type==1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstateSet.Address_City,realEstateSet.Address_Street,realEstateSet.Address_House,realEstateSet.Address_Number,
                        realEstateSet.Coordinate_latitude.ToString(),realEstateSet.Coordinate_longitude.ToString(),realEstateSet.TotalArea.ToString(),
                        realEstateSet.TotalFloors.ToString()
                    });
                    item.Tag = realEstateSet;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else if(realEstateSet.Type == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstateSet.Address_City,realEstateSet.Address_Street,realEstateSet.Address_House,realEstateSet.Address_Number,
                        realEstateSet.Coordinate_latitude.ToString(),realEstateSet.Coordinate_longitude.ToString(),realEstateSet.TotalArea.ToString()
                        
                    });
                    item.Tag = realEstateSet;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
                listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex==0)
            {
                if(listViewRealEstateSet_Apartment.SelectedItems.Count==1)
                {
                    RealEstateSet realEstateSet = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    realEstateSet.Address_City = textBoxAddress_City.Text;
                    realEstateSet.Address_House = textBoxAddress_House.Text;
                    realEstateSet.Address_Number = textBoxAddress_Number.Text;
                    realEstateSet.Address_Street = textBoxAddress_Street.Text;
                    realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstateSet.Floor = Convert.ToInt32(textBoxFloor.Text);
                    realEstateSet.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    Program.wtfDb.SaveChanges();
                    showRealEstateSet();
                }
            }
            else if(comboBoxType.SelectedIndex==1)
            {
                if(listViewRealEstateSet_House.SelectedItems.Count==1)
                {
                    RealEstateSet realEstateSet = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                    realEstateSet.Address_City = textBoxAddress_City.Text;
                    realEstateSet.Address_House = textBoxAddress_House.Text;
                    realEstateSet.Address_Number = textBoxAddress_Number.Text;
                    realEstateSet.Address_Street = textBoxAddress_Street.Text;
                    realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstateSet.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
                    Program.wtfDb.SaveChanges();
                    showRealEstateSet();
                }
            }
            else if(comboBoxType.SelectedIndex==2)
            {
                if(listViewRealEstateSet_Land.SelectedItems.Count==1)
                {
                    RealEstateSet realEstateSet = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                    realEstateSet.Address_City = textBoxAddress_City.Text;
                    realEstateSet.Address_House = textBoxAddress_House.Text;
                    realEstateSet.Address_Number = textBoxAddress_Number.Text;
                    realEstateSet.Address_Street = textBoxAddress_Street.Text;
                    realEstateSet.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstateSet.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstateSet.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    Program.wtfDb.SaveChanges();
                    showRealEstateSet();
                }
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewRealEstateSet_Apartment.SelectedItems.Count==1)
            {
                RealEstateSet realEstateSet = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstateSet.Address_City;
                textBoxAddress_House.Text = realEstateSet.Address_House;
                textBoxAddress_Number.Text = realEstateSet.Address_Number;
                textBoxAddress_Street.Text=realEstateSet.Address_Street;
                textBoxCoordinate_longitude.Text = Convert.ToString(realEstateSet.Coordinate_longitude);
                textBoxCoordinate_latitude.Text = Convert.ToString(realEstateSet.Coordinate_latitude);
                textBoxTotalArea.Text = Convert.ToString(realEstateSet.TotalArea);

                textBoxFloor.Text = Convert.ToString(realEstateSet.Floor);
                textBoxRooms.Text = Convert.ToString(realEstateSet.Rooms);
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxFloor.Text = "";
                textBoxRooms.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                RealEstateSet realEstateSet = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstateSet.Address_City;
                textBoxAddress_House.Text = realEstateSet.Address_House;
                textBoxAddress_Number.Text = realEstateSet.Address_Number;
                textBoxAddress_Street.Text = realEstateSet.Address_Street;
                textBoxCoordinate_longitude.Text = Convert.ToString(realEstateSet.Coordinate_longitude);
                textBoxCoordinate_latitude.Text = Convert.ToString(realEstateSet.Coordinate_latitude);
                textBoxTotalArea.Text = Convert.ToString(realEstateSet.TotalArea);

                textBoxTotalFloors.Text = Convert.ToString(realEstateSet.TotalFloors);
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";

                textBoxTotalFloors.Text = "";
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                RealEstateSet realEstateSet = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstateSet.Address_City;
                textBoxAddress_House.Text = realEstateSet.Address_House;
                textBoxAddress_Number.Text = realEstateSet.Address_Number;
                textBoxAddress_Street.Text = realEstateSet.Address_Street;
                textBoxCoordinate_longitude.Text = Convert.ToString(realEstateSet.Coordinate_longitude);
                textBoxCoordinate_latitude.Text = Convert.ToString(realEstateSet.Coordinate_latitude);
                textBoxTotalArea.Text = Convert.ToString(realEstateSet.TotalArea);
            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxType.SelectedIndex==0)
                {
                    if(listViewRealEstateSet_Apartment.SelectedItems.Count==1)
                    {
                        RealEstateSet realEstateSet = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        Program.wtfDb.RealEstateSet.Remove(realEstateSet);
                        Program.wtfDb.SaveChanges();
                        showRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxFloor.Text = "";
                    textBoxRooms.Text = "";
                    textBoxTotalArea.Text = "";
                }
                else if(comboBoxType.SelectedIndex == 1)
                {
                    if(listViewRealEstateSet_House.SelectedItems.Count==1)
                    {
                        RealEstateSet realEstateSet = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        Program.wtfDb.RealEstateSet.Remove(realEstateSet);
                        Program.wtfDb.SaveChanges();
                        showRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalFloors.Text = "";
                    textBoxTotalArea.Text = "";
                }
                else if(comboBoxType.SelectedIndex == 2)
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstateSet = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        Program.wtfDb.RealEstateSet.Remove(realEstateSet);
                        Program.wtfDb.SaveChanges();
                        showRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBoxCoordinate_longitude_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoordinate_longitude.Text != "" && textBoxCoordinate_longitude.Text != "-")
            { if (Convert.ToDouble(textBoxCoordinate_longitude.Text) > 180 || Convert.ToDouble(textBoxCoordinate_longitude.Text) < -180) textBoxCoordinate_longitude.Text = ""; }
        }

        private void textBoxLongitude_PressKey(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if(!Char.IsDigit(number)|| number!='-' || number != ',')
            {
                e.Handled = false;
            }
        }

        private void textBoxCoordinate_latitude_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCoordinate_latitude.Text != "" && textBoxCoordinate_latitude.Text != "-")
            { if (Convert.ToDouble(textBoxCoordinate_latitude.Text) > 90 || Convert.ToDouble(textBoxCoordinate_latitude.Text) < -90) textBoxCoordinate_latitude.Text = ""; }
        }

        private void textBoxLatitudeCoordinate_PressKey(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) || number != '-' || number != ',')
            {
                e.Handled = false;
            }
        }
    }
}
