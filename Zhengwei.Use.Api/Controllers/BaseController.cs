﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zhengwei.Use.Api.Dtos;

namespace Zhengwei.Use.Api.Controllers
{
    public class BaseController : Controller
    {
        protected UserIdentity UserIdentity
        {
            get
            {
                var identity = new UserIdentity()
                {
                    UserId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "sub").Value),
                    Name = User.Claims.FirstOrDefault(C => C.Type == "name").Value,
                    Company = User.Claims.FirstOrDefault(c => c.Type == "company").Value,
                    Title = User.Claims.FirstOrDefault(c => c.Type == "title").Value,
                    Avatar = User.Claims.FirstOrDefault(c => c.Type == "avatar").Value
                };
                return identity;


            }
        }

    }
}
