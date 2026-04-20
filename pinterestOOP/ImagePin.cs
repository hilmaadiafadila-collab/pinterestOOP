using System;

namespace pinterestOOP
{
    // Mewarisi abstract class 'Content' DAN memakai interface
    public class ImagePin : Content, IShareable, IReportable, ICommentable
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
                    Console.WriteLine("PERINGATAN: Gambar ini telah diblokir sistem!");
                }
            }
        }

        public override void TampilkanKonten()
        {
            if (this.IsBanned)
            {
                Console.WriteLine("Gambar disembunyikan karena melanggar aturan.");
            }
            else
            {
                Console.WriteLine($"[Gambar] {this.Creator} memposting foto. URL: {this.URLGambar}");
            }
        }

        public string GenerateShareLink()
        {
            return $"https://pinterest.com/pin/img_{this.Id}";
        }

        public void BagikanKePesan(string penerima)
        {
            Console.WriteLine($"Membagikan gambar {this.Id} kepada {penerima}.");
        }

        // Implementasi IReportable (Sama persis dengan yang ada di Account!)
        public void Laporkan(string alasan, string pelapor)
        {
            Console.WriteLine($"{pelapor} melaporkan GAMBAR {this.Id}. Alasan: {alasan}");
            this.IsBanned = true;
        }

        public void TambahKomentar(string teks, string user)
        {
            comment komenBaru = new comment(teks, user);
            this.daftarKomentar.Add(komenBaru);
            Console.WriteLine($"{user} berkomentar di gambar: {teks}");
        }

        public void TampilkanSemuaKomentar()
        {
            Console.WriteLine($"--- Komentar Gambar {this.Id} ---");
            foreach (var k in this.daftarKomentar)
            {
                Console.WriteLine($"@{k.UsernamePembuat}: {k.Teks}");
            }
        }

        public void HapusKomentar(int idKomentar)
        {
            if (idKomentar >= 0 && idKomentar < this.daftarKomentar.Count)
            {
                this.daftarKomentar.RemoveAt(idKomentar);
                Console.WriteLine("Komentar gambar berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Peringatan: Komentar tidak ditemukan.");
            }
        }
    }
}