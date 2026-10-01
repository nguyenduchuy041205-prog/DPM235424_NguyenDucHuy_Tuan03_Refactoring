namespace DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.After
{
    public class RemoveAssignmentsToParameters_After
    {
        public int Discount(int inputVal, int quantity)
        {
            // Khởi tạo biến cục bộ riêng, không can thiệp/gán đè lên tham số inputVal
            int result = inputVal;

            if (quantity > 50)
            {
                result -= 2;
            }
            if (result > 100)
            {
                result -= 5;
            }

            return result;
        }
    }
}