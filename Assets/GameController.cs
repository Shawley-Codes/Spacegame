using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector2 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float numberOfWaves;
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        for (int n = 0; n < numberOfWaves; n++)
        { 
        Debug.Log("Spawning wave " + n);
        {
            int i;
            for (i = 0; i < hazardCount; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            i = 0;
            yield return new WaitForSeconds(waveWait);
        }
    }
    }
}
