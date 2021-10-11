using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace lession10
{
    public static class DataPlayer
    {
        private const string KART_DATA = "kart_data";
        public static AllData kartData;

        private static UnityEvent updateSource;
        static DataPlayer()
        {
            kartData = JsonUtility.FromJson<AllData>(PlayerPrefs.GetString(KART_DATA));

            if (kartData == null)
            {
                kartData = new AllData();
                kartData.kartList = new List<int>();
                kartData.currentKart = 1;

                kartData.kartList.Add(1);
                SaveDataKart();
            }
        }

        private static void SaveDataKart()
        {
            PlayerPrefs.SetString(KART_DATA, JsonUtility.ToJson(kartData));
        }

        public static void AddListener(Action action)
        {
            updateSource?.AddListener(action.Invoke);
        }
        
        public static void RemoveListener(Action action)
        {
            updateSource?.RemoveListener(action.Invoke);
        }
        
        public static void AddKart(int id)
        {
            kartData.AddKart(id);
            updateSource?.Invoke();
            
            SaveDataKart();
        }
        
        public static void AddCoin(int coin)
        {
            kartData.AddCoin(coin);
            updateSource?.Invoke();
            
            SaveDataKart();
        }

        public static void SubCoin(int coin)
        {
            kartData.SubCoin(coin);

            SaveDataKart();
        }
        
        public static int GetCurrentKartId()
        {
            return kartData.currentKart;
        }

        public static int GetPrevKart()
        {
            return kartData.GetPrevKart();
        }

        public static int GetNextKart()
        {
            return kartData.GetNextKart();
        }
    }

    public class AllData
    {
        public List<int> kartList;
        public int currentKart;
        public int coin;
        public void AddKart(int id)
        {
            if (!kartList.Contains(id))
            {
                kartList.Add(id);
            }
        }

        public void AddCoin(int coin)
        {
            this.coin += coin;
        }
        
        public void SubCoin(int coin)
        {
            this.coin -= coin;
        }
        
        public int GetPrevKart()
        {
            var kartId = 1;
            var index = kartList.IndexOf(currentKart);

            if (index == 0)
                kartId = kartList[kartList.Count - 1];
            else
                kartId = kartList[index - 1];

            currentKart = kartId;
            return currentKart;
        }

        public int GetNextKart()
        {
            var kartId = 1;
            var index = kartList.IndexOf(currentKart);

            if (index == kartList.Count - 1)
                kartId = kartList[0];
            else
                kartId = kartList[index + 1];

            currentKart = kartId;
            return currentKart;
        }
    }
}