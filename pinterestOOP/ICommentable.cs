using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public interface ICommentable
    {
        void TambahKomentar(string teks, string user);
        void HapusKomentar(int idKomentar);
    }
}
