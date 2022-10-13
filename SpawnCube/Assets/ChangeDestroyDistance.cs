using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeDestroyDistance : MonoBehaviour
{
    public float newDistance;

    void Start()
    {
        GetComponent<InputField>().text = newDistance.ToString();
    }



    void Update()
    {
        newDistance = float.Parse(GetComponent<InputField>().text);

    }
}
