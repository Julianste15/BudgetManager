// File:    clsBudgetManager.cs
// Author:  Julian
// Created: jueves, 26 de septiembre de 2024 9:11:32 p. m.
// Purpose: Definition of Class clsBudgetManager

using System;
using System.Collections.Generic;
using packServices.packCRUD;

namespace packDomain
{
   public class clsBudgetManager
   {
      private static clsBudgetManager attInstance = null;
      private List<clsSavingGoal> attMySavingGoals = new List<clsSavingGoal>();
      private List<clsSpent> attMySpents = new List<clsSpent>();
      private List<clsIncome> attMyIncomes = new List<clsIncome>();
      
      private System.Collections.ArrayList attMySavingGoal;
      
      /// <summary>
      /// Property for collection of clsSavingGoal
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList AttMySavingGoal
      {
         get
         {
            if (attMySavingGoal == null)
               attMySavingGoal = new System.Collections.ArrayList();
            return attMySavingGoal;
         }
         set
         {
            RemoveAllAttMySavingGoal();
            if (value != null)
            {
               foreach (clsSavingGoal oclsSavingGoal in value)
                  AddAttMySavingGoal(oclsSavingGoal);
            }
         }
      }
      
      /// <summary>
      /// Add a new clsSavingGoal in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAttMySavingGoal(clsSavingGoal newClsSavingGoal)
      {
         if (newClsSavingGoal == null)
            return;
         if (this.attMySavingGoal == null)
            this.attMySavingGoal = new System.Collections.ArrayList();
         if (!this.attMySavingGoal.Contains(newClsSavingGoal))
            this.attMySavingGoal.Add(newClsSavingGoal);
      }
      
      /// <summary>
      /// Remove an existing clsSavingGoal from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAttMySavingGoal(clsSavingGoal oldClsSavingGoal)
      {
         if (oldClsSavingGoal == null)
            return;
         if (this.attMySavingGoal != null)
            if (this.attMySavingGoal.Contains(oldClsSavingGoal))
               this.attMySavingGoal.Remove(oldClsSavingGoal);
      }
      
      /// <summary>
      /// Remove all instances of clsSavingGoal from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAttMySavingGoal()
      {
         if (attMySavingGoal != null)
            attMySavingGoal.Clear();
      }
      private System.Collections.ArrayList attMySpent;
      
      /// <summary>
      /// Property for collection of clsSpent
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList AttMySpent
      {
         get
         {
            if (attMySpent == null)
               attMySpent = new System.Collections.ArrayList();
            return attMySpent;
         }
         set
         {
            RemoveAllAttMySpent();
            if (value != null)
            {
               foreach (clsSpent oclsSpent in value)
                  AddAttMySpent(oclsSpent);
            }
         }
      }
      
      /// <summary>
      /// Add a new clsSpent in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAttMySpent(clsSpent newClsSpent)
      {
         if (newClsSpent == null)
            return;
         if (this.attMySpent == null)
            this.attMySpent = new System.Collections.ArrayList();
         if (!this.attMySpent.Contains(newClsSpent))
            this.attMySpent.Add(newClsSpent);
      }
      
      /// <summary>
      /// Remove an existing clsSpent from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAttMySpent(clsSpent oldClsSpent)
      {
         if (oldClsSpent == null)
            return;
         if (this.attMySpent != null)
            if (this.attMySpent.Contains(oldClsSpent))
               this.attMySpent.Remove(oldClsSpent);
      }
      
      /// <summary>
      /// Remove all instances of clsSpent from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAttMySpent()
      {
         if (attMySpent != null)
            attMySpent.Clear();
      }
      private System.Collections.ArrayList attMyIncome;
      
      /// <summary>
      /// Property for collection of clsIncome
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList AttMyIncome
      {
         get
         {
            if (attMyIncome == null)
               attMyIncome = new System.Collections.ArrayList();
            return attMyIncome;
         }
         set
         {
            RemoveAllAttMyIncome();
            if (value != null)
            {
               foreach (clsIncome oclsIncome in value)
                  AddAttMyIncome(oclsIncome);
            }
         }
      }
      
      /// <summary>
      /// Add a new clsIncome in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAttMyIncome(clsIncome newClsIncome)
      {
         if (newClsIncome == null)
            return;
         if (this.attMyIncome == null)
            this.attMyIncome = new System.Collections.ArrayList();
         if (!this.attMyIncome.Contains(newClsIncome))
            this.attMyIncome.Add(newClsIncome);
      }
      
      /// <summary>
      /// Remove an existing clsIncome from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAttMyIncome(clsIncome oldClsIncome)
      {
         if (oldClsIncome == null)
            return;
         if (this.attMyIncome != null)
            if (this.attMyIncome.Contains(oldClsIncome))
               this.attMyIncome.Remove(oldClsIncome);
      }
      
      /// <summary>
      /// Remove all instances of clsIncome from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAttMyIncome()
      {
         if (attMyIncome != null)
            attMyIncome.Clear();
      }
      
      public static clsBudgetManager opGetInstance()
      {
         if(attInstance==null)
            attInstance=new clsBudgetManager();
         return attInstance;
      }
      
      public List<clsSavingGoal> opGetSavingGoals()
      {
         return attMySavingGoals;
      }
      
      public List<clsSpent> opGetSpents()
      {
         return attMySpents;
      }
      
