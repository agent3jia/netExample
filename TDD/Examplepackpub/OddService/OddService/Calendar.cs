using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DdepencyInversionGood;

namespace OddService
{
    public class Calendar
    {
        private readonly ICollection<ICalendarItem> _items;
        private readonly Reminder _reminder;

        public Calendar(ICollection<ICalendarItem> items)
        {
            _items = items;
        }

        public void Start()
        {
            foreach (var item in _items)
            {

            }
        }
    }
}
