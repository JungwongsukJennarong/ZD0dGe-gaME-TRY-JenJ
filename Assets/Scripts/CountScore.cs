using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    private float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        GameObject.Find("SocreNumber").GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * 10f;
        GameObject.Find("SocreNumber").GetComponent<Text>().text = System.Math.Round(score, 0).ToString();
    }
}
