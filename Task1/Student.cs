using System;

namespace Task1
{
    public class Student
    {
        public string FullName { get; set; }
        public Education EducationFrom { get; set; }
        public DateTime BirthDay { get; set; }
        public int GroupId { get; set; }

        public Student()
        {
            FullName = null;
            EducationFrom = Education.Specialist;
            BirthDay = new DateTime();
            GroupId = 0;
        }

        public Student(string fullName, Education educationFrom, DateTime birthDay, int groupId)
        {
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            EducationFrom = educationFrom;
            BirthDay = birthDay;
            GroupId = groupId;
        }

        public override string ToString()
        {
            return $"№{GroupId, -6} | {FullName, 16} | {EducationFrom, 14} | {BirthDay.ToString("d")}";
        }
    }
}
