﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfoDatabaseGroupStudy
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void addInfoButton_Click(object sender, EventArgs e)
        {
            EmployeeInfoUI employeeInfo = new EmployeeInfoUI();
          
            employeeInfo.ShowDialog();
        }

        private void searchAndEditButton_Click(object sender, EventArgs e)
        {
            SearchUI searchUI = new SearchUI();
 
            searchUI.ShowDialog();
        }
    }
}
