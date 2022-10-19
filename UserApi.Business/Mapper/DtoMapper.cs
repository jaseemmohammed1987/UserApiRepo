using UserApi.Common.Dto;
using UserApi.Repository.Models;

namespace UserApi.Business.Mapper
{
    public class DtoMapper
    {
        public static UserDto GetUserDto(User user)
        {
            if (user == null) return null;

            var userDto = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = GetAddressDto(user.Address),
                Employments = user.Employments.Select(e => GetEmploymentDto(e)).ToList()
            };

            return userDto;
        }
        private static AddressDto GetAddressDto(Address address)
        {
            if (address == null) return null;

            var addressDto = new AddressDto
            {
                Id = address.Id,
                Street = address.Street,
                City = address.City,
                PostCode = address.PostCode
            };

            return addressDto;
        }
        private static EmploymentDto GetEmploymentDto(Employment employment)
        {
            if (employment == null) return null;

            var employmentDto = new EmploymentDto
            {
                Id = employment.Id,
                Company = employment.Company,
                Salary = employment.Salary,
                MonthsOfExperience = employment.MonthsOfExperience,
                StartDate = employment.StartDate,
                EndDate = employment.EndDate
            };

            return employmentDto;
        }

    }
}
