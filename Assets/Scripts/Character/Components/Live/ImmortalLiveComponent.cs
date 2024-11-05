using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmortalLiveComponent : ILiveComponent
{
    public float  MaxHealth { get => 1; private set { } }
    public float Health { get => 1;  private set { } }

    public void SetDamage(float damage)
    {
        Debug. Log("I am immortal");
    }
}
