namespace DPM235424_NguyenDucHuy_Refact_15_RemoveMiddleMan.Before
{
    public class Department
    {
        public string Manager { get; set; } = "Tran Van Quan Ly";
        public string DepartmentCode { get; set; } = "DEP-KD-01";
        public string Location { get; set; } = "Khu vuc DBSCL";
    }

    public class RemoveMiddleMan_Before
    {
        public string Name { get; set; } = "Nguyen Duc Huy";
        private Department _department = new Department();

        // Các phương thức ủy quyền rườm rà biến Person thành kẻ trung gian
        public string GetManager() => _department.Manager;
        public string GetDepartmentCode() => _department.DepartmentCode;
        public string GetLocation() => _department.Location;
    }
}