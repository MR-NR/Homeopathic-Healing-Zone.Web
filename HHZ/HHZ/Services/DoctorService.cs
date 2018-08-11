//using HHZ.Data;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Threading.Tasks;

//namespace HHZ.Services
//{
//    public class DoctorService
//    {
//        public ApplicationDbContext Db { get; } = new ApplicationDbContext();


//        public Doctor FindById(int? id)
//        {
//            return Db.Doctors
//        }


//        public Student FindByUserId(string userId)
//        {
//            var student= Db.Students.FirstOrDefault(st => st.UserId == userId);
//            return student;
//        }

//        public IEnumerable<Student> Students()
//        {
//            return Db.Students.ToList();
//        }

//        public void Create(Student student)
//        {
//            Db.Students.Add(student);
//            Db.SaveChanges();
//        }


//        public async Task CreateAsync(Student student)
//        {
//            Db.Students.Add(student);
//           await Db.SaveChangesAsync();
//        }

//        public void Update(Student student)
//        {
//            Db.Entry(student).State = EntityState.Modified;
//            Db.SaveChanges();
//        }

//        public void Update(Student student, string userId)
//        {
//            student.UserId = userId;
//            Db.Entry(student).State = EntityState.Modified;
//            Db.SaveChanges();
//        }


//        public void Delete(Student student)
//        {
//            Db.Students.Remove(student);
//            Db.SaveChanges();
//        }
//    }

   
//}