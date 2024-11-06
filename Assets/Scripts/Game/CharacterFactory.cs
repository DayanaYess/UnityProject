using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
   [SerializeField] private Character playerCharacterPrefab;
   [SerializeField] private Character enemyCharacterPrefab;

   private Dictionary<CharacterType, Queue<Character>> disabledCharacter 
   = new Dictionary<CharacterType, Queue<Character>>();

   private List<Character> activeCharacter = new List<Character>();

   public Character Player
   {
      get; private set;
   }

   public List<Character> ActiveCharacters => activeCharacter;  

   public Character GetCharacter(CharacterType. type)
   { 
      Character character = null;
      if (disabledCharacters.ContainsKey())
      {
        if (disabledCharacter[type].Count > 0)
        {
           character = disabledCharacter[type].Dequeue();
        }
      }
      else
      {
        disabledCharacters.Add(type, new Queue<Character>());
      }

      if(character == null)
      {
          character = InstantiateCharacter(type);
      }
      activeCharacters.Add(character);
      return character; 
   }

   public void ReturnCharacter(Character character)
   {
      Queue<Character> characters = disabledCharacter[character.CharacterType];
      character.Enqueue(character);
    
      activateCharacters.Remove(character);
   }
   private Character IstantiateCharacter(CharacterType. type)
   {
      Character character = null;
      switch (type)
      {
        case CharacterType.Player:
            character = GameObject.Instantiate(playerCharacterPrefab, null);
            Player = character;
            break; 
        case CharacterType.DefaultEnemy:
            character = GameObject.Instantiate(enemyCharacterPrefab, null);
            break;
        default:
            Debug.LongError("Unknown character type:" + type);
            break;        
      }
      return character;
   }
}

