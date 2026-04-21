using System;

namespace pinterestOOP
{
    public class Comment
    {
        private string teks;
        private string usernamePembuat;

        public string Teks
        {
            get { return this.teks; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Peringatan: Komentar tidak boleh kosong!");
                    this.teks = "[Komentar disembunyikan]"; // Nilai default jika kosong
                }
                else
                {
                    this.teks = value;
                }
            }
        }

        public string UsernamePembuat
        {
            get { return this.usernamePembuat; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Peringatan: Username terlalu pendek.");
                    this.usernamePembuat = "Anonim";
                }
                else
                {
                    this.usernamePembuat = value;
                }
            }
        }

        public Comment(string teks, string username)
        {
            this.Teks = teks;
            this.UsernamePembuat = username;
        }
    }
}