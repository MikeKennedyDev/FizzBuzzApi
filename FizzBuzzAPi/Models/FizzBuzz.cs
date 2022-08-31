namespace FizzBuzzAPi.Models
{
    public class FizzBuzz
    {
        #region Properties

        public string Buzz { get; set; } = "Buzz";
        public string Fizz { get; set; } = "Fizz";
        public Guid Id { get; set; } = new Guid();

        #endregion Properties
    }
}