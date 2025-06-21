using DES.Controllers;
using DES.Models;
using System;
using System.Windows.Forms;

namespace DES.Views
{
    public partial class Form1 : Form
    {
        private readonly DesController _controller;

        public Form1()
        {
            InitializeComponent();
            DesModel model = new DesModel();
            _controller = new DesController(model, this);
        }

        // Events
        public event EventHandler EncryptButtonClicked;
        public event EventHandler DecryptButtonClicked; // Event baru

        #region Public properties for Enkripsi
        public string PlaintextInput
        {
            get => plaintextInput_tb.Text.Trim();
            set => plaintextInput_tb.Text = value;
        }

        public string KeyInput
        {
            get => kunciDesInput_tb.Text.Trim();
            set => kunciDesInput_tb.Text = value;
        }

        public string CiphertextOutput
        {
            get => enkripsiOutput_tb.Text;
            set => enkripsiOutput_tb.Text = value;
        }
        #endregion

        #region Public properties for Dekripsi (Baru)
        public string CiphertextInput
        {
            get => cyphertextInput_tb.Text.Trim(); // Sesuai nama dari request
            set => cyphertextInput_tb.Text = value;
        }

        public string KeyInput2
        {
            get => kunciDesInput_tb2.Text.Trim(); // Sesuai nama dari request
            set => kunciDesInput_tb2.Text = value;
        }

        public string PlaintextOutput
        {
            get => plaintextOutput_tb.Text; // Sesuai nama dari request
            set => plaintextOutput_tb.Text = value;
        }
        #endregion

        #region Public properties for Proses Output
        public string ProsesOutput
        {
            get => prosesOutput_tb.Text;
            set => prosesOutput_tb.Text = value;
        }

        public TextBox ProsesOutputTextBox => prosesOutput_tb;
        #endregion

        private void start_btn_Click(object sender, EventArgs e)
        {
            EncryptButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        // Event handler baru untuk tombol dekripsi
        private void start_btn2_Click(object sender, EventArgs e)
        {
            DecryptButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}