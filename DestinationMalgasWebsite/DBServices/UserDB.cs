using DestinationMalgasWebsite.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace DestinationMalgasWebsite.DBServices
{
    public class UserDB
    {
        private readonly DMDBContext myDBContext;

        public UserDB(DMDBContext dbContext)
        {
            myDBContext = dbContext;
        }

        /// <summary>
        /// This method takes in a name, surname, email, and password and 
        /// generates a user object and a unique salt for the password
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<User> CreateUserAsync(string name, string surname, string email, string password)
        {
            // Generate a unique salt for the password
            string salt = GenerateSalt();

            // Hash the password using the salt
            string hashedPassword = HashPassword(password, salt);

            // Create a new User object
            User user = new User
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = hashedPassword,
                Salt = salt
            };

            // Save the user object to the database
            myDBContext.Users.Add(user);
            await myDBContext.SaveChangesAsync();

            return user;
        }

        /// <summary>
        /// this method validates the user by checking if the email exists in the database and then 
        /// comparing the hashed password with the stored hashed password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUser(string email, string password)
        {
            // Retrieve the user from the database using the email
            User user = myDBContext.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                // User not found
                return false;
            }

            // Hash the input password using the stored salt
            string hashedInputPassword = HashPassword(password, user.Salt);

            // Compare the hashed input password with the stored hashed password
            return hashedInputPassword == user.Password;
        }

        /// <summary>
        /// this method generates a unique salt for the password
        /// </summary>
        /// <returns></returns>
        private string GenerateSalt()
        {
            // Generate a unique salt for the password
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// this method hashes the password using the salt
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        private string HashPassword(string password, string salt)
        {
            // Hash the password using the salt
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
//____________________________________EOF_________________________________________________________________________