using System;

namespace pinterestOOP
{
    // Mewarisi abstract class 'Content' DAN memakai interface
    public class VideoPin : Content, IShareable, IReportable, ICommentable
    {
        public int DurasiDetik { get; set; }
        private bool isBanned;

        public bool IsBanned
        {
            get { return this.isBanned; }
            set
            {
                this.isBanned = value;
                if (this.isBanned)
                {
                    Console.WriteLine("PERINGATAN: Video ini telah diblokir sistem!");
                }
            }
        }

        public override void TampilkanKonten()
        {
            if (this.IsBanned)
            {
                Console.WriteLine("Video ditarik dari peredaran karena pelanggaran hak cipta.");
            }
            else
            {
                Console.WriteLine($"[Video] {this.Creator} memposting video ({this.DurasiDetik} detik). URL: {this.URLGambar}");
            }
        }

        public string GenerateShareLink()
        {
            return $"https://pinterest.com/pin/vid_{this.Id}";
        }

        public void BagikanKePesan(string penerima)
        {
            Console.WriteLine($"Membagikan video {this.Id} kepada {penerima}.");
        }

        // Implementasi IReportable
        public void Laporkan(string alasan, string pelapor)
        {
            Console.WriteLine($"{pelapor} melaporkan VIDEO {this.Id}. Alasan: {alasan}");
            this.IsBanned = true;
        }

        public void TambahKomentar(string teks, string user)
        {
            comment komenBaru = new comment(teks, user);
            this.daftarKomentar.Add(komenBaru);
            Console.WriteLine($"{user} berkomentar di video: {teks}");
        }

        public void TampilkanSemuaKomentar()
        {
            Console.WriteLine($"--- Komentar Video {this.Id} ---");
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
                Console.WriteLine("Komentar video berhasil dihapus.");
            }
            else
            {
                Console.WriteLine("Peringatan: Komentar tidak ditemukan.");
            }
        }
    }
}