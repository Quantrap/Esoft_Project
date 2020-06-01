namespace Esoft_Project
{
    partial class DemandForm
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
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewLand = new System.Windows.Forms.ListView();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAgent = new System.Windows.Forms.Label();
            this.textBoxMinArea = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMaxArea = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMinRooms = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMinFloor = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMinFloors = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.MaskedTextBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewHouse = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewApartament = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 401);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(45, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Тип ОН";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(12, 144);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(132, 20);
            this.textBoxMaxPrice.TabIndex = 1;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(12, 105);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(132, 20);
            this.textBoxMinPrice.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(12, 417);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(132, 21);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listViewLand
            // 
            this.listViewLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewLand.FullRowSelect = true;
            this.listViewLand.GridLines = true;
            this.listViewLand.Location = new System.Drawing.Point(164, 25);
            this.listViewLand.MultiSelect = false;
            this.listViewLand.Name = "listViewLand";
            this.listViewLand.Size = new System.Drawing.Size(824, 411);
            this.listViewLand.TabIndex = 6;
            this.listViewLand.UseCompatibleStateImageBehavior = false;
            this.listViewLand.View = System.Windows.Forms.View.Details;
            this.listViewLand.SelectedIndexChanged += new System.EventHandler(this.listViewLand_SelectedIndexChanged);
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(12, 65);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(132, 21);
            this.comboBoxAgent.TabIndex = 7;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 25);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(132, 21);
            this.comboBoxClient.TabIndex = 8;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(9, 9);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 9;
            this.labelClient.Text = "Клиент";
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(9, 49);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 10;
            this.labelAgent.Text = "Риелтор";
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(12, 183);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(132, 20);
            this.textBoxMinArea.TabIndex = 11;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(12, 222);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(132, 20);
            this.textBoxMaxArea.TabIndex = 12;
            this.textBoxMaxArea.Text = " ";
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(12, 261);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(132, 20);
            this.textBoxMinRooms.TabIndex = 13;
            this.textBoxMinRooms.Text = " ";
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(12, 300);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(132, 20);
            this.textBoxMaxRooms.TabIndex = 14;
            this.textBoxMaxRooms.Text = " ";
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(12, 339);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(132, 20);
            this.textBoxMinFloor.TabIndex = 15;
            this.textBoxMinFloor.Text = " ";
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(12, 378);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(132, 20);
            this.textBoxMaxFloor.TabIndex = 16;
            this.textBoxMaxFloor.Text = " ";
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(12, 261);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(132, 20);
            this.textBoxMinFloors.TabIndex = 17;
            this.textBoxMinFloors.Text = " ";
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(12, 300);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(132, 20);
            this.textBoxMaxFloors.TabIndex = 18;
            this.textBoxMaxFloors.Text = " ";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(12, 89);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(105, 13);
            this.labelMinPrice.TabIndex = 19;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(12, 128);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(111, 13);
            this.labelMaxPrice.TabIndex = 20;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(9, 167);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(126, 13);
            this.labelMinArea.TabIndex = 21;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(12, 206);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(132, 13);
            this.labelMaxArea.TabIndex = 22;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(12, 245);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(71, 13);
            this.labelMinRooms.TabIndex = 23;
            this.labelMinRooms.Text = "Мин. комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(12, 284);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(77, 13);
            this.labelMaxRooms.TabIndex = 24;
            this.labelMaxRooms.Text = "Макс. комнат";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(12, 323);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(59, 13);
            this.labelMinFloor.TabIndex = 25;
            this.labelMinFloor.Text = "Мин. этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(12, 362);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(65, 13);
            this.labelMaxFloor.TabIndex = 26;
            this.labelMaxFloor.Text = "Макс. этаж";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(12, 245);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(71, 13);
            this.labelMinFloors.TabIndex = 27;
            this.labelMinFloors.Text = "Мин. этажей";
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Location = new System.Drawing.Point(12, 284);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(77, 13);
            this.labelMaxFloors.TabIndex = 28;
            this.labelMaxFloors.Text = "Макс. этажей";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Клиент";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Риелтор";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Мин. цена";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Макс. цена";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Мин. площадь";
            this.columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Макс. площадь";
            this.columnHeader6.Width = 135;
            // 
            // listViewHouse
            // 
            this.listViewHouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader29,
            this.columnHeader30});
            this.listViewHouse.FullRowSelect = true;
            this.listViewHouse.GridLines = true;
            this.listViewHouse.Location = new System.Drawing.Point(164, 25);
            this.listViewHouse.MultiSelect = false;
            this.listViewHouse.Name = "listViewHouse";
            this.listViewHouse.Size = new System.Drawing.Size(824, 411);
            this.listViewHouse.TabIndex = 30;
            this.listViewHouse.UseCompatibleStateImageBehavior = false;
            this.listViewHouse.View = System.Windows.Forms.View.Details;
            this.listViewHouse.SelectedIndexChanged += new System.EventHandler(this.listViewHouse_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Клиент";
            this.columnHeader13.Width = 89;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Риелтор";
            this.columnHeader14.Width = 89;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Мин. цена";
            this.columnHeader15.Width = 124;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Макс. цена";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Мин. площадь";
            this.columnHeader17.Width = 117;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Макс. площадь";
            this.columnHeader18.Width = 135;
            // 
            // listViewApartament
            // 
            this.listViewApartament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28});
            this.listViewApartament.FullRowSelect = true;
            this.listViewApartament.GridLines = true;
            this.listViewApartament.Location = new System.Drawing.Point(164, 25);
            this.listViewApartament.MultiSelect = false;
            this.listViewApartament.Name = "listViewApartament";
            this.listViewApartament.Size = new System.Drawing.Size(824, 411);
            this.listViewApartament.TabIndex = 31;
            this.listViewApartament.UseCompatibleStateImageBehavior = false;
            this.listViewApartament.View = System.Windows.Forms.View.Details;
            this.listViewApartament.SelectedIndexChanged += new System.EventHandler(this.listViewApartament_SelectedIndexChanged_1);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Клиент";
            this.columnHeader19.Width = 89;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Риелтор";
            this.columnHeader20.Width = 89;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Мин. цена";
            this.columnHeader21.Width = 124;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Макс. цена";
            this.columnHeader22.Width = 120;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Мин. площадь";
            this.columnHeader23.Width = 87;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Макс. площадь";
            this.columnHeader24.Width = 96;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Мин. комнат";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Макс. Комнат";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Мин. этаж";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Макс. этаж";
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Мин. этажей";
            this.columnHeader29.Width = 74;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Макс. этажей";
            this.columnHeader30.Width = 81;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(737, 454);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 39);
            this.buttonAdd.TabIndex = 32;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(818, 454);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 39);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(904, 454);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 39);
            this.buttonDel.TabIndex = 34;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(12, 444);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 100);
            this.Logo.TabIndex = 35;
            this.Logo.TabStop = false;
            // 
            // DemandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 557);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewApartament);
            this.Controls.Add(this.listViewHouse);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.listViewLand);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.labelType);
            this.Name = "DemandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребности";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.MaskedTextBox textBoxMinPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewLand;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.MaskedTextBox textBoxMinArea;
        private System.Windows.Forms.MaskedTextBox textBoxMaxArea;
        private System.Windows.Forms.MaskedTextBox textBoxMinRooms;
        private System.Windows.Forms.MaskedTextBox textBoxMaxRooms;
        private System.Windows.Forms.MaskedTextBox textBoxMinFloor;
        private System.Windows.Forms.MaskedTextBox textBoxMaxFloor;
        private System.Windows.Forms.MaskedTextBox textBoxMinFloors;
        private System.Windows.Forms.MaskedTextBox textBoxMaxFloors;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listViewHouse;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ListView listViewApartament;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox Logo;
    }
}