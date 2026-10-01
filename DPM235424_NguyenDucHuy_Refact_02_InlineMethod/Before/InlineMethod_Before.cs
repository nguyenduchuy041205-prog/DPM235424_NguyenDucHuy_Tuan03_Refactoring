namespace DPM235424_NguyenDucHuy_Refact_02_InlineMethod.Before
{
    public class InlineMethod_Before
    {
        private int _numberOfLateDeliveries = 6;

        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        // Hàm trung gian không cần thiết
        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}