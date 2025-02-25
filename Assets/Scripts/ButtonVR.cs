using UnityEngine;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    AudioSource sound;
    bool isPressed;
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }
    public void PressButton(){
        if(!isPressed){
            button.transform.position += new Vector3(0f, -0.01f, 0f);
            isPressed = true;
        }
       
    }
    public void ReleaseButton(){
        if(isPressed){
            button.transform.position -= new Vector3(0f, -0.01f, 0f);
            isPressed = false;
        }
        
    }
}
