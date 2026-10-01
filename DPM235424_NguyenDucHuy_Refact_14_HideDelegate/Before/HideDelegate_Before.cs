namespace DPM235424_NguyenDucHuy_Refact_14_HideDelegate.Before
{
    public class Department
    {
        public string DepartmentName { get; set; } = "Kinh doanh";
        public string Manager { get; set; } = "Tran Van Quan Ly";
    }

    public class HideDelegate_Before
    {
        public string Name { get; set; } = "Nguyen Duc Huy";
        // Client phải truy cập trực tiếp vào đối tượng trung gian Department
        public Department Department { get; set; } = new Department();
    }
}