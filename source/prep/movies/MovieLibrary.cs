using System;
using System.Collections.Generic;
using System.Reflection;

namespace code.prep.movies
{
    public class MovieLibrary
    {
        readonly IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return movies;
        }

        public void add(Movie movie)
        {
            foreach (var item in movies)
            {
                if ((item.GetHashCode() == movie.GetHashCode()) || item.title == movie.title)
                    return;
            }
            movies.Add(movie);
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            foreach (var item in movies)
            {
                if (item.production_studio ==  ProductionStudio.Pixar)
                    yield return item;
            }
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            foreach (var item in movies)
            {
                if (item.production_studio == ProductionStudio.Pixar || item.production_studio == ProductionStudio.Disney)
                    yield return item;
            }
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            foreach (var item in movies)
            {
                if (item.production_studio != ProductionStudio.Pixar)
                    yield return item; 
            }
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            foreach (var item in movies)
            {
                if (item.date_published.Year > year)
                    yield return item;                 
            }
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            foreach (var movie in movies)
            {
                if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            foreach (var movie in movies)
            {
                if (movie.genre == Genre.kids)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> all_action_movies()
        {
            foreach (var movie in movies)
            {
                if (movie.genre == Genre.action)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}
