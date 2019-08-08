using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface ISeccionesService
    {
        IEnumerable<Secciones> GetAll();
        bool Add(Secciones Model);
        bool Delete(int id);
        bool Update(Secciones Model);
        Secciones Get(int id);
    }

    public class Seccionesservice : ISeccionesService
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public Seccionesservice(
            UniversidadDbContext universidadDbContext
            )
        {
            _universidadDbContext = universidadDbContext;
        }

        public IEnumerable<Secciones> GetAll()
        {
            var result = new List<Secciones>();

            try
            {
                result = _universidadDbContext.Secciones.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Secciones Get(int id)
        {
            var result = new Secciones();

            try
            {
                result = _universidadDbContext.Secciones.Single(x => x.SeccionId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(Secciones Model)
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

        public bool Update(Secciones Model)
        {
            try
            {
                var originalModel = _universidadDbContext.Secciones.Single(x =>
                    x.SeccionId == Model.SeccionId
                    );

                originalModel.Aula = Model.Aula;
           


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
                _universidadDbContext.Entry(new Secciones { SeccionId = id }).State = EntityState.Deleted; ;
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
