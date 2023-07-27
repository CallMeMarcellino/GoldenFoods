﻿using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace GoldenFoodsNS
{
    public class GoldenFoods : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "goldenfoods_blueprint_golden_berry", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "goldenfoods_blueprint_golden_apple", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "goldenfoods_blueprint_golden_banana", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "goldenfoods_blueprint_golden_cane_sugar", 1);
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "goldenfoods_blueprint_golden_bottle_of_rum", 1);
            
            Logger.Log("Ready!");
        }
    }
}