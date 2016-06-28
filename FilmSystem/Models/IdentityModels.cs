using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace FilmSystem.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Login { get; set; }
        public string RegistrationDate { get; set; }
        public char BlackList { get; set; }
        public int Count { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string NameRU { get; set; }
        public string NameEN { get; set; }
        public int FilmID { get; set; }
        public string Year { get; set; }
        public string Length { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string RatingAgeLimits { get; set; }
        public string PremiereWorld { get; set; }
        public string Budget { get; set; }
        public string RatingIMDB { get; set; }
        public string RatingKP { get; set; }
        public string Rating { get; set; }
        public int CountViews { get; set; }

    }

    public class Actor
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int ActorKPID { get; set; }
        public char Gender { get; set; }
        public string Year { get; set; }
        public int CountMovies { get; set; }
    }

    public class Director
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int DirectorKPID { get; set; }
        public char Gender { get; set; }
        public string Year { get; set; }
        public int CountMovies { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }

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