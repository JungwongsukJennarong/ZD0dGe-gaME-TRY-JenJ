using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 endPosition;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerYasuo");
        endPosition = player.transform.position;
        transform.LookAt(endPosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * MoveSpeed * Time.deltaTime, Space.World);
        if (System.Math.Abs(transform.position.x) > 13 || System.Math.Abs(transform.position.z) > 8)
        {
            DestroyImmediate(this);
        }
    }
}
