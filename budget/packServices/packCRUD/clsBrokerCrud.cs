// File:    clsBrokerCrud.cs
// Author:  Julian
// Created: Tuesday, October 15, 2024 7:44:35 PM
// Purpose: Definition of Class clsBrokerCrud

using System;
using packServices.packEntity;
using System.Collections.Generic;

namespace packServices.packCRUD
{
   public static class clsBrokerCrud
   {
      public static bool opExistsItemWith<T>(string prmOUID, List<T> prmCollection) where T : iThing
      {
         foreach(T varItem in prmCollection)
            if(varItem.opGetOUID()==prmOUID) return true;
         return false;
      }
      
      public static bool opAssociateItemWith<T>(T prmObj, List<T> prmCollection)
      {
         try
         {
            prmCollection.Add(prmObj);
            return true;
         }
         catch(Exception e)
         {
            return false;
         }
      }
      
      public static T opRetrieveItemWith<T>(string prmOUID, List<T> prmCollection) where T : iThing
      {
         foreach(T varItem in prmCollection)
            if(varItem.opGetOUID()==prmOUID) return varItem;
         return default;
         
      }
      
      public static bool opAreEqual<T>(List<T> prmCollection, List<T> prmOtherCollection) where T : IComparable
      {
         if (prmCollection.Count != prmOtherCollection.Count)
         {
      	   Console.WriteLine($"Count mismatch: Expected {prmCollection.Count}, Actual {prmOtherCollection.Count}");
      	   return false;
         }
      
         for (int varIdx = 0; varIdx < prmCollection.Count; varIdx++)
         {
      	   if (prmCollection[varIdx].CompareTo(prmOtherCollection[varIdx]) != 0)
      	   {
      		   Console.WriteLine($"Mismatch at index {varIdx}:");
      		   Console.WriteLine($"Expected: {prmCollection[varIdx]}");
      		   Console.WriteLine($"Actual: {prmOtherCollection[varIdx]}");
      		   return false;
      	   }
         }
         return true;
      }
   
   }
}