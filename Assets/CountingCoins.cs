using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingCoins : MonoBehaviour
{
    public GameObject UiObject;
    public int Counting;
    public Text CountingCoinsText;
    PlayerScript playerscipt;
    // Start is called before the first frame update
    void Start()
    {
        Counting += 1;
        CountingCoinsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CountingCoinsText.text = Counting.ToString();
    }
}
