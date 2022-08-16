namespace Lab4Library
{
    public class CoffeeMachine
    {
        private Dictionary<RecipeName,Recipe> _recipes = new Dictionary<RecipeName, Recipe>();
        private GrinderUnit _grinderUnit;
        private BrewingUnit _brewingUnit;
        private Container _waterContainer;
        private Container _milkContainer;
        private Container _beansContainer;

        public CoffeeMachine(int capacity)
        {
            _waterContainer = new Container(capacity);
            _milkContainer = new Container(capacity);
            _beansContainer = new Container(capacity);
            _recipes = new Dictionary<RecipeName, Recipe>();
            Recipe espressoRecipe = new Recipe(50, 0, 10);
            _recipes.Add(RecipeName.Espresso, espressoRecipe);
            Recipe latteRecipe = new Recipe(150, 150, 20);
            _recipes.Add(RecipeName.Latte, latteRecipe);
            Recipe capuchinoRecipe = new Recipe(200, 100, 20);
            _recipes.Add(RecipeName.Capuchino, capuchinoRecipe);
            Recipe FilteredRecipe = new Recipe(300, 0, 30);
            _recipes.Add(RecipeName.Filtered, FilteredRecipe);
        }

        public Coffee Brew(RecipeName recipeName)
        {
            Coffee coffee = new Coffee();
            coffee.Recipe = recipeName;
            _waterContainer.GetResource(_recipes[coffee.Recipe].Water);
            _milkContainer.GetResource(_recipes[coffee.Recipe].Milk);
            _beansContainer.GetResource(_recipes[coffee.Recipe].Beans);
            coffee = _brewingUnit.Brew(_grinderUnit.Grind(_recipes[coffee.Recipe].Beans));
            return coffee;
        }
        public void LoadWater(int value)
        {
            _waterContainer.LoadResource(value);
        }
        public void LoadMilk(int value)
        {
            _milkContainer.LoadResource(value);
        }
        public void LoadBeans(int value)
        {
            _beansContainer.LoadResource(value);
        }
        public int GetWaterLevel()
        {
            return _waterContainer.GetValue();
        }
        public int GetMilkLevel()
        {
            return _milkContainer.GetValue();
        }
        public int GetBeansLevel()
        {
            return _beansContainer.GetValue();
        }
    }
}