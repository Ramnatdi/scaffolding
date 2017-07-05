using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Seeding
{
    class SeedingSetup
    {
        public static void DoSeed(IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<ApiContext>();

            PopulateRoles(context);
        }

        public static void DoSeed(IApiContext context)
        {
            PopulateRoles(context);
        }

        private static void PopulateRoles(IApiContext context)
        {
            //if (!context.Roles.Any(a => a.Name == "Member"))
            //{
            //    var memberRole = new Role
            //    {
            //        Name = "Member",
            //        Description = "Member roles have minimum permissions and can not create Projects or Organizations"
            //    };

            //    context.Roles.Add(memberRole);
            //    context.SaveChanges();
            //}

            //if (!context.Roles.Any(a => a.Name == "Owner"))
            //{
            //    var ownerRole = new Role
            //    {
            //        Name = "Owner",
            //        Description = "Owner roles have the most permissions and can create and edit Projects or Organizations"
            //    };

            //    context.Roles.Add(ownerRole);
            //    context.SaveChanges();
        }
    }
}

