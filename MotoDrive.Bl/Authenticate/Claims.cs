using MotoDrive.Dal.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using MotoDrive.Dal;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace MotoDrive.Bl.Authenticate
{
    public class Claims
    {
        //public async Task Authenticate(User user)
        //{
        //    var claims = new List<Claim>
        //    {
        //        new Claim(ClaimsIdentity.DefaultNameClaimType,user.Mail),
        //        new Claim(ClaimsIdentity.DefaultNameClaimType,user.Role?.Name)
        //    };

        //    ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        //    await Microsoft.AspNetCore.Http.HttpContext(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        //}


    }
}
