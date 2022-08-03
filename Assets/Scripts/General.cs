using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class General : MonoBehaviour, IPointerDownHandler
{
    public Image HealthImage;
    public Image GeneralImage;

    public GameObject winScreen;
    public GameObject winBanner;

    public int _health = 20;

    public void getDamage(int damage)
    {
        if (_health > 0 && damage <= _health)
        {
            _health -= damage;
        } else
        {
            _health = 0;
        }

        HealthImage.sprite = FontContainer.instance.HealthNumbers[_health];

        if (_health == 0)
        {
            winBanner.SetActive(false);
            winScreen.SetActive(true);
        }
    }

    public void SetActiveEffect(bool active)
    {
        gameObject.transform.Find("GeneralActive").gameObject.SetActive(active);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameController.instance.PlayedCard)
        {
            if (PlayerSwitcher.instance.GetActivePlayer().GetGeneral() != GetComponent<General>())
            {
                getDamage(GameController.instance.PlayedCard.GetDamage());
                GameController.instance.PlayedCard.Activate(false);
                GameController.instance.PlayedCard = null;
            }
        }
    }
}
