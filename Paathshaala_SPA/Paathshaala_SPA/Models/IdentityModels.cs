using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Paathshaala_SPA.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Hometown { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class Student : IdentityUser
    {
        public string StudentID { get; set; }
        public string Hometown { get; set; }
        public string Name { get; set; }
        public string SchoolID { get; set; }
        public string AadhaarID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string ClassOfStudy { get; set; }
        public string RollNumber { get; set; }
        public DateTime YearOfAdmit { get; set; }
        public string ContactNumber { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Student> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class Teacher : IdentityUser
    {
        public string TeacherID { get; set; }
        public string Name { get; set; }
        public string AadhaarID { get; set; }
        public string SchoolID { get; set; }
        public string[] Subject { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime YearOfJoining { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Teacher> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class Principal : IdentityUser
    {
        public string Name { get; set; }
        public string SchoolID { get; set; }
        public string AadhaarID { get; set; }
        public string Address { get; set; }
        public DateTime YearOfJoining { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Principal> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}