using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Manufacturer.Desktop.Models;
using Manufacturer.Desktop.Services;

namespace Manufacturer.Desktop.Forms
{
    public partial class MainForm : Form
    {
        private readonly BlanketService _service;
        public MainForm()
        {
            InitializeComponent();
            _service = new BlanketService();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var blankets = await _service.GetAllAsync();
            dgvBlankets.DataSource = blankets;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new BlanketForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _service.CreateAsync(form.BlanketData);
                await LoadData();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBlankets.CurrentRow?.DataBoundItem is BlanketDTO selected)
            {
                using var form = new BlanketForm(selected);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await _service.UpdateAsync(selected.Id, form.BlanketData);
                    await LoadData();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBlankets.CurrentRow?.DataBoundItem is BlanketDTO selected)
            {
                var confirmed = MessageBox.Show(
                    $"Delete {selected.ModelName}?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmed == DialogResult.Yes)
                {
                    var success = await _service.DeleteAsync(selected.Id);
                    if (success)
                        await LoadData();
                    else
                        MessageBox.Show("Delete failed.", "Error");
                }
            }
        }
    }
}
