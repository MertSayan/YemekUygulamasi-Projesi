﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Recipes.Results
{
    public class GetTopRatedRecipeQueryResult
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string RecipeImageUrl { get; set; }
    }
}
