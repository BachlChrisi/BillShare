using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts
{
    public interface ICopyable<T>
    {
        void CopyProperties(T other);
    }
}
