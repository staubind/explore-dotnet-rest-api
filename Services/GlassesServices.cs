using GlassesModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace seeSharpEyewear.Services
{
    public static class GlassesService
    {
        static List<Glasses> GlassesList { get; }
        static int nextId = 3;
        static GlassesService()
        {
            GlassesList = new List<Glasses>
            {
                new Glasses { Id = 1, Name = "Classic Italian", Color = "red", Shape = "triangle" },
                new Glasses { Id = 2, Name = "Veggie", Color = "green", Shape = "pumpkin" }
            };
        }

        public static List<Glasses> GetAll() => GlassesList;

        public static Glasses Get(int id) => GlassesList.FirstOrDefault(p => p.Id == id);

        public static void Add(Glasses glasses)
        {
            glasses.Id = nextId++;
            GlassesList.Add(glasses);
        }

        public static void Delete(int id)
        {
            var glasses = Get(id);
            if(glasses is null)
                return;

            GlassesList.Remove(glasses);
        }

        public static void Update(Glasses glasses)
        {
            var index = GlassesList.FindIndex(p => p.Id == glasses.Id);
            if(index == -1)
                return;

            GlassesList[index] = glasses;
        }
    }
}