using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MotelManagement.Business.IService;
using MotelManagement.Data.Models;

namespace MotelManagement.Pages.admin
{
    public class ListArticleRoomModel : PageModel
    {
        public readonly IArticleService _control;

        public ListArticleRoomModel(IArticleService _service)
        {
            _control = _service;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            List<ArticleRoom> data = await _control.GetListArticleRooms();
            ViewData["lstArticleRoom"] = data;
            return Page();
        }
    }
}
