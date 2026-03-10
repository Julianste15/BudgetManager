using Microsoft.VisualStudio.TestTools.UnitTesting;
using packDomain;

namespace uTestBudgetManager
{
	[TestClass]
	public class uTestSavingGoal
	{
		#region Test Attributes
		clsSavingGoal testActualObj;
		clsSavingGoal testExpectedObj;
		string testOUID;
		string testName;
		string testDescription;
		int testLimitYear;
		int testLimitMonth;
		int testLimitDay;
		float testGoalAmount;
		int testProgress;
		bool testConfirmDeletion;
		#endregion

		/// <summary>
		/// Valida el constructor (Builder) de la clase clsSavingGoal.
		/// Comprueba que la meta de ahorro se cree con los valores de monto y fecha límite correctos.
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
			testLimitYear = default;
			testLimitMonth = default;
			testLimitDay = default;
			testGoalAmount = default;
			testProgress = default;
			#endregion
			#region Post-Conditions
			testOUID = "ABC";
			testName = "Car";
			testDescription = "I need a new car";
			testLimitYear = 2030;
			testLimitMonth = 01;
			testLimitDay = 15;
			testGoalAmount = 40000000;
			testProgress = 0;
			#endregion
			#endregion
			#region Test & Assert
			testActualObj = new clsSavingGoal(testOUID, testName,testDescription,testLimitYear,testLimitMonth,testLimitDay,testGoalAmount);
			Assert.IsNotNull(testActualObj);
			Assert.AreEqual(testOUID, testActualObj.opGetOUID());
			Assert.AreEqual(testName, testActualObj.opGetName());
			Assert.AreEqual(testDescription, testActualObj.opGetDescription());
			Assert.AreEqual(testLimitYear, testActualObj.opGetLimitYear());
            Assert.AreEqual(testLimitMonth, testActualObj.opGetLimitMonth());
            Assert.AreEqual(testLimitDay, testActualObj.opGetLimitDay());
            Assert.AreEqual(testGoalAmount, testActualObj.opGetGoalAmount());
			Assert.AreEqual(testProgress, testActualObj.opGetProgress());
			#endregion
		}
        /// <summary>
        /// Comprueba la capacidad de modificación de una Meta de Ahorro.
        /// Valida que el método opModify actualice correctamente los objetivos financieros.
        /// </summary>
        [TestMethod]
        public void testModifier()
        {
            #region SetUp
            #region Pre-Conditions
            testOUID = "ABC";
            testName = "Car";
            testDescription = "I need a new car";
            testLimitYear = 2030;
            testLimitMonth = 01;
            testLimitDay = 15;
            testGoalAmount = 40000000;
            testProgress = 0;
            testActualObj = new clsSavingGoal(testOUID, testName, testDescription, testLimitYear, testLimitMonth, testLimitDay, testGoalAmount);
            #endregion
            #region PostConditions
            testName = "Motorbike";
            testDescription = "mountain bike";
            testLimitYear = 2028;
            testLimitMonth = 02;
            testLimitDay = 20;
            testGoalAmount = 12000000;
            testProgress = 0; 
            testExpectedObj = new clsSavingGoal(testOUID, testName, testDescription, testLimitYear, testLimitMonth, testLimitDay, testGoalAmount);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testActualObj.opModify("Motorbike", "mountain bike", 2028, 02, 20, 12000000));
            Assert.AreEqual(0, testActualObj.CompareTo(testExpectedObj));
            #endregion
        }
        /// <summary>
        /// Valida el ciclo de vida (eliminación) de una Meta de Ahorro.
        /// Asegura que el objeto responda correctamente al proceso de baja (opDie).
        /// </summary>
        [TestMethod]
        public void testKiller()
        {
            #region SetUp
            #region Pre-Conditions
            testOUID = "ABC";
            testName = "Car";
            testDescription = "I need a new car";
            testLimitYear = 2030;
            testLimitMonth = 01;
            testLimitDay = 15;
            testGoalAmount = 40000000;
            testProgress = 0;
			testConfirmDeletion = false;
            testActualObj = new clsSavingGoal(testOUID, testName, testDescription, testLimitYear, testLimitMonth, testLimitDay, testGoalAmount);
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
