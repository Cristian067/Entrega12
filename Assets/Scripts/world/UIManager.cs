using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    static public UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Hay mas de un UI Manager");
        }

        Instance = this;
    }


    [SerializeField]private GameObject menuPanel;

    [SerializeField] private Button selectButton;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMenu()
    {

        selectButton.Select();
        menuPanel.SetActive(true);


    }
    public void HideMenu()
    {
        menuPanel.SetActive(false);
    }




}
