using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLearning1.UnitTests
{
    public static class WorldsDumbestFunctionTests
    {
        //Naming Convention - Classname_MethodName_ExpectedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                //Arrange - take all you need to run testing function
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new();

                //Act - execute function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);
                
                //Assert - Whatever is returned - look, is it what you want
                if(result == "Pikachu")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
