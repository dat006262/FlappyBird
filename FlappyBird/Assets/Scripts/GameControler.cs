using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public bool isEndGame;
    bool isStartFirstTime=true;
    int GamePoint = 0;
    public Text txtPoint;
    public GameObject pannelEnd;
    public Text YourPoint;
    public Button btnRestart;
    public Button btnMenu;
    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStartFirstTime = true;
        pannelEnd.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        


        if (isEndGame)//true
        {

            if (Input.GetMouseButtonDown(0)&& isStartFirstTime)
            {
                StartGame();
                Debug.Log("load1");
            }

        }
        else
        {
                if (Input.GetMouseButtonDown(0))
                    Time.timeScale = 1;
            }
        
    }
    public void GetPoint()
    {
        GamePoint++;
        txtPoint.text = "Point:" + GamePoint.ToString();
    }    

    public void StartGame()
    {
        Debug.Log("23");
        SceneManager.LoadScene(0);
    }    
    public void ReStart()
    {
        Debug.Log("load");
        StartGame();
    }    
    public void endGame()
    {
        isEndGame = true;
        isStartFirstTime = false;
        Time.timeScale = 0;
        pannelEnd.SetActive(true);
        YourPoint.text = "Your point:\n" +GamePoint.ToString();
    }    

   public void ButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnIdle;
    }   
    public void ButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnHover;
    }   
    public void ButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnClick;
    }   
    
    
}
