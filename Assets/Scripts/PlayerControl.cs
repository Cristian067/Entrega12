using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerControl : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    public float speedS = 8f;

    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject spellCard;

    //[SerializeField] private GameObject player;

    //public PlayerControl ascript;


    public TMP_Text contador;

    public TMP_Text cPuntos;


    //disparo normal
    [SerializeField] private float FireRate = 0.3f;
    private float NextFire;
    //invulnerabilidad despues de ser golpeado
    [SerializeField] private float InvTime;
    private float NextTouch;
    //ataque especial
    [SerializeField] private float SpecialRate = 0.3f;
    private float NextSpecial;



    [SerializeField] private float limitX = 8;

    //[SerializeField] private int lives = 3;


    public int life = 3;
    public int maxlive = 8;


    public int special = 3;
    public int maxsp = 8;

    public int points = 0;

    private int inf_maxScore;


    private float horizontalInput;
    private float verticalInput;


    private Vector3 pos;

    



    // Start is called before the first frame update
    void Start()
    {

     
        inf_maxScore = PlayerPrefs.GetInt("inf_score");

    }

    // Update is called once per frame
    void Update()
    {


        pos = transform.position;

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(new Vector3(1, 0, 0) * horizontalInput * speed * Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0) * verticalInput * speed * Time.deltaTime);


        if (Input.GetButton("Shoot") && Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            shooting();
        }


        if (Input.GetButton("Special") && Time.time > NextSpecial && special > 0)
        {
            NextSpecial = Time.time + SpecialRate;
            special_s();
        }



        if (life == 0)
        {
            Destroy(gameObject);

            if(points > inf_maxScore)
            {
                PlayerPrefs.SetInt("inf_score", points);
                PlayerPrefs.Save();
            }
            

        }


        contador.text = $"Lives: {life}" + 
            $" Special: {special}";

        cPuntos.text = $"Score: {points}"
            + $" Max Score: {inf_maxScore}";


        //limitar limites
        
        if (pos.y < -1) {

            transform.position = new Vector3(transform.position.x,-1,transform.position.z);

        }

        if (pos.x > limitX) 
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }

        if (pos.x < -limitX)
        {
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        }
        
        //-----




        //quitar effecto invulnaribilidad
        if (Time.time !> NextTouch)
        {
            

            gameObject.transform.localScale = new Vector3(1, 1, 1);

        }
        //-----







    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Enemy" || other.tag == "Bullet")
        {


            if (Time.time > NextTouch)
            {
                NextTouch = Time.time + InvTime;
                life--;

                gameObject.transform.localScale = new Vector3(2,2,2);

            }
            

            

            /*
             * 
             * mirar el como hacer que spawne desde abajo
            if (life > 0) 
            { 
            
                Instantiate(player, new Vector3(0,0,0), Quaternion.identity);
                //ascript.enabled = true;
            }
            
            Destroy(gameObject);

            */

        }
        

    }



    private void shooting()
    {

        
        Instantiate(bullet, new Vector3(pos.x +0.2f,pos.y,pos.z), Quaternion.identity);
        Instantiate(bullet, new Vector3(pos.x -0.2f,pos.y,pos.z), Quaternion.identity);


    }


    private void special_s()
    {

        special--;

        //M. S.

        speed = speed / 3;
        speedS = speedS / 3;

        Instantiate(spellCard, new Vector3(pos.x,pos.y,pos.z), Quaternion.Euler(90,0,0));

        Invoke("normal", 3);
        

        Debug.Log("WIP");

    }

    private void normal()
    {
        speed = speed * 3;
        speedS = speedS * 3;
    }

    private void MS()
    {

    }


}
