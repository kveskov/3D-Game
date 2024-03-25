using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void StartGame()
    {
        //ova e koga kje stisnis startuvaj pocinja igrata od staza 1.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
