using System;
using System.Collections.Generic;
using System.Text;

namespace pinterestOOP
{
    public interface IShareable
    {
        string GenerateShareLink();
        void BagikanKePesan(string penerima);
    }
}
