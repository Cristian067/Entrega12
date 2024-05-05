using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    private PlayerControl player;

    [SerializeField] private Transform playerPos;
    [SerializeField] private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {

        player = FindObjectOfType<PlayerControl>();
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = playerPos.position + playerPos.TransformDirection(offset);
        transform.rotation = playerPos.rotation;
        //transform.Translate(player.transform.position * Time.deltaTime * player.speedS, Space.World);
        
    }
}
