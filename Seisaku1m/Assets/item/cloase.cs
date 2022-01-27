using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloase : MonoBehaviour
{
    Image fadeImage;

    void Start(){
        fadeImage = GetComponent<Image> ();
    }
    public void imageActive(){
        fadeImage.enabled = true;
    }

    public void imageHide(){
        fadeImage.enabled = false;
    }
}
