using System.Text;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Utils;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;

public class UserService : IUserService
{

    private IUserRepository _userRepository;
    private IConfiguration _config;
    private IMapper _mapper;


    public UserService(IUserRepository userRepository, IConfiguration config, IMapper mapper)
    {
        _userRepository = userRepository;
        _config = config;
        _mapper = mapper;
    }

    public User? CreateOne(User user)
    {
        User? foundUser = _userRepository.FindOneByEmail(user.Email);

        if (foundUser is not null)
        {
            return null;
        }
        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);

        PasswordUtils.HashPassword(user.Password, out string hashedPassword, pepper);

        user.Password = hashedPassword;
        return _userRepository.CreateOne(user);
    }

    public List<UserReadDto> FindAll()
    {
        var users = _userRepository.FindAll();
        var usersRead = users.Select(_mapper.Map<UserReadDto>);
        return usersRead.ToList();
    }

    public UserReadDto? FindOneByEmail(string email)
    {
        User? user = _userRepository.FindOneByEmail(email);
        UserReadDto? userRead = _mapper.Map<UserReadDto>(user);
        return userRead;
    }

    public User? UpdateOne(string email, User newValue)
    {
        User? user = _userRepository.FindOneByEmail(email);
        if (user is not null)
        {
            user.FirstName = newValue.FirstName;
            return _userRepository.UpdateOne(user);
        }
        return null;
    }


}
