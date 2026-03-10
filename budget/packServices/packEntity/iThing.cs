// File:    iThing.cs
// Author:  Julian
// Created: Tuesday, October 15, 2024 7:48:17 PM
// Purpose: Definition of Interface iThing

using System;

namespace packServices.packEntity
{
   public interface iThing
   {
      string opGetOUID();
      
      string opGetName();
      
      string opGetDescription();
      
      bool opSetOUID(string prmOUID);
      
      bool opSetName(string prmName);
      
      bool opSetDescription(string prmDescription);
   
   }
}