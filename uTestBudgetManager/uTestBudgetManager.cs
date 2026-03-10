using Microsoft.VisualStudio.TestTools.UnitTesting;
using packDomain;
using System.Collections.Generic;
using packServices.packCRUD;
using System;
namespace uTestBudgetManager
{
    [TestClass]
    public class uTestBudgetManager
    {
        private clsBudgetManager testFacade;
        private List<clsSavingGoal> testActualMySavingGoals;
		private List<clsSavingGoal> testExpectedSavingGoals;
		private List<clsSpent> testActualMySpents;
		private List<clsSpent> testExpectedSpents;
		private List<clsIncome> testActualMyIncomes;
        private List<clsIncome> testExpectedIncomes;

        /// <summary>
        /// Valida el registro de un nuevo Ingreso (Income) en el sistema.
        /// Verifica que el sistema base se genere correctamente y luego asegura
        /// que al registrar un nuevo ingreso, este se agregue satisfactoriamente
        /// a la colección y coincida con el resultado esperado.
        /// </summary>
        [TestMethod]
        public void TestRegisterIncome()
        {
            #region Setup
            #region Pre-Conditions
            testFacade = clsBudgetManager.opGetInstance();
            testFacade.opGenerate();
            testActualMyIncomes = new List<clsIncome>();
            testActualMyIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            testActualMyIncomes.Add(new clsIncome("2", "Football", "bet", 2024, 05, 16, 50000, 2));
            #endregion
            #region Post-Conditions
            testExpectedIncomes = new List<clsIncome>();
            testExpectedIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            testExpectedIncomes.Add(new clsIncome("2", "Football", "bet", 2024, 05, 16, 50000, 2));
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testFacade.opGenerate());
            Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedIncomes, testFacade.opGetIncomes()));
            Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedIncomes, testActualMyIncomes));
            Assert.IsTrue(testFacade.opRegisterIncome("3", "Job", "fortnight", 2024, 06, 16, 600000, 3));
            testExpectedIncomes.Add(new clsIncome("3", "Job", "fortnight", 2024, 06, 16, 600000, 3));
            Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedIncomes, testFacade.opGetIncomes()));
            #endregion
        }
		/// <summary>
		/// Valida el registro de un nuevo Gasto (Spent) en el sistema.
		/// Asegura que el estado inicial de gastos (fijos y variables) sea correcto,
		/// para posteriormente insertar un nuevo gasto y confirmar que la lista
		/// actual en el sistema (Facade) corresponda de forma exacta con lo esperado.
		/// </summary>
		[TestMethod]
		public void TestRegisterSpent()
        {
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySpents = new List<clsSpent>();
			testActualMySpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			testActualMySpents.Add(new clsSpent("4", "Suscription", "Netflix", 2023, 04, 18, 35000, 5, true));
			#endregion
			#region Post-Conditions
			testExpectedSpents = new List<clsSpent>();
			testExpectedSpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			testExpectedSpents.Add(new clsSpent("4", "Suscription", "Netflix", 2023, 04, 18, 35000, 5, true));
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opGenerate());
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSpents, testFacade.opGetSpents()));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSpents, testActualMySpents));
			Assert.IsTrue(testFacade.opRegisterSpent("5", "Shoe", "nike", 2023, 06, 16, 100000, 6, false));
			testExpectedSpents.Add(new clsSpent("5", "Shoe", "nike", 2023, 06, 16, 100000, 6, false));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSpents, testFacade.opGetSpents()));
			#endregion
		}
        /// <summary>
        /// Comprueba el registro de una nueva Meta de Ahorro (Saving Goal).
        /// Revisa las precondiciones con metas generadas por defecto y
        /// efectúa el registro de una nueva. Finalmente, contrasta la lista
        /// generada con una lista de control previamente definida.
        /// </summary>
        [TestMethod]
        public void TestRegisterSavingGoal()
        {
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySavingGoals = new List<clsSavingGoal>();
			testActualMySavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			testActualMySavingGoals.Add(new clsSavingGoal("6", "Moto", "Yamaha", 2027, 10, 25, 15000000));
			#endregion
			#region Post-Conditions
			testExpectedSavingGoals = new List<clsSavingGoal>();
			testExpectedSavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			testExpectedSavingGoals.Add(new clsSavingGoal("6", "Moto", "Yamaha", 2027, 10, 25, 15000000));
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opGenerate());
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSavingGoals, testFacade.opGetSavingGoals()));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSavingGoals, testActualMySavingGoals));
			Assert.IsTrue(testFacade.opRegisterSavingGoal("7", "Car", "Tesla", 2027, 02, 18, 15000000));
			testExpectedSavingGoals.Add(new clsSavingGoal("7", "Car", "Tesla", 2023, 02, 18, 15000000));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSavingGoals, testFacade.opGetSavingGoals()));
			#endregion
		}
		/// <summary>
		/// Verifica la funcionalidad de actualización para un Ingreso existente.
		/// Parte de un estado con ingresos previamente creados, actualiza uno y
		/// afirma que el objeto modificado mediante la clase Facade coincide
		/// con los nuevos valores esperados en nuestras precondiciones.
		/// </summary>
		[TestMethod]
        public void TestUpdateIncome()
        {
            #region Setup
            #region Pre-Conditions
            testFacade = clsBudgetManager.opGetInstance();
            testFacade.opGenerate();
            testActualMyIncomes = new List<clsIncome>();
            testActualMyIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            testActualMyIncomes.Add(new clsIncome("2", "Football", "bet", 2024, 05, 16, 50000, 2));
            #endregion
            #region Post-Conditions
            testExpectedIncomes = new List<clsIncome>();
            testExpectedIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            testExpectedIncomes.Add(new clsIncome("2", "Job", "fortnight", 2024, 06, 16, 600000, 3));
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testFacade.opUpdateIncome("2", "Job", "fortnight", 2024, 06, 16, 600000, 3));
            Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedIncomes, testFacade.opGetIncomes()));
            #endregion
        }
        /// <summary>
        /// Prueba que se actualice exitosamente la información de un Gasto registrado.
        /// Se modifica un atributo existente y se valida que el cambio quede
        /// persistido comparando contra la colección de gastos esperados.
        /// </summary>
        [TestMethod]
		public void TestUpdateSpent()
		{
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySpents = new List<clsSpent>();
			testActualMySpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			testActualMySpents.Add(new clsSpent("4", "Suscription", "Netflix", 2023, 04, 18, 35000, 5, true));
			#endregion
			#region Post-Conditions
			testExpectedSpents = new List<clsSpent>();
			testExpectedSpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			testExpectedSpents.Add(new clsSpent("4", "Shoe", "nike", 2023, 06, 16, 100000, 6, false));
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opUpdateSpent("4", "Shoe", "nike", 2023, 06, 16, 100000, 6, false));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSpents, testFacade.opGetSpents()));
			#endregion
		}
		/// <summary>
		/// Asegura que las Metas de Ahorro sean actualizadas de forma consistente.
		/// Inicia un escenario con dos metas base, modifica los datos de una de
		/// ellas, y valida que el resultado en el Manager respeta los cambios ejecutados.
		/// </summary>
		[TestMethod]
		public void TestUpdateSavingGoal()
		{
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySavingGoals = new List<clsSavingGoal>();
			testActualMySavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			testActualMySavingGoals.Add(new clsSavingGoal("6", "Moto", "Yamaha", 2027, 10, 25, 15000000));
			#endregion
			#region Post-Conditions
			testExpectedSavingGoals = new List<clsSavingGoal>();
			testExpectedSavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			testExpectedSavingGoals.Add(new clsSavingGoal("6", "Car", "Tesla", 2027, 02, 18, 15000000));
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opUpdateSavingGoal("6", "Car", "Tesla", 2027, 02, 18, 15000000));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSavingGoals, testFacade.opGetSavingGoals()));
			#endregion
		}
		/// <summary>
		/// Valida el proceso de eliminación lógica y física de un Ingreso.
		/// Configura el estado marcando su estado para eliminación y luego invoca la
		/// eliminación desde Facade para confirmar que desaparece de las listas.
		/// </summary>
		[TestMethod]
        public void testDeleteIncome()
        {
            #region Setup
            #region Pre-Conditions
            testFacade = clsBudgetManager.opGetInstance();
            testFacade.opGenerate();
            testActualMyIncomes = new List<clsIncome>();
            testActualMyIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            testActualMyIncomes.Add(new clsIncome("2", "Football", "bet", 2024, 05, 16, 50000, 2));
            #endregion
            #region Post-Conditions
            testExpectedIncomes = new List<clsIncome>();
            testExpectedIncomes.Add(new clsIncome("1", "Gift", "birthay", 2022, 02, 21, 8000, 1));
            clsIncome varObj = clsBrokerCrud.opRetrieveItemWith<clsIncome>("2", testFacade.opGetIncomes());
            varObj.opSetConfirmDeletion(true);
            #endregion
            #endregion
            #region Test & Assert
            Assert.IsTrue(testFacade.opDeleteIncome("2"));
            Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedIncomes, testFacade.opGetIncomes()));

            #endregion
        }
        /// <summary>
        /// Comprueba la eliminación de un Gasto.
        /// Verifica que tras ejecutar el método de borrado (opSetConfirmDeletion -> Delete),
        /// la colección final de gastos omitirá el elemento previamente retirado.
        /// </summary>
        [TestMethod]
        public void testDeleteSpent()
        {
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySpents = new List<clsSpent>();
			testActualMySpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			testActualMySpents.Add(new clsSpent("4", "Suscription", "Netflix", 2023, 04, 18, 35000, 5, true));
			#endregion
			#region Post-Conditions
			testExpectedSpents = new List<clsSpent>();
			testExpectedSpents.Add(new clsSpent("3", "Food", "McDonals", 2022, 11, 21, 30000, 7, false));
			clsSpent varObj = clsBrokerCrud.opRetrieveItemWith<clsSpent>("4", testFacade.opGetSpents());
			varObj.opSetConfirmDeletion(true);
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opDeleteSpent("4"));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSpents, testFacade.opGetSpents()));

			#endregion
		}
		/// <summary>
		/// Testea la eliminación segura de una Meta de Ahorro guardada en el sistema.
		/// Realiza la aprobación para eliminación de un elemento por OUID, y contrasta
		/// que el estado final omita correctamente el registro removido.
		/// </summary>
		[TestMethod]
		public void TestDeleteSavingGoal()
		{
			#region Setup
			#region Pre-Conditions
			testFacade = clsBudgetManager.opGetInstance();
			testFacade.opGenerate();
			testActualMySavingGoals = new List<clsSavingGoal>();
			testActualMySavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			testActualMySavingGoals.Add(new clsSavingGoal("6", "Moto", "Yamaha", 2027, 10, 25, 15000000));
			#endregion
			#region Post-Conditions
			testExpectedSavingGoals = new List<clsSavingGoal>();
			testExpectedSavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
			clsSavingGoal varObj = clsBrokerCrud.opRetrieveItemWith<clsSavingGoal>("6", testFacade.opGetSavingGoals());
			varObj.opSetConfirmDeletion(true);
			#endregion
			#endregion
			#region Test & Assert
			Assert.IsTrue(testFacade.opDeleteSavingGoal("6"));
			Assert.IsTrue(clsBrokerCrud.opAreEqual(testExpectedSavingGoals, testFacade.opGetSavingGoals()));

			#endregion
		}
	}
}
