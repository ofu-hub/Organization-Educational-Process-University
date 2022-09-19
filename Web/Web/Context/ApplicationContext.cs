using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Context
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Преподователи
        /// </summary>
        public DbSet<Teacher> Teachers { get; set; } = null!;
        /// <summary>
        /// Тип занятий
        /// </summary>
        public DbSet<LessonType> Lessons { get; set; } = null!;
        /// <summary>
        /// Группы
        /// </summary>
        public DbSet<Group> Groups { get; set; } = null!;
        /// <summary>
        /// Аудитории
        /// </summary>
        public DbSet<Audience> Audiences { get; set; } = null!;
        /// <summary>
        /// Корпуса
        /// </summary>
        public DbSet<Campus> Campuses { get; set; } = null!;
        /// <summary>
        /// Дисциплины
        /// </summary>
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        /// <summary>
        /// Коллекция отношений дисциплин и преподователей
        /// </summary>
        public DbSet<DisciplineTeacher> DisciplineTeachers { get; set; } = null!;
        /// <summary>
        /// Занятие
        /// </summary>
        public DbSet<Couple> Couples { get; set; } = null!;
        /// <summary>
        /// Неделя
        /// </summary>
        public DbSet<Week> Week { get; set; } = null!;
        /// <summary>
        /// День недели
        /// </summary>
        public DbSet<WeekDay> WeekDay { get; set; } = null!;

        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            if (Database.GetPendingMigrations().Any())
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Week>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name);

                entity.HasMany(x => x.WeekDays).WithOne(x => x.Week);
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name);

                entity.HasMany(x => x.Couples).WithOne(x => x.WeekDay);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired();
                entity.Property(x => x.Surname).IsRequired();
                entity.Property(x => x.Patronymic).IsRequired(false);

                entity.HasMany(x => x.DisciplineTeachers).WithOne(x => x.Teacher);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Title).IsRequired();
            });

            modelBuilder.Entity<LessonType>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Title).IsRequired();
            });

            modelBuilder.Entity<DisciplineTeacher>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Discipline).WithMany(x => x.DisciplineTeachers);
                entity.HasOne(x => x.Teacher).WithMany(x => x.DisciplineTeachers);
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Title).IsRequired();

                entity.HasMany(x => x.DisciplineTeachers).WithOne(x => x.Discipline);

                entity.HasMany(x => x.Couples).WithOne(x => x.Discipline);
            });

            modelBuilder.Entity<Campus>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Number).IsRequired();

                entity.HasMany(x => x.Audiences).WithOne(x => x.Campus);
            });

            modelBuilder.Entity<Audience>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Number).IsRequired();

                entity.HasOne(x => x.Campus).WithMany(x => x.Audiences);
                
                entity.HasMany(x => x.Couples).WithOne(x => x.Audience);
            });

            modelBuilder.Entity<Couple>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.LectureTime).IsRequired();

                entity.HasOne(x => x.Audience).WithMany(x => x.Couples);
                entity.HasOne(x => x.Discipline).WithMany(x => x.Couples);
                entity.HasOne(x => x.LessonType).WithMany(x => x.Couples);
                entity.HasOne(x => x.Teacher).WithMany(x => x.Couples);
                entity.HasOne(x => x.WeekDay).WithMany(x => x.Couples);

                entity.HasMany(x => x.Groups).WithOne(x => x.Couple);
            });
        }
    }
}
