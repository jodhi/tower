using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour {

    public Text livesText;

	// Update is called once per frame
	void Update () {
        if (PlayerStats.Lives >= 0)
        {
            livesText.text = "Lives: " + PlayerStats.Lives.ToString();
        }

        
	}
}
 