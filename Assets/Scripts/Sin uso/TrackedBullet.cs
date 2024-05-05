using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TrackedBullet : MonoBehaviour
{

    [SerializeField] private float speed = 20f;

    private GameObject player;
    private Vector3 playerPos;

    private PlayerControl playerS;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerS = FindFirstObjectByType<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);


        playerPos = player.transform.position;








    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            playerS.life--;
            //Destroy(other.gameObject);
        }
    }


}
