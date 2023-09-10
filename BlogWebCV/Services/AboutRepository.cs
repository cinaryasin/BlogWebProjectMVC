using BlogWebCV.DataAccess;
using BlogWebCV.DataAccess.Entities;
using Dapper;

namespace BlogWebCV.Services
{
    public class AboutRepository : IAboutRepository
    {
        private readonly DapperContext _context;
        public AboutRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<About>> GetAbouts()
        {
            var query = "SELECT * FROM Abouts";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var abouts = await connection.QueryAsync<About>(query);
                    return abouts.ToList();
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }
        }
    }
    
}
