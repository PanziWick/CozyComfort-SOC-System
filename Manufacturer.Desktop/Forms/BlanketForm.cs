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

namespace Manufacturer.Desktop.Forms
{
    public partial class BlanketForm : Form
    {
        public BlanketDTO BlanketData { get; private set; }
        private readonly bool _isEditMode;

        public BlanketForm(BlanketDTO? dto = null)
        {
            InitializeComponent();
            _isEditMode = dto != null;

            if (_isEditMode)
            {
                Text = "Edit Blanket";
                txtModelName.Text = dto!.ModelName;
                txtMaterial.Text = dto.Material;
                numCapacity.Value = dto.ProductionCapacity;
                numInStock.Value = dto.InStock;

                BlanketData = dto;
            }
            else
            {
                Text = "Add New Blanket";
                BlanketData = new BlanketDTO();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelName.Text) || string.IsNullOrWhiteSpace(txtMaterial.Text))
            {
                MessageBox.Show("Model name and material are required.");
                return;
            }

            BlanketData.ModelName = txtModelName.Text.Trim();
            BlanketData.Material = txtMaterial.Text.Trim();
            BlanketData.ProductionCapacity = (int)numCapacity.Value;
            BlanketData.InStock = (int)numInStock.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
