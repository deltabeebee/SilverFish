﻿using System;
using System.Collections.Generic;
using System.IO;

namespace HREngine.Bots
{
    public partial class CardDB
    {
        public Dictionary<cardIDEnum,cardName> SpecialNames { get; set; }

        public void InitSpecialNames()
        {
            SpecialNames = new Dictionary<cardIDEnum, cardName>();
            string path = Settings.Instance.path;
            string[] lines = File.ReadAllLines(path + "special_card_name.txt");
            Helpfunctions.Instance.ErrorLog("read special_card_name.txt " + lines.Length + " lines");
            foreach (var item in lines)
            {
                var array = item.Split('-');
                if (array.Length != 2)
                {
                    throw new Exception($"{item} can not be parsed for special name");
                }

                string key = array[0];
                string value = array[1];
                var tempCardIdEnum = (cardIDEnum) Enum.Parse(typeof(cardIDEnum), key);
                var tempCardNameEnum = (cardName) Enum.Parse(typeof(cardName), value);
                SpecialNames.Add(tempCardIdEnum, tempCardNameEnum);
            }
        }

        public cardName GetSpecialCardNameEnumFromCardIdEnum(cardIDEnum tempCardIdEnum)
        {
            if (SpecialNames.ContainsKey(tempCardIdEnum))
            {
                return SpecialNames[tempCardIdEnum];
            }
            else
            {
                return cardName.unknown;
            }
        }
    }
}