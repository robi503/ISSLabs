namespace LibraryApp.Model
{
    public class Customer(string username, string name, string address, string telephone, string password)
    {
        public string Username { get; set; } = username;
        public string Name { get; set; } = name;
        public string Address { get; set; } = address;
        public string Telephone { get; set; } = telephone;
        public string Password { get; set; } = password;
    }
}
