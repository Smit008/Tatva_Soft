
using Data_Access_Layer;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_Layer
{
    public class BALAdminUser
    {
        private readonly DALAdminUser _dalAdminUser;

        public BALAdminUser(DALAdminUser dalAdminUser)
        {
            _dalAdminUser = dalAdminUser;
        }

        public async Task<List<UserDetail>> UserDetailsAsync()
        {
            return await _dalAdminUser.UserDetailsListAsync();
        }

        public async Task<string> DeleteUserAndUserDetailAsync(int userId)
        {
            return await _dalAdminUser.DeleteUserAndUserDetailAsync(userId);
        }

        //public async Task<bool> UpdateUserAsync(User user)
        //{
        //    // Add your update logic here. This is just an example.
        //    var existingUser = await _dalAdminUser.GetUserByIdAsync(user.Id);
        //    if (existingUser == null)
        //    {
        //        throw new KeyNotFoundException("User not found.");
        //    }

        //    existingUser.FirstName = user.FirstName;
        //    existingUser.LastName = user.LastName;
        //    existingUser.PhoneNumber = user.PhoneNumber;
        //    existingUser.EmailAddress = user.EmailAddress;
        //    existingUser.Password = user.Password;

        //    return await _dalAdminUser.UpdateUserAsync(existingUser);
        //}
    }
}
