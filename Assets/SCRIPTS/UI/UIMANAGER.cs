using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMANAGER : MonoBehaviour
{

    private static float playerCamX1 = 0.38f;
    private static float playerCamY1 = 0.1f;
    private static float playerCamW1 = 0.25f;
    private static float playerCamH1 = 0.8f;

    private static float playerCamX2 = 0.05f;
    private static float playerCamY2 = 0.1f;
    private static float playerCamW2 = 0.25f;
    private static float playerCamH2 = 0.8f;

    public Camera playerCam;

    public Button character;
    public Button inventory;
    public Button crafting;
    public Button shop;
    public Button talent;
    public Button companions;

    public GameObject characterC;
    public GameObject inventoryC;
    public GameObject craftingC;
    public GameObject shopC;
    public GameObject talentC;
    public GameObject companionsC;

    public GameObject characterPanel;
    public GameObject inventoryPanel;
    public GameObject craftingPanel;
    public GameObject shopPanel;
    public GameObject talentPanel;
    public GameObject companionsPanel;

    public GameObject settingsPanel;
    public GameObject settingsButton;
    public GameObject closeSettings;

    void Start() {
        playerCam.enabled = false;
    }

    public void openSlider(){
        settingsPanel.SetActive(true);
        closeSettings.SetActive(true);
        settingsButton.SetActive(false);
    }

    public void closeSlider(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        settingsButton.SetActive(true);
    }

    public void characterMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        characterPanel.SetActive(true);
        characterC.SetActive(true);
        playerCam.enabled = true;
    }

    public void characterMenuC(){
        settingsButton.SetActive(true);
        characterC.SetActive(false);
        characterPanel.SetActive(false);
        playerCam.enabled = false;
    }

    public void inventoryMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        inventoryPanel.SetActive(true);
        inventoryC.SetActive(true);
    }

    public void inventoryMenuC(){
        settingsButton.SetActive(true);
        inventoryC.SetActive(false);
        inventoryPanel.SetActive(false);
    }

    public void craftingMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        craftingPanel.SetActive(true);
        craftingC.SetActive(true);
    }

    public void craftingMenuC(){
        settingsButton.SetActive(true);
        closeSettings.SetActive(false);
        craftingPanel.SetActive(false);
    }

    public void shopMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        shopPanel.SetActive(true);
        shopC.SetActive(true);
    }

    public void shopMenuC(){
        settingsButton.SetActive(true);
        shopC.SetActive(false);
        shopPanel.SetActive(false);
    }

    public void talentMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        talentPanel.SetActive(true);
        talentC.SetActive(true);
    }

    public void talentMenuC(){
        settingsButton.SetActive(true);
        talentC.SetActive(false);
        talentPanel.SetActive(false);
    }

    public void companionMenu(){
        settingsPanel.SetActive(false);
        closeSettings.SetActive(false);
        companionsPanel.SetActive(true);
        companionsC.SetActive(true);
    }

    public void companionMenuC(){
        settingsButton.SetActive(true);
        companionsC.SetActive(false);
        companionsPanel.SetActive(false);
    }

}
