using System;
using System.Collections.Generic;

namespace DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.After
{
    public class SubstituteAlgorithm_After
    {
        public string FoundPerson(string[] people)
        {
            var candidates = new List<string> { "Don", "John", "Kent" };
            return Array.Find(people, p => candidates.Contains(p)) ?? "";
        }
    }
}