      public List<clsIncome> opGetIncomes()
      {
         return attMyIncomes;
      }
      
      public bool opSetSavingGoals(List<clsSavingGoal> prmOtherSavingGoals)
      {
         attMySavingGoals = prmOtherSavingGoals;
         return true;
      }
      
      public bool opSetSpents(List<clsSpent> prmOtherSpents)
      {
         attMySpents = prmOtherSpents;
         return true;
      }
      
      public bool opSetIncomes(List<clsIncome> prmOtherIncomes)
      {
         attMyIncomes = prmOtherIncomes;
         return true;
      }
      
      public bool opRegisterIncome(string prmOUID, string prmName, int prmYear, int prmMonth, int prmDay, float prmAmount, string prmDescription, int prmCategory)
      {
         if(clsBrokerCrud.opExistsItemWith<clsIncome>(prmOUID,attMyIncomes)) return false;
         return clsBrokerCrud.opAssociateItemWith<clsIncome>(new clsIncome(prmOUID,prmName,prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory),attMyIncomes);
      }
      
      public bool opRegisterSpent(string prmOUID, string prmName, int prmYear, int prmMonth, int prmDay, float prmAmount, string prmDescription, int prmCategory, bool prmFixed)
      {
         if(clsBrokerCrud.opExistsItemWith<clsSpent>(prmOUID,attMySpents)) return false;
         return clsBrokerCrud.opAssociateItemWith<clsSpent>(new clsSpent(prmOUID, prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory, prmFixed),attMySpents);
      }
      
      public bool opRegisterSavingGoal(string prmOUID, string prmName, string prmDescription, int prmLimitYear, int prmLimitMonth, int prmLimitDay, float prmGoalAmount)
      {
         if(clsBrokerCrud.opExistsItemWith<clsSavingGoal>(prmOUID,attMySavingGoals)) return false;
         return clsBrokerCrud.opAssociateItemWith<clsSavingGoal>(new clsSavingGoal(prmOUID, prmName, prmDescription, prmLimitYear, prmLimitMonth, prmLimitDay, prmGoalAmount),attMySavingGoals);
      }
      
      public bool opUpdateIncome(string prmOUID, string prmName, int prmYear, int prmMonth, int prmDay, float prmAmount, string prmDescription, int prmCategory)
      {
         try
            {
               return clsBrokerCrud.opRetrieveItemWith<clsIncome>(prmOUID,attMyIncomes).opModify(prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory);
         
            }
         catch (Exception e)
            {
               return false;
            }
      }
      
      public bool opUpdateSpent(string prmOUID, string prmName, int prmYear, int prmMonth, int prmDay, float prmAmount, string prmDescription, int prmCategory, bool prmFixed)
      {
         try
            {
               return clsBrokerCrud.opRetrieveItemWith<clsSpent>(prmOUID,attMySpents).opModify(prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory, prmFixed);
         
            }
         catch (Exception e)
            {
               return false;
            }
      }
      
      public bool opUpdateSavingGoal(string prmOUID, string prmName, string prmDescription, int prmLimitYear, int prmLimitMonth, int prmLimitDay, float prmGoalAmount)
      {
         try
            {
               return clsBrokerCrud.opRetrieveItemWith<clsSavingGoal>(prmOUID,attMySavingGoals).opModify(prmName, prmDescription, prmLimitYear, prmLimitMonth, prmLimitDay, prmGoalAmount);
         
            }
         catch (Exception e)
            {
               return false;
            }
      }
      
      public bool opDeleteIncome(string prmOUID)
      {
         clsIncome varObj = clsBrokerCrud.opRetrieveItemWith<clsIncome>(prmOUID, attMyIncomes);
         if (varObj == null) return false;
         if (!varObj.opDie()) return false;
         return attMyIncomes.Remove(varObj);
      }
      
      public bool opDeleteSpent(string prmOUID)
      {
         clsSpent varObj = clsBrokerCrud.opRetrieveItemWith<clsSpent>(prmOUID, attMySpents);
         if (varObj == null) return false;
         if (!varObj.opDie()) return false;
         return attMySpents.Remove(varObj);
      }
      
      public bool opDeleteSavingGoal(string prmOUID)
      {
         clsSavingGoal varObj = clsBrokerCrud.opRetrieveItemWith<clsSavingGoal>(prmOUID, attMySavingGoals);
         if (varObj == null) return false;
         if (!varObj.opDie()) return false;
         return attMySavingGoals.Remove(varObj);
      }
      
      public bool opGenerate()
      {
         attMyIncomes.Add(new clsIncome("1", "Gift", "Birthay", 2022, 02, 21, 8000, 1));
         attMyIncomes.Add(new clsIncome("2", "Football", "Bet", 2024, 05, 16, 50000, 2));
      
         attMySpents.Add(new clsSpent("3", "Food", "McDonalds", 2022, 11, 21, 30000, 7, false));
         attMySpents.Add(new clsSpent("4", "Suscription", "Netflix", 2023, 04, 18, 35000, 5, true));
      
         attMySavingGoals.Add(new clsSavingGoal("5", "Computer", "Asus", 2025, 06, 30, 7000000));
         attMySavingGoals.Add(new clsSavingGoal("6", "Bike", "Yamaha", 2027, 10, 25, 15000000));
         
         return true;
      }
   
   }
}