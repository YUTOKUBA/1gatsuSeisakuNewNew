using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject cam;
    public GameObject iphone;

    int a;

    private float move_x = -7.032f;
    private float move_y = 2.28f;
    private float move_z = 4f;

    private float angle_x;
    private float imove_x;
    private float imove_y;
    private float imove_z;
    private float iangle_x;
    private float iangle_y;
    private float iangle_z;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.JoystickButton0)){
            a = 1;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton1)){
            a = 2;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton3)){
            a = 3;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton2)){
            a = 4;
        }
        switch(a){
            //眠る
            case 1:
                angle_x = -34.271f;

                cam.transform.position = new Vector3(move_x, move_y, move_z);
                cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);

                break;
            //すまほ
            case 2:
                angle_x = 38.812f;

                imove_x = -7.05f;
                imove_y = 1.761f;
                imove_z = 3.421f;
                iangle_x = 58.21f;
                iangle_y = 0.387f;
                iangle_z = 0.189f;

                iphone.transform.position = new Vector3(imove_x,imove_y,imove_z);
                iphone.transform.rotation = Quaternion.Euler(iangle_x,iangle_y,iangle_z);
                cam.transform.position = new Vector3(move_x, move_y, move_z);
                cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);

                break;
            //ゲーム
            case 3:
                cam.transform.position = new Vector3(move_x, move_y, move_z);
                cam.transform.rotation = Quaternion.Euler(-180,0,180);

                break;
            //ネット
            case 4:
                cam.transform.position = new Vector3(move_x, move_y, move_z);
                cam.transform.rotation = Quaternion.Euler(-180,0,180);

                break;
        }
    }
}
