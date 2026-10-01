namespace DPM235424_NguyenDucHuy_Refact_08_ReplaceMethodWithMethodObject.After
{
    public class ReplaceMethodWithMethodObject_After
    {
        public int Delta() => 10;

        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new GammaCalculator(this, inputVal, quantity, yearToDate).Compute();
        }
    }

    public class GammaCalculator
    {
        private readonly ReplaceMethodWithMethodObject_After _account;
        private int _inputVal;
        private int _quantity;
        private int _yearToDate;
        private int _importantValue1;
        private int _importantValue2;
        private int _importantValue3;

        public GammaCalculator(ReplaceMethodWithMethodObject_After account, int inputVal, int quantity, int yearToDate)
        {
            _account = account;
            _inputVal = inputVal;
            _quantity = quantity;
            _yearToDate = yearToDate;
        }

        public int Compute()
        {
            _importantValue1 = (_inputVal * _quantity) + _account.Delta();
            _importantValue2 = (_inputVal * _yearToDate) + 100;

            ImportantThing();

            _importantValue3 = _importantValue2 * 7;
            return _importantValue3 - 2 * _importantValue1;
        }

        private void ImportantThing()
        {
            if ((_yearToDate - _importantValue1) > 100)
            {
                _importantValue2 -= 20;
            }
        }
    }
}