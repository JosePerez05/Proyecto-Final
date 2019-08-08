using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IProfesorService
    {
        IEnumerable<Profesor> GetAll();
        bool Add(Profesor Model);
        bool Delete(int id);
        bool Update(Profesor Model);
        Profesor Get(int id);
    }

    public class Profesorservice : IProfesorService
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public Profesorservice(
            UniversidadDbContext universidadDbContext
            )
        {
            _universidadDbContext = universidadDbContext;
        }

        public IEnumerable<Profesor> GetAll()
        {
            var result = new List<Profesor>();

            try
            {
                result = _universidadDbContext.Profesor.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Profesor Get(int id)
        {
            var result = new Profesor();

            try
            {
                result = _universidadDbContext.Profesor.Single(x => x.ProfesorId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(Profesor Model)
        {
            try
            {
                _universidadDbContext.Add(Model);
                _universidadDbContext.SaveChanges();

            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Profesor Model)
        {
            try
            {
                var originalModel = _universidadDbContext.Profesor.Single(x =>
                    x.Nombre == Model.Nombre
                    );

                originalModel.Nombre = Model.Nombre;
                originalModel.Apellido = Model.Apellido;


                _universidadDbContext.Update(Model);
                _universidadDbContext.SaveChanges();

            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _universidadDbContext.Entry(new Profesor { ProfesorId = id }).State = EntityState.Deleted; ;
                _universidadDbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }

    }
}
