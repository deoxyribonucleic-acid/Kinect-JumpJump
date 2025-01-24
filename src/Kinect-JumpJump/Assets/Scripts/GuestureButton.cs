using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GuestureButton : MonoBehaviour
{

    private CubeGestureListener glistener;
    private bool isGameOver = false;
    private long configureUserID = 0;
    private int playerIndex = 0;

    public void callGameOver()
    {
        isGameOver = true;
        configureUserID = glistener.sendUserID();
        glistener.ResetDetectionManual(configureUserID,playerIndex);
        glistener.StartDetectionManual(configureUserID,playerIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        glistener = CubeGestureListener.Instance;
        playerIndex = glistener.playerIndex;
        //glistener.ResetDetectionManual(configureUserID,playerIndex);
        isGameOver = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (glistener == null)
        {
            Debug.Log("CubeGestureListener is null");
        }
        if (isGameOver && (glistener.IsSwipeLeft() || glistener.IsSwipeRight()))
        {
            isGameOver = false;
            SceneManager.LoadScene(0);
            glistener.ResetDetectionManual(configureUserID,playerIndex);
        }
    }
}
