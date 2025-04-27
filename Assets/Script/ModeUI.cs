using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeUI : MonoBehaviour
{
    public Image pressMode1;
    public Image pressMode2;
    public Image pressMode3;
    // Start is called before the first frame update
    void Start()
    {
        pressMode1.gameObject.SetActive(true);
        pressMode2.gameObject.SetActive(false);
        pressMode3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            pressMode1.gameObject.SetActive(true);
            pressMode2.gameObject.SetActive(false);
            pressMode3.gameObject.SetActive(false);
        }else if(Input.GetKeyDown(KeyCode.Alpha2)) {
            pressMode1.gameObject.SetActive(false);
            pressMode2.gameObject.SetActive(true);
            pressMode3.gameObject.SetActive(false);
        }else if(Input.GetKeyDown(KeyCode.Alpha3)) {
            pressMode1.gameObject.SetActive(false);
            pressMode2.gameObject.SetActive(false);
            pressMode3.gameObject.SetActive(true);
        }
    }
}
