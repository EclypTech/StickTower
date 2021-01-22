using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // It used when we create main menu which means new scenes.

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    public GameObject pauseMenuUI; // Define game object which means canvaspause.

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
        // This part for computer. We can remove.(trigger function when click esc.)
        {
            if(GameIsPaused) // If..
            {
                Resume(); // Resume if game is pause.
            }else
            {
                Pause(); // Pause the game if game is fies.
            }
        }
    }

    public void Resume () // Resume button function.
    {
        pauseMenuUI.SetActive(false); // Close the pause menu.
        Time.timeScale = 1f;          // Resume the time.
        GameIsPaused = false;         // Value is false.
    }

    public void Pause ()  // Pause function.
    {
        pauseMenuUI.SetActive(true);  // Open the pause menu.
        Time.timeScale = 0f;          // Freeze the time.
        GameIsPaused = true;          // Value is true.
    }

    public void LoadMenu() // Main menu function. Triggered in the pause menu.
    {
        Time.timeScale = 1f;  // Solve freeze in the main menu. Time flies.
        Debug.Log("Loading menu...");
        // SceneManager.LoadScene("MainMenu");
        // We use upper command when we create main manu scene.
    }

    public void QuitGame() // Quit game function. Triggered in the pause menu.
    {
        Debug.Log("Quiting Game..."); // Command.
        Application.Quit(); //Quit game. It didnt works in the editor part.
    }

    public void PauseButton() // Assign this function to button where means in to the game scene upper right.
    {
        Pause(); // Pause function.(Line33)
    }
}
