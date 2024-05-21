using NewAssignmentWebApp.Data;

namespace NewAssignmentWebApp.Repos
{
    public class AddressRepo : BaseRepo<AddressEntity, ApplicationDbContext>
    {
        public AddressRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
