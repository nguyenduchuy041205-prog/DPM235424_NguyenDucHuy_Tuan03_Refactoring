using System;

namespace DPM235424_NguyenDucHuy_Refact_21_ChangeReferenceToValue.After
{
    public class Currency : IEquatable<Currency>
    {
        public string Code { get; }

        public Currency(string code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Currency);
        }

        public bool Equals(Currency other)
        {
            if (ReferenceEquals(other, null)) return false;
            return Code == other.Code;
        }

        public override int GetHashCode()
        {
            return Code != null ? Code.GetHashCode() : 0;
        }

        public static bool operator ==(Currency left, Currency right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Currency left, Currency right)
        {
            return !(left == right);
        }
    }

    public class ChangeReferenceToValue_After
    {
        public bool CompareCurrencies()
        {
            var c1 = new Currency("VND");
            var c2 = new Currency("VND");

            // So sánh giá trị trả về true vì cùng mã "VND"
            return c1.Equals(c2);
        }
    }
}