using System.Linq.Dynamic.Core;
using System.Security.Claims;
using HackatonInovaUniEGov.Data;
using Microsoft.EntityFrameworkCore;

namespace HackatonInovaUniEGov.Controller;

public class AuthController
{
    public AuthController(ApplicationContext context)
    {
        Context = context;
    }

    public ApplicationContext Context { get; set; }
    
    
    
    
    public async  Task<List<Claim>> Login(string email, string password)
    {
        try
        {
            var user = await Context.Usuarios.FirstOrDefaultAsync(x=>x.Email == email);

            if (user == null)
            {
                throw new Exception("Email ou senha incorretos!");
            }

            if (!user.Senha.Equals(password))
            {
                throw new Exception("Verifique o email ou senha");
            }


            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), // Id do usuário
                new Claim(ClaimTypes.Name, user.Nome), // Nome do usuário
                // Adicione outras reivindicações conforme necessário
            };

            return claims;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

}