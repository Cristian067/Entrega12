using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpecialForm : MonoBehaviour
{

    [SerializeField] private float speed = 20f;

    [SerializeField] private float spinSpeed = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime, Space.World);

        transform.Rotate(new Vector3(0, 0, 1) * spinSpeed * Time.deltaTime);





    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            PlayerControl.life--;
            //Destroy(other.gameObject);
        }
    }
    */


}
