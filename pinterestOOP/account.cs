using System;

namespace pinterestOOP
{
    public abstract class Account
    {
        private string email = string.Empty;
        private string password = string.Empty;

        public string Username = string.Empty;
        public string Bio = string.Empty;

        public string Email
        {
            get { return this.email; }
            set
            {
                if (!value.Contains("@") || !value.Contains("."))
                {
                    Console.WriteLine("Peringatan: Format email tidak valid! Email belum disimpan.");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public string Password
        {
            get { return this.password; }
            set
            {
                if (value.Length < 8)
                {
                    Console.WriteLine("Peringatan: Keamanan lemah, password minimal 8 karakter!");
                }
                else
                {
                    this.password = value;
                }
            }
        }

        public abstract void Register(string email, string username, string password);
        public abstract void Login(string username, string password);

        public virtual void UpdateBio(string newBio)
        {
            this.Bio = newBio;
            Console.WriteLine("Profil berhasil diperbarui.");
        }

        public void Logout()
        {
            Console.WriteLine("Telah keluar dari sistem.");
        }
    }
}