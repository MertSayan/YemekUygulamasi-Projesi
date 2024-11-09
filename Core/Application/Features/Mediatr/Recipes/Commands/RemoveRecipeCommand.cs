﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Mediatr.Recipes.Commands
{
    public class RemoveRecipeCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveRecipeCommand(int ıd)
        {
            Id = ıd;
        }
    }
}