using ProjetoCadastroUsuarioDDD.Domain.Entities;
using ProjetoCadastroUsuarioDDD.Domain.Interfaces.Repositores;
using ProjetoCadastroUsuarioDDD.Domain.Interfaces.Services;


namespace ProjetoCadastroUsuarioDDD.Domain.Services
{
    public  class UsuarioService :ServiceBase<Usuario>,IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
