using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionManager : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("A");  // Replace with the actual name of your game scene
    }
}
