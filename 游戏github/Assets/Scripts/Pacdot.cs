using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour
{
    private GameManager gm;
    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (gm == null) Debug.Log("Energizer did not find Game Manager!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "blinky" || other.name == "inky" || other.name == "pinky" || other.name == "clyde")
        {
            GameManager.score += 0;
            GameObject[] pacdots = GameObject.FindGameObjectsWithTag("pacdot");
            gm.ScareGhosts();
            Destroy(gameObject);

            /*if (pacdots.Length == 1)
		    {
		        GameObject.FindObjectOfType<GameGUINavigation>().LoadLevel();
		    }*/
        }
    }
}
