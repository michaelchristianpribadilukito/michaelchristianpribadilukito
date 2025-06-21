using DES.Models;
using DES.Views;
using System;
using System.Windows.Forms;

namespace DES.Controllers
{
    public class RsaController
    {
        private readonly RsaModel _model;
        private readonly Form2 _view;

        public RsaController(RsaModel model, Form2 view)
        {
            _model = model;
            _view = view;

            _view.GenerateKeysClicked += OnGenerateKeys;
            _view.EncryptClicked += OnEncrypt;
            _view.DecryptClicked += OnDecrypt;
        }

        private void OnGenerateKeys(object sender, EventArgs e)
        {
            if (_model.GenerateKeys(_view.P_Input, _view.Q_Input, _view.E_Input))
            {
                _view.N_Output = _model.N.ToString();
                _view.Phi_Output = _model.Phi.ToString();
                _view.D_Output = _model.D.ToString();
                _view.PublicKey_Output = $"({_model.E}, {_model.N})";
                _view.PrivateKey_Output = $"({_model.D}, {_model.N})";
            }
            else
            {
                MessageBox.Show(_model.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Update Process Output di View
            _view.Process_Output = _model.ProcessOutput;
        }

        private void OnEncrypt(object sender, EventArgs e)
        {
            _view.Ciphertext_Output = _model.Encrypt(_view.Message_Input);
            // Update Process Output di View
            _view.Process_Output = _model.ProcessOutput;
        }

        private void OnDecrypt(object sender, EventArgs e)
        {
            _view.Plaintext_Output = _model.Decrypt(_view.Ciphertext_Input);
            // Update Process Output di View
            _view.Process_Output = _model.ProcessOutput;
        }
    }
}