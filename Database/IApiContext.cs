using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    interface IApiContext
    {
        DbSet<Audit> Audits { get; set; }

        int SaveChanges();
    }
}
