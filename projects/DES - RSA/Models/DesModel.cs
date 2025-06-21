using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES.Models
{
    public class DesModel
    {
        #region Properties for Storing Results
        // Properti untuk menyimpan setiap langkah agar bisa diambil oleh Controller
        public string PlaintextHex { get; private set; }
        public string KeyHex { get; private set; }
        public string CiphertextHex { get; private set; }
        public string PlaintextBinary { get; private set; }
        public string KeyBinary { get; private set; }
        public string CiphertextBinary { get; private set; } // Ditambahkan untuk dekripsi
        public string PermutedKey { get; private set; }
        public string C0 { get; private set; }
        public string D0 { get; private set; }
        public List<string> C_list { get; } = new List<string>();
        public List<string> D_list { get; } = new List<string>();
        public List<string> K_list { get; } = new List<string>();
        public string InitialPermutation { get; private set; }
        public string L0 { get; private set; }
        public string R0 { get; private set; }
        public List<string> L_list { get; } = new List<string>();
        public List<string> R_list { get; } = new List<string>();
        public List<string> ExpansionResults { get; } = new List<string>();
        public List<string> XorWithKeyResults { get; } = new List<string>();
        public List<string> SBoxOutputs { get; } = new List<string>();
        public List<string> PBoxOutputs { get; } = new List<string>();
        public string PreOutput { get; private set; }
        public string FinalPermutation { get; private set; }

        // Output properti bisa dipisah untuk kejelasan
        public string EncryptedHexOutput { get; private set; }
        public string DecryptedHexOutput { get; private set; }

        #endregion

        #region DES Constants (Tables)
        private static readonly int[] initialPermutationTable = 
            { 
            58, 50, 42, 34, 26, 18, 10, 2, 60, 52, 44, 36, 28, 20, 12, 4, 
            62, 54, 46, 38, 30, 22, 14, 6, 64, 56, 48, 40, 32, 24, 16, 8, 
            57, 49, 41, 33, 25, 17, 9, 1, 59, 51, 43, 35, 27, 19, 11, 3, 
            61, 53, 45, 37, 29, 21, 13, 5, 63, 55, 47, 39, 31, 23, 15, 7 
            };
        private static readonly int[] keyPermutationTable = 
            { 
            57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18, 
            10, 2, 59, 51, 43, 35, 27, 19, 11, 3, 60, 52, 44, 36, 
            63, 55, 47, 39, 31, 23, 15, 7, 62, 54, 46, 38, 30, 22, 
            14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 28, 20, 12, 4 
            };
        private static readonly int[] shiftTable = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };
        private static readonly int[] compressionTable = 
            { 
            14, 17, 11, 24, 1, 5, 3, 28, 15, 6, 21, 10, 
            23, 19, 12, 4, 26, 8, 16, 7, 27, 20, 13, 2, 
            41, 52, 31, 37, 47, 55, 30, 40, 51, 45, 33, 48, 
            44, 49, 39, 56, 34, 53, 46, 42, 50, 36, 29, 32 
            };
        private static readonly int[] expansionTable = 
            { 
            32, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 
            8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 
            16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 
            24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 1 
            };
        private static readonly int[,,] SBoxes = 
            new int[8, 4, 16] 
            { 
                { 
                    { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7 }, 
                    { 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8 }, 
                    { 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0 }, 
                    { 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 } 
                }, 
                { 
                    { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10 }, 
                    { 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5 }, 
                    { 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15 }, 
                    { 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 } 
                }, 
                { 
                    { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8 }, 
                    { 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1 }, 
                    { 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7 }, 
                    { 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 } 
                }, 
                { 
                    { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15 }, 
                    { 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9 }, 
                    { 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4 }, 
                    { 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 } 
                }, 
                { 
                    { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9 }, 
                    { 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6 }, 
                    { 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14 }, 
                    { 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 } 
                }, 
                { 
                    { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11 }, 
                    { 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8 }, 
                    { 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6 }, 
                    { 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 } 
                }, 
                { 
                    { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1 }, 
                    { 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6 }, 
                    { 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2 }, 
                    { 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 } 
                }, 
                { 
                    { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7 }, 
                    { 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2 }, 
                    { 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8 }, 
                    { 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 } 
                } 
            };
        private static readonly int[] permutationP = 
            { 
            16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 26, 5, 18, 31, 10, 
            2, 8, 24, 14, 32, 27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25 
            };
        private static readonly int[] finalPermutationTable = 
            { 
            40, 8, 48, 16, 56, 24, 64, 32, 39, 7, 47, 15, 55, 23, 63, 31, 
            38, 6, 46, 14, 54, 22, 62, 30, 37, 5, 45, 13, 53, 21, 61, 29, 
            36, 4, 44, 12, 52, 20, 60, 28, 35, 3, 43, 11, 51, 19, 59, 27, 
            34, 2, 42, 10, 50, 18, 58, 26, 33, 1, 41, 9, 49, 17, 57, 25 
            };
        #endregion

        private void ClearPreviousResults()
        {
            C_list.Clear();
            D_list.Clear();
            K_list.Clear();
            L_list.Clear();
            R_list.Clear();
            ExpansionResults.Clear();
            XorWithKeyResults.Clear();
            SBoxOutputs.Clear();
            PBoxOutputs.Clear();
        }

        public void Encrypt(string plaintextHex, string keyHex)
        {
            ClearPreviousResults();

            this.PlaintextHex = plaintextHex;
            this.KeyHex = keyHex;

            // Konversi dari heksadesimal ke biner
            PlaintextBinary = HexToBinary(plaintextHex);
            KeyBinary = HexToBinary(keyHex);

            // Hasilkan sub-kunci dari kunci yang diberikan
            GenerateSubKeys();

            // Proses enkripsi menggunakan sub-kunci urutan normal (K1..K16)
            ProcessRounds(PlaintextBinary, K_list);

            EncryptedHexOutput = BinaryToHex(FinalPermutation);
        }

        public void Decrypt(string ciphertextHex, string keyHex)
        {
            ClearPreviousResults();

            this.CiphertextHex = ciphertextHex;
            this.KeyHex = keyHex;

            CiphertextBinary = HexToBinary(ciphertextHex);
            KeyBinary = HexToBinary(keyHex);

            GenerateSubKeys();

            // Buat list kunci terbalik untuk dekripsi
            var reversedKeys = new List<string>(K_list);
            reversedKeys.Reverse();

            // Proses dekripsi menggunakan sub-kunci urutan terbalik (K16..K1)
            ProcessRounds(CiphertextBinary, reversedKeys);

            DecryptedHexOutput = BinaryToHex(FinalPermutation);
        }

        private void GenerateSubKeys()
        {
            PermutedKey = ApplyPermutation(KeyBinary, keyPermutationTable);
            C0 = PermutedKey.Substring(0, 28);
            D0 = PermutedKey.Substring(28, 28);

            C_list.Add(C0);
            D_list.Add(D0);

            string Cn = C0;
            string Dn = D0;

            for (int i = 0; i < 16; i++)
            {
                Cn = LeftShift(Cn, shiftTable[i]);
                Dn = LeftShift(Dn, shiftTable[i]);
                C_list.Add(Cn);
                D_list.Add(Dn);

                string CD = Cn + Dn;
                string K = ApplyPermutation(CD, compressionTable);
                K_list.Add(K);
            }
        }

        // Method ini sekarang digeneralisasi untuk menangani enkripsi dan dekripsi
        private void ProcessRounds(string inputBinary, List<string> subKeys)
        {
            InitialPermutation = ApplyPermutation(inputBinary, initialPermutationTable);
            L0 = InitialPermutation.Substring(0, 32);
            R0 = InitialPermutation.Substring(32, 32);

            L_list.Add(L0);
            R_list.Add(R0);

            for (int i = 0; i < 16; i++)
            {
                string Ln = L_list[i];
                string Rn = R_list[i];

                string expandedR = ApplyPermutation(Rn, expansionTable);
                ExpansionResults.Add(expandedR);

                // Gunakan sub-kunci dari list yang diberikan
                string xorWithKey = XOR(expandedR, subKeys[i]);
                XorWithKeyResults.Add(xorWithKey);

                string sBoxOutput = ApplySBoxes(xorWithKey);
                SBoxOutputs.Add(sBoxOutput);

                string pBoxOutput = ApplyPermutation(sBoxOutput, permutationP);
                PBoxOutputs.Add(pBoxOutput);

                string Rnext = XOR(Ln, pBoxOutput);
                string Lnext = Rn;

                L_list.Add(Lnext);
                R_list.Add(Rnext);
            }

            PreOutput = R_list[16] + L_list[16];
            FinalPermutation = ApplyPermutation(PreOutput, finalPermutationTable);
        }


        #region Core Utility Methods
        // ... (Semua method di region ini sama persis, tidak ada perubahan)
        private string ApplyPermutation(string input, int[] table)
        {
            var output = new StringBuilder();
            foreach (int index in table)
            {
                output.Append(input[index - 1]);
            }
            return output.ToString();
        }

        private string LeftShift(string input, int shift)
        {
            return input.Substring(shift) + input.Substring(0, shift);
        }

        private string XOR(string a, string b)
        {
            var result = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
            {
                result.Append(a[i] == b[i] ? '0' : '1');
            }
            return result.ToString();
        }

        private string ApplySBoxes(string input48Bit)
        {
            var output32Bit = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                string sixBits = input48Bit.Substring(i * 6, 6);
                int row = Convert.ToInt32($"{sixBits[0]}{sixBits[5]}", 2);
                int col = Convert.ToInt32(sixBits.Substring(1, 4), 2);
                int sValue = SBoxes[i, row, col];
                output32Bit.Append(Convert.ToString(sValue, 2).PadLeft(4, '0'));
            }
            return output32Bit.ToString();
        }

        public static string HexToBinary(string hex)
        {
            var binary = new StringBuilder();
            foreach (char c in hex)
            {
                int val = Convert.ToInt32(c.ToString(), 16);
                binary.Append(Convert.ToString(val, 2).PadLeft(4, '0'));
            }
            return binary.ToString();
        }

        public static string BinaryToHex(string binary)
        {
            var hex = new StringBuilder();
            for (int i = 0; i < binary.Length; i += 4)
            {
                string nibble = binary.Substring(i, 4);
                hex.Append(Convert.ToInt32(nibble, 2).ToString("X"));
            }
            return hex.ToString();
        }
        #endregion
    }
}