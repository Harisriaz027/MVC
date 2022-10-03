using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareFollow : MonoBehaviour
{
    float mouseX, mouseY;
    LoadCharacter lc;
    float xRotation;
    void Start()
    {
        lc = GameObject.Find("Game Manager").GetComponent<LoadCharacter>();
    }

    
    void Update()
    {
        GameObject playerFollow = lc.clone;
        mouseX = Input.GetAxis("Mouse X")*150*Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")*150*Time.deltaTime;
        playerFollow.transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        
        gameObject.transform.SetParent(playerFollow.transform);
        
    }
}
