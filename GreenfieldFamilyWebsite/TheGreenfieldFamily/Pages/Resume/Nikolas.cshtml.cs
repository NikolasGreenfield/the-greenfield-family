using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using TheGreenfieldFamily.Pages.Shared;

namespace TheGreenfieldFamily.Pages.Resume
{
    public class NikolasModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly string trustedMessageOrigin;

        public string TrustedMessageOrigin
        {
            get
            {
                return trustedMessageOrigin;
            }
        }

        public NikolasModel(ILogger<IndexModel> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            trustedMessageOrigin = appSettings.Value.TrustedMessageOrigin;
        }

        public void OnGet()
        {
        }
    }
}
