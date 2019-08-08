using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface ICarreraService
    {
        IEnumerable<Carrera> GetAll();
        bool Add(Carrera Model);
        bool Delete(int id);
        bool Update(Carrera Model);
        Carrera Get(int id);
    }

    public class Carreraservice : ICarreraService
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public Carreraservice(
            UniversidadDbContext universidadDbContext
            )
        {
            _universidadDbContext = universidadDbContext;
        }

        public IEnumerable<Carrera> GetAll()
        {
            var result = new List<Carrera>();

            try
            {
                result = _universidadDbContext.Carrera.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Carrera Get(int id)
        {
            var result = new Carrera();

            try
            {
                result = _universidadDbContext.Carrera.Single(x => x.CarreraId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(Carrera Model)
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

        public bool Update(Carrera Model)
        {
            try
            {
                var originalModel = _universidadDbContext.Materia.Single(x =>
                    x.Nombre == Model.Nombre
                    );

                originalModel.Nombre = Model.Nombre;
            


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
                _universidadDbContext.Entry(new Carrera { CarreraId = id }).State = EntityState.Deleted; ;
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
