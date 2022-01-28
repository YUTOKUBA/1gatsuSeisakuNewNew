using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class item : MonoBehaviour
{
    public GameObject cam;
    public GameObject iphone;
    public GameObject image,game,net,inet,camera;
    public GameObject Panel;
    public AudioClip sound1;
    AudioSource audioSource;

    int a,savage;
    public float sleeptime = 5.0f;
    public float itime = 60.0f;
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
        savage = 0;
        flag = true;
        image = GameObject.Find("Image");
        Panel = GameObject.Find("Panel");
        game = GameObject.Find("game");
        net = GameObject.Find("net");
        inet = GameObject.Find("inet");
        camera = GameObject.Find("camera");
        Panel.GetComponent<Fade>().isFadeOut = false;
        audioSource = GetComponent<AudioSource>();
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(flag == true){
            if(Gamepad.current.rightShoulder.wasPressedThisFrame){
                savage++;
            }
            else if(Gamepad.current.leftShoulder.wasPressedThisFrame){
                savage--;
            }
            if(savage >= 6){
                savage = 0;
            }
            else if(savage < 0){
                savage = 5;
            }
        }

        if(savage == 0 && Gamepad.current.buttonEast.wasPressedThisFrame){
            time = 0f;
            a = 3;
            flag = true;
        }
        else if(savage == 1 && Gamepad.current.buttonEast.wasPressedThisFrame){
            time = 0f;
            a = 2;
            flag = true;
        }
        else if(savage == 2 && Gamepad.current.buttonEast.wasPressedThisFrame){
            time = 0f;
            a = 4;
            flag = true;
        }
        else if(savage == 3 && Gamepad.current.buttonEast.wasPressedThisFrame){
            time = 0f;
            a = 1;
            flag = true;
        }
        else if(savage == 4 && Gamepad.current.buttonEast.wasPressedThisFrame){
            a = 5;
        }

        //選択中
        //if(flag == true){
            switch(a){
                //眠る
                case 1:
                    flag = false;
                    angle_x = -34.271f;
                    cam.transform.position = new Vector3(move_x, move_y, move_z);
                    cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);
                    time += Time.deltaTime;
                    if(flag == false){
                        if(time < sleeptime){
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
                    flag = false;
                    angle_x = 38.812f;

                    imove_x = -7.04f;
                    imove_y = 2.295f;
                    imove_z = 3.119f;
                    iangle_x = 63.989f;
                    iangle_y = 0.465f;
                    iangle_z = 0.278f;
                    time += Time.deltaTime;
                    

                    if(time < itime){
                        iphone.transform.position = new Vector3(imove_x,imove_y,imove_z);
                        iphone.transform.rotation = Quaternion.Euler(iangle_x,iangle_y,iangle_z);
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(angle_x,-180,0);
                        inet.GetComponent<cloase>().imageActive();
                    }

                    if(time >= itime){
                        //初期値
                        //Initialize();
                        flag = true;
                        imove_x = -7.834f;
                        imove_y = 2.063f;
                        imove_z = 3.09f;
                        iangle_x = 0f;
                        iangle_y = 37.744f;
                        iangle_z = 0f;
                        iphone.transform.position = new Vector3(imove_x,imove_y,imove_z);
                        iphone.transform.rotation = Quaternion.Euler(iangle_x,iangle_y,iangle_z);

                        inet.GetComponent<cloase>().imageHide();
                    }
                    break;
                //ゲーム
                case 3:
                    flag = false;
                    time += Time.deltaTime;
                    
                    if(time < gtime){
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(-180,0,180);
                        game.GetComponent<cloase>().imageActive();
                    }

                    if(time >= gtime){
                        //初期値
                        //Initialize();
                        flag = true;
                        game.GetComponent<cloase>().imageHide();
                    }

                    break;
                //ネット
                case 4:
                    flag = false;
                    time += Time.deltaTime;
                    
                    if(time < mtime){
                        net.GetComponent<cloase>().imageActive();
                        cam.transform.position = new Vector3(move_x, move_y, move_z);
                        cam.transform.rotation = Quaternion.Euler(-180,0,180);
                    }

                    if(time >= mtime){
                        net.GetComponent<cloase>().imageHide();
                        //初期値
                        //Initialize();
                        flag = true;
                    }
                    break;

                case 5:
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
