using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S1Mgr : MonoBehaviour
{
    public Button btn1;

    private void Awake()
    {
        btn1.onClick.AddListener(Onbtn1Click);
    }

    // Start is called before the first frame update
    void Start()
    {
        int childcount = this.transform.childCount;
        Debug.Log(childcount);

        for (int i = 0; i < childcount; i++)
        {
            Transform temp = this.transform.GetChild(i);
            Debug.Log(temp.name);
            if (temp.name == "Main Camera")
            {
                Camera camera = temp.GetComponent<Camera>();
                camera.fieldOfView = 200;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

//Function--------------------
    public void Onbtn1Click()
    {
        Debug.Log("hello!");
    }
}