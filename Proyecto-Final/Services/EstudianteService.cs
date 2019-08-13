using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IEstudianteService
    {
        IEnumerable<Estudiante> GetAll();
        bool Add(Estudiante Model);
        bool Delete(int id);
        bool Update(Estudiante Model);
        Estudiante Get(int id);
    }

    public class Estudianteservice : IEstudianteService
    {
        private readonly UniversidadDbContext _universidadDbContext; 

        public Estudianteservice(
            UniversidadDbContext universidadDbContext
            )
        {
            _universidadDbContext = universidadDbContext;
        }
        
        public IEnumerable<Estudiante> GetAll()
        {
            var result = new List<Estudiante>();

            try
            {
                result = _universidadDbContext.Estudiante.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Estudiante Get(int id)
        {
            var result = new Estudiante();

            try
            {
                result = _universidadDbContext.Estudiante.Single(x => x.EstudianteId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }   
        public bool Add(Estudiante Model )
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

        public bool Update(Estudiante Model)
        {
            try
            {
                var originalModel = _universidadDbContext.Estudiante.Single(x =>
                    x.EstudianteId == Model.EstudianteId
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
                _universidadDbContext.Entry(new Estudiante { EstudianteId = id }).State = EntityState.Deleted; ;
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
