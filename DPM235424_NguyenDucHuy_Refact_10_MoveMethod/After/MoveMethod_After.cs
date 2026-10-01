namespace DPM235424_NguyenDucHuy_Refact_10_MoveMethod.After
{
    public class AccountType
    {
        public bool IsPremium() => true;

        // Đã di chuyển phương thức sang đúng nơi chứa logic của loại tài khoản
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium())
            {
                double result = 10;
                if (daysOverdrawn > 7)
                {
                    result += (daysOverdrawn - 7) * 0.85;
                }
                return result;
            }
            else
            {
                return daysOverdrawn * 1.75;
            }
        }
    }

    public class MoveMethod_After
    {
        private AccountType _type = new AccountType();
        private int _daysOverdrawn = 10;

        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0)
            {
                // Gọi phương thức tại lớp mới
                result += _type.OverdraftCharge(_daysOverdrawn);
            }
            return result;
        }
    }
}