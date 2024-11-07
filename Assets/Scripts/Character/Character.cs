using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private CharacterType characterType;
    [SerializeField] protected CharacterData characterData;

    public CharacterType CharacterType => CharacterType;
    public CharacterData characterdata => characterdata;

    public virtual Character CharacterTarget { get; }
    public IMovable MovableComponent { get; protected set; }
    public ILiveComponent LiveComponent { get; protected set; }
    public IDamageComponent DamageComponent { get; protected set; }

    public virtual void Initialize()
    {
        MovableComponent = new CharacterMovementComponent();
        MovableComponent.Initialize(characterData);
    }
    
    public abstract void Update();
}
