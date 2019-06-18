using System.Linq;
using Tadb.BL;
using Tadb.DAL;
using Xunit;

namespace Tadb.UnitTests
{
    public class SurfaceCodeTests
    {
        [Theory]
        [InlineData(0, "101", "demo")]
        public void Test_CreateSurfaceCode(int code, string model, string name)
        {
            SurfaceCatalog surface = new SurfaceCatalog()
            {
                surface_code = code,
                model = model,
                name = name
            };

            using (MachineDbContext context = new MachineDbContext())
            {
                foreach (var surf in context.CodesSurfaces)
                {
                    context.CodesSurfaces.Remove(surf);
                }

                context.CodesSurfaces.Add(surface);
                context.SaveChanges();
            }

            using (MachineDbContext context = new MachineDbContext())
            {
                var surfaceRecord = context.CodesSurfaces.FirstOrDefault(x=>x.name.Equals(name));
                Assert.NotNull(surfaceRecord);
                Assert.Equal(model, surfaceRecord.model);
                Assert.NotEqual(0, surfaceRecord.surface_code);
            }
        }
    }
}