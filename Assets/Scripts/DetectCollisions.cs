using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    [SerializeField] private string exeption;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag != exeption)
        {
            Destroy(gameObject);
        }
           
        

    }

}
