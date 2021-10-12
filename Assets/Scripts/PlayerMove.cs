using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float FastSpeed;
    private float MoveSpeed = 0f;//define moving speed
    private Ray ray;//define reflect ray
    private RaycastHit hit;//ray detect hit position
    private Vector3 endPosition;//move to mouse last hit

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))//when left is clicked(left click is 0, right click is 1.) 
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);//ray from camera to mouse last hit, Input.mousePosition is where is the mouse last hit.
            if (Physics.Raycast(ray, out hit))//Physics.Raycast()when ray hit any objetc it return true, otherwise return false
            {
                if (hit.collider.gameObject.name == "Plane")//when ray hit plane
                {
                    hit.point += new Vector3(0, 0.5f, 0);
                    endPosition = hit.point;//let mouse last hit be endPosition
                    endPosition.y = transform.position.y;//position of y unchange
                    transform.LookAt(endPosition);//look at the mouse last hit
                    MoveSpeed = FastSpeed;//move speed is 10
                }
            }
        }
        if (Vector3.Distance(transform.position, hit.point) < 0.1f)//reach target position, when the distance between object position and mouse pointer smaller than 0, very very slow
        {
            MoveSpeed = 0;//when reach mouse position, speed is 0
        }
        transform.Translate(transform.forward * MoveSpeed * Time.deltaTime, Space.World);//move to where the mouse last hit
    }
}
