namespace DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.Before
{
    public class SelfEncapsulateField_Before
    {
        private int _low;
        private int _high;

        public SelfEncapsulateField_Before(int low, int high)
        {
            _low = low;
            _high = high;
        }

        // Truy cập trực tiếp vào biến trường nội bộ
        public bool Includes(int arg)
        {
            return arg >= _low && arg <= _high;
        }

        public void Grow(int factor)
        {
            _high = _high * factor;
        }
    }
}