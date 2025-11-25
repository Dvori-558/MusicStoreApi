using MusicStore.Dto;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class UserService
    {

        private readonly UserRepository _userRepository = new();
        //get
        public List<UserDto> GetUsers()
        {
            return _userRepository.GetUsers();
        }
        //post
        public int CreateUser(CreateUserDto user)
        {
            return _userRepository.CreateUser(user);
        }
        //put
        //delete
    }
}
