using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheGreenfieldFamily.Pages.Resume
{
    public class NikolasModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public NikolasModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
