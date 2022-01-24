using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    private
    int i;
    public RectTransform Menubur;
    int Menu_Num = 0;
    bool Push_flag = false;
    int Event;
    private bool inGame;


    [SerializeField]
    private GameObject EventSystems;

    //　ポーズした時に表示するUI
    [SerializeField]
    private GameObject pauseUI;


    public object Button1 { get; private set; }

    // private void Start() {  }

    void Start()
    {
        pauseUI.SetActive(false);
        Invoke("Update", 4);
    }
    // Update is called once per frame


    void Update()
    {

        if (Input.GetKeyDown("joystick button 7"))

        {

            pauseUI.SetActive(!pauseUI.activeSelf);
            i = (i + 1) % 2;
            if (pauseUI.activeSelf) { Time.timeScale = 0f; }
            else { Time.timeScale = 1f; }
        }



        if (i == 1)
        {
            //　ポーズUIのアクティブ、非アクティブを切り替え
            if (Input.GetKey(KeyCode.Alpha1)) { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
        }
    }
}
