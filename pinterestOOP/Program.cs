using System;

namespace pinterestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inisialisasi Akun
            UserAccount user = new UserAccount();
            user.Register("Revietha@mail.com", "ReviethaCantik", "user123");
            user.Login("ReviethaCantik", "user123");

            //Membuat Konten (bisa Image & Video)
            VideoPin tutorMasak = new VideoPin { Id = "VID001", URLGambar = "masak.mp4", Creator = "ChefJuna", DurasiDetik = 60 };
            ImagePin fotoPemandangan = new ImagePin { Id = "IMG001", URLGambar = "GunungMerbabu.jpg", Creator = "ReviPendakiKalcer" };

            //Membuat Board (AGREGASI)
            Board boardInspirasi = new Board("Inspirasi Harian");

            //Aksi: Simpan Pin ke Board (ASOSIASI)
            user.SimpanPin(tutorMasak, boardInspirasi);
            user.SimpanPin(fotoPemandangan, boardInspirasi);

            //Inrteraksi (Interface ICommentable)
            tutorMasak.TambahKomentar("Enak banget chepp, aku dah recook!", "Jojo");
            tutorMasak.TampilkanSemuaKomentar();

            //Pelaporan (Interface IReportable)
            tutorMasak.Laporkan("Ini Spam", "Admin");
            tutorMasak.TampilkanKonten();

            user.Logout();
            
        }
    }
}