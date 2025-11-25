namespace MusicStore.Dto
{
    public class UserDto
    {
       public string Name { get; set; }
       public string Username { get; set; }

    }
    public class CreateUserDto()
    {
        public string Name { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
