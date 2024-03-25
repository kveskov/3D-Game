using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    //ako finishot ima colider zavrsi ja igrata.
    private void OnTriggerEnter(Collider other)
    {
        //so ova koga kje stignime na finish line ne nosi na drug level koj se pravi so build settings.
        //drugiot level se kreira racno i se povrzuva preku ovie komandi.

        if(other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
