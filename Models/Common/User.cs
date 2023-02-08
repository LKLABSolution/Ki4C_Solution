namespace Ki4C_Solution.Models.Common
{
    public class User
    {
        //used JWT to generate token
        public string Token { get; set; } = string.Empty;

        //used to authenticate user
        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;

        //used to authorize user
        public string Role { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Id { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Company { get; set; } = string.Empty;

        public string Website { get; set; } = string.Empty;

        public string ProfilePicture { get; set; } = string.Empty;

        public string ProfilePictureThumbnail { get; set; } = string.Empty;

        public string ProfilePictureThumbnail2 { get; set; } = string.Empty;






    }

}
