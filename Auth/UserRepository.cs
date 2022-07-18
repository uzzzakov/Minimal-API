public class UserRepository : IUserRepository
{
    private List<UserDto> _users => new()
    {
        new UserDto("manucho", "2323"),
        new UserDto("admin", "admin")
    };
    public UserDto GetUser(UserModel userModel) =>
        _users.FirstOrDefault(u => 
            string.Equals(u.UserName, userModel.UserName) &&
            string.Equals(u.Password, userModel.Password)) ??
            throw new Exception();
}