using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeRespawnTimer : MonoBehaviour
{
    public float newTime;

    void Start()
    {
        GetComponent<InputField>().text = newTime.ToString();
    }


    void Update()
    {
        newTime = float.Parse(GetComponent<InputField>().text);
        

    }
}
