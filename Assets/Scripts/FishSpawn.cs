using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private FishDestroy _fishPrefab;

    private float _spawnTime = 2f;

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }

    private IEnumerator StartSpawn() 
    {
        var waitTime = new WaitForSeconds(_spawnTime);
        int randomPoint = UnityEngine.Random.Range(0, _spawnPoints.Length);

        Instantiate(_fishPrefab, _spawnPoints[randomPoint].transform.position, Quaternion.identity);

        yield return waitTime;

        StartCoroutine(StartSpawn());
    }

}
