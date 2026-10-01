namespace DPM235424_NguyenDucHuy_Refact_18_SelfEncapsulateField.After
{
    public class SelfEncapsulateField_After
    {
        private int _low;
        private int _high;

        public SelfEncapsulateField_After(int low, int high)
        {
            Initialize(low, high);
        }

        private void Initialize(int low, int high)
        {
            _low = low;
            _high = high;
        }

        // Getter / Setter nội bộ
        public virtual int Low
        {
            get => _low;
            set => _low = value;
        }

        public virtual int High
        {
            get => _high;
            set => _high = value;
        }

        // Truy cập thông qua Getter thay vì đọc trực tiếp biến
        public bool Includes(int arg)
        {
            return arg >= Low && arg <= High;
        }

        public void Grow(int factor)
        {
            High = High * factor;
        }
    }

    // Lớp con có thể ghi đè logic Getter mà không phá vỡ hàm Includes
    public class CappedRange : SelfEncapsulateField_After
    {
        private int _cap;

        public CappedRange(int low, int high, int cap) : base(low, high)
        {
            _cap = cap;
        }

        public override int High
        {
            get => System.Math.Min(base.High, _cap);
            set => base.High = value;
        }
    }
}