﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpro_Hotels
{
    public partial class FormAddData : Form
    {
        String finalTransaction = null;
        int finalPrice = 0;
        public FormAddData()
        {
            InitializeComponent();
        }

        private void FormAddData_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.Items.Add("Deluxe");
            comboBoxRoomType.Items.Add("Superior");
            comboBoxRoomType.Items.Add("Grand Deluxe");
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            int[] arrayOfRoomsPrice = new int[3] { 300000, 500000, 1000000 };
            double totalPrice = arrayOfRoomsPrice[comboBoxRoomType.SelectedIndex] * int.Parse(textBoxLengthStay.Text);

            listBoxDetailAddData.Items.Add($"Mr./Mrs.: {textBoxName.Text}");
            listBoxDetailAddData.Items.Add("Thank you for choosing Luxury Hotel as your place to stay");
            listBoxDetailAddData.Items.Add($"You chose {comboBoxRoomType.SelectedItem} room to stay for {textBoxLengthStay.Text} days");
            listBoxDetailAddData.Items.Add($"Price per night is Rp. {arrayOfRoomsPrice[comboBoxRoomType.SelectedIndex]}");
            listBoxDetailAddData.Items.Add($"Total Price Rp. {totalPrice}");

            if (radioButtonMemberTrue.Checked)
            {
                listBoxDetailAddData.Items.Add($"Discount 10%: Rp. {0.1 * totalPrice}");
                totalPrice -= (0.1 * totalPrice);
            }
            else
            {
                listBoxDetailAddData.Items.Add($"Discount : Rp.0");
            }
            listBoxDetailAddData.Items.Add($"Total price must be paid: Rp. {totalPrice}");
            listBoxDetailAddData.Items.Add("");
            finalTransaction = $"Mr./Mrs.: {textBoxName.Text}.........................Rp.{totalPrice}";
            finalPrice = (int)totalPrice;

            FormMainMenu formMainMenu = (FormMainMenu)this.Owner;
            formMainMenu.listOfHistorySaleData.Add(finalTransaction);
            formMainMenu.listOfHistoryPriceSaleData.Add(finalPrice);
            formMainMenu.ShowData();
            cleanField();
            MessageBox.Show("Data successfully added");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cleanField();
            listBoxDetailAddData.Items.Clear();
        }

        private void cleanField()
        {
            textBoxName.Clear();
            textBoxLengthStay.Clear();
            comboBoxRoomType.SelectedIndex = 0;
            radioButtonMemberTrue.Checked = false;
            radioButtonMemberFalse.Checked = false;
            finalTransaction = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
  
        }
    }
}
