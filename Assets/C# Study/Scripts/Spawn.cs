using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject target;
    void Start()
    {
        GameObject instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);

        instance.GetComponent<Rigidbody>().AddForce(0, 1000, 0);

        Debug.Log("Instance name: " + instance.name);
    }
}
