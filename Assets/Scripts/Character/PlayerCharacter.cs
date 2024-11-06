using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character 
{
    public override void Initialize()
    {
        base.Initialize();
        LiveComponent = new CharacterLiveComponent();
    } 
        
    public override void Update()
    {
        float moveHorizontal = Input. GetAxis("Horizontal");
        float moveVertical = Input. GetAxis("Vertical");

        Vector3 movementVector = new Vector3(moveHorizontal, 0, moveVertical).normalized;
        movementVector.Normalize();

        MovableComponent.Move(movementVector);
        MovableComponent.Rotation(movementVector);
    }
}

  