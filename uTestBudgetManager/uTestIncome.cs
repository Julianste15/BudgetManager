using Microsoft.VisualStudio.TestTools.UnitTesting;
using packDomain;

namespace uTestBudgetManager
{
    [TestClass]
    public class uTestIncome
    {
        clsIncome testActualObj;
        clsIncome testExpectedObj;
        string testOUID;
        string testName;
        string testDescription;
        int testYear;
        int testMonth;
        int testDay;
        float testAmount;
        int testCategory;
        bool testConfirmDeletion;

        /// <summary>
        /// Valida el constructor (Builder) de la clase clsIncome.
        /// Verifica que los atributos se inicialicen correctamente según los parámetros proporcionados.
        /// </summary>
        [TestMethod]
        public void TestBuilder()
        {
            #region Setup
            #region Pre-Conditions
            testActualObj = null;
            testOUID = "0";
            testName = "none";
            testDescription = "none";
            testYear = default;
            testMonth = default;
            testDay = default;
            testAmount = default;
            testCategory = default;
            #endregion
            #region Post-Conditions
            testOUID = "ABC";
            testName = "Gift";
            testDescription = "birthday";
            testYear = 2024;
            testMonth = 11;
            testDay = 7;
            testAmount = 1000;
            testCategory = 1;
            #endregion
            #endregion
            #region Test & Assert
            testActualObj = new clsIncome("ABC", "Gift", "birthday", 2024, 11, 7, 1000, 1);
            Assert.IsNotNull(testActualObj);
            Assert.AreEqual(testOUID, testActualObj.opGetOUID());
            Assert.AreEqual(testName, testActualObj.opGetName());
            Assert.AreEqual(testDescription, testActualObj.opGetDescription());
            Assert.AreEqual(testYear, testActualObj.opGetYear());
            Assert.AreEqual(testMonth, testActualObj.opGetMonth());
            Assert.AreEqual(testDay, testActualObj.opGetDay());
            Assert.AreEqual(testAmount, testActualObj.opGetAmount());
            Assert.AreEqual(testCategory, testActualObj.opGetCategory());
            #endregion
        }
        /// <summary>
        /// Comprueba el método modificador (opModify) de la clase clsIncome.
        /// Asegura que los cambios en los atributos se apliquen y persistan correctamente.
        /// </summary>
        [TestMethod]
        public void testModifier()
        {
            #region SetUp
            #region Pre-Conditions
            testOUID = "ABC";
            testName = "Gift";
            testDescription = "birthday";
            testYear = 2024;
            testMonth = 11;
            testDay = 7;
            testAmount = 1000;
            testCategory = 1;
            testActualObj = new clsIncome(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory);
            #endregion
            #region PostConditions
            testName = "Job";
            testDescription = "Fortnight";
            testYear = 2024;
            testMonth = 10;
            testDay = 15;
            testAmount = 500;
            testCategory = 1;
            testExpectedObj = new clsIncome(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testActualObj.opModify("Job", "Fortnight", 2024, 10, 15, 500, 1));
            Assert.AreEqual(0, testActualObj.CompareTo(testExpectedObj));
            #endregion
        }
        /// <summary>
        /// Valida el método de eliminación (opDie) de la clase clsIncome.
        /// Verifica que el objeto pueda ser "eliminado" lógicamente tras confirmar la acción.
        /// </summary>
        [TestMethod]
        public void testKiller()
        {
            #region SetUp
            #region Pre-Conditions
            testOUID = "ABC";
            testName = "Gift";
            testDescription = "birthday";
            testYear = 2024;
            testMonth = 11;
            testDay = 7;
            testAmount = 100;
            testCategory = 1;
            testConfirmDeletion = false;
            testActualObj = new clsIncome(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory);
            #endregion
            #region Post-Conditions
            testConfirmDeletion = true;
            testActualObj.opSetConfirmDeletion(true);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testActualObj.opDie());
            #endregion
        }
    }
}
