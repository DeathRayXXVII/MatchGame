using System.Security.Cryptography;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        RandomSpawnLocation();
    }

    private void RandomSpawnLocation()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        Instantiate(gameObject, spawnPos, gameObject.transform.rotation);
    }
}
