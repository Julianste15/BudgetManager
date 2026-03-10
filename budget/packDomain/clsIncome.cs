// File:    clsIncome.cs
// Author:  Julian
// Created: Thursday, September 26, 2024 9:13:57 PM
// Purpose: Definition of Class clsIncome

using System;

namespace packDomain
{
   public class clsIncome : clsFinancialRecord
   {
      public clsIncome(string prmOUID, string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory) : base(prmOUID, prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory)
      {
       
      }
      
      public new bool opDie()
      {
         return base.opDie();
      }
      
      public new bool opModify(string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory)
      {
         return base.opModify(prmName, prmDescription, prmYear, prmMonth, prmDay, prmAmount, prmCategory);
      }
      
      public int CompareTo(clsIncome prmOther)
      {
         if (prmOther == null) return 1;
         return base.CompareTo(prmOther);
      }
   
   }
}