using BlogWebCV.DataAccess.Entities;

namespace BlogWebCV.Services
{
    public interface IAboutRepository
    {
        public Task<List<About>> GetAbouts();
    }
    
}
