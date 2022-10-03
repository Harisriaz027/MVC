    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRay : MonoBehaviour
{
   
    public Vector3 mousePos;
    private LoadCharacter loadCharacterScript;
    void Start()
    {
        loadCharacterScript = GameObject.Find("Game Manager").GetComponent<LoadCharacter>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        //var origion = loadCharacterScript.gunclone.transform.position;
       Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, loadCharacterScript.gunclone.GetComponent<Renderer>().material.color,50);
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit))
            {
                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log(hit.transform.name);
                    Destroy(hit.transform.gameObject);
                }
                
            }
            
        }
    }
}
