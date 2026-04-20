using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public abstract class Content
    {
        public string Id;
        public string URLGambar;
        public string Deskripsi;
        public string Creator;
        public int JumlahLike;
        public DateTime TanggalUnggah;

        public List<string> DaftarKomentar = new List<string>();

        //Method
        public abstract void TampilkanKonten();

        public void EditDeskripsi(string deskripsiBaru)
        {
            this.Deskripsi = deskripsiBaru;
            Console.WriteLine($"Deskripsi konten {Id} berhasil diperbarui.");
        }

        public void LikeKonten()
        {
            this.JumlahLike++;
            Console.WriteLine($"Konten {Id} disukai! Total like: {JumlahLike}");
        }
    }
}
