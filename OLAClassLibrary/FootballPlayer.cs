namespace OLAClassLibrary
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException(nameof(Name));
            else if (Name.Length < 2) throw new ArgumentOutOfRangeException(nameof(Name));
        }

        public void ValidateAge()
        {
            if (Age < 1) throw new ArgumentOutOfRangeException(nameof(Age));
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1) throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
            else if (ShirtNumber > 99) throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
        }
    }
}