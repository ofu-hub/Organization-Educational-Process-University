using Web.Models;

namespace Web.Repositories
{
    public class MockCoupleRepository : ICoupleRepository
    {
		private readonly List<Couple> _couple;

		public MockCoupleRepository()
		{
			_couple = GenerateData();
		}

		public IQueryable<Couple> GetCouples()
		{
			return _couple.AsQueryable();
		}

		public Couple? GetCouple(int id)
		{
			var couple = _couple.SingleOrDefault(couple => couple.Id == id);
			return couple;
		}
		
		public Task AddCouple(Couple couple)
		{
			_couple.Add(couple);
			return Task.CompletedTask;
		}

		public Task UpdateCouple(Couple updatedCouple)
		{
			throw new NotImplementedException();
		}

		private static List<Couple> GenerateData()
        {
			return new List<Couple>
			{
				new()
				{
					Id = 0,
					WeekDay = new()
					{
						Id = 0,
						Name = "Понедельник",
						Week = new()
						{
							Id = 0,
							Name = "Нечётная"
						}
					},
					Audience = new()
					{
						Id = 0,
						Number = "А101",
						Campus = new()
						{
							Id = 0,
							Number = "1"
						}
					},
					Discipline = new()
					{
						Id = 0,
						Title = "Математика"
					},
					Groups = new List<Group>()
					{
						new()
                        {
							Id = 0,
							Title = "ИБ-11"
                        },
                        new()
                        {
                            Id = 0,
                            Title = "ОГ-11"
                        },
                        new()
                        {
                            Id = 0,
                            Title = "КХ-11"
                        },
                    },
					LessonType = new()
					{
						Id = 0,
						Title = "Лекция"
					},
					Teacher = new()
					{
						Id = 0,
						Name = "Павел",
						Surname = "Булатов",
						Patronymic = "Николаевич"
					},
					LectureTime = Models.Utils.LectureTime.First
				},
                new()
                {
                    Id = 1,
                    WeekDay = new()
                    {
                        Id = 0,
                        Name = "Понедельник",
                        Week = new()
                        {
                            Id = 0,
                            Name = "Нечётная"
                        }
                    },
                    Audience = new()
                    {
                        Id = 0,
                        Number = "А204",
                        Campus = new()
                        {
                            Id = 0,
                            Number = "1"
                        }
                    },
                    Discipline = new()
                    {
                        Id = 0,
                        Title = "Математика"
                    },
                    Groups = new List<Group>()
                    {
                        new()
                        {
                            Id = 0,
                            Title = "ИБ-11"
                        },
                    },
                    LessonType = new()
                    {
                        Id = 1,
                        Title = "Практика"
                    },
                    Teacher = new()
                    {
                        Id = 0,
                        Name = "Павел",
                        Surname = "Булатов",
                        Patronymic = "Николаевич"
                    },
                    LectureTime = Models.Utils.LectureTime.Second
                },
                new()
                {
                    Id = 2,
                    WeekDay = new()
                    {
                        Id = 0,
                        Name = "Понедельник",
                        Week = new()
                        {
                            Id = 0,
                            Name = "Чётная"
                        }
                    },
                    Audience = new()
                    {
                        Id = 0,
                        Number = "А301",
                        Campus = new()
                        {
                            Id = 0,
                            Number = "5"
                        }
                    },
                    Discipline = new()
                    {
                        Id = 0,
                        Title = "Разработка веб-приложений"
                    },
                    Groups = new List<Group>()
                    {
                        new()
                        {
                            Id = 0,
                            Title = "ИБ-11"
                        },
                        new()
                        {
                            Id = 0,
                            Title = "ИБ-12"
                        },

                    },
                    LessonType = new()
                    {
                        Id = 1,
                        Title = "Лабораторная"
                    },
                    Teacher = new()
                    {
                        Id = 0,
                        Name = "Селимов",
                        Surname = "Загидин",
                        Patronymic = "Мурадович"
                    },
                    LectureTime = Models.Utils.LectureTime.Fourth
                }
            };
        }
	}
}
