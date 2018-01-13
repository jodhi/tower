using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave_Spanner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public Text waveCountdownText;

    public float timeBetweenWaves = 3f;
    private float countdown = 2f;

    private int waveIndex = 0;

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpanWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;

        waveCountdownText.text = "New Wave In "+Mathf.Floor(countdown).ToString();
    }
    IEnumerator SpanWave()
    {
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
