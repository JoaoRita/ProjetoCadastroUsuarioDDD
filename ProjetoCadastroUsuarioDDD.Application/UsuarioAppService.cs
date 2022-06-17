

using ProjetoCadastroUsuarioDDD.Application.Interface;
using ProjetoCadastroUsuarioDDD.Domain.Entities;
using ProjetoCadastroUsuarioDDD.Domain.Interfaces.Services;

namespace ProjetoCadastroUsuarioDDD.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioAppService(IUsuarioService usuarioService): base(usuarioService)
        {
            _usuarioService = usuarioService;
        }
    }
}
