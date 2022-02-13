using UnityEngine;

public class DataBaseView : MonoBehaviour
{
    [SerializeField] DataBase DataBase;
    [SerializeField] Transform ItemsContainer;
    [SerializeField] GameObject ItemPrefab;

    void Start()
    {
        foreach(var item in DataBase.DataBaseEntities)
        {
            var itemView = CreateView();
            itemView.Initialize(item);
        }
    }

    public DataBaseItemView CreateView()
    {
        var itemGO = Instantiate(ItemPrefab, ItemsContainer);
        return itemGO.GetComponent<DataBaseItemView>();
    }
}
