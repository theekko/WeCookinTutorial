using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//After creating one recipeSOList we can comment it out from the AssetMenu to make sure that another one 
//cannot be made.
//[CreateAssetMenu()]
public class RecipeListSO : ScriptableObject {


    public List<RecipeSO> recipeSOList;
}
