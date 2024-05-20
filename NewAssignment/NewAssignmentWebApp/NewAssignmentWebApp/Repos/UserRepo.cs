using Microsoft.EntityFrameworkCore;
using NewAssignmentWebApp.Data;
using System.Linq.Expressions;

namespace NewAssignmentWebApp.Repos
{
    public class UserRepo : BaseRepo<ApplicationUser, ApplicationDbContext>
    {
        private readonly ApplicationDbContext _context;
        public UserRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //I nedanstående overrides  gör jag en Include för att göra en JOIN sats på User entiteterna man får tillbaka, så att man även får tillbaka dess addressinformation.

        public override async Task<IEnumerable<ApplicationUser>> GetAllAsync()
        {
            try
            {
                var entityList = await _context.Users.Include(x => x.Address).ToListAsync();
                return entityList;

            }
            catch { }

            return null!;
        }

        public override async Task<ApplicationUser> GetOneAsync(Expression<Func<ApplicationUser, bool>> expression)
        {
            try
            {
                var entity = await _context.Users.Include(x => x.Address).FirstOrDefaultAsync(expression);
                if (entity != null)
                {
                    return entity;
                }
            }
            catch { }

            return null!;
        }
    }
}
