using AutoMapper;
using OnlineAssessmentProject.DomainModel;
using OnlineAssessmentProject.Repository;
using OnlineAssessmentProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineAssessmentProject.ServiceLayer
{
    public interface IUserService
    {
        UserViewModel ValidateUser(UserViewModel user);
        void Create(User user);
        void Delete(int UserId);
        User Edit(int UserId);

        void Update(User user);
        List<User> Display();
    }
    public class UserService : IUserService
    {
        readonly IUserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public UserViewModel ValidateUser(UserViewModel user)
        {
            User fetchedData= userRepository.ValidateUser(user).FirstOrDefault();
            UserViewModel sensitiveData = null;
            if (fetchedData != null)
            {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<User, UserViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            sensitiveData = mapper.Map<User, UserViewModel>(fetchedData);
            }
            return sensitiveData;
            

        }
        public void Create(User user)
        {
            user.CreatedDate = DateTime.Now.ToShortDateString();
            userRepository.Create(user);
        }
        public void Delete(int UserId)
        {
            userRepository.Delete(UserId);
        }
        public User Edit(int UserId)
        {
            return userRepository.Edit(UserId);
        }
        public void Update(User user)
        {
            string temp;
            user.ModifiedDate = DateTime.Now.ToShortDateString();
            temp = user.CreatedDate;
            user.CreatedDate = temp;
            userRepository.Update(user);
        }

        public List<User> Display()
        {
            return (userRepository.Display());
        }
    }
}
