namespace DPM235424_NguyenDucHuy_Refact_14_HideDelegate.After
{
    public class Department
    {
        public string DepartmentName { get; set; } = "Kinh doanh";
        public string Manager { get; set; } = "Tran Van Quan Ly";
    }

    public class HideDelegate_After
    {
        public string Name { get; set; } = "Nguyen Duc Huy";
        private Department _department = new Department();

        // Ẩn đối tượng ủy quyền Department, cung cấp phương thức truy cập trực tiếp
        public string GetManager()
        {
            return _department.Manager;
        }

        public string GetDepartmentName()
        {
            return _department.DepartmentName;
        }
    }
}