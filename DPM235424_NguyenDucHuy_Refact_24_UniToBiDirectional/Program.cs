using System;
using System.Collections.Generic;
using DPM235424_NguyenDucHuy_Refact_24_UniToBi.Before;
using DPM235424_NguyenDucHuy_Refact_24_UniToBi.After;
using DPM235424_NguyenDucHuy_Refact_24_UniToBi.Real;

namespace DPM235424_NguyenDucHuy_Refact_24_UniToBi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(">>> 1. DEMO CLASS: UniToBi_Before <<<");
            var before = new UniToBi_Before();
            var cusBefore = new Before.Customer("Khách hàng A");
            var orders = new List<Before.Order>
            {
                new Before.Order("ORD-01", cusBefore),
                new Before.Order("ORD-02", new Before.Customer("Khách hàng B")),
                new Before.Order("ORD-03", cusBefore)
            };
            var foundOrders = before.GetOrdersForCustomer(orders, cusBefore);
            Console.WriteLine(string.Format("Số đơn tìm thấy cho {0}: {1}", cusBefore.Name, foundOrders.Count));

            Console.WriteLine("\n>>> 2. DEMO CLASS: UniToBi_After <<<");
            var cusAfter = new After.Customer("Khách hàng A");
            var ord1 = new After.Order("ORD-101") { Customer = cusAfter };
            var ord2 = new After.Order("ORD-102") { Customer = cusAfter };
            int count = 0;
            foreach (var o in cusAfter.Orders) count++;
            Console.WriteLine(string.Format("Số đơn trong Customer.Orders của {0}: {1}", cusAfter.Name, count));

            Console.WriteLine("\n>>> 3. DEMO CLASS: UniToBi_Real (NÔNG DƯỢC AN GIANG) <<<");
            var real = new UniToBi_Real();
            real.ChayQuanLyCongNoHaiChieu();
        }
    }
}