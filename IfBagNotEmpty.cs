using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Inventory;
using GameCreator.Runtime.Variables;
using GameCreator.Runtime.VisualScripting;
using UnityEngine;

    [Version(0, 0, 1)]
[Title("if bag not empty")]
[Description("if bag not empty")]
[Category("Inventory/Bags/if bag empty")]
[Keywords("Bag", "Inventory", "Container", "Stash", "Chest", "Take", "All")]
[Keywords("Give", "Take", "Borrow", "Lend", "Buy", "Purchase", "Sell", "Steal", "Rob")]
[Image(typeof(IconItem), ColorTheme.Type.Yellow, typeof(OverlayListVariable))]
[Serializable]
public class IfBagNotEmpty : Condition
{
    [SerializeField] private PropertyGetGameObject m_FromBag = GetGameObjectInventoryBag.Create();
    // [SerializeField] private PropertySetNumber m_Set = SetNumberGlobalName.Create;

    protected override bool Run(Args args)
    {
        Bag fromBag = this.m_FromBag.Get<Bag>(args);
        if (fromBag == null) return true;
        int itemsFound = fromBag.Content.CountWithStack;
        // double value = itemsFound;
        //  this.m_Set.Set(value, args);
        //  return DefaultResult;
        if (itemsFound > 0)
        {
            return true;
        }
        else { return false; }
    }
}
