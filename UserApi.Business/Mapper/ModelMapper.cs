using UserApi.Common.Dto;
using UserApi.Repository.Models;

namespace UserApi.Business.Mapper
{
    public class ModelMapper
    {
        public static User GetUser(UserDto userDto)
        {
            var user = new User
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Address = GetAddress(userDto.Address),
                Employments = userDto.Employments.Select(e => GetEmployment(e)).ToList()
            };

            return user;
        }
        private static Address GetAddress(AddressDto addressDto)
        {
            var address = new Address
            {
                Id = addressDto.Id,
                Street = addressDto.Street,
                City = addressDto.City,
                PostCode = addressDto.PostCode
            };

            return address;
        }
        private static Employment GetEmployment(EmploymentDto employmentDto)
        {
            var employment = new Employment
            {
                Id = employmentDto.Id,
                Company = employmentDto.Company,
                Salary = employmentDto.Salary,
                MonthsOfExperience = employmentDto.MonthsOfExperience,
                StartDate = employmentDto.StartDate,
                EndDate = employmentDto.EndDate
            };

            return employment;
        }
    }
}
