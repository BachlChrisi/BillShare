using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts.Persistence
{
    public interface IBill : IIdentifiable, ICopyable<IBill>
    {
        DateTime Date { get; set; }

        string Title { get; set; }

        string Desciption { get; set; }

        string Friends { get; set; }

        string Currency { get; set }

    }
}
