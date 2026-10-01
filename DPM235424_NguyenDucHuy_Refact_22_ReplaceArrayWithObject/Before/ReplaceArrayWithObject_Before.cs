using System;

namespace DPM235424_NguyenDucHuy_Refact_22_ReplaceArrayWithObject.Before
{
    public class ReplaceArrayWithObject_Before
    {
        public void DisplayTeamPerformance()
        {
            // Mảng chứa các thuộc tính khác nhau bằng chỉ số ngầm định
            string[] row = new string[3];
            row[0] = "Liverpool";
            row[1] = "15";
            row[2] = "48";

            string name = row[0];
            int wins = int.Parse(row[1]);
            int points = int.Parse(row[2]);

            Console.WriteLine(string.Format("Đội: {0} | Thắng: {1} | Điểm: {2}", name, wins, points));
        }
    }
}