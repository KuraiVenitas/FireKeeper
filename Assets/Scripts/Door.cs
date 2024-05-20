using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public Torch[] gameObjects;
    public List<bool> litObjects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // The following code checks if all torch objects are lit. If so, the player can progress to the next level.
        if (collision.CompareTag("Player") && !litObjects.Contains(false) && litObjects.Count != 0 && litObjects.Count == gameObjects.Length)
        {
            SceneManager.LoadScene(0);
        }
    }
}
