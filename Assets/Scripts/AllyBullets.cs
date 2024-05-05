using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AllyBullet : MonoBehaviour
{

    [SerializeField] private float speed = 20f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


}
