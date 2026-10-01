using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.Before
{
    public class Course
    {
        public string Name { get; set; }
        public bool IsAdvanced { get; set; }

        public Course(string name, bool isAdvanced)
        {
            Name = name;
            IsAdvanced = isAdvanced;
        }
    }

    public class EncapsulateColl_Before
    {
        // Code smell: Cho phép client can thiệp trực tiếp vào List hoặc gán danh sách mới hoàn toàn
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}