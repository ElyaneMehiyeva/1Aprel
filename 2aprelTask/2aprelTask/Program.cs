using System;

namespace _2aprelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Meeting
            //Meeting meeting1 = new Meeting()
            //{
            //    Name = "1-1 gorusme",
            //    FromDate = new DateTime(2022, 04, 01, 13, 00, 00),
            //    ToDate = new DateTime(2022, 04, 01, 14, 00, 00),
            //};
            //Meeting meeting2 = new Meeting()
            //{
            //    Name = "Rektor ile gorus",
            //    FromDate = new DateTime(2022, 04, 02, 15, 00, 00),
            //    ToDate = new DateTime(2022, 04, 02, 18, 00, 00),
            //};
            #endregion

            MeetingSchedule schedule1 = new MeetingSchedule();
            try
            {
                schedule1.SetMeeting("meet1", new DateTime(2022, 04, 01, 13, 00, 00), new DateTime(2022, 04, 01, 14, 00, 00));
                schedule1.SetMeeting("meet2", new DateTime(2022, 04, 02, 15, 00, 00), new DateTime(2022, 04, 02, 18, 00, 00));
                schedule1.SetMeeting("meet3", new DateTime(2022, 04, 02, 16, 00, 00), new DateTime(2022, 04, 02, 18, 00, 00));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(schedule1.FindMeetingsCount(new DateTime(2022, 02, 12)));
            foreach (var item in schedule1.Meetings)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in schedule1.GetExistMeetings(""))
            {
                Console.WriteLine(item.Name);
            }
            
           
        }
    }
}

