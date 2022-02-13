using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataBaseItemView : MonoBehaviour
{
    [SerializeField] TMP_Text Name;
    [SerializeField] TMP_Text Speed;
    [SerializeField] TMP_Text Weight;
    [SerializeField] Image Image;

    public void Initialize(DataBaseEntity entity)
    {
        Name.text = entity.Name;
        Speed.text = entity.Speed.ToString();
        Weight.text = entity.Weight.ToString();
        Image.sprite = entity.Image;
    }
}
