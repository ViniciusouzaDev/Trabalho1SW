using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Trabalho1SW.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trabalho1SW.Context
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                if (!context.Fornecedores.Any())
                {
                    context.Fornecedores.AddRange(new List<Fornecedor>()
                            {
                                new Fornecedor()
                                {
                                    RazaoSocial = "ABC Soluções Ltda",
                                    NomeFantasia = " ABC Soluções",
                                    Email = "contato@abcsolucoes.com.br",
                                    cnpj ="12.345.678/0001-90",
                                    Telefone = "(11) 98765-4321",
                                    cep = "01234-567",
                                    PessoaContato ="João da Silva",
                                    rua = "Avenida Paulista\r\n",
                                    Numero = 295,
                                    bairro ="Bela Vista",
                                    cidade ="São Paulo",
                                    estado ="SP",
                                    Pais ="Brasil",

                                },

                                 new Fornecedor()
                                {
                                  RazaoSocial = "GlobalTech Comércio Eireli",
                                    NomeFantasia = "GlobalTech",
                                    Email = "vendas@globaltech.com",
                                    cnpj ="98.765.432/0001-21",
                                    Telefone = "(21) 99876-5432",
                                    cep = "21012-345",
                                    PessoaContato ="Maria Oliveira",
                                    rua = "Rua das Laranjeiras",
                                    Numero = 104,
                                    bairro ="Laranjeiras",
                                    cidade ="Rio de Janeiro",
                                    estado ="RJ",
                                    Pais ="Brasil",
                                },

                                   new Fornecedor()
                                {
                                   RazaoSocial = "Inovação Digital SA",
                                    NomeFantasia = "InovaDigital",
                                    Email = "suporte@inovadigital.com.br",
                                    cnpj ="36.454.987/0001-11",
                                    Telefone = "(31) 91234-5678",
                                    cep = "30123-456",
                                    PessoaContato ="Carlos Pereira",
                                    rua = "Avenida Afonso Pena",
                                    Numero = 800,
                                    bairro ="Centro",
                                    cidade ="Belo Horizonte",
                                    estado ="MG",
                                    Pais ="Brasil",
                                },
                            });
                    context.SaveChanges();
                }
            }
        }
    }
}