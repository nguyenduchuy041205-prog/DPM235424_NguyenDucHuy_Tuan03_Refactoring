using System;

namespace DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.Before
{
    public class IntroduceLocalExtension_Before
    {
        private DateTime _currentDate = new DateTime(2026, 10, 1);

        public void ProcessSchedule()
        {
            // Nhiều Foreign Method rải rác ngay trong lớp client
            DateTime nextDay = GetNextDay(_currentDate);
            DateTime nextWeek = GetNextWeek(_currentDate);

            Console.WriteLine($"Ngày kế tiếp: {nextDay:dd/MM/yyyy}");
            Console.WriteLine($"Tuần kế tiếp: {nextWeek:dd/MM/yyyy}");
        }

        private static DateTime GetNextDay(DateTime arg) => arg.AddDays(1);
        private static DateTime GetNextWeek(DateTime arg) => arg.AddDays(7);
    }
}