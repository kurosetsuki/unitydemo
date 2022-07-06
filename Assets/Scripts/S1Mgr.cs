using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class S1Mgr : MonoBehaviour
{
    public Image square;
    public Button btnChangeColor;
    public Button btnSize;
    public Button btnRotation;

    private void Awake()
    {
        btnChangeColor.onClick.AddListener(OnbtnChangeColor1Click);
        btnSize.onClick.AddListener(OnbtnsizeClick);
        btnRotation.onClick.AddListener(OnbtnRotationClick);
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
    public void OnbtnChangeColor1Click()
    {
        Debug.Log("hello!");
        square.color = new Color(Random.Range(0.0f, 1.0f), 1, 0);
    }

    public void OnbtnsizeClick()
    {
        Debug.Log("size");
        square.transform.localScale = new Vector3(2, 2, 2);
    }

    public void OnbtnRotationClick()
    {
        int x = 0;
        int y = 360;
        Debug.Log("rotation");
        square.transform.rotation =
            new quaternion(0, 0, Random.Range(x, y));
    }
}