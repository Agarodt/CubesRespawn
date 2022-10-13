using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeSpeed : MonoBehaviour
{
    public float newSpeed;

    void Start()
    {
        GetComponent<InputField>().text = newSpeed.ToString();
    }



    void Update()
    {
        newSpeed = float.Parse(GetComponent<InputField>().text);

    }
}
