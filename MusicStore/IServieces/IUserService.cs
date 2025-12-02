using MusicStore.Dto;

namespace MusicStore.IServieces
{
    public interface IUserService
    {
        int CreateUser(CreateUserDto user);
        List<UserDto> GetUsers();
    }
}