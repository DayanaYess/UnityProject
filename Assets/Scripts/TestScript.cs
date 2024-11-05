using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Floor[] floors;
    public float speed;

    void Update()
    { float moveHorizontal = Input .GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");

    Vector3 movementVector = new Vector3(moveHorizontal, 0, moveVertical);

    transform.position = transform.position + movementVector * speed * Time. deltaTime;
   }
}