using CustomerService.Application;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerService.Presentation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Aggregator _aggregator;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _aggregator = new Aggregator();
        }

        public void OnGet()
        {
            //aggregator.LookupOrderService.Invoke(45432543253245324543252);

            //returning result back to the web browser?
        }
    }
}