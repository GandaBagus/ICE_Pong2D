using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Main Menu Panel List")]
    public GameObject MainPanel;
    public GameObject HTPPanel;
    public GameObject TimerPanel;
    public GameObject BallPanel;
    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
    }

    public void SingePlayerButton()
    {
        GameData.instance.isSinglePlayer = true;
        TimerPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();

    }

    public void MultiPlayerButton()
    {
        GameData.instance.isSinglePlayer =  false;
        TimerPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }
    
    public void BackButton()
    {
        MainPanel.SetActive(true);
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }
    
    public  void  SetTimerButton(float Timer)
    {
        GameData.instance.gameTimer = Timer;
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        MainPanel.SetActive(false);
        BallPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }

    public  void  SetBallButton(GameObject obj)
    {
        GameData.instance.prefab = obj;
        HTPPanel.SetActive(true);
        TimerPanel.SetActive(false);
        MainPanel.SetActive(false);
        BallPanel.SetActive(false);
        
        SoundManager.instance.UIClickSfx();
    }

    public void BackButtonBall()
    {
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(true);
        BallPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }

    public void BackButtonHTP()
    {
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        BallPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("2. Gameplay");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
