using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public float CreatTime;
    public GameObject Enemy;
    public float width;
    public float height;
    private float CountTime;

    // Start is called before the first frame update
    void Start()
    {
        CountTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (CountTime > 0)
        {
            CountTime -= Time.deltaTime;
        }
        else if (CountTime <= 0)    // When the counter become 0
        {
            Vector3 RandomPosition = RandomVector3();
            Quaternion RandomRotation = Quaternion.identity;
            GameObject EnemyInstance = Instantiate(Enemy, RandomPosition, RandomRotation);
            CountTime = CreatTime;
        }
    }
    float RandomX()
    {
        float tem = Random.Range(-1f, 1f);
        if (tem >= 0)
            return width + tem;
        else
            return tem - width;
    }
    Vector3 RandomVector3()
    {
        float x=0f, y=0f, z=0f;
        while(System.Math.Abs(x) <= 10 && System.Math.Abs(z) <= 6)
        {
            x = Random.Range(-width - 1f, width + 1f);
            y = 0.5f;
            z = Random.Range(-height - 1f, height + 1f);
        }
        return new Vector3(x, y, z);
    }
}
