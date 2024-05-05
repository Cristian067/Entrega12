using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Apagar : MonoBehaviour
{

    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = boton.GetComponent<Button>();
        //Transform mainTransform = main.GetComponent<RectTransform>();
        btn.onClick.AddListener(TaskOnClick);
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void StopAndShutDown()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = Application.streamingAssetsPath + "/apagar.bat";
        startInfo.UseShellExecute = true;

        try
        {
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
        catch { }
    }


    void TaskOnClick()
    {
        StopAndShutDown();




    }


}
