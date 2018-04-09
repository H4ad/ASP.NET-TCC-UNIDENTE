using WPF_TCC_UNIDENTE.Web.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace WPF_TCC_UNIDENTE.Web.Server.Controllers
{
    public class HomeController : Controller
    {
        #region Protected Members

        /// <summary>
        /// Escopo para o Application context
        /// </summary>
        protected ApplicationDbContext mContext;

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="context">O contexto injetado</param>
        public HomeController(ApplicationDbContext context)
        {
            mContext = context;
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }


    }
}
