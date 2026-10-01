namespace DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.After
{
    public class Department
    {
        public string Manager { get; set; } = "Tran Van Quan Ly";
        public string DepartmentCode { get; set; } = "DEP-KD-01";
        public string Location { get; set; } = "Khu vuc DBSCL";
    }

    public class RemoveMiddleMan_After
    {
        public string Name { get; set; } = "Nguyen Duc Huy";
        // Cung cấp truy cập trực tiếp đến Department, xóa sạch các hàm chuyển tiếp thừa
        public Department Department { get; set; } = new Department();
    }
}