namespace DPM235424_NguyenDucHuy_Refact_12_ExtractClass.After
{
    // Lớp mới được trích xuất
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        public string GetFullTelephoneNumber()
        {
            return $"({AreaCode}) {Number}";
        }
    }

    public class ExtractClass_After
    {
        public string Name { get; set; } = "Nguyen Van A";
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();

        public string GetTelephoneNumber()
        {
            return OfficeTelephone.GetFullTelephoneNumber();
        }
    }
}