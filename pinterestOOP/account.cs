using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public abstract class account
    {
        public string Email;
        public string Username;
        public string Password;
        public string Bio;

        // method
        public abstract void Register(string Email, string Username, string Password);

        public abstract void Login(string Username, string Password);

        public virtual void UpdateBio(string newBio)
        {
            this.Bio = newBio;
            Console.WriteLine($"Profil {Username} berhasil diperbarui.");
        }

        public void Logout()
        {
            Console.WriteLine($"Akun {Username} telah keluar dari sistem.");
        }
    }
}
