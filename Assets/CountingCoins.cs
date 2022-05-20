using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingCoins : MonoBehaviour
{
    public Text CountingCoinsText;
    public CoinTaker player;
    // Start is called before the first frame update
    void Start()
    {
        CountingCoinsText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CountingCoinsText.text = player.coinAmount.ToString();
    }
}
