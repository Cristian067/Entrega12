using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomllet : MonoBehaviour
{

    [SerializeField] private float speed;

    [SerializeField] private GameObject bullet;

    private int contador = 0;

    private int RNum;

    [SerializeField] private int[] gradePlusNumber;






    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("explode", Random.Range(1, 3), Random.Range(2,8));
        
    }

    // Update is called once per frame
    void Update()
    {


        RNum = Random.Range(2, 8);
        Debug.Log(RNum);



        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime, Space.World);





    
    }


    private void time()
    {

        if (contador  < RNum)
        {
            contador++;
        }
        else
        {
            explode();
        }




    }


    private void explode()
    {

        for (int i = 0; i < gradePlusNumber.Length; i++)
        {

            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, gradePlusNumber[i]));
            Destroy(gameObject);

        }

    }







}
