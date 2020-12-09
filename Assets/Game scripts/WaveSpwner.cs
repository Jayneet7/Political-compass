using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}
public class WaveSpwner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public Animator animator;
    public Text waveName;
    public GameObject questionbox;
    public GameObject questionbox1;
    



    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool canSpawn = true;
    private bool canAnimate = false;


    public void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.noOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if (currentWave.noOfEnemies == 0)
            {
                canSpawn = false;
                canAnimate = true;
            }
        }

    }
    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;

    }

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("KILL");

        if (totalEnemies.Length == 0)
        {
            //SpawnNextWave();
            if (currentWaveNumber + 1 != waves.Length)
            {
                if (canAnimate)
                {
                    //Debug.Log("Wave number" + currentWaveNumber);
                    waveName.text = waves[currentWaveNumber + 1].waveName;
                    animator.SetTrigger("Wavefinished");
                    canAnimate = false;
                }

            }
            else
            {
                StartCoroutine(Timedelay());
            }


        }

    }

    IEnumerator Timedelay() 
    {
        yield return new WaitForSeconds(2);
        questionbox.SetActive(true);

    }

}


