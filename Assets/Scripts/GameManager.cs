using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //Ressources for the game
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References
    public Player player;
    public FloatingTextManager floatingTextManager;

    //Logic
    public int pesos;
    public int experience;

    //save state
    /*
     * int preferedSkin
     * int pesos
     * int experience
     * int weaponLevel
     */

    //Floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            SceneManager.sceneLoaded += LoadState;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    
    public void SaveState()
    {
        string saveValue = "";

        saveValue += "0" + "|";
        saveValue += pesos.ToString() + "|";
        saveValue += experience.ToString() + "|";
        saveValue += "0";

        PlayerPrefs.SetString("SaveState", saveValue);
        
    }

    private void LoadState(Scene s, LoadSceneMode mode) 
    {
        if(PlayerPrefs.HasKey("SaveState"))
        {
            string[] data = PlayerPrefs.GetString("SaveState").Split('|');
            //ej: "0|10|15|2"  ---  {0,10,15,2}

            //Change player skin

            //Load pesos
            pesos = int.Parse(data[1]);

            //Load experience
            experience = int.Parse(data[2]);

            //Load weapon level
        }


    }
}
