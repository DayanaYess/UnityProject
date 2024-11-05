using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
 [SerializeField] protected CharacterData characterData;

    public IMovable MovableComponent { get; protected set; }
    public ILiveComponent LiveComponent { get; protected set; }


    public IDamageComponent DamageComponent { get; protected set; }

    public virtual void Start()
    
    {
        MovableComponent = new CharacterMovementComponent();
        MovableComponent.Initialize(characterData);
    }
   public abstract void Update();
}
