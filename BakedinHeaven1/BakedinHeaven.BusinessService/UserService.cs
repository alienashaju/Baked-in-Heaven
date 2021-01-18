using BakedinHeaven.DataAccess.Entities;
using BakedinHeaven.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedinHeaven.BusinessService
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        } 
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users = _userRepository.GetAllUsers();
            return users.ToList();
        }
       
    }
}
