using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{

    public class CookTimerClient : TimerClient
{
    private readonly Recipe recipe;

    public CookTimerClient(Recipe recipe)
    {
        this.recipe = recipe;
    }

    public void TimeOut()
    {
        recipe.Cooked = true;
    }
}

}