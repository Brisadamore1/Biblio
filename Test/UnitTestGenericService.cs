using Microsoft.Extensions.DependencyModel;
using Service.Models;
using Service.Services;

namespace Test
{ 
    public class UnitTestGenericService
    {
        [Fact]
        public async Task Test_GetAllAsync_ReturnsListOfEntities()
        {
            //ARRAGE es el contexto del test. Lo que necesito para correr el test.
            var service = new GenericService<Libro>();

            //ACT. Accion que voy a testear.
            var result = await service.GetAllAsync();

            //ASSERT. Verificacion de que la accion se comporta como espero. Comprobaciones.
            Assert.NotNull(result);
            Assert.IsType<List<Libro>>(result);
            Assert.True(result.Count > 0);
        }
    }
}

