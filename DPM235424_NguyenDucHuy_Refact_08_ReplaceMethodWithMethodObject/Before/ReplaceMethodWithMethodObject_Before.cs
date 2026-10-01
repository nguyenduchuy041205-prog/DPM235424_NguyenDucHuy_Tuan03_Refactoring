namespace DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.Before
{
    public class ReplaceMethodWithMethodObject_Before
    {
        public int Delta() => 10;

        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            int importantValue1 = (inputVal * quantity) + Delta();
            int importantValue2 = (inputVal * yearToDate) + 100;

            if ((yearToDate - importantValue1) > 100)
            {
                importantValue2 -= 20;
            }

            int importantValue3 = importantValue2 * 7;
            return importantValue3 - 2 * importantValue1;
        }
    }
}