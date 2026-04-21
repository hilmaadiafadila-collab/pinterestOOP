using System;

namespace pinterestOOP
{
    // Mewarisi abstract class 'Account' DAN memakai interface 'IReportable'
    public class BusinessAccount : Account, IReportable
    {
        public string? WebsiteBisnis;
        private bool isBanned;

        public bool IsBanned
        {
            get { return this.isBanned; }
            set
            {
                this.isBanned = value;
                if (this.isBanned)
                {
                    Console.WriteLine($"PERINGATAN: Akun Bisnis {this.Username} telah diblokir!");
                }
            }
        }

        public override void Register(string email, string username, string password)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            Console.WriteLine($"Akun bisnis {this.Username} berhasil didaftarkan.");
        }

        public override void Login(string username, string password)
        {
            Console.WriteLine($"Masuk ke dasbor analitik bisnis... Selamat datang {username}!");
        }

        // Implementasi dari IReportable (Lintas keluarga)
        public void Laporkan(string alasan, string pelapor)
        {
            Console.WriteLine($"{pelapor} melaporkan akun bisnis {this.Username} karena indikasi penipuan. Alasan: {alasan}");
            this.IsBanned = true;
        }
    }
}