using System;
using System.Collections.Generic;

namespace cookwise.Models
{
    public class Ingredient
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public double Grams { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
    }

    public class CookingStep
    {
        public int StepNumber { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? DurationMinutes { get; set; }
        public string? HeatLevel { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new();
    }

    public class Recipe
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Ingredient> Ingredients { get; set; } = new();
        public List<CookingStep> Steps { get; set; } = new();
        public int Servings { get; set; } = 1;
        public double EstimatedCost { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> CategoryTags { get; set; } = new();
        public bool IsCustom { get; set; }
        public string? ParentRecipeId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class UserNote
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = "default";
        public string RecipeId { get; set; } = string.Empty;
        public string RecipeName { get; set; } = string.Empty;
        public string AdjustmentsText { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class FlavorProfile
    {
        public string UserId { get; set; } = "default";
        public Dictionary<string, int> TastePreferences { get; set; } = new();
        public List<string> DislikedIngredients { get; set; } = new();
        public List<string> PreferredCategories { get; set; } = new();
    }

    public class SearchResult
    {
        public Recipe Recipe { get; set; } = null!;
        public List<Ingredient> MissingIngredients { get; set; } = new();
        public int MatchScore { get; set; }
    }
}
