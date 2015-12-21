using System;
using System.Collections.Generic;
using System.Text;

namespace Vox.Enums
{
    public enum View
    {
        Init = 0,               //there is only buttons in the middle of the screen
        ShowRightBar = 1,       //right bar is meant to contain applicable sound effects
        HideRightBar = 2,
        ShowLeftBar = 3,        //left bar is meant to contain sound files
        HideLeftBar = 4,
        ShowBottomBar = 5,      //bottom bar is meant to contain player
        HideBottomBar = 6,
        ShowTopPanel = 7,       //top panel is meant to contain informative content such is progress, adds and such
        HodeTopPanel = 8,
        ShowPurchasePanel = 9,  //purchase panel is meant to contain shop with purchasable items
        HidePurchasePanel = 10,
        ShowRecordButton = 11,  //is meant to show record button and hide stop and pause buttons
        ShowStopButton = 12,    //is meant to show stop and pause buttons and hide record button
    }
}
