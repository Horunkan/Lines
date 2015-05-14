﻿using UnityEngine;
using System.Collections;

public class debugMenu : MonoBehaviour 
{
    public bool active = false;
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active) hideMenu();
            else showMenu();
        }
	}

    //Add 100 points
    public void addPoints()
    {
        manager.points += 100;
    }

    //Substract 100 points
    public void substractPoints()
    {
        manager.points -= 100;
    }

    //Push new blocks
    public void pushBlocks()
    {
        manager.nextBlock.blocksToAdd = 4;
        hideMenu();
    }

    //Rand new nextBlocks colors
    public void randNew()
    {
        manager.nextBlock.randNewColor();
    }

    //Exit game button
    public void exitGame()
    {
        Application.Quit();
    }

    //Hide debug menu
    private void hideMenu()
    {
        active = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    //Display debug menu
    private void showMenu()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        active = true;
    }
}
