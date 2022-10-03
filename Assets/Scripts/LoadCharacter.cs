using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : Selection
{
    public GameObject[] playerPrefabs;
    public GameObject[] gunPrefabs;
    public GameObject clone;
    public GameObject gunclone;

    void Start()
    {
        int selectedcharacter = PlayerPrefs.GetInt("selectedPlayer");
        int selectedgun = PlayerPrefs.GetInt("selectedGun");
        GameObject prefab = playerPrefabs[selectedcharacter];
        GameObject gunprefab = gunPrefabs[selectedgun];
        prefab.SetActive(true);
        gunprefab.SetActive(true);
        clone = Instantiate(prefab, new Vector3(0, 1, 0), prefab.transform.rotation);
        gunclone = Instantiate(gunprefab, clone.transform.position + new Vector3(.5f, 0, 0.5f), gunprefab.transform.rotation);
        gunclone.transform.parent = Camera.main.transform;
    }
}
