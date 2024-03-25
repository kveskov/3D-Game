using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PayerLife : MonoBehaviour

{

    [SerializeField] AudioSource deathSound;

    bool dead = false;
    private void Update()
    {
        //ova e koga ke padnime na zemjata dane pusti odpocetok na levelol.
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //ako ja cepnime crvenata kocka umirame ili respawn ni prave od pocetok.
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }
    //ova e za da ukluce komandite sto se mesh render rigidbody ako e true ili false.
    void Die()
    {
        
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        deathSound.Play();
        

    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


