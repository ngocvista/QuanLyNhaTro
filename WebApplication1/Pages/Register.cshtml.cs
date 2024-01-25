using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MotelManagement.Business.IService;
using MotelManagement.Common;
using MotelManagement.Data.Models;
using System.Text.Json;

namespace MotelManagement.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _service;
        private readonly ILogger<RegisterModel> _logger;
        public RegisterModel(IUserService userService, ILogger<RegisterModel> logger)
        {
            this._service = userService;
            this._logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRegisterAsync(User user)
        {
            Console.WriteLine(JsonSerializer.Serialize(user));
            try
            {
                await _service.Register(user);
                TempData["Message"] = "Success";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                TempData["Message"] = "Failed";
            }
            return Redirect("~/user/login");
        }



    }
}
