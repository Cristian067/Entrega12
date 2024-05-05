using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy_shoot : MonoBehaviour
{


    [SerializeField] private GameObject bullet;

    [SerializeField] private float[] numberPlusGrade;

    //[SerializeField] private Quaternion[] grades;

    

    //[SerializeField] private int mirador = life;






    // Start is called before the first frame update
    void Start()
    {


        InvokeRepeating("bullets", 2.2f, 2);

        
    }

    // Update is called once per frame
    void Update()
    {
        //mirador = life;


        
    }


    void bullets()
    {

        for (int i = 0; i < numberPlusGrade.Length; i++)
        {

            Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, numberPlusGrade[i]));

        }




    }

    




}
