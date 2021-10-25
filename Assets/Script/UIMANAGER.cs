
using UnityEngine;
using UnityEngine.UI;

public class UIMANAGER : MonoBehaviour
{
    public static UIMANAGER instance { get; private set; } = null;

    public Text _timerText = null;

    private Text timerText { get { return _timerText; } set { _timerText = value; } }
    private void Start()
    {
        
    }


    private void Awake()
    {
        instance = this;
    }



    private void Update()
    {
        
    }
    public void SetTimer(float time)
    {
        timerText.text = "Timer" + time.ToString("F1");
    }
}

