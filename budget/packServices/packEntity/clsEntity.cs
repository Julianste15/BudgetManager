//

using System;

namespace packServices.packEntity
{
   public abstract class clsEntity : iThing
   {
      protected string attOUID = "0";
      protected string attName = "none";
      protected string attDescription = "none";
      
      public clsEntity(string prmOUID)
      {
         attOUID = prmOUID;
      }
      
      public clsEntity(string prmOUID, string prmName, string prmDescription)
      {
         attOUID = prmOUID;
         attName = prmName;
         attDescription = prmDescription;
      }
      
      public clsEntity(string prmOUID, string prmName)
      {
         attOUID = prmOUID;
         attName = prmName;
      }
      
      public string opGetOUID()
      {
         return attOUID;
      }
      
      public string opGetName()
      {
         return attName;
      }
      
      public string opGetDescription()
      {
         return attDescription;
      }
      
      public bool opSetOUID(string prmOUID)
      {
         attOUID = prmOUID;
         
         return true;
      }
      
      public bool opSetName(string prmName)
      {
         attName = prmName;
         
         return true;
      }
      
      public bool opSetDescription(string prmDescription)
      {
         attDescription = prmDescription;
         
         return true;
      }
      
      public int CompareTo(clsEntity prmOther)
      {
        if (prmOther == null) return 1;
            int result = attOUID.CompareTo(prmOther.attOUID);
        if (result != 0) return result;
            result = attName.CompareTo(prmOther.attName);
        if (result != 0) return result;
            return attDescription.CompareTo(prmOther.attDescription);
      }
   
   }
}