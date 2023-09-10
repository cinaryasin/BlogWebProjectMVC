using BlogWebCV.DataAccess.Entities;
using BlogWebCV.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogWebCV.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAboutRepository _companyRepo;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IAboutRepository companyRepo)
        {
            _logger = logger;
            _companyRepo = companyRepo;
        }
        public List<About> Data { get; set; }
        public void OnGet()
        {
           Data =  _companyRepo.GetAbouts().Result;
        }
    }
}