namespace Blazor.Client.Pages
{
    public partial class Index
    {
        private List<City>? Cities { get; set; }
        private City? SelectedCity { get; set; } 
        private Dessert? SelectedDessert { get; set; } = null;
        protected override void OnParametersSet()
        {
            Cities = new List<City>
            {
                new City { Name = "Tel Aviv", Description = "Modern" },
                new City { Name = "Jerusalem", Description = "Holy" },
                new City { Name = "Haifa", Description = "Integrated"},
                new City { Name = "Be'er Sheva", Description = "Southern"},
                new City { Name = "Eilat", Description = "Beaches"},
            };
            base.OnParametersSet();
        }

        private void OnSelectedCity(City category)
        {
            SelectedCity = category;
        }

        private void OnSelectedDessert(Dessert? dessert)
        {
            SelectedDessert = dessert;
        }
    }
}
