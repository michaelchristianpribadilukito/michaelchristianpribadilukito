using DES.Controllers;
using DES.Models;
using System;
using System.Windows.Forms;

namespace DES.Views
{
    public partial class Form2 : Form
    {
        private readonly RsaController _controller;

        public Form2()
        {
            InitializeComponent();
            RsaModel model = new RsaModel();
            _controller = new RsaController(model, this);
        }

        // ... (Events tetap sama) ...
        public event EventHandler GenerateKeysClicked;
        public event EventHandler EncryptClicked;
        public event EventHandler DecryptClicked;

        // ... (Properti lainnya tetap sama) ...
        public string P_Input => p_tb.Text.Trim();
        public string Q_Input => q_tb.Text.Trim();
        public string E_Input => e_tb.Text.Trim();
        public string N_Output { set => n_tb.Text = value; }
        public string Phi_Output { set => phi_tb.Text = value; }
        public string D_Output { set => d_tb.Text = value; }
        public string PublicKey_Output { set => publicKey_tb.Text = value; }
        public string PrivateKey_Output { set => privateKey_tb.Text = value; }
        public string Message_Input => message_tb.Text.Trim();
        public string Ciphertext_Input => ciphertext_tb.Text.Trim();
        public string Ciphertext_Output { set => encrypted_tb.Text = value; }
        public string Plaintext_Output { set => decrypted_tb.Text = value; }


        // Properti baru untuk menampilkan proses
        public string Process_Output
        {
            set => prosesOutput_tb.Text = value; // sesuaikan dengan nama TextBox Anda
        }

        // ... (Event handlers tetap sama) ...
        private void generateKeys_btn_Click(object sender, EventArgs e)
        {
            GenerateKeysClicked?.Invoke(this, EventArgs.Empty);
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            EncryptClicked?.Invoke(this, EventArgs.Empty);
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            DecryptClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}