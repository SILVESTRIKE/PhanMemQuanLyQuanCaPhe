using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF_GUI
{
    public partial class frmIDQuanLi : Form
    {
        // Public property to access the input text
        public string InputText { get; private set; }

        public frmIDQuanLi()
        {
            InitializeComponent();
        }

        private void InputBoxForm_Load(object sender, EventArgs e)
        {
            // Optionally, set default text or focus on the TextBox
            txtInput.Focus();
        }

        // OK Button click event
        private void btnOK_Click(object sender, EventArgs e)
        {
            InputText = txtInput.Text; // Store the input
            DialogResult = DialogResult.OK; // Close the form with OK result
        }

        // Cancel Button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Close the form with Cancel result
        }
    }
}
