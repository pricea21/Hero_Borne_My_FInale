using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Behavior : MonoBehaviour
{
    //1
    public string labelText;
    public int maxItems = 1;

    public bool showWinScreen = false;
    public bool showLossScreen = false;


    private int _itemsCollected = 0;
    public int Items
    {
        //2
        get { return _itemsCollected; }
        //3
        set
        {
            _itemsCollected = value;
            //2
            if (_itemsCollected >= maxItems)
            {
                labelText = "You've found all the items!";
                //2
                showWinScreen = true;

                //2
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found, only" + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }
    private int _playerHP = 10;
    //4
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    //3
    void OnGUI()
    {
        //4
        GUI.Box(new Rect(20, 20, 250, 25), "Player Health:" + _playerHP);
        //5
        GUI.Box(new Rect(20, 50, 250, 25), "Items Collected: " + _itemsCollected);
        //6
        GUI.Label(new Rect(Screen.width / 20 - 200, Screen.height - 100, 300, 100), labelText);
        //3
        if (showWinScreen)
        {
                SceneManager.LoadScene(2);
                Time.timeScale = 1.0f;
         
        }
        if (showLossScreen)
        {
                SceneManager.LoadScene(3);
                Time.timeScale = 1.0f;
        }
    }
}
