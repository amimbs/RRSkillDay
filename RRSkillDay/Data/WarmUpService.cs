namespace RRSkillDay.Data
{
    public class WarmUpService
    {
        public List<WarmUp> GetWarmUps()
        {
            var warmUps = new List<WarmUp>
            {
                new WarmUp
                {
                    Title = "cat",
                    Repetitions = "1",
                    ImageUrl = "safsd",
                    Description = "Description",
                    VideoUrl = "utubz"
                },
                new WarmUp
                {
                    Title = "dog",
                    Repetitions = "2",
                    ImageUrl = "safsd",
                    Description = "Description",
                    VideoUrl = "utubz"
                },
                new WarmUp
                {
                    Title = "rat",
                    Repetitions = "3",
                    ImageUrl = "safsd",
                    Description = "Description",
                    VideoUrl = "utubz"
                },
            };
            return warmUps;
        }
    }
}
