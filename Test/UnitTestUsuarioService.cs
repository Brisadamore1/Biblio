using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyModel;
using Service.DTOs;
using Service.Models;
using Service.Services;

namespace Test
{
    public class UnitTestUsuarioService
    {
        //Test GetAllAsync método del GenericService
        [Fact]
        public async Task Test_GetAllAsync_ReturnsListOfEntities()
        {
            //ARRAGE es el contexto del test. Lo que necesito para correr el test.
            await LoginTest();

            var service = new UsuarioService();

            //ACT. Accion que voy a testear.
            var result = await service.GetAllAsync();

            //ASSERT. Verificacion de que la accion se comporta como espero. Comprobaciones.
            Assert.NotNull(result);
            Assert.IsType<List<Usuario>>(result);
            Assert.True(result.Count > 0);
        }

        private async Task LoginTest()
        { 
            var serviceAuth = new AuthService();
            var token = await serviceAuth.Login(new LoginDTO
            {
                Username = "bridamore17@gmail.com",
                Password = "1234567"
            });
            Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>Token: {token}");
        }

        //test GetAllAsync method of GenericService
        [Fact]
        public async Task Test_GetByEmailAsync()
        {
            //ARRAGE es el contexto del test. Lo que necesito para correr el test.
            await LoginTest();
            var service = new UsuarioService();
            //ACT. Accion que voy a testear.
            var result = await service.GetByEmailAsync("bridamore17@gmail.com");
            //ASSERT. Verificacion de que la accion se comporta como espero. Comprobaciones.
            Assert.NotNull(result);
            Assert.IsType<Usuario>(result);
            Assert.Equal("bridamore17@gmail.com", result.Email);
        }
    }
}

