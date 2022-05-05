using System;
using MvcMovie.Models;

namespace MvcMovie.Supporters
{
    public static class MovieLibrary
    {
        public static Movies ToMovies(this List<Movie> movieList)
        {
            return new Movies(movieList);
        }
    }
}