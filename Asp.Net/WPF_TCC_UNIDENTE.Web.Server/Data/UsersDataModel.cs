using System.ComponentModel.DataAnnotations;

namespace WPF_TCC_UNIDENTE.Web.Server.Data
{
    /// <summary>
    /// Representação do modelo de tabela de usuários (Users)
    /// </summary>
    public class UsersDataModel
    {
        #region Public Properties

        /// <summary>
        /// O id único do usuário
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// O paciente ao qual esse usuário está referenciando
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// O nome do usuário
        /// </summary>
        [MaxLength(256)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// O e-mail do usuário
        /// </summary>
        /// <remarks>Essa coluna está como index</remarks>
        [MaxLength(256)]
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// A senha do usuário
        /// </summary>
        /// <remarks>Essa coluna está como index</remarks>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// O ip do usuário
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Ip { get; set; }

        /// <summary>
        /// A data do último login do usuário
        /// </summary>
        public string LastLogin { get; set; }

        /// <summary>
        /// O nível de acesso do usuário
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string Nda { get; set; }

        #endregion
    }
}
