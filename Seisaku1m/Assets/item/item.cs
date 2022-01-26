using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public GameObject cam;
    public GameObject iphone;
    public GameObject image;
    public GameObject Panel;
    public AudioClip sound1;
    AudioSource audioSource;

    int a;
    public float sleeptime = 5.0f;
    public float itime = 3.0f;
    public float mtime = 6.0f;
    public float gtime = 10.0f;
    float time;

    private float move_x = -7.032f;
    private float move_y = 2.28f;
    private float move_z = 4f;

    private float angle_x;
    private float imove_x, imove_y, imove_z;
    private float iangle_x, iangle_y, iangle_z;

    public bool audioflag = false, flag = false;

    void Start(){
        time = 0f;
        image = GameObject.Find("Image");
        Panel = GameObject.Find("Panel");
        Panel.GetComponent<Fade>().isFadeOut = false;
        audioSource = GetComponent<AudioSource>();
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.JoystickButton1)){
            a = 1;
            flag = true;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton0)){
            a = 2;
            flag = true;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton2)){
            a = 3;
            flag = true;
        }
        if(Input.GetKeyDown(KeyCode.JoystickButton3)){
            a = 4;
            flag = true;
        }
        //if(flag == true){
            switch(a){
                //眠る
                case 1:
                    flag = false;
                    angle_x = -34.271f;
                    cam.transform.position = new Vector3(move_x, move_y, move_z);
                    cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);
                    time += Time.deltaTime;
                    if(time < sleeptime){
                        Debug.Log(time);
                        Panel.GetComponent<Fade>().isFadeOut = true;
                        image.GetComponent<cloase>().imageActive();
                        if(audioflag == false){
                            audioSource.PlayOneShot(sound1);
                            audioflag = true;
                        }
                        if(Panel.GetComponent<Fade>().alfa >= 1 ){
                            Panel.GetComponent<Fade>().isFadeOut = false;
                        }
                    }
                    if(time >= sleeptime){
                        flag = true;
                        audioflag = false;
                        Panel.GetComponent<Fade>().isFadeIn = true;
                        image.GetComponent<cloase>().imageHide();
                        audioSource.Pause();
                        if(Panel.GetComponent<Fade>().alfa <= 0){
                            Panel.GetComponent<Fade>().isFadeIn = false;
                        }
                    }

                    break;
                //すまほ
                case 2:
                    //flag = false;
                    angle_x = 38.812f;

                    imove_x = -7.05f;
                    imove_y = 1.761f;
                    imove_z = 3.421f;
                    iangle_x = 58.21f;
                    iangle_y = 0.387f;
                    iangle_z = 0.189f;

                    if(time < itime){
                        time += Time.deltaTime;
                        iphone.transform.position = new Vector3(imove_x,imove_y,imove_z);
                        iphone.transform.rotation = Quaternion.Euler(iangle_x,iangle_y,iangle_z);
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);
                    }

                    if(time >= itime){
                        time = 0f;
                        //初期値
                        //Initialize();
                        flag = true;
                    }
                    break;
                //ゲーム
                case 3:
                    flag = true;
                    if(time < gtime){
                        time += Time.deltaTime;
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(-180,0,180);
                    }

                    if(time >= gtime){
                        time = 0f;
                        //初期値
                        //Initialize();
                        flag = true;
                    }

                    break;
                //ネット
                case 4:
                    flag = true;
                    if(time < mtime){
                        time += Time.deltaTime;
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(-180,0,180);
                    }

                    if(time >= mtime){
                        time = 0f;
                        //初期値
                        //Initialize();
                        flag = true;
                    }
                    break;
            }
        //}
    }

    public void Initialize(){
        //angle_x;
        imove_x = 2.74f;
        imove_y = 1.5536f;
        imove_z = 6.0749f;
        iangle_x = 0f;
        iangle_y = 37.744f;
        iangle_z = 0f;
        //time = 0f;
        //iphone.transform.position = new Vector3(imove_x,imove_y,imove_z);
        //iphone.transform.rotation = Quaternion.Euler(iangle_x,iangle_y,iangle_z);
    }
}
