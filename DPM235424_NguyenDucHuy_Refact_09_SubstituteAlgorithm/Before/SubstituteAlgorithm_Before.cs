namespace DPM235424_NguyenDucHuy_Refact_09_SubstituteAlgorithm.Before
{
    public class SubstituteAlgorithm_Before
    {
        public string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    return "John";
                }
                if (people[i].Equals("Kent"))
                {
                    return "Kent";
                }
            }
            return "";
        }
    }
}