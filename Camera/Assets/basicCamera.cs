using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicCamera : MonoBehaviour
{
    [SerializeField] GameObject thisCamera;
    int x = 0;

    private void Awake()
    {
        thisCamera.transform.position = new Vector3(-15f, 25, -15f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            x += 1;
        }
        if (Input.GetMouseButtonDown(1) && x == 1)
        {
            thisCamera.transform.Rotate(0.0f, 270.0f, 0.0f);
            thisCamera.transform.position = new Vector3(25f, 25f, 25f);
        }
        if (Input.GetMouseButtonDown(1) && x == 2)
        {
            thisCamera.transform.Rotate(0.0f, 270.0f, 0.0f);
            thisCamera.transform.position = new Vector3(15f, 25f, 65f);
        }
        if (Input.GetMouseButtonDown(1) && x == 3)
        {
            thisCamera.transform.Rotate(0.0f, 270.0f, 0.0f);
            thisCamera.transform.position = new Vector3(-55f, 25f, 25f);
        }
        if (Input.GetMouseButtonDown(1) && x == 4)
        {
            thisCamera.transform.Rotate(0.0f, 270.0f, 0.0f);
            thisCamera.transform.position = new Vector3(-15f, 25f, -15f);
            x = 1;
        }
    }
}
