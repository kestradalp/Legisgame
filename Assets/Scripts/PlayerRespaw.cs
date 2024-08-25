using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespaw : MonoBehaviour
{
    private float checkPositionPositionX, checkPositionPositionY;
    public Animator animator;

    void Start()
    {
        if(PlayerPrefs.GetFloat("checkPositionPositionX")!=0){
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPositionPositionX"), PlayerPrefs.GetFloat("checkPositionPositionY")));
        }
    }
    public void reachedCheckPoint(float x, float y){
        PlayerPrefs.SetFloat("checkPositionPositionX", x);
        PlayerPrefs.SetFloat("checkPositionPositionY", y);
    }

    public void PlayerDamaged(){
        animator.Play("hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
