using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource HeroicIntrusionSound;
        // Start is called before the first frame update
    void Start()
    {
        HeroicIntrusionSound = GetComponent<AudioSource>(); 
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.name == "Player")
        { 
        HeroicIntrusionSound.Play();
        Completelevel();
        }
	}
	private void Completelevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
