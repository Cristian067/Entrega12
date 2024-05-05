using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel: MonoBehaviour
{

    [SerializeField] private string levelSelection;
    [SerializeField] private int evelSelection;
    [SerializeField] private SceneAsset map;


    Vector3 PlayerPos;



    // Start is called before the first frame update
    void Start()
    {

        
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    
    
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") {

            if (Input.GetKeyDown("z"))
            {
                /*
                PlayerPrefs.SetFloat("Coord_x", transform.position.x);
                PlayerPrefs.SetFloat("Coord_z", transform.position.z);
                PlayerPrefs.Save();
                */
                GameManager.Instance.Savedata();
                SceneManager.LoadScene(levelSelection);

            }

            

        }
    }

   


}
