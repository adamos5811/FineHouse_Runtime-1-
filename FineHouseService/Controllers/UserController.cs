using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.AspNet.Identity;
    using FineHouseService.DataObjects;

using FineHouseService.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Http.Tracing;
using Microsoft.Azure.Mobile.Server.Config;
using System.Net.Http;
using FineHouseService.Models;   

using System.Web;



namespace FineHouseService.Controllers
{
    [MobileAppController]

   
    public class AccountsController : ApiController
    {



        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;

        public AccountsController()
        {
        }

        public AccountsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }



        [Route("CreateUser")]
        public async Task<IHttpActionResult> CreateUser(CreateUserBindingModel createUserModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

             var user = new User()
            {
                UserName = createUserModel.Username,
                Email = createUserModel.Email,
                FirstName = createUserModel.FirstName,
                LastName = createUserModel.LastName,
                Level = 3,
                JoinDate = DateTime.Now.Date,
            };

            IdentityResult addUserResult = await this.UserManager.CreateAsync(user, createUserModel.Password);

           

            Uri locationHeader = new Uri(Url.Link("GetUserById", new { id = user.Id }));

            return Ok(User);
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [Route("users")]
        public  IHttpActionResult GetUsers()
        {
            
            string c = "14d0b09f - 65d5 - 4ed4 - 89d8 - 82e3e3c90b64";
            c = "CC";

            ApplicationUserManager UserManagers = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();


            int k = 5;
             var user = UserManagers.Users.First<User>();
            k++;
            return Ok(user);
          }

    } }