using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_titleScreen : MonoBehaviour
{
    static public UIManager_titleScreen Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }


    //selecciones de la pantalla titulo
    [SerializeField] private GameObject mainPanel;
    [SerializeField] private Button mainSelect;
    [SerializeField] private GameObject OptionsPanel;
    [SerializeField] private Button optionsSelect;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private Button playSelect;

    //Texto del guardado
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI levelsCompleteText;
    [SerializeField] private Image colorPanel;

    [SerializeField] private GameObject saveFile;
    [SerializeField] private GameObject noSaveFile;




    // Start is called before the first frame update
    void Start()
    {
        HideOptionsPanel();
        HidePlayPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ShowMainPanel()
    {
        mainPanel.SetActive(true);
        mainSelect.Select();
    }
    public void ShowOptionsPanel()
    {
        OptionsPanel.SetActive(true);
        optionsSelect.Select();
        
    }
    public void ShowPlayPanel()
    {
        playPanel.SetActive(true);
        playSelect.Select();
    }
    public void HideMainPanel()
    {
        mainPanel.SetActive(false);
    }
    public void HideOptionsPanel()
    {
        OptionsPanel.SetActive(false);
    }
    public void HidePlayPanel()
    {
        playPanel.SetActive(false);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.InGame(true);

    }

    public void Exit()
    {
        Application.Quit();
    }


    public void SetFile(bool exist, string setName, int setLevel, int setPoints, int setLevelsComplete, Color setPlayerColor)
    {
        if(exist)
        {
            saveFile.SetActive(true);
            noSaveFile.SetActive(false);
            nameText.text = $"Name: {setName}";
            levelText.text = $"Level: {setLevel}";
            pointsText.text = $"Points: {setPoints}";
            levelsCompleteText.text = $"Levels Complete: {setLevelsComplete}";
            colorPanel.color = setPlayerColor;

        }
        else if (!exist)
        {
            saveFile.SetActive(false);
            noSaveFile.SetActive(true);

        }
        


    }

}
