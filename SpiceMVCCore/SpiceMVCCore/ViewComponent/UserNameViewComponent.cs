using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpiceMVCCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SpiceMVCCore.ViewComponenets
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext_db _db;

        public UserNameViewComponent(ApplicationDbContext_db db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var userFromDb = await _db.ApplicationUser.FirstOrDefaultAsync(u => u.Id == claims.Value);

            return View(userFromDb);
        }

    }
}
