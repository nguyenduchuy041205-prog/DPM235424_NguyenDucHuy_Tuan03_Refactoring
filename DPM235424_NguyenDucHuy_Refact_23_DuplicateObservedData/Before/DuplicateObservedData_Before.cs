using System;

namespace DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.Before
{
    // Giả lập một Form/Giao diện cửa sổ chứa trực tiếp nghiệp vụ
    public class DuplicateObservedData_Before
    {
        // Dữ liệu nghiệp vụ bị trói chặt vào UI Component
        public string TxtStart { get; set; } = "100";
        public string TxtEnd { get; set; } = "150";
        public string TxtLength { get; set; } = "50";

        // Xử lý sự kiện UI trộn lẫn với tính toán nghiệp vụ
        public void OnEndLostFocus()
        {
            try
            {
                int start = int.Parse(TxtStart);
                int end = int.Parse(TxtEnd);
                int length = end - start;
                TxtLength = length.ToString();
                Console.WriteLine(string.Format("[UI Before] Chiều dài tính được trên Form: {0}", TxtLength));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi định dạng: " + ex.Message);
            }
        }
    }
}