using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class players 
{
    public string playerName;
    public int health;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++; 
    }
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(playerName + "Health has increased: " + amount + "Health now " + health);
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log(playerName + " Health fully restored to 100.");
        }
    }
    public static void ShowPlayerCount()
    {
        Debug.Log("total number players: " + playerCount);
    }
}
