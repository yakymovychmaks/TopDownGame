using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficultGame : MonoBehaviour
{
    private static readonly string SetDamage = "SetDamage";
    private static readonly string SetSpead = "SetSpead";
    // public Dropdown drops;
    
    public void SetsDifficults(int index)
    {
        
        switch (index)
        {
            case 0:   PlayerPrefs.SetInt("SetDamage", 5);
                      PlayerPrefs.SetFloat("SetSpead", 2f);
                    break;

            // case 1: PlayerPrefs.SetInt("SetDamage", 10);
            //         PlayerPrefs.SetFloat("SetSpead", 5f);
            //         break;
        }
    }
}
