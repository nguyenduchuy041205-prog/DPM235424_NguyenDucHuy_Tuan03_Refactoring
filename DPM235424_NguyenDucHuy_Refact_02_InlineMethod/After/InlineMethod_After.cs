namespace DPM235424_NguyenDucHuy_Refact_02_InlineMethod.After
{
    public class InlineMethod_After
    {
        private int _numberOfLateDeliveries = 6;

        public int GetRating()
        {
            // Thay thế lời gọi hàm trực tiếp bằng biểu thức điều kiện
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}