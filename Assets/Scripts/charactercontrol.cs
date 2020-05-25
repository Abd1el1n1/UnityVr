using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
public Camera fpcamera;

public float horizontalspeed;
public float verticalspeed;
public float speed;

float h;
float v;

    void Update()
    {
          h = horizontalspeed*Input.GetAxis("Mouse X");
          v = verticalspeed*Input.GetAxis("Mouse Y");

          transform.Rotate(0,h,0);
          fpcamera.transform.Rotate(-v,0,0);

          if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,0,speed);
          } else{
            if(Input.GetKey(KeyCode.S)){
              transform.Translate(0,0,-speed);
            } else{
              if(Input.GetKey(KeyCode.A)){
                transform.Translate(-speed,0,0);
              } else {
                if(Input.GetKey(KeyCode.D)){
                  transform.Translate(speed,0,0);
              }
            }

          }

    }
}
}
