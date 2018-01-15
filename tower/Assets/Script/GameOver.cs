using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text roundsText;
	
	// Update is called once per frame
	void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
	}

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Debug.Log("Go to Menu.");
        SceneManager.LoadScene("MainMenu");
    }
}
