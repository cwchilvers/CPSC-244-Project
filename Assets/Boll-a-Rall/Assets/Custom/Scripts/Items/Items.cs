using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public Text itemsText;
    public GameObject scripts;

    private int _currentLevel;
    private int _items;
    private int _totalItems;
    private int _total_lv01 = Constants.ITEMS_LV01;
    private int _total_lv02 = Constants.ITEMS_LV02;
    private int _total_lv03 = Constants.ITEMS_LV03;

    private void Start()
    {
        UpdateTotalItems();
        UpdateItemsText();
    }

    private void Update()
    {
        UpdateTotalItems();
        UpdateItemsText();
    }

    private void UpdateTotalItems()
    {
        GetCurrentLevel();

        if (_currentLevel == 1)
        {
            _totalItems = _total_lv01;
        }

        if (_currentLevel == 2)
        {
            _totalItems = _total_lv02;
        }

        if (_currentLevel == 3)
        {
            _totalItems = _total_lv03;
        }
    }

    private void UpdateItemsText()
    {
        itemsText.text = _items.ToString() + " / " + _totalItems.ToString();
    }

    public void AddItem()
    {
        _items += 1;
    }

    public void ResetItems()
    {
        _items = 0;
    }

    public bool CompareItems()
    {
        if (_items == _totalItems)
        {
            return true;
        }

        else
            return false;
    }

    private void GetCurrentLevel()
    {
        _currentLevel = scripts.GetComponent<Level>().currentLevel;
    }
}
