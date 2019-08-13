using Newtonsoft.Json;
using Rafael.Millis.Models;
using Rafael.Millis.Models.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Rafael.Millis.MovieRepository
{
    public class Repository : IRepository
    {
        /// <summary>
        /// Get All Movies
        /// </summary>
        public IEnumerable<Movie> GetMovies()
        {
            //should be in cache
            string json = System.IO.File.ReadAllText(FullFilePath+ $"/{MOVIES}{FILE_EXT}");
            movieJson = JsonConvert.DeserializeObject<MovieJson>(json);

            return movieJson.Movies;
        }


        /// <summary>
        /// Get Movie details by id
        /// </summary>
        public Movie GetMovie(int id )
        {
            //should be in cache
            string json = File.ReadAllText(FullFilePath + $"/{MOVIES}{FILE_EXT}");
            movieJson = JsonConvert.DeserializeObject<MovieJson>(json);

            return Filter(id).FirstOrDefault();
        }


        /// <summary>
        /// Get MOvie
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public IEnumerable<Movie> Filter(int id)
        {
            return movieJson.Movies.Where(x => x.Id == id);
        }


        private string FullFilePath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) +
                        "/data";
            }
        }

        private MovieJson movieJson;
        const string MOVIES = "movies";
        const string FILE_EXT = ".json";
    }
}
