namespace RRSkillDay.Data
{
	//public class WarmUpService
	//{
	//	public List<WarmUp> WarmUps = new();
	//	public WarmUpService() 
	//	{ 
	//		WarmUps.Add(new WarmUp()
	//		{
	//			Title = "hell",
	//			Repetitions = "1",
	//			Link = "safsd",
	//			Description = "Description",
	//		});

	//		WarmUps.Add(new WarmUp()
	//		{
	//			Title = "hell",
	//			Repetitions = "1",
	//			Link = "safsd",
	//			Description = "Description",
	//		});

	//		WarmUps.Add(new WarmUp()
	//		{
	//			Title = "hell",
	//			Repetitions = "1",
	//			Link = "safsd",
	//			Description = "Description",
	//		});

	//	}
	//}

	public class WarmUpService
	{
		public List<WarmUp> GetWarmUps = new()
		{
			new WarmUp
			{
				Title = "cat",
				Repetitions = "1",
				Link = "safsd",
				Description = "Description",
			},
			new WarmUp
			{
				Title = "hell",
				Repetitions = "1",
				Link = "safsd",
				Description = "Description",
			},
			new WarmUp
			{
				Title = "dog",
				Repetitions = "1",
				Link = "safsd",
				Description = "Description",
			},

		};
	}
}
