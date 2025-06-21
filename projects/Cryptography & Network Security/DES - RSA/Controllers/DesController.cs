using DES.Models;
using DES.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace DES.Controllers
{
    public class DesController
    {
        private readonly DesModel _model;
        private readonly Form1 _view;

        public DesController(DesModel model, Form1 view)
        {
            _model = model;
            _view = view;

            // Subscribe to the view's events
            _view.EncryptButtonClicked += OnEncryptRequest;
            _view.DecryptButtonClicked += OnDecryptRequest; // Subscribe ke event baru
        }

        private void OnEncryptRequest(object sender, EventArgs e)
        {
            string plaintext = _view.PlaintextInput;
            string key = _view.KeyInput;

            if (!IsValidInput(plaintext, key)) return;

            _model.Encrypt(plaintext, key);

            _view.CiphertextOutput = _model.EncryptedHexOutput;
            _view.ProsesOutput = FormatProcessDetails("ENKRIPSI");
        }

        // Method baru untuk menangani dekripsi
        private void OnDecryptRequest(object sender, EventArgs e)
        {
            string ciphertext = _view.CiphertextInput;
            string key = _view.KeyInput2;

            if (!IsValidInput(ciphertext, key)) return;

            _model.Decrypt(ciphertext, key);

            _view.PlaintextOutput = _model.DecryptedHexOutput;
            _view.ProsesOutput = FormatProcessDetails("DEKRIPSI");
        }

        private bool IsValidInput(string text, string key)
        {
            // ... (Isi method ini sama persis, tidak ada perubahan)
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Harap masukkan input dan kunci.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(text, @"\A[0-9a-fA-F]{16}\z") || !Regex.IsMatch(key, @"\A[0-9a-fA-F]{16}\z"))
            {
                MessageBox.Show("Harap masukkan nilai heksadesimal 16 karakter yang valid untuk input dan kunci.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #region Formatting Logic
        private string FormatProcessDetails(string mode)
        {
            var result = new StringBuilder();
            string line = GenerateLine(_view.ProsesOutputTextBox);
            List<string> subKeys = new List<string>(_model.K_list);

            if (mode == "DEKRIPSI")
            {
                subKeys.Reverse(); // Gunakan kunci terbalik untuk display dekripsi
                result.AppendLine(CenteredTitle("HEXADECIMAL"));
                result.AppendLine($"C = {_model.CiphertextHex}");
                result.AppendLine($"K = {_model.KeyHex}");
                result.AppendLine(line).AppendLine();

                result.AppendLine(CenteredTitle("BINARY"));
                result.AppendLine($"C = {FormatBinaryWithSpacing(_model.CiphertextBinary, 4)}");
                result.AppendLine($"K = {FormatBinaryWithSpacing(_model.KeyBinary, 4)}");
                result.AppendLine(line).AppendLine();
            }
            else // ENKRIPSI
            {
                result.AppendLine(CenteredTitle("HEXADECIMAL"));
                result.AppendLine($"M = {_model.PlaintextHex}");
                result.AppendLine($"K = {_model.KeyHex}");
                result.AppendLine(line).AppendLine();

                result.AppendLine(CenteredTitle("BINARY"));
                result.AppendLine($"M = {FormatBinaryWithSpacing(_model.PlaintextBinary, 4)}");
                result.AppendLine($"K = {FormatBinaryWithSpacing(_model.KeyBinary, 4)}");
                result.AppendLine(line).AppendLine();
            }

            result.AppendLine("Tahap 1 : Membuat 16 sub-kunci");
            result.AppendLine($"K+ = {FormatBinaryWithSpacing(_model.PermutedKey, 7)}\r\n");
            result.AppendLine($"C0 = {FormatBinaryWithSpacing(_model.C0, 7)}");
            result.AppendLine($"D0 = {FormatBinaryWithSpacing(_model.D0, 7)}\r\n");
            
            for (int i = 1; i <= 16; i++)
            {
                result.AppendLine($"C{i}D{i} = {FormatBinaryWithSpacing(_model.C_list[i] + _model.D_list[i], 7)}");
                result.AppendLine($"K{i} = {FormatBinaryWithSpacing(_model.K_list[i-1], 6)}\r\n");
            }

            result.AppendLine(line).AppendLine();

            result.AppendLine($"Tahap 2 : Proses {mode} untuk setiap 64-bit blok data.");
            result.AppendLine($"Input Awal = {FormatBinaryWithSpacing(mode == "ENKRIPSI" ? _model.PlaintextBinary : _model.CiphertextBinary, 4)}");
            result.AppendLine($"Hasil permutasi awal (IP): {FormatBinaryWithSpacing(_model.InitialPermutation, 4)}");
            result.AppendLine($"L0 = {FormatBinaryWithSpacing(_model.L0, 4)}");
            result.AppendLine($"R0 = {FormatBinaryWithSpacing(_model.R0, 4)}");
            result.AppendLine("\r\nPutaran 1 sampai 16:");

            for (int i = 1; i <= 16; i++)
            {
                result.AppendLine($"Putaran {i.ToString().PadLeft(2)}:");
                result.AppendLine($"L{(i - 1).ToString().PadLeft(2)} = {FormatBinaryWithSpacing(_model.L_list[i - 1], 4)}");
                result.AppendLine($"R{(i - 1).ToString().PadLeft(2)} = {FormatBinaryWithSpacing(_model.R_list[i - 1], 4)}");
                result.AppendLine($"E(R{(i - 1).ToString().PadLeft(2)}) = {FormatBinaryWithSpacing(_model.ExpansionResults[i - 1], 6)}");

                result.AppendLine($"K{(mode == "DEKRIPSI" ? 17 - i : i).ToString().PadLeft(2)} = {FormatBinaryWithSpacing(subKeys[i - 1], 6)}");
                result.AppendLine($"K XOR E = {FormatBinaryWithSpacing(_model.XorWithKeyResults[i - 1], 6)}");
                result.AppendLine($"S-Box Output = {FormatBinaryWithSpacing(_model.SBoxOutputs[i - 1], 4)}");
                result.AppendLine($"P(S-Box Output) = {FormatBinaryWithSpacing(_model.PBoxOutputs[i - 1], 4)}");
                result.AppendLine($"L{i.ToString().PadLeft(2)} = {FormatBinaryWithSpacing(_model.L_list[i], 4)}");
                result.AppendLine($"R{i.ToString().PadLeft(2)} = L{(i - 1).ToString().PadLeft(2)} XOR P(S-Box) = {FormatBinaryWithSpacing(_model.R_list[i], 4)}\r\n");
            }

            result.AppendLine($"Gabungan R16 || L16 : {FormatBinaryWithSpacing(_model.PreOutput, 8)}");
            result.AppendLine($"IP-1 : {FormatBinaryWithSpacing(_model.FinalPermutation, 8)}");

            if (mode == "DEKRIPSI")
            {
                result.AppendLine($"Plaintext (Hex) : {_model.DecryptedHexOutput}");
            }
            else
            {
                result.AppendLine($"Ciphertext (Hex) : {_model.EncryptedHexOutput}");
            }

            return result.ToString();
        }

        private string FormatBinaryWithSpacing(string binary, int groupSize)
        {
            var result = new StringBuilder();
            for (int i = 0; i < binary.Length; i += groupSize)
            {
                result.Append(binary.Substring(i, Math.Min(groupSize, binary.Length - i)) + " ");
            }
            return result.ToString().Trim();
        }

        private string CenteredTitle(string title, char lineChar = '=')
        {
            string decoratedTitle = $" {title} ";
            int totalWidth = 90; // Approx width for textbox
            int padding = (totalWidth - decoratedTitle.Length) / 2;
            if (padding < 0) padding = 0;
            string line = new string(lineChar, padding);
            string remainingLine = new string(lineChar, totalWidth - line.Length - decoratedTitle.Length);
            return line + decoratedTitle + remainingLine;
        }

        private string GenerateLine(TextBox tb, char character = '=')
        {
            return new string(character, 90);
        }
        #endregion
    }
}