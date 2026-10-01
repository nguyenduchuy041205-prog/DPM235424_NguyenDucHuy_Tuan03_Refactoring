using System;

namespace DPM235424_NguyenDucHuy_Refact_27_EncapsulateField.After
{
    public class EncapsulateField_After
    {
        private string _name = string.Empty;

        // Đóng gói trường dữ liệu bằng Property có kiểm tra điều kiện
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên không được để trống!");
                }
                _name = value.Trim();
            }
        }
    }
}