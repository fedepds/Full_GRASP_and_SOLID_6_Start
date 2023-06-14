using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{

public class RecipeTimerClient : TimerClient
{
    private Recipe recipe;

    public RecipeTimerClient(Recipe recipe)
    {
        this.recipe = recipe;
    }

    public void TimeOut()
    {
        recipe.Cooked = true;
    }
}
}