using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject arCamera;
    //public GameObject smoke;

    public void Shooting()
    {
        RaycastHit hit; //variable of type raycasthit

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Balloon1(Clone)" || hit.transform.name == "Balloon2(Clone)" || hit.transform.name == "Balloon3(Clone)")
            {
                Destroy(hit.transform.gameObject);

                //Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
