using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Aplicacao.Services;
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
            services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
            #endregion

            #region Serviços
            services.AddTransient<IProdutoCategoriaService, ProdutoCategoriaService>();
            services.AddTransient<IProdutoService, ProdutoService>();
            #endregion
        }
    }
}
