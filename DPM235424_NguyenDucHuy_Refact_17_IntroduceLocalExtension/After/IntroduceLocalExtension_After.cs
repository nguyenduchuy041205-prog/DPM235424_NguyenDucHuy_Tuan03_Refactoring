using System;

namespace DPM235424_NguyenDucHuy_Refact_17_IntroduceLocalExtension.After
{
    // Local Extension dạng Wrapper Class
    public class MfDateSub
    {
        private DateTime _originalDate;

        public MfDateSub(DateTime originalDate)
        {
            _originalDate = originalDate;
        }

        public DateTime Value => _originalDate;

        // Các phương thức tiện ích mở rộng được gom về một lớp thống nhất
        public DateTime NextDay() => _originalDate.AddDays(1);
        public DateTime NextWeek() => _originalDate.AddDays(7);
    }

    public class IntroduceLocalExtension_After
    {
        public void ProcessSchedule()
        {
            var dateWrapper = new MfDateSub(new DateTime(2026, 10, 1));

            Console.WriteLine($"Ngày gốc:     {dateWrapper.Value:dd/MM/yyyy}");
            Console.WriteLine($"Ngày kế tiếp: {dateWrapper.NextDay():dd/MM/yyyy}");
            Console.WriteLine($"Tuần kế tiếp: {dateWrapper.NextWeek():dd/MM/yyyy}");
        }
    }
}