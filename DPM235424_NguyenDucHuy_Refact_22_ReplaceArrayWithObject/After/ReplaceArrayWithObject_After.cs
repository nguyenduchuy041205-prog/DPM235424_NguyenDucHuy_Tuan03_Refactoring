using System;

namespace DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.After
{
    // Đối tượng hóa mảng dữ liệu
    public class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Points { get; set; }
    }

    public class ReplaceArrayWithObject_After
    {
        public void DisplayTeamPerformance()
        {
            var row = new Performance
            {
                Name = "Liverpool",
                Wins = 15,
                Points = 48
            };

            Console.WriteLine(string.Format("Đội: {0} | Thắng: {1} | Điểm: {2}", row.Name, row.Wins, row.Points));
        }
    }
}