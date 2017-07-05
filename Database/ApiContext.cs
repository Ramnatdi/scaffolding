using Microsoft.EntityFrameworkCore;
using System;
using Models;


namespace Database
{
    public class ApiContext : DbContext, IApiContext
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options">DbContext options to apply</param>
        public ApiContext(DbContextOptions options)
            : base(options)
        {
        }

        #endregion

        #region Proprties
        public DbSet<Audit> Audits { get; set; }
        #endregion

        #region Private Methods
        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetupAuditsTable(modelBuilder);
        }

        /// <summary>
        /// Set up the audits table
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        private static void SetupAuditsTable(ModelBuilder modelBuilder)
        {
         
        }
        #endregion
    }
}
