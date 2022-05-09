using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ColTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        try
        {
        // collision.gameObject.GetComponentInParent<ThirdPersonController>().enabled = false;
        // collision.gameObject.GetComponentInParent<Animator>().Play("Base Layer.Idle Walk Run Blend.Idle"  );
            
        }
        catch (System.Exception)
        {
            
        }

    }
}
