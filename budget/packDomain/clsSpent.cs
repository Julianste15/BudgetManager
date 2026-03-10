// File:    clsSpent.cs
// Author:  Julian
// Created: Thursday, September 26, 2024 9:13:56 PM
// Purpose: Definition of Class clsSpent

using System;

namespace packDomain
{
   public class clsSpent : clsFinancialRecord
   {
      protected bool attFixed;
      
      public clsSpent(string prmOUID, string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory, bool prmFixed) : base(prmOUID, prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory)
      {
         attFixed = prmFixed;
      }
      
      public bool opIsFixed()
      {
         return attFixed;
      }
      
      public bool opSetFixedExpense(bool prmFixed)
      {
         attFixed = prmFixed;
         
         return true;
      }
      
      public new bool opDie()
      {
         return base.opDie();
      }
      
      public bool opModify(string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory, bool prmFixed)
      {
         base.opModify(prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory);
         
         attFixed = prmFixed;
         
         return true;
      }
      
      public int CompareTo(clsSpent prmOther)
      {
         if (base.CompareTo(prmOther) != 0) return -1;
             if (attFixed != prmOther.attFixed) return -1;
         return 0;
      }
   
   }
}