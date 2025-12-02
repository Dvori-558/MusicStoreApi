using MusicStore.Dto;

namespace MusicStore.IRepositories
{
    public interface IUserRepository
    {
        int CreateUser(CreateUserDto user);
        List<UserDto> GetUsers();
    }
}