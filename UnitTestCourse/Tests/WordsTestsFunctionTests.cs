//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTestCourse.Tests
//{
//    public static class WordsTestsFunctionTests
//    {
//        //Naming Convention - ClassName_MethodName_ExteptedResult
//        public static void WordsTestsFunctionTests_ReturnsPicIfZero_ReturnString()
//        {
//            try
//            {
//                //Arrange - Go get your variables, classes, functions
//                int num = 0;
//                WordsTestsFunctionTests wordsTests = new WordsTestsFunction();
//                //Act- execute this function
//                var result = wordsTests.ReturnsPicIfZero(num);

//                //Assert - Whatever ever is returns is it what you want
//                if (result == "Pic")
//                {
//                    Console.WriteLine("PASSED: WordsTestsFunction.ReturnsPicifZero_ReturnString ");
//                }
//                else
//                {
//                    Console.WriteLine("FAILED:WordsTestsFunction.ReturnsPicifZero_ReturnString ");
//                }
//                Assert.AreEqual(num, result);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//            }
//        }

//    }
//}
