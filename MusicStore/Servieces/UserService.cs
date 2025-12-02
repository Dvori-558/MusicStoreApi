using MusicStore.Dto;
using MusicStore.IRepositories;
using MusicStore.IServieces;
using MusicStore.Repositories;

namespace MusicStore.Servieses
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
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
