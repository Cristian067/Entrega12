using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b1 : MonoBehaviour
{

    [SerializeField] private GameObject bullet1;

    private Vector3 Pos;




    // Start is called before the first frame update
    void Start()
    {
        attack();


    }

    // Update is called once per frame
    void Update()
    {
        Pos = transform.position;
        //Rot =

        //transform.Rotate(0,0,2);

        
        

        
    }


    private void attack()
    {
        /*
        for (int i = 0; i < 5; i++)
        {



        }
        */


        InvokeRepeating("shootAt1",0,0.7f);

        Invoke("cancel", 7);
        


    }


    private void shootAt1()
    {

        Instantiate(bullet1, new Vector3(Pos.x, Pos.y, Pos.x), Quaternion.Euler(0, 0, 0 + Quaternion.identity.z));
        Instantiate(bullet1, new Vector3(Pos.x, Pos.y, Pos.x), Quaternion.Euler(0, 0, 72 + Quaternion.identity.z));
        Instantiate(bullet1, new Vector3(Pos.x, Pos.y, Pos.x), Quaternion.Euler(0, 0, 144 + Quaternion.identity.z));
        Instantiate(bullet1, new Vector3(Pos.x, Pos.y, Pos.x), Quaternion.Euler(0, 0, 216 + Quaternion.identity.z));
        Instantiate(bullet1, new Vector3(Pos.x, Pos.y, Pos.x), Quaternion.Euler(0, 0, 288 + Quaternion.identity.z));

    }

    private void cancel()
    {

        CancelInvoke();

    }



}
