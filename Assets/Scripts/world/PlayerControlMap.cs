using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerControlMap : MonoBehaviour
{
    static public PlayerControlMap Instance { get; private set; }




    [SerializeField] private float speed = 10f;

    [SerializeField] private GameObject bullet;

    [SerializeField] private Stats stats = new Stats();

    //datos a guardar/cargar

    

    private float horizontalInput;
    private float verticalInput;

    Vector3 PlayerPos;

    private bool inMenu = false;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        /*
         //Restaurar posicion
        PlayerPrefs.SetFloat("Coord_x", 110.02f);
        PlayerPrefs.SetFloat("Coord_z", -35.03f);
            
        //*/
        //PlayerPos = new Vector3(PlayerPrefs.GetFloat("Coord_x", transform.position.x), transform.position.y, PlayerPrefs.GetFloat("Coord_z", transform.position.z));

        //transform.position = PlayerPos;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = transform.position;

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (!inMenu)
        {
            transform.Translate(new Vector3(1, 0, 0) * horizontalInput * speed * Time.deltaTime);
            transform.Translate(new Vector3(0, 0, 1) * verticalInput * speed * Time.deltaTime);
        }
        


        if (Input.GetKeyDown("x"))
        {
            if(inMenu)
            {
                UIManager.Instance.HideMenu();
                inMenu = false;
            }
            else if (!inMenu)
            {
                UIManager.Instance.ShowMenu();
                inMenu = true;
            }
            


        }


    }


    private void OnTriggerEnter(Collider other)
    {

        /*
        
        if(other.tag == "Enemy" || other.tag == "Bullet")
        {


            if (Time.time > NextTouch)
            {
                NextTouch = Time.time + InvTime;
                life--;

                gameObject.transform.localScale = new Vector3(2,2,2);

            }
            */

            

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

    
    public void SetPlayerPos(Vector3 loadedPos)
    {
        transform.position = loadedPos;
    }






    }


    
