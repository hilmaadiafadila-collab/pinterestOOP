using System;

namespace pinterestOOP
{
    // Mewarisi abstract class 'account' DAN memakai interface 'IReportable'
    public class UserAccount : account, IReportable
    {
        private bool isBanned;

        public bool IsBanned
        {
            get { return this.isBanned; }
            set
            {
                this.isBanned = value;
                if (this.isBanned)
                {
                    Console.WriteLine($"PERINGATAN: Akun {this.Username} telah diblokir!");
                }
            }
        }

        public override void Register(string email, string username, string password)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            Console.WriteLine($"Akun personal {this.Username} berhasil didaftarkan.");
        }

        public override void Login(string username, string password)
        {
            Console.WriteLine($"Memeriksa kredensial... Selamat datang {username}!");
        }

        // Implementasi dari IReportable (Lintas keluarga)
        public void Laporkan(string alasan, string pelapor)
        {
            Console.WriteLine($"{pelapor} melaporkan akun {this.Username}. Alasan: {alasan}");
            this.IsBanned = true;
        }

        public void SimpanPin(Content pin, Board targetBoard)
        {
            Console.WriteLine($"{this.Username} sedang menyimpan pin...");
            targetBoard.TambahPinKeBoard(pin);
        }
    }
}