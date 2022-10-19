using UserApi.Common.Dto;

namespace UserApi.Business
{
    public interface IUserManager
    {
        public Task<UserDto> GetUserAsync(int id);

        public Task PutUserAsync(UserDto user);

        public Task<UserDto> PostUserAsync(UserDto user);
    }
}
