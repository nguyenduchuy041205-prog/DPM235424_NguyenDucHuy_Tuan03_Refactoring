namespace DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.Before
{
    public class TypeCodeWithClass_Before
    {
        // Type code dùng số nguyên thuần túy
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;
        public const int AB = 3;

        private int _bloodGroup;

        public TypeCodeWithClass_Before(int bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public int BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
    }
}