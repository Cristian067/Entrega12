using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Hay mas de un Game Manager");
        }
        Instance = this;
    }

    [SerializeField] private string playerName;
    [SerializeField] private int points;
    [SerializeField] private Color playerColor;
    [SerializeField] private int level;
    [SerializeField] private int exp;
    [SerializeField] private float initialPower;
    [SerializeField] private int levelsCompleted;
    [SerializeField] private float timePlayed;

    [SerializeField] static private bool inGame;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("a" + inGame);

        if (!inGame)
        {
            Save.Instance.LoadDataTittleScreen();
        }

        else if (inGame)
        {
            LoadData();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Savedata()
    {

        Debug.Log("Saved?");
        //Debug.Log("a", new Vector3(0, 0, 0), points, playerColor, level, exp, initialPower, levelsCompleted, timePlayed);
        Save.Instance.saveJSON(playerName, PlayerControlMap.Instance.transform.position,points,playerColor,level,exp,initialPower,levelsCompleted,timePlayed);
        //Save.Instance.saveJSON("a", new Vector3(0,0,0),  2, new Color(0,0,0), 2,  2,  2, 1,  5);

    }
    
    public void LoadData()
    {
        Save.Instance.LoadData();
    }

    public void Load(string getPlayerName, Vector3 getPlayerPos, int getPoints, Color getPlayerColor, int getLevel, int getExp, float getInitialPower, int getLevelComplete, float getTimePlayed)
    {
        playerName = getPlayerName;
        PlayerControlMap.Instance.transform.position = getPlayerPos;
        points = getPoints;
        playerColor = getPlayerColor;
        level = getLevel;
        exp= getExp;
        initialPower = getInitialPower;
        levelsCompleted = getLevelComplete;
        timePlayed = getTimePlayed;
    }
    public void LoadTittleScreen(bool exist,string getPlayerName, Vector3 getPlayerPos, int getPoints, Color getPlayerColor, int getLevel, int getExp, float getInitialPower, int getLevelComplete, float getTimePlayed)
    {
        playerName = getPlayerName;
        points = getPoints;
        playerColor = getPlayerColor;
        level = getLevel;
        levelsCompleted = getLevelComplete;

        UIManager_titleScreen.Instance.SetFile( exist, playerName, level, points, levelsCompleted, playerColor);
    }

    public void InGame(bool insideGame)
    {
        inGame = insideGame;
    }

}
