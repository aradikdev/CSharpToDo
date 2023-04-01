using Microsoft.EntityFrameworkCore;

namespace TODO.Web.Data;

public class TODOContext : DbContext
{
    public TODOContext(DbContextOptions options) : base(options)
    {
    }

}
