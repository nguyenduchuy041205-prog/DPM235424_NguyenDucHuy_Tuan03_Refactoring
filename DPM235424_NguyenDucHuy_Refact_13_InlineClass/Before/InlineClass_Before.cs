namespace DPM235424_NguyenDucHuy_Refact_13_InlineClass.Before
{
    // Lớp quá nhỏ, không còn đủ lý do tồn tại độc lập
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = "0296";
        public string Number { get; set; } = "3856789";

        public string GetFullNumber() => $"({AreaCode}) {Number}";
    }

    public class InlineClass_Before
    {
        public string Name { get; set; } = "Nguyễn Văn A";
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();

        public string GetContactInfo()
        {
            return $"{Name} - {Phone.GetFullNumber()}";
        }
    }
}