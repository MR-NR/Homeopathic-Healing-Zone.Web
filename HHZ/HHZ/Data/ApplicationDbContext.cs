using HHZ.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        //public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<DoctorType> DoctorTypes { get; set; }
        //public DbSet<DoctorQualification> PhysicianQualifications { get; set; }
        //public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        //public DbSet<Specialization> Specializations { get; set; }

        //public DbSet<ClinicInfo> ClinicInfos { get; set; }
        //public DbSet<ClinicTime> ClinicTimes { get; set; }
        //public DbSet<Sign> signs { get; set; }
        //public DbSet<SignsValue> SignsValues { get; set; }
        //public DbSet<Test> Tests { get; set; }
        //public DbSet<Parameter> Parameters { get; set; }
        //public DbSet<ParameterValues> ParameterValues { get; set; }
        //public DbSet<Symptom> symptoms { get; set; }
        //public DbSet<SymptomMedicine> symptomMedicines { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)   //Fluent Api
        {

            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));

            base.OnModelCreating(modelBuilder);
        }
    }

}