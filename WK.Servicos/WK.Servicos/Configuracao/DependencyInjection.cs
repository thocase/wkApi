using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.Repositorio;

namespace WK.Servicos.Configuracao
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Repositórios
            services.AddTransient<IProdutoCategoriaRepositorio, ProdutoCategoriaRepositorio>();
            #endregion

        }
    }
}
