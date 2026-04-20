using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public abstract class account
    {
        public string Id;
        public string URLGambar;
        public string Deskripsi;
        public string Creator;
        public DateTime TanggalUnggah;

        // method
        public abstract void TampilkanAccount();
    }
}
