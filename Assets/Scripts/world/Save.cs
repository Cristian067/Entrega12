using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{
    static public Save Instance { get; private set; }


    private string path = Application.dataPath + "/../saves/" + "save.json";

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    private bool inTitleScreen = true;
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveJSON(string playerName,Vector3 setPos, int setPoints, Color setColor, int setLevel, int setExp, float setInPwer, int setLevelsComplete, float setTimePlayed)
    {

        Stats save = new Stats
        {
            name= playerName,
            mapPosition = setPos,
            points= setPoints,
            color = setColor,
            level = setLevel,
            exp= setExp,
            initialPower=setInPwer,
            levelsCompleted=setLevelsComplete,
            timePlayed=setTimePlayed,
        };


        string jsonContent = JsonUtility.ToJson(save);
        Debug.Log(jsonContent);
        File.WriteAllText(path, jsonContent);

    }


    public void LoadData()
    {
        if (File.Exists(path))
        {
            string jsonContent = File.ReadAllText(path);

            Stats save= JsonUtility.FromJson<Stats>(jsonContent);

            //if(!inTitleScreen){}

            GameManager.Instance.Load(save.name, save.mapPosition, save.points, save.color, save.level, save.exp, save.initialPower, save.levelsCompleted, save.timePlayed);
            //GameManager.Instance.Load(save.name, save.mapPosition, save.points, save.color, save.level, save.exp, save.initialPower, save.levelsCompleted, save.timePlayed);
            //PlayerControlMap.Instance.SetPlayerPos(save.mapPosition);
        }
        else
        {
            Debug.LogError("¡¡¡ EL ARCHIVO DE GUARDADO NO EXISTE !!!");
        }
    }

    public void LoadDataTittleScreen()
    {
        if (File.Exists(path))
        {
            string jsonContent = File.ReadAllText(path);

            Stats save = JsonUtility.FromJson<Stats>(jsonContent);

            //if(!inTitleScreen){}

            //GameManager.Instance.Load(save.name, save.mapPosition, save.points, save.color, save.level, save.exp, save.initialPower, save.levelsCompleted, save.timePlayed);
            GameManager.Instance.LoadTittleScreen(true, save.name, save.mapPosition, save.points, save.color, save.level, save.exp, save.initialPower, save.levelsCompleted, save.timePlayed);
                        //PlayerControlMap.Instance.SetPlayerPos(save.mapPosition);
        }
        else if (!File.Exists(path)) 
        {
            GameManager.Instance.LoadTittleScreen(false,"a", new Vector3(0,0,0), 1, new Color(0,0,0), 1, 0, 0, 0, 0);

        }
    }


}
