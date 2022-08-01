using UnityEngine;

[System.Serializable]
public class Hand
{
    public GameObject cardArea;

    public Card[] cards = new Card[7];
    
    public string[] animNames = new string[3];
    
    // public void activateCards()
    // {
    //     Card[] cards = this.cards;

    //     for (int i = 0; i < cards.Length; i++)
    //     {
    //         if (cards[i] != null)
    //         {
    //             cards[i].isDraggable = true;
    //             cards[i].cardBack.SetActive(false);
    //         }
    //     }
    // }

    // public void deactivateCards()
    // {
    //     Card[] cards = this.cards;

    //     for (int i = 0; i < cards.Length; i++)
    //     {
    //         if (cards[i] != null)
    //         {
    //             cards[i].isDraggable = false;
    //             cards[i].cardBack.SetActive(true);
    //         }
    //     }
    // }

    // public void moveCardtoDropZone(Card card, Board board)
    // {
    //     for (int i = 0; i < 7; i++)
    //     {
    //         if (cards[i] == card)
    //         {
    //             board.addCard(card, board);
    //             GameObject.Destroy(cards[i].gameObject);
    //         }
    //     }
    // }
}
