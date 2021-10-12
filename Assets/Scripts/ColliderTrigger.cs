using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject canvas;
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        AS = GameObject.Find("Plane").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Enemy(Clone)")
        {
            AS.Stop();
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
    }
}
