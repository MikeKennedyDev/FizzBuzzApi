namespace FizzBuzzAPi.Models
{
    public class FizzBuzz
    {
        #region Fields

        private readonly ILogger _logger;

        #endregion Fields

        #region Properties

        public string Buzz { get; set; } = "Buzz";
        public string Fizz { get; set; } = "Fizz";
        public string[] FizzBuzzList { get => GetList(); }
        public Guid Id { get; set; } = new Guid();

        #endregion Properties

        #region Constructors

        public FizzBuzz()
        { }

        public FizzBuzz(string fizz, string buzz)
        {
            Fizz = fizz;
            Buzz = buzz;
        }

        #endregion Constructors

        #region Methods

        private string fb_entity(int value)
        {
            if (value % 15 == 0)
            {
                return Fizz + Buzz;
            }
            if (value % 3 == 0)
            {
                return Fizz;
            }
            if (value % 5 == 0)
            {
                return Buzz;
            }
            return value.ToString();
        }

        private string[] GetList()
        {
            return Enumerable.Range(1, 100).Select(o => fb_entity(o))
                .ToArray();
        }

        #endregion Methods
    }
}