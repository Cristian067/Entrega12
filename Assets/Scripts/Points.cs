using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{


    public int GPoints = 100;

    private PlayerControl playerControl;




    // Start is called before the first frame update
    void Start()
    {

        playerControl = FindAnyObjectByType<PlayerControl>();


        



    }

    // Update is called once per frame
    void Update()
    {



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerControl.points += GPoints;
            Destroy(gameObject);
        }
    }
}
