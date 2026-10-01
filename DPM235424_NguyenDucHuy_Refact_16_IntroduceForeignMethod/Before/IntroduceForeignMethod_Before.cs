using System;

namespace DPM235424_NguyenDucHuy_Refact_16_IntroduceForeignMethod.Before
{
    public class IntroduceForeignMethod_Before
    {
        private DateTime _previousEnd = new DateTime(2026, 10, 1);

        public void SchedulePayment()
        {
            // Code smell: Logic tính toán ngày tiếp theo bị viết rải rác ngay trong hàm
            DateTime paymentDate = new DateTime(_previousEnd.Year, _previousEnd.Month, _previousEnd.Day).AddDays(1);
            Console.WriteLine($"Ngày thanh toán (Before): {paymentDate:dd/MM/yyyy}");
        }
    }
}