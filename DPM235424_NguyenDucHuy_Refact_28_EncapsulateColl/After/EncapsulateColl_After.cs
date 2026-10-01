using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_28_EncapsulateColl.After
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

    public class EncapsulateColl_After
    {
        private readonly List<Course> _courses = new List<Course>();

        // Chỉ cho phép đọc tập hợp dưới dạng ReadOnlyCollection
        public IReadOnlyCollection<Course> Courses
        {
            get { return _courses.AsReadOnly(); }
        }

        // Cung cấp các thao tác thêm / xóa có kiểm soát
        public void AddCourse(Course course)
        {
            if (course != null && !_courses.Contains(course))
            {
                _courses.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }

        public int NumberOfAdvancedCourses()
        {
            int count = 0;
            foreach (var course in _courses)
            {
                if (course.IsAdvanced) count++;
            }
            return count;
        }
    }
}