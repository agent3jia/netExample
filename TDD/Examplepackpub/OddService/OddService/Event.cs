using DdepencyInversionGood;

namespace OddService
{
    public class Event: ICalendarItem
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void StartEvent()
        {

        }
    }
}