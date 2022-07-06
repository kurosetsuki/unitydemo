using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1=>" + this.transform.name); //D
        Debug.Log("2=>" + this.transform.parent.name); //B
        Debug.Log("3=>" + this.transform.parent.parent.name); //A

        GameObject a = this.transform.parent.parent.gameObject;

        int childCount = a.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            string name = a.transform.GetChild(i).name;

            switch (name)
            {
                case "B":
                    break;
                case "C":
                    Debug.Log("Get C");
                    break;
            }
        }

        this.transform.parent = a.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
