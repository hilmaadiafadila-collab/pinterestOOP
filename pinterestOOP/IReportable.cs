using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public interface IReportable
    {
        void LaporkanKonten(string alasan, string user);
        bool IsBanned { get; set; }
    }
}
