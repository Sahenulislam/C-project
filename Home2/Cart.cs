﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Home2
{
    public partial class cart : Form
    {
<<<<<<< HEAD
        string Namex = null;
        string Idx = null;
        string Emailx = null;
        string Type = null;
        public cart(string Type, string Namex, string Idx, string Emailx)
        {
=======
        string usrID;
        user_panel upOb;
        int allTotal = 0;
        public cart(string ID,user_panel ob)
        {
            usrID = ID;
            upOb = ob;
>>>>>>> 2cc23533e78600e3688c6258843f676105136a0c
            InitializeComponent();
            this.MinimumSize = new Size(60, 50);
            this.CenterToScreen();
            this.Namex = Namex;
            this.Type = Type;
            this.Idx = Idx;
            this.Emailx = Emailx;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=;database=#shop");
            conn.Open();
            
            string query = "SELECT `product_id`,`product_name`,`quantity`,`price`,(`quantity`*`price`) as `total` FROM `cart` WHERE `user_id`= "+this.Idx;
            //MessageBox.Show(usrID);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();

            int tk;
            string id, name, qunt, price, total;
            while (reader.Read())
            {
                id = reader.GetString(0);
                name = reader.GetString(1);
                qunt = reader.GetString(2);
                price = reader.GetString(3);
                total = reader.GetString(4);

                tk= System.Convert.ToInt32(total);
                allTotal += tk;
                cartGrid.Rows.Add(new object[] { id, name, qunt, price, total });
            }
            conn.Close();

            labelAllTotal.Text = allTotal.ToString();
            
        }

<<<<<<< HEAD
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            user_panel obx = new user_panel(this.Type, this.Namex, this.Idx, this.Emailx);
            obx.Show();
=======
        private void cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            upOb.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

>>>>>>> 2cc23533e78600e3688c6258843f676105136a0c
        }
    }
}
