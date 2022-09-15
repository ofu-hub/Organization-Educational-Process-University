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
					LectureTime = 0,
					WeekDay = 0,
					WeekType = 0,
					Audience = new()
					{
						Id = 0,
						Number = "A101",
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
					Group = new()
					{
						Id = 0,
						Title = "ОГ-11"
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
						Surname = "Маркелов",
						Patronymic = "Николаевич"
					}
				},
				new()
				{
					Id = 1,
					LectureTime = Models.Utils.LectureTime.Second,
					WeekDay = 0,
					WeekType = 0,
					Audience = new()
					{
						Id = 0,
						Number = "A101",
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
					Group = new()
					{
						Id = 0,
						Title = "ДБ-11"
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
						Surname = "Маркелов",
						Patronymic = "Николаевич"
					}
				}
			};
        }
	}
}
