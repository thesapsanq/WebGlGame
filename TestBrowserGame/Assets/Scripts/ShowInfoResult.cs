using UnityEngine;
using UnityEngine.SceneManagement;



public class ShowInfoResult : MonoBehaviour
{

    private void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUIStyle gUIStyle = new GUIStyle();
        Font myFont = (Font)Resources.Load("Fonts/impact2", typeof(Font));
        gUIStyle.font = myFont;
        switch (PlayerFinishOrLose.finish)
        {
            case 1:
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 250, 50), $"Вы выиграли! Ваше время:{PlayerFinishOrLose.timer.TotalSeconds}", gUIStyle);
                break;
            case 2:
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 150, 50), $"Вы проиграли!", gUIStyle);
                break;
            default:
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 150, 50), $"Вы еще не играли!", gUIStyle);
                break;
        }

        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
    }
}
