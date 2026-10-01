namespace DPM235424_NguyenDucHuy_Refact_07_RemoveAssignmentsToParameters.Before
{
    public class RemoveAssignmentsToParameters_Before
    {
        public int Discount(int inputVal, int quantity)
        {
            // Gán trực tiếp giá trị tính toán lại vào tham số inputVal
            if (quantity > 50)
            {
                inputVal -= 2;
            }
            if (inputVal > 100)
            {
                inputVal -= 5;
            }

            return inputVal;
        }
    }
}