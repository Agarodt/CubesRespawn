using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
   public float speedCorrection;
   public float SpeedCurrent;
   public float destroyDistance;
   public GameObject SpeedInput;
   public GameObject DistanceInput;

   void Start()
   {
    SpeedInput = GameObject.Find("SpeedInput");
    DistanceInput = GameObject.Find("DistanceInput");
   }


    void Update()
    {
        
        ///скорость
         SpeedCurrent = speedCorrection * Time.deltaTime;
         speedCorrection = SpeedInput.GetComponent<ChangeSpeed>().newSpeed;

        ///направление движения
         transform.Translate(Vector3.forward * SpeedCurrent);

        ///дистанция уничтожения
        destroyDistance = DistanceInput.GetComponent<ChangeDestroyDistance>().newDistance;
        if (gameObject.transform.position.z >= destroyDistance)
        {
            Destroy(gameObject);
        }

        
    }
}
