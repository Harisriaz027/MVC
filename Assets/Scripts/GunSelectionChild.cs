using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSelectionChild : Selection
{
    public GameObject[] gunSelected;
    [HideInInspector]public int gunIndex = 0;

    public void NextGun()
    {
        Next(gunSelected,gunIndex++);
    }

    public void PreviousGun()
    {
        Previous(gunSelected,gunIndex--);
        if (gunIndex < 0)
        {
            gunIndex += gunSelected.Length;
        }
    }
}
