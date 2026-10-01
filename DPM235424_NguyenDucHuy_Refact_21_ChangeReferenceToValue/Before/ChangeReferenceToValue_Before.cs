namespace DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.Before
{
    public class Currency
    {
        public string Code { get; set; }

        public Currency(string code)
        {
            Code = code;
        }
    }

    public class ChangeReferenceToValue_Before
    {
        public bool CompareCurrencies()
        {
            var c1 = new Currency("VND");
            var c2 = new Currency("VND");

            // So sánh tham chiếu mặc định sẽ là false vì hai vùng nhớ khác nhau
            return c1.Equals(c2);
        }
    }
}