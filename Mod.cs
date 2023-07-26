using HarmonyLib;
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
            Logger.Log("Ready!");
        }
    }
}