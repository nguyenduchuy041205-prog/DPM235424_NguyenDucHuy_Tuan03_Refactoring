namespace DPM235424_NguyenDucHuy_Refact_11_MoveField.Before
{
    public class AccountType
    {
    }

    public class MoveField_Before
    {
        private AccountType _type = new AccountType();
        // Field bị đặt sai chỗ: mỗi loại tài khoản nên có mức lãi suất riêng
        private double _interestRate = 0.05;

        public double CalculateInterest(double amount, int days)
        {
            return _interestRate * amount * days / 365;
        }
    }
}