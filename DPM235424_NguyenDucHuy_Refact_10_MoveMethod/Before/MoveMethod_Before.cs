namespace DPM235424_NguyenDucHuy_Refact_10_MoveMethod.Before
{
    public class AccountType
    {
        public bool IsPremium() => true;
    }

    public class MoveMethod_Before
    {
        private AccountType _type = new AccountType();
        private int _daysOverdrawn = 10;

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
            {
                result += OverdraftCharge();
            }
            return result;
        }

        // Phương thức bị đặt sai vị trí: nó phụ thuộc hoàn toàn vào AccountType
        public double OverdraftCharge()
        {
            if (_type.IsPremium())
            {
                double result = 10;
                if (_daysOverdrawn > 7)
                {
                    result += (_daysOverdrawn - 7) * 0.85;
                }
                return result;
            }
            else
            {
                return _daysOverdrawn * 1.75;
            }
        }
    }
}