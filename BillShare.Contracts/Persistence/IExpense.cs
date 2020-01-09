using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts.Persistence
{
    public interface IExpense : IIdentifiable, ICopyable<IExpense>
    {
        int BillId { get; set; }

        string Designation { get; set; }

        int Amount { get; set; }

        string Friend { get; set; }
    }
}
