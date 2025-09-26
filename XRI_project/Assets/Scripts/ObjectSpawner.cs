using UnityEngine;
using UnityEngine.XR;

/* 
Select to spawn 
TODO:Where object spawns
Cooldown period
Input - Button
Hand
*/


public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // object to spawn
    public Transform spawnPoint; //Where it spawns
    public XRNode controllerNode = XRNode.RightHand;
    public float spawnCooldown = 1.0f; // Need a coroutine 
    private bool canSpawn = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
