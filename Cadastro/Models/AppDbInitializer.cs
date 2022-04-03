using Cadastro.Data;

namespace Cadastro.Models
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var contx = serviceScope.ServiceProvider.GetService<AppCont>();
                contx.Database.EnsureCreated();

                if (!contx.Clientes.Any())
                {
                    contx.Clientes.AddRange(new List<Cliente>()
                    {

                        new Cliente()
                        {
                            Nome = " Critofer Estoteles ",
                            Emai = " crit_estoteles@emal",
                            Telefone = "11422255566"

                        },
                         new Cliente()
                        {
                            Nome = " Marcelo Tas ",
                            Emai = " macelotas@maia",
                            Telefone = "21232135464"

                        },


                    });
                    contx.SaveChanges();
                }

                if (!contx.Enderecos.Any())
                {
                    contx.Enderecos.AddRange(new List<Endereco>()
                        {

                          new Endereco()
                          {
                              Rua = " Caramelo vermelho",
                              Bairro = "Balão Aluzul",
                              Cidade = " Porto Alegre",
                              Numero = "1234"
                          },

                            new Endereco()
                          {
                              Rua = " Reis do anjos",
                              Bairro = "Alto Boa vista",
                              Cidade = " Sergipe",
                              Numero = "5464"
                          }


                        });
                    contx.SaveChanges();
                }
            }
        }

    }

}
