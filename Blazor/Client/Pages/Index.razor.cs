namespace Blazor.Client.Pages
{
    public partial class Index
    {
        private List<Category>? Categories { get; set; }
        private Category? SelectedCategory { get; set; } = new Category { Name = "Select a City" };
        protected override void OnParametersSet()
        {
            Categories = new List<Category>
            {
                new Category { Name = "Tel Aviv", Description = "Modern" },
                new Category { Name = "Jerusalem", Description = "Holy" },
                new Category { Name = "Haifa", Description = "Integrated"},
                new Category { Name = "Be'er Sheva", Description = "Southern"},
                new Category { Name = "Eilat", Description = "Beaches"},
            };
            base.OnParametersSet();
        }

        private void OnSelectedCategory(Category category)
        {
            SelectedCategory = category;
        }
    }
}
