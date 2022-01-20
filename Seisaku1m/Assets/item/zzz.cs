using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zzz : MonoBehaviour
{
    public GameObject cam;
    public GameObject image;
    public GameObject Panel;

    //座標の指定
    private float move_x = -1.529f;
    private float move_y = 2.133f;
    private float move_z = 1.808f;
    private float angle_x = -34.271f;

    void Start(){
        image = GameObject.Find("Image");
        Panel = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.G)){
            cam.transform.position = new Vector3(move_x, move_y, move_z);
            cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);
            Panel.GetComponent<Fade>().StartFadeOut();
            image.GetComponent<cloase>().imageActive();
        }
    }
}
