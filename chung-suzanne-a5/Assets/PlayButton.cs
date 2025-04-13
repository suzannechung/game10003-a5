using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame() 
    {
        //on click - change from main menu scene to game scene
        SceneManager.LoadSceneAsync(1);
    }
}
