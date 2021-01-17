namespace API.Entities
{
    public class AppUser
    {
        // prop autofills a class property snippet
        public int Id { get; set; } // named as such because of conventions with entity framework
        public string Username { get; set; } //aspcore identity needs Username to be named as such
    }
}