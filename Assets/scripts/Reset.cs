using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

    public Camera player;

    public void ResetModelPositions()
    {
        Vector3 pos = new Vector3(-14, 2, -38);
        player.transform.position = pos;
        Quaternion qon = new Quaternion(0, 90, 0, 0);
        player.transform.rotation = qon;
    }

    public void GoToRoom1()
    {
        Vector3 pos = new Vector3(-5, 2, -8);
        player.transform.position = pos;
        Quaternion qon = new Quaternion(0, 90, 0, 0);
        player.transform.rotation = qon;
    }

    public void GoToRoom2()
    {
        Vector3 pos = new Vector3(12, 2, -37);
        player.transform.position = pos;
        Quaternion qon = new Quaternion(0, 90, 0, 0);
        player.transform.rotation = qon;
    }

    public void GoToRoom3()
    {
        Vector3 pos = new Vector3(-5, 2, -21);
        player.transform.position = pos;
        Quaternion qon = new Quaternion(0, 90, 0, 0);
        player.transform.rotation = qon;
    }

}
