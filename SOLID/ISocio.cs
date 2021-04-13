using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface ISocio
    {
        decimal PurchaseInStore(int price);
        void SubscribeNextYear();
        void CongratsSocio();
        void SumarySocio();
    }
}
