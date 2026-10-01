namespace DPM235424_NguyenDucHuy_Refact_11_MoveField.After
{
    public class AccountType
    {
        // Đã chuyển field về đúng lớp đại diện cho chính sách loại tài khoản
        public double InterestRate { get; set; } = 0.05;
    }

    public class MoveField_After
    {
        private AccountType _type = new AccountType();

        public double CalculateInterest(double amount, int days)
        {
            return _type.InterestRate * amount * days / 365;
        }
    }
}