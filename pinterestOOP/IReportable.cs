using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public interface IReportable
    {
        void Laporkan(string alasan, string user);
        bool IsBanned { get; set; }
    }
}
