using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AM{

public class Mover : MonoBehaviour
{

  public int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame    public float speed = 10.0f;
        public float speed = 10.0f;

    public float rotationSpeed = 1.0f;

    void Update()
    {

      if(DataHolder.Instance.activeNumber == number){

            // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation );

        // Rotate around our y-axis
        transform.Rotate(0, rotation  * 5, 0);
      }
    }
}
}