using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    void Start()
    {
        int playerLives = 3;

        while (playerLives > 0)
        {
            if (playerLives == 3)
            {
                Debug.Log("Many lives");
            }
            else if (playerLives == 1)
            {
                Debug.Log("The last life");
            }
            playerLives--; 
        }
        
        Debug.Log(" Game Over:( ");
    }
}


