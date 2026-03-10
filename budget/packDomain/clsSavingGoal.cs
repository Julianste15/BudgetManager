// File:    clsSavingGoal.cs
// Author:  Julian
// Created: Thursday, September 26, 2024 9:13:57 PM
// Purpose: Definition of Class clsSavingGoal

using System;
using packServices.packEntity;

namespace packDomain
{
   public class clsSavingGoal : clsEntity
   {
      protected int attLimitYear;
      protected int attLimitMonth;
      protected int attLimitDay;
      protected float attGoalAmount;
      protected int attProgress;
      protected bool attConfirmDeletion;
      
      public clsSavingGoal(string prmOUID, string prmName, string prmDescription, int prmLimitYear, int prmLimitMonth, int prmLimitDay, float prmGoalAmount) : base(prmOUID, prmName, prmDescription)
      {
         attLimitYear = prmLimitYear;
         attLimitMonth = prmLimitMonth;
         attLimitDay = prmLimitDay;
         attGoalAmount = prmGoalAmount;
         attProgress = 0;
         attConfirmDeletion = false;
      }
      
      public int opGetProgress()
      {
         return attProgress;
      }
      
      public float opGetGoalAmount()
      {
         return attGoalAmount;
      }
      
      public int opGetLimitYear()
      {
         return attLimitYear;
      }
      
      public int opGetLimitMonth()
      {
         return attLimitMonth;
      }
      
      public int opGetLimitDay()
      {
         return attLimitDay;
      }
      
      public bool opSetProgress(int prmProgress)
      {
         attProgress = prmProgress;
         return true;
      }
      
      public bool opSetGoalAmount(float prmGoalAmount)
      {
         attGoalAmount = prmGoalAmount;
         return true;
      }
      
      public bool opSetLimitYear(int prmLimitYear)
      {
         attLimitYear = prmLimitYear;
         return true;
      }
      
      public bool opSetLimitMonth(int prmLimitMonth)
      {
         attLimitMonth = prmLimitMonth;
         return true;
      }
      
      public bool opSetLimitDay(int prmLimitDay)
      {
         attLimitDay = prmLimitDay;
         return true;
      }
      
      public bool opSetConfirmDeletion(bool prmConfirmDeletion)
      {
         attConfirmDeletion = prmConfirmDeletion;
         return true;
      }
      
      public bool opDie()
      {
         if (attConfirmDeletion != true) return false;
         return true;
      }
      
      public bool opModify(string prmName, string prmDescription, int prmLimitYear, int prmLimitMonth, int prmLimitDay, float prmGoalAmount)
      {
         attName = prmName;
         attDescription = prmDescription;
         attLimitYear = prmLimitYear;
         attLimitMonth = prmLimitMonth;
         attLimitDay = prmLimitDay;
         attGoalAmount = prmGoalAmount;
         
         return true;
      }
      
      public int CompareTo(clsSavingGoal prmOther)
      {
         if (base.CompareTo(prmOther) != 0) return -1;
         if (attLimitYear != prmOther.attLimitYear && attLimitMonth != prmOther.attLimitMonth &&
      	   attLimitDay != prmOther.attLimitDay && attGoalAmount != prmOther.attGoalAmount && attProgress != prmOther.attProgress) return -1;
         return 0;
      }
   
   }
}