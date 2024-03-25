using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    //so ova komanda se gase aplikacijata (igrata) ne nosi na start.
    public void QuitGame()
    {
        Application.Quit();
    }
}
