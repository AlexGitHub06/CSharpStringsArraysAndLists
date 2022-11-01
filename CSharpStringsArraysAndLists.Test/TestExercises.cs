using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStringsArraysAndLists;

namespace CSharpStringsArraysAndLists.Test
{
    [TestClass]
    public class TestExercises
    {
        [TestMethod]
        public void TestWriteVariableNames()
        {
           string variableName = Exercises.WriteVariableName("A very important variable", Exercises.VariableNameType.SnakeCase);
            Assert.AreEqual("a_very_important_variable", variableName);
        }
    }
}