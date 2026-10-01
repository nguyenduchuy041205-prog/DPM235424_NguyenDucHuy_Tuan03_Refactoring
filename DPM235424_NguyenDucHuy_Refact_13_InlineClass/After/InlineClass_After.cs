namespace DPM235424_NguyenDucHuy_Refact_13_InlineClass.After
{
    public class InlineClass_After
    {
        public string Name { get; set; } = "Nguyễn Văn A";

        // Đã inline các thuộc tính của lớp TelephoneNumber vào trực tiếp lớp này
        public string AreaCode { get; set; } = "0296";
        public string Number { get; set; } = "3856789";

        public string GetContactInfo()
        {
            return $"{Name} - ({AreaCode}) {Number}";
        }
    }
}