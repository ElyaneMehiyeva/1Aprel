using System;
using System.Collections.Generic;
using System.Text;

namespace _2aprelTask
{
    internal class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();
        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            Meeting meeting1 = new Meeting()
            {
                Name = name,
                FromDate = fromDate,
                ToDate = toDate,
            };
            if (Meetings.Count == 0)
            {                
                Meetings.Add(meeting1);
            } else
            {
                int count = 0;
                foreach (Meeting Meeting in Meetings)
                {

                    if (Meeting.FromDate > toDate || Meeting.ToDate < fromDate)
                    {

                        count = 1;

                    }
                    else
                    {
                        throw new Exception("Bu vaxtda meeting var!");
                    }
                }
                if(count == 1)
                {
                    Meetings.Add(meeting1);
                }
            }
            
        }
        public int FindMeetingsCount(DateTime time)
        {
            List<Meeting> newMeetings = new List<Meeting>();
            foreach (Meeting Meeting in Meetings)
            {
                if (time < Meeting.FromDate)
                {
                   newMeetings.Add(Meeting);
                }
            }
            return newMeetings.Count;   
        }
        public bool IsExistsMeetingByName(string text)
        {
            foreach (Meeting Meeting in Meetings)
            {
                if (Meeting.Name.Contains(text))
                {
                    return true;
                }
            }
            return false;
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            List<Meeting> newMeetings = new List<Meeting>();
            foreach (Meeting Meeting in Meetings)
            {
                if (Meeting.Name.Contains(name))
                {
                    newMeetings.Add(Meeting);
                }
            }
            return newMeetings;
        }
    }
}