using SK_CORE.Models;

namespace SK_CORE.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> GetAllStudent()
        {
            return GetDataSource();
        }

        public Student GetStudentById(int Id)
        {
            return GetDataSource().Where(x => x.Id_ == Id).FirstOrDefault();
        }
        private List<Student> GetDataSource()
        {
            return new List<Student>
            {
                new Student() { Id_ = 1, Name_ = "Suresh1", Age_ = 23,Class_="1" },
                new Student() { Id_ = 2, Name_ = "Suresh2", Age_ = 24,Class_="2" },
                new Student() { Id_ = 3, Name_ = "Suresh3", Age_ = 25 ,Class_="3"},
                new Student() { Id_ = 4, Name_ = "Suresh4", Age_ = 26,Class_="4" },
                new Student() { Id_ = 5, Name_ = "Suresh5", Age_ = 27,Class_="5" },
            };
        }
    }
}
