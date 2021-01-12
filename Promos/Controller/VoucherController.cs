using System;
using System.Collections.Generic;
using System.Text;
using Promos.Model;

namespace Promos.Controller
{
    class Payment
    {
        private List<Voucher> items;

        public Payment()
        {
            items = new List<Voucher>();
        }

        public void addItem(Voucher item)
        {
            this.items.Add(item);
        }

        public List<Voucher> getItems()
        {
            return this.items;
        }

    }
}