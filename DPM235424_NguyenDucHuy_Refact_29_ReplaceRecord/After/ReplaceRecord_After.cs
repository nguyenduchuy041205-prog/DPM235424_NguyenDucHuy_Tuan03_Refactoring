using System;

namespace DPM235424_NguyenDucHuy_Refact_29_ReplaceRecord.After
{
    // Chuyển bản ghi thô thành Data Class chính quy
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }

        public Person(string name, int age, string title)
        {
            Name = name;
            Age = age;
            Title = title;
        }

        public string GetInfo()
        {
            return string.Format("Nhân sự: {0} | Tuổi: {1} | Vị trí: {2}", Name, Age, Title);
        }
    }

    public class ReplaceRecord_After
    {
        public Person CreatePerson()
        {
            return new Person("Nguyen Duc Huy", 21, "Software Engineer");
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine(person.GetInfo());
        }
    }
}