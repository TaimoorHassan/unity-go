using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using StarterAssets;

namespace AM
{

  
    public class TileController : MonoBehaviour
    {
        public int number = 1;
        public GameObject Player;


        // Start is called before the first frame update
        void Start()
        {
            if (Player != null )
            {
                Player = Instantiate(Player, new Vector3(transform.position.x , transform.position.y + 1.0f, transform.position.z), number % 2 == 0 ? Quaternion.AngleAxis(90, Vector3.up) : Quaternion.AngleAxis(270, Vector3.up));
                Player.GetComponent<Mover>().number = number;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            // Debug.Log("Trigger Entered : " + other.gameObject.name);
            Debug.Log("Other Number :" + other.gameObject.GetComponent<Mover>().number.ToString() + " My Number : " + number.ToString() );
            if (!other.gameObject.name.ToLower().StartsWith("cube") || other.GetComponentInParent<Mover>().number == number)
            {
                return;
            }
            Debug.Log(other.gameObject.GetComponent<Mover>().ToString());

            DataHolder.Instance.activeNumber =  Player.GetComponent<Mover>().number;
            other.transform.SetPositionAndRotation(new Vector3(transform.position.x , 1.41f , transform.position.z) , number % 2 == 0 ? Quaternion.AngleAxis(90, Vector3.up) : Quaternion.AngleAxis(270, Vector3.up));
            number = other.gameObject.GetComponent<Mover>().number;
            Player = other.gameObject;
            

            
            // CharacterController characterController = Player.GetComponent<CharacterController>();

            // characterController.Move(Vector3.forward);
            // Destroy(other.gameObject);
        }
        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision Entered");
        }
    }

}
