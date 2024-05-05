using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Contador : MonoBehaviour
{

    private PlayerControl player;

    public TMP_Text messageText;

    //public TMP_Text contador;


    // Start is called before the first frame update
    void Start()
    {

        player = FindFirstObjectByType<PlayerControl>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(player.life);

        //messageText.SetText($"lives: {player.life}" +
           // $"Special: {player.special}");


        
    }
}
