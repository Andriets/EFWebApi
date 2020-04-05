﻿using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork UOW;
        public UserService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }

        public void Delete(int id)
        {
            UOW.UserRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return UOW.UserRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return UOW.UserRepository.GetById(id);
        }

        public void Insert(User obj)
        {
            UOW.UserRepository.Insert(obj);
        }

        public void Update(User obj)
        {
            UOW.UserRepository.Update(obj);
        }
    }
}
