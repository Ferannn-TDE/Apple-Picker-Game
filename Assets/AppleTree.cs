using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Inscribed")]
    // Prefab for instantiating apples
    public GameObject applePrefab;
    // Prefab for instantiating branches
    public GameObject branchPrefab;
    
    // Speed at which the AppleTree moves
    public float speed = 1f;
    
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    
    // Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;
    
    // Seconds between Apples instantiations
    public float appleDropDelay = 1f;
    
    // Chance that a branch will drop instead of an apple (0.1 = 10%)
    [Range(0f, 1f)]
    public float branchDropChance = 0.15f;
    
    void Start() {
        // Start dropping apples
        Invoke("DropApple", 2f);
    }
    
    void DropApple() {
        // Randomly decide whether to drop a branch or an apple
        GameObject prefabToUse;
        if (branchPrefab != null && Random.value < branchDropChance) {
            prefabToUse = branchPrefab;
        } else {
            prefabToUse = applePrefab;
        }
        
        if (prefabToUse != null) {
            GameObject fallingObject = Instantiate<GameObject>(prefabToUse);
            fallingObject.transform.position = transform.position;
        }
        
        Invoke("DropApple", appleDropDelay);
    }
    
    void Update() {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        
        // Changing Direction
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Move right
        } else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed); // Move left
        }
    }
    
    void FixedUpdate() {
        // Random direction changes are now time-based due to FixedUpdate()
        if (Random.value < changeDirChance) {
            speed *= -1; // Change direction
        }
    }
}