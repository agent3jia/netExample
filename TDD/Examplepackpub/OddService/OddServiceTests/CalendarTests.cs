using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DdepencyInversionGood;
using Moq;
using OddService;

namespace OddServiceTests
{
    public class CalendarTests
    {
        [Fact]
        public void Start_oneItemInCollection_ItemMethodCalled()
        {
            var item = new Mock<ICalendarItem>();
            var collection = new Collection<ICalendarItem>();
            var calendar = new Calendar(collection);
            calendar.Start();
            item.Verify(x => x.Start());
        }
    }
}
