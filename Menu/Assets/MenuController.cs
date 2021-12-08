using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Player;

    public void OpenMenu()
    {
        Menu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnToGame()
    {
        Menu.SetActive(false);
    }

    public void RespawnPlayer()
    {
        Player.transform.position = new Vector3();
    }
}
