﻿using System.Collections.Generic;

namespace MovieShop.Core.Models.Response
{
    public class FavoriteResponseModel
    {
        public int UserId { get; set; }
        public List<FavoriteMovieResponseModel> FavoriteMovies { get; set; }
        public class FavoriteMovieResponseModel : MovieResponseModel
        {
        }
    }
}