using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;

    private bool isShowingMenu = false;

    public TMP_Text Title;
    public TMP_Text Message;

    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        // Ban đầu chưa hiển thị popup
        GameMenu.enabled = isShowingMenu;

        // Nội dung popup
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";

        // Nội dung 2 button
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }


    public void ShowGameMenu()
    {
        isShowingMenu = true;
        GameMenu.enabled = true;
    }

    // Nút Restart: load lại scene hiện tại
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Nút Enter: chuyển sang scene tiếp theo
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}