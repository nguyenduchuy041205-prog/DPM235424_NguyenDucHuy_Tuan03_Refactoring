namespace DPM235424_NguyenDucHuy_Refact_12_ExtractClass.Before
{
    public class ExtractClass_Before
    {
        public string Name { get; set; } = "Nguyen Van A";
        public string OfficeAreaCode { get; set; } = "0296";
        public string OfficeNumber { get; set; } = "3856789";

        public string GetTelephoneNumber()
        {
            return $"({OfficeAreaCode}) {OfficeNumber}";
        }
    }
}