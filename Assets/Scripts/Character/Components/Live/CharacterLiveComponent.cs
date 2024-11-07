using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLiveComponent : ILiveComponent
{
   private Character selfCharacter;
   private float currentHealth;

   public float MaxHealth
   {
      get => 50;
      protected set { return; }
   }
    
   public float Health
   {
      get => currentHealth;
      protected set
      {
        currentHealth = value;
        if(currentHealth > MaxHealth)
           currentHealth = MaxHealth;

           if (currentHealth<= 0)
               currentHealth = 0;
               SetDeath();
            
      }
   }

   public CharacterLiveComponent()
   {
      Health = MaxHealth;
   }
   
   public void SetDamage(float damage)
   {
      Health -= damage;
        
      Debug.Log("Get damage = " + damage);
   }

   private void SetDeath()
   {
      OnCharacterDeath?.Invoke();
      Debug.Log("Character is death");
   }

   public void Initialize(Character selfCharacter)
   {
      throw new NotImplementedException(selfCharacter)
      {
         this.selfCharacter = selfCharacter;
      }
   }
}   
