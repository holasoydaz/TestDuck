using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CountManager : MonoBehaviour
{
    public TextMeshProUGUI countText; 
    public Button button;
    public int count;
    void Start()
    {
        button.onClick.AddListener(AddCount);
    }
public void AddCount()
    { 
        count++;
        countText.text = count.ToString();
    LeanTween.cancel(button.gameObject);
      LeanTween.scale(button.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.1f).setOnComplete(() =>
        {
            LeanTween.scale(button.gameObject, new Vector3(1,1,1), 0.1f);
        });
    }
    
}
