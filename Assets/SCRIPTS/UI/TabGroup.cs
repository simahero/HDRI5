using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
   public List<TabButton> tabButtons;
   public List<GameObject> gameObjects;
   public TabButton selectedTab; 
   public Sprite idle;
   public Sprite hover;
   public Sprite selected;

    public void Subscribe(TabButton button){
        if(tabButtons == null){
            tabButtons = new List<TabButton>();
        }

    tabButtons.Add(button);

    }

    public void OnTabEnter(TabButton button){
        ResetTabs();
        if (selectedTab == null ||selectedTab != button){
        button.background.sprite = hover;
        }
    }

    public void OnTabExit(TabButton button){
        ResetTabs();
    }

    public void OnTabSelected(TabButton button){
        if (selectedTab != null){
            selectedTab.Deselect();
        }

        selectedTab = button;
        
        selectedTab.Select();
        
        ResetTabs();
        button.background.sprite = selected;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < gameObjects.Count; i++){
            if (i == index){
                gameObjects[i].SetActive(true);
            } else {
            gameObjects[i].SetActive(false);
            }
        }
    }

    public void ResetTabs(){
        foreach(TabButton button in tabButtons){
            if (button == selectedTab && selectedTab != null){continue;}
            button.background.sprite = idle;
        }
    }


}