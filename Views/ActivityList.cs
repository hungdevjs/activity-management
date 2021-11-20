﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

using ActivityManagement.Controllers;

namespace ActivityManagement.Views
{
    public partial class ActivityList : Form
    {
        private ActivityController controller;
        private readonly SqlDataAdapter _sqlDataAdapter;
        private readonly BindingSource _bindingSource;
        private readonly DataTable _dataTable;

        public ActivityList()
        {
            controller = new ActivityController();
            InitializeComponent();
            var (bindingSource, sqlDataAdapter, dataTable) = controller.LoadData();
            _bindingSource = bindingSource;
            _sqlDataAdapter = sqlDataAdapter;
            _dataTable = dataTable;
            LoadData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            Hide();
        }

        private void LoadData()
        {
            ActivityListView.DataSource = _bindingSource;
            ActivityListView.Columns[0].ReadOnly = true;
            ActivityListView.Columns[9].ReadOnly = true;
            ActivityListView.Columns[14].ReadOnly = true;
            ActivityListView.Columns[15].ReadOnly = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlDataAdapter.Update(_dataTable);
                MessageBox.Show("Update activity list successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
