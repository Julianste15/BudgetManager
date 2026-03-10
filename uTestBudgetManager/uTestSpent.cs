using Microsoft.VisualStudio.TestTools.UnitTesting;
using packDomain;

namespace uTestBudgetManager
{
	[TestClass]
	public class uTestSpent
	{
		#region Test Attributes
		clsSpent testActualObj;
		clsSpent testExpectedObj;

        string testOUID;
		string testName;
		string testDescription;
		int testYear;
		int testMonth;
		int testDay;
		float testAmount;
		int testCategory;
		bool testFixed;
		#endregion

		/// <summary>
		/// Prueba la creación de objetos de la clase clsSpent.
		/// Verifica la correcta asignación de valores incluyendo si el gasto es fijo o variable.
		/// </summary>
		[TestMethod]
		public void TestBuilder()
		{
			#region Setup
			#region Pre-Conditions
			testActualObj = null;
			testOUID = null;
			testName = "none";
			testDescription = "none";
			testYear = default;
			testMonth = default;
			testDay = default;
			testAmount = default;
			testCategory = default;
			testFixed = false;
			#endregion
			#region Post-Conditions
			testOUID = "ABC";
			testName = "R1";
			testDescription = "Ingreso";
			testYear = 2024;
			testMonth = 11;
			testDay = 7;
			testAmount = 1000;
			testCategory = 1;
			testFixed = false;
			#endregion
			#endregion
			#region Test & Assert
			testActualObj = new clsSpent("ABC", "R1", "Ingreso", 2024,11,7, 1000, 1,false);
			Assert.IsNotNull(testActualObj);
			Assert.AreEqual(testOUID, testActualObj.opGetOUID());
			Assert.AreEqual(testName, testActualObj.opGetName());
			Assert.AreEqual(testDescription, testActualObj.opGetDescription());
			Assert.AreEqual(testYear, testActualObj.opGetYear());
            Assert.AreEqual(testMonth, testActualObj.opGetMonth());
            Assert.AreEqual(testDay, testActualObj.opGetDay());
            Assert.AreEqual(testAmount, testActualObj.opGetAmount());
			Assert.AreEqual(testCategory, testActualObj.opGetCategory());
            Assert.AreEqual(testFixed, testActualObj.opIsFixed());
            #endregion
        }
        /// <summary>
        /// Valida la edición de un gasto ya registrado.
        /// Asegura que los cambios en monto, descripción y fecha se procesen con éxito.
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
            testAmount = 100;
            testCategory = 1;
			testFixed = false;
            testActualObj = new clsSpent(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory,testFixed);
            #endregion
            #region PostConditions
            testName = "Gift";
            testDescription = "Christmas";
            testYear = 2024;
            testMonth = 12;
            testDay = 25;
            testAmount = 200;
            testCategory = 2;
            testExpectedObj = new clsSpent(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory,testFixed);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testActualObj.opModify("Gift", "Christmas", 2024, 12, 25, 200, 2));
            Assert.AreEqual(0, testActualObj.CompareTo(testExpectedObj));
            #endregion
        }
        /// <summary>
        /// Comprueba el proceso de eliminación (Killer) de un objeto clsSpent.
        /// Verifica que el objeto cumpla con las condiciones de borrado lógico.
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
            testFixed = false;
            testActualObj = new clsSpent(testOUID, testName, testDescription, testYear, testMonth, testDay, testAmount, testCategory, testFixed);
            #endregion
            #region Post-Conditions
            testActualObj.opSetConfirmDeletion(true);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testActualObj.opDie());
            #endregion
        }
    }
}
