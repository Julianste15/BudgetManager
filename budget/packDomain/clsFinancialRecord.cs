//

using System;
using packServices.packEntity;

namespace packDomain
{
   public abstract class clsFinancialRecord : clsEntity
   {
      protected int attYear;
      protected int attMonth;
      protected int attDay;
      protected float attAmount;
      protected int attCategory;
      protected bool attConfirmDeletion;
      
      public clsFinancialRecord(string prmOUID, string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory) : base(prmOUID,prmName)
      {
         attDay = prmDay;
         attMonth = prmMonth;
         attYear = prmYear;
         attAmount = prmAmount;
         attDescription = prmDescription;
         attCategory = prmCategory;
         attConfirmDeletion = false;
      }
      
      public float opGetAmount()
      {
         return attAmount;
      }
      
      public int opGetCategory()
      {
         return attCategory;
      }
      
      public int opGetDay()
      {
         return attDay;
      }
      
      public int opGetMonth()
      {
         return attMonth;
      }
      
      public int opGetYear()
      {
         return attYear;
      }
      
      public bool opGetConfirmDeletion()
      {
         return attConfirmDeletion;
      }
      
      public bool opSetDay(int prmDay)
      {
         attDay = prmDay;
         return true;
      }
      
      public bool opSetMonth(int prmMonth)
      {
         attMonth = prmMonth;
         return true;
      }
      
      public bool opSetYear(int prmYear)
      {
         attYear = prmYear;
         return true;
      }
      
      public bool opSetAmount(float prmAmount)
      {
         attAmount = prmAmount;
         return true;
      }
      
      public bool opSetCategory(int prmCategory)
      {
         attCategory = prmCategory;
         return true;
      }
      
      public bool opSetConfirmDeletion(bool prmConfirmDeletion)
      {
         attConfirmDeletion = prmConfirmDeletion;
         return true;
      }
      
      public bool opModify(string prmName, string prmDescription, int prmYear, int prmMonth, int prmDay, float prmAmount, int prmCategory)
      {
          attName = prmName;
          attDescription = prmDescription;
          attDay = prmDay;
          attMonth = prmMonth;
          attYear = prmYear;
          attAmount = prmAmount;
          attCategory = prmCategory;
      
          return true;
      }
      
      public bool opDie()
      {
         if (attConfirmDeletion != true) return false;
         return true;
      }
      
      public int CompareTo(clsFinancialRecord prmOther)
      {
         if (prmOther == null) return 1;
            int result = base.CompareTo(prmOther);
         if (result != 0) return result;
            result = attYear.CompareTo(prmOther.attYear);
         if (result != 0) return result;
            result = attMonth.CompareTo(prmOther.attMonth);
         if (result != 0) return result;
            result = attDay.CompareTo(prmOther.attDay);
         if (result != 0) return result;
            result = attAmount.CompareTo(prmOther.attAmount);
         if (result != 0) return result;
            return attCategory.CompareTo(prmOther.attCategory);
      }
   
   }
}