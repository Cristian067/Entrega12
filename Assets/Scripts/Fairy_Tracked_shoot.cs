using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Fairy_Tracked_shoot : MonoBehaviour
{


    [SerializeField] private GameObject bullet;

    [SerializeField] private float[] numberPlusGrade;


    

    private GameObject player;
    private Vector3 playerPos;

    private Vector3 fairyPos;

   


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        InvokeRepeating("bullets", 2.2f, 2);

        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        //transform.rotation = Quaternion.Euler(0,0,0);
    }


    void bullets()
    {
        playerPos = player.transform.position;
        fairyPos = transform.position;
        
        Vector3 direccion = (playerPos - fairyPos).normalized;

        //GameObject go = GameObject.FindGameObjectWithTag("Player");
        //target = go.transform;
        // rotate the projectile to aim the target:
        //
        //transform.LookAt(playerPos);


        //transform.LookAt(playerPos);
        //transform.rotation = Quaternion.LookRotation(playerPos);

        /*
        Debug.Log(playerPos);
        Debug.Log(fairyPos);
        Debug.Log(direccion);
        */
        



        //transform.forward = direccion;



        GameObject go = 
        Instantiate(bullet, transform.position, Quaternion.identity);


        go.transform.up = -direccion;

        //Debug.Log(go.transform.);

        

        
        

    }



}
