using ProjetoCadastroUsuarioDDD.Domain.Entities;
using ProjetoCadastroUsuarioDDD.Domain.Interfaces.Repositores;

namespace ProjetoCadastroUsuarioDDD.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
      /*  public bool login(string user, string senha)
        {
            if(user == "a"  && senha == "a")
            {
                return true;

            }
            else
            {
                return false;
            }

        }*/
    }
}