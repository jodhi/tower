using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Spanner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public Text waveCountdownText;

    public float timeBetweenWaves = 3f;
    private float countdown = 0f;

    private int waveIndex = 0;

    void Update()
    {
        if (Mathf.Floor(countdown).ToString() == "0")
        {
            waveCountdownText.text = "Wave Coming";
        }
        else
        {
            waveCountdownText.text = "New Wave In " + Mathf.Floor(countdown).ToString();
        }
        
        if (countdown <= 0f)
        {
            StartCoroutine(SpanWave());
            countdown = timeBetweenWaves;
        }
        else
        {
            countdown -= Time.deltaTime;
        }
        

        
    }
    IEnumerator SpanWave()
    {
        waveIndex++;
        PlayerStats.Rounds++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.4f);
        }

        waveIndex++;
        Debug.Log("wave come");
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
