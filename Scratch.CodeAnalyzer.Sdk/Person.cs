namespace Scratch.CodeAnalyzer.Sdk
{
    public class Person
    {
        private Person(
            string id,
            string name,
            string lastName,
            string title,
            string city)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Title = title;
            City = city;
        }

        public static Person Create(
            string id,
            string name,
            string lastName,
            string title,
            string city)
        {
            return new Person(
                id,
                name,
                lastName,
                title,
                city);
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
    }
}
