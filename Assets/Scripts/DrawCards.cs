using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject OpponentArea;
    
    // Start is called before the first frame update
    void Start()
    {
        dealCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dealCards() 
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerArea.transform, false);

            GameObject opponentCard = Instantiate(Card2, new Vector3(0, 0, 0), Quaternion.identity);
            opponentCard.transform.SetParent(OpponentArea.transform, false);
        }
    }
}
