using UserApi.Business.Mapper;
using UserApi.Common.Dto;
using UserApi.Repository;

namespace UserApi.Business
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserDto> GetUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
           
            return DtoMapper.GetUserDto(user);
        }

        public async Task<UserDto> PostUserAsync(UserDto userDto)
        {
            var user = ModelMapper.GetUser(userDto);
            var result = await _userRepository.PostUserAsync(user);
           
            return DtoMapper.GetUserDto(result);
        }

        public async Task PutUserAsync(UserDto userDto)
        {
            var user = ModelMapper.GetUser(userDto);
            await _userRepository.PutUserAsync(user);
        }
    }
}