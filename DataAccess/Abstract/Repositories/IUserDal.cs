﻿using Entities.DBClasses;
using Entities.DTOClasses;
using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Repositories
{
    public interface IUserDal : IBaseEntityRespository<User>
    {
        Task<User> GetUserByEmailAndPassword(UserLoginDto userLoginDto);    
    }
}
