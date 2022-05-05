using System;
using System.Collections.Generic;
using MvcMovie.Models;

namespace MvcMovie.Supporters
{
    public class Movies
    {
        private List<Movie> movies;

        public Movies (List<Movie> movies)
        {
            this.movies = movies;
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
        public List<Movie> GetAllMoviesWhereTitleContain(string searchString)
        {
            return movies.Where(s => s.Title!.Contains(searchString)).ToList();
        }
        public List<Movie> GetAllMoviesWhereGenreEquals(string searchString)
        {
            return movies.Where(movie => movie.Genre == searchString).ToList();
        }
        public List<string?> GetAllGenres()
        {
            return movies.Select(m => m.Genre).Distinct().OrderBy(t => t).ToList();
        }
    }
}