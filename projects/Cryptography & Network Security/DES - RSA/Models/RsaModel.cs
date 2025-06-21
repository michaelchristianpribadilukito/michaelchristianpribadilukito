using System;
using System.Numerics;
using System.Text; 

namespace DES.Models
{
    public class RsaModel
    {
        public BigInteger P { get; private set; }
        public BigInteger Q { get; private set; }
        public BigInteger N { get; private set; }
        public BigInteger Phi { get; private set; }
        public BigInteger E { get; private set; }
        public BigInteger D { get; private set; }
        public string ErrorMessage { get; private set; }

        // Properti baru untuk menyimpan log proses
        public string ProcessOutput { get; private set; }

        public bool GenerateKeys(string p_str, string q_str, string e_str)
        {
            ErrorMessage = "";
            var processLog = new StringBuilder();
            processLog.AppendLine("====== PROSES PEMBANGKITAN KUNCI ======");

            if (!BigInteger.TryParse(p_str, out BigInteger p) || !BigInteger.TryParse(q_str, out BigInteger q) || !BigInteger.TryParse(e_str, out BigInteger e))
            {
                ErrorMessage = "Please enter valid integer values for p, q, and e.";
                return false;
            }

            processLog.AppendLine($"1. Pilih dua bilangan prima, p dan q."); // 
            processLog.AppendLine($"   p = {p}");
            processLog.AppendLine($"   q = {q}");


            if (!IsPrime(p) || !IsPrime(q))
            {
                ErrorMessage = "p and q must be prime numbers.";
                processLog.AppendLine("\nERROR: p dan q harus bilangan prima.");
                ProcessOutput = processLog.ToString();
                return false;
            }

            P = p;
            Q = q;
            E = e;

            N = P * Q;
            processLog.AppendLine($"\n2. Hitung n = p * q"); // 
            processLog.AppendLine($"   n = {P} * {Q} = {N}");

            Phi = (P - 1) * (Q - 1);
            processLog.AppendLine($"\n3. Hitung φ(n) = (p - 1) * (q - 1)"); // 
            processLog.AppendLine($"   φ(n) = ({P} - 1) * ({Q} - 1) = {Phi}");

            processLog.AppendLine($"\n4. Pilih kunci publik e = {E}"); // 
            processLog.AppendLine($"   Syarat: FPB(e, φ(n)) = 1"); // 

            BigInteger fpb = Gcd(E, Phi, processLog);
            processLog.AppendLine($"   Hasil FPB({E}, {Phi}) = {fpb}");


            if (fpb != 1)
            {
                ErrorMessage = "e is not relatively prime to phi(n).";
                processLog.AppendLine($"\nERROR: e tidak relatif prima terhadap φ(n).");
                ProcessOutput = processLog.ToString();
                return false;
            }

            processLog.AppendLine($"   Syarat terpenuhi.");

            D = ModInverse(E, Phi);
            processLog.AppendLine($"\n5. Hitung kunci privat d, dimana e*d ≡ 1 (mod φ(n))"); // 
            processLog.AppendLine($"   d = {E}^-1 mod {Phi}");
            processLog.AppendLine($"   d = {D}");

            processLog.AppendLine($"\n====== HASIL ======");
            processLog.AppendLine($"Kunci Publik (e, n): ({E}, {N})");
            processLog.AppendLine($"Kunci Privat (d, n): ({D}, {N})");

            ProcessOutput = processLog.ToString();
            return true;
        }

        public string Encrypt(string message_str)
        {
            var processLog = new StringBuilder();
            processLog.AppendLine("\n====== PROSES ENKRIPSI ======");
            if (BigInteger.TryParse(message_str, out BigInteger m))
            {
                processLog.AppendLine($"Pesan (m) = {m}");
                processLog.AppendLine($"Kunci Publik (e, n) = ({E}, {N})");
                processLog.AppendLine($"\nRumus Enkripsi: c = m^e mod n"); // 

                BigInteger c = BigInteger.ModPow(m, E, N);

                processLog.AppendLine($"c = {m}^{E} mod {N}");
                processLog.AppendLine($"c = {c}");
                processLog.AppendLine($"\nHasil Ciphertext: {c}");

                ProcessOutput = processLog.ToString();
                return c.ToString();
            }

            ProcessOutput = processLog.AppendLine("Error: Pesan harus berupa angka desimal.").ToString();
            return "Invalid Message";
        }

        public string Decrypt(string ciphertext_str)
        {
            var processLog = new StringBuilder();
            processLog.AppendLine("\n====== PROSES DEKRIPSI ======");
            if (BigInteger.TryParse(ciphertext_str, out BigInteger c))
            {
                processLog.AppendLine($"Ciphertext (c) = {c}");
                processLog.AppendLine($"Kunci Privat (d, n) = ({D}, {N})");
                processLog.AppendLine($"\nRumus Dekripsi: m = c^d mod n"); // 

                BigInteger m = BigInteger.ModPow(c, D, N);

                processLog.AppendLine($"m = {c}^{D} mod {N}");
                processLog.AppendLine($"m = {m}");
                processLog.AppendLine($"\nHasil Plaintext: {m}");

                ProcessOutput = processLog.ToString();
                return m.ToString();
            }

            ProcessOutput = processLog.AppendLine("Error: Ciphertext harus berupa angka desimal.").ToString();
            return "Invalid Ciphertext";
        }

        private BigInteger Gcd(BigInteger a, BigInteger b, StringBuilder log)
        {
            log.AppendLine($"   Mencari FPB({a}, {b}) menggunakan Algoritma Euclidean:"); // 
            while (b != 0)
            {
                log.AppendLine($"   {a} mod {b} = {a % b}");
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        // ... (metode lainnya tetap sama) ...
        private bool IsPrime(BigInteger n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (BigInteger i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            (BigInteger x, BigInteger y) = (1, 0);

            while (a > 1)
            {
                BigInteger q = a / m;
                (a, m) = (m, a % m);
                (x, y) = (y, x - q * y);
            }
            if (x < 0)
                x += m0;

            return x;
        }
    }
}