/* Script for Loading the second level
 * Includes a fade to black animation 
 * as well as a delay
 * 
 * @author Thomas Grady
 *  student number 24452238
 *  
 *  Last updated: 28 / 12 / 2021
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    // delay for the animation
    public float transitionTime;

    public void OnTriggerEnter(Collider other)
    {
        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        // Set scene index in unity.
        // This method is better if you have multiple scenes.
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // Adding a delay to the animation
    IEnumerator LoadLevel(int levelIndex)
    {
        // Play animation
        transition.SetTrigger("Start");

        // Delay of the animation
        yield return new WaitForSeconds(transitionTime);

        // Loads the next scene
        SceneManager.LoadScene(levelIndex);
    }

}
