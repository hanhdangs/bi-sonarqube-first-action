namespace Hello.All
{
    public class Foo
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int GetId()
        {
            var username = "hello";
            var password = "123456";
            var credential = $"{username}/{password}";
            return Id;
        }

        public string GetName()
        {
            return Name ?? string.Empty;
        }
    }
}