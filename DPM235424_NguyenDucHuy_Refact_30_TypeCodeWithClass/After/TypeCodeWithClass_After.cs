namespace DPM235424_NguyenDucHuy_Refact_30_TypeCodeWithClass.After
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0, "O");
        public static readonly BloodGroup A = new BloodGroup(1, "A");
        public static readonly BloodGroup B = new BloodGroup(2, "B");
        public static readonly BloodGroup AB = new BloodGroup(3, "AB");

        private readonly int _code;
        private readonly string _name;

        private BloodGroup(int code, string name)
        {
            _code = code;
            _name = name;
        }

        public int Code => _code;
        public string Name => _name;
    }

    public class TypeCodeWithClass_After
    {
        private BloodGroup _bloodGroup;

        // Bắt buộc phải truyền đúng đối tượng BloodGroup, ngăn chặn truyền số nguyên bất hợp lệ
        public TypeCodeWithClass_After(BloodGroup bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public BloodGroup BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }
    }
}