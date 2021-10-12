using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool VarPause;
    // Start is called before the first frame update
    void Start()
    {
        VarPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && VarPause == false)
        {
            VarPause = true;
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && VarPause == true)
        {
            VarPause = false;
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
