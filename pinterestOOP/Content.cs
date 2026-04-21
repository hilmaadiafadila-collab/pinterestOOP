using System;
using System.Collections.Generic;

namespace pinterestOOP
{
    public abstract class Content
    {
        private string id;
        private int jumlahLike;

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value.Length < 5)
                {
                    Console.WriteLine("Peringatan: ID Konten harus minimal 5 karakter.");
                    this.id = "ID_INVALID";
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public int JumlahLike
        {
            get { return this.jumlahLike; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Peringatan: Jumlah like tidak mungkin minus!");
                    this.jumlahLike = 0;
                }
                else
                {
                    this.jumlahLike = value;
                }
            }
        }

        public string URLGambar { get; set; }
        public string Deskripsi { get; set; }
        public string Creator { get; set; }

        // Mengganti _ dengan nama variabel biasa.
        // Protected agar bisa diakses oleh subclass seperti ImagePin.
        protected List<Comment> daftarKomentar = new List<comment>();

        public abstract void TampilkanKonten();

        public void LikeKonten()
        {
            this.JumlahLike++;
            Console.WriteLine($"Konten {this.Id} disukai! Total: {this.JumlahLike}");
        }
    }
}