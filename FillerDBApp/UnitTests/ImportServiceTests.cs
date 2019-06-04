using BL;
using DAL;
using System;
using Xunit;
using System.Linq;

namespace UnitTests
{
    public class ImportServiceTests
    {
        [Fact]
        public void Test_ParseRecord()
        {
            Random random = new Random();
            string[] numbers = new string[176];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100).ToString();
            }

            ImportService service = new ImportService();
            var result = service.ParseRecordString(numbers);

            Assert.NotNull(result);
        }

        [Fact]
        public void Test_FillDatabase()
        {
            Random random = new Random();

            string[] args = new string[3];
            for (int i = 0; i < 3; i++)
            {
                string[] numbers = new string[176];
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = random.Next(1, 2).ToString();
                }
                args[i] = string.Join(",", numbers);
            }

            ImportService service = new ImportService();
            service.FillDatabase(args);

            using (MachineDbContext context = new MachineDbContext())
            {
                Assert.NotEmpty(context.Records);
            }

        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 2, 6)]
        public void Test_Calc(int x, int y, int result)
        {
            Assert.Equal(result, this.Calc(x, y));
        }

        public int Calc(int x, int y) => x + y * 2;
    }
}
