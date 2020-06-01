﻿namespace Esoft_Project
{
    partial class FormSupply
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxRealEstate = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(709, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 39);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(790, 337);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 39);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(871, 337);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 39);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(12, 25);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(209, 21);
            this.comboBoxAgents.TabIndex = 16;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(12, 65);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(209, 21);
            this.comboBoxClients.TabIndex = 17;
            // 
            // comboBoxRealEstate
            // 
            this.comboBoxRealEstate.FormattingEnabled = true;
            this.comboBoxRealEstate.Location = new System.Drawing.Point(12, 105);
            this.comboBoxRealEstate.Name = "comboBoxRealEstate";
            this.comboBoxRealEstate.Size = new System.Drawing.Size(209, 21);
            this.comboBoxRealEstate.TabIndex = 18;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 145);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(209, 20);
            this.textBoxPrice.TabIndex = 19;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(12, 9);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(49, 13);
            this.labelAgent.TabIndex = 20;
            this.labelAgent.Text = "Риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 49);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 21;
            this.labelClient.Text = "Клиент";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Location = new System.Drawing.Point(12, 89);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(123, 13);
            this.labelRealEstate.TabIndex = 22;
            this.labelRealEstate.Text = "Объект недвижимости";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 129);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "Цена";
            // 
            // listViewSupplySet
            // 
            this.listViewSupplySet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSupplySet.FullRowSelect = true;
            this.listViewSupplySet.GridLines = true;
            this.listViewSupplySet.Location = new System.Drawing.Point(227, 25);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(728, 306);
            this.listViewSupplySet.TabIndex = 24;
            this.listViewSupplySet.UseCompatibleStateImageBehavior = false;
            this.listViewSupplySet.View = System.Windows.Forms.View.Details;
            this.listViewSupplySet.SelectedIndexChanged += new System.EventHandler(this.listViewSupplySet_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id риелтора";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ФИО риелтора";
            this.columnHeader9.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Id клиента";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ФИО клиента";
            this.columnHeader11.Width = 127;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id ОН";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Адрес ОН";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(12, 338);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 100);
            this.Logo.TabIndex = 25;
            this.Logo.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxRealEstate);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения";
            this.Load += new System.EventHandler(this.FormSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxRealEstate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox Logo;
    }
}