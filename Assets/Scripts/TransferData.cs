using UnityEngine;
using UnityEngine.UI;

public class TransferData : MonoBehaviour
{
    [SerializeField]
    private Text contentPlayerPrefsText;
    [SerializeField]
    private Text contentLocalStorageText;

    public void ClickSetPlayerPrefsHandler()
    {
        PlayerPrefs.SetString("command", "This is test work PlayerPrefs. Time " + Time.time);
    }

    public void ClickGetPlayerPrefsHandler()
    {
        contentPlayerPrefsText.text = PlayerPrefs.GetString("command", "Not work. Time " + Time.time);
    }

    public void ClickSetLocalStorageHandler()
    {
        Application.ExternalCall("setLocalStorage", "This is test work ExternalCall. Time " + Time.time);
    }

    public void GetLocalStorage(string message)
    {
        contentLocalStorageText.text = message;
    }

    public void ClickOpenWindow()
    {
        Application.ExternalCall("openWindow");
    }
}