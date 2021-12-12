using RecipesApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesApp.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Method that creates token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string CreateToken(MyUser user);
    }
}
