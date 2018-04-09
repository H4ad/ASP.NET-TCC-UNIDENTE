using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPF_TCC_UNIDENTE.Web.Server.Data
{
    /// <summary>
    /// Representação do banco de dados para essa aplicação
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        #region Public Properties

        /// <summary>
        /// A tabela usuário para a aplicação
        /// </summary>
        public DbSet<UsersDataModel> Users { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="options">Opções de contexto do banco de dados</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API
            modelBuilder.Entity<UsersDataModel>().HasIndex(a => a.Email);
            modelBuilder.Entity<UsersDataModel>().HasIndex(a => a.Password);
        }
    }
}
