using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelectionChild : Selection 
{
    public GameObject[] playerSelected;
    [HideInInspector] public int playerIndex = 0;
    GunSelectionChild script;
    int gunIndexRefernce;
   
    private void Update()
    {
        gunIndexRefernce = script.gunIndex;
    }

    private void Start()
    {
        script= GameObject.Find("Guns").GetComponent<GunSelectionChild>();
    }

    public void NextPlayer()
    {
        Next(playerSelected,playerIndex++);
    }

    public void PreviousPLayer()
    {
        Previous(playerSelected,playerIndex--);
        if (playerIndex < 0)
        {
            playerIndex += playerSelected.Length;
        }
    }

    public void Play()
    {
        
        PlayerPrefs.SetInt("selectedPlayer", playerIndex%playerSelected.Length);
        PlayerPrefs.SetInt("selectedGun", gunIndexRefernce % playerSelected.Length);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}

