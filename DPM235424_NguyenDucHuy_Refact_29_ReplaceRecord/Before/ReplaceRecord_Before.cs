using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.Before
{
    public class ReplaceRecord_Before
    {
        // Sử dụng Dictionary làm Record thô (phi đối tượng)
        public Dictionary<string, object> CreatePersonRecord()
        {
            var record = new Dictionary<string, object>();
            record["Name"] = "Nguyen Duc Huy";
            record["Age"] = 21;
            record["Title"] = "Software Engineer";
            return record;
        }

        public void PrintRecord(Dictionary<string, object> record)
        {
            // Code smell: Truy xuất dựa trên string keys, không an toàn kiểu
            string name = (string)record["Name"];
            int age = (int)record["Age"];
            string title = (string)record["Title"];

            Console.WriteLine(string.Format("Nhân sự: {0} | Tuổi: {1} | Vị trí: {2}", name, age, title));
        }
    }
}