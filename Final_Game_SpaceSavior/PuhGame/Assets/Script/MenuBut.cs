using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBut : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextLevel() 
    {
        SceneManager.LoadScene("Game Scene");
    }
    public void NextMenu()
    {
        SceneManager.LoadScene("Game Menu");
    }
    public void NextCredit() 
    {
        SceneManager.LoadScene("Credit Scene");
    }
    public void NextExit()
    {
        Application.Quit();
    }
}
