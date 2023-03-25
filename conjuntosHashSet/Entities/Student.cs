namespace conjuntosHashSet.Entities
{
    class Student
    {
        public int StudentNumber { get; set; }

        public Student(int studentNumber)
        {
            StudentNumber = studentNumber;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student objCourse = (Student)obj;

            return StudentNumber.Equals(objCourse.StudentNumber);
        }

        public override int GetHashCode()
        {
            return StudentNumber.GetHashCode();
        }
    }
}
