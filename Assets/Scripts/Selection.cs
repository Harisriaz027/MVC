using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Selection : MonoBehaviour
{
    GameObject[] arr;
    int index = 0;

    public void Next(GameObject[] player,int a)
    {
        arr = player;
        index = a%arr.Length;
        arr[index].SetActive(false);
        index = (index + 1) % arr.Length;
        arr[index].SetActive(true);
    }

    public void Previous(GameObject[] player,int a)
    {
        arr = player;
        index = a%arr.Length;
        arr[index].SetActive(false);
        index--;
        if (index < 0)
        {
           index += arr.Length;
        }
        arr[index].SetActive(true);
    }
}
