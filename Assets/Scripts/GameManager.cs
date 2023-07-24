using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if(GameManager.instance != null)
        {
            //Destroy(gameObject);
        }
        else
        {
            instance = this;
            //SceneManager.sceneLoaded += LoadState;
            //DontDestroyOnLoad(gameObject);
        }
        
    }

    //Ressources for the game
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //References
    public Player player;

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
    public void SaveState()
    {
        string saving = "";
    }

    public void LoadState() 
    {
        Debug.Log("Load State");
    }
}
