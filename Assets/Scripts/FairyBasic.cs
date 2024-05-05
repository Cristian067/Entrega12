using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyBasic : MonoBehaviour
{
    public int life = 50;
    [SerializeField] private GameObject drop;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pos = transform.position;
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (life < 0)
        {
            Instantiate(drop, pos, Quaternion.Euler(0,90,0));
            Destroy(gameObject);

        }
        if (other.tag == "Ally")
        {

            life--;

        }

        //if (life < 0)
        //{ 
        //  Destroy(gameObject);

        //}
    }



}
