using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IMateriaService
    {
        IEnumerable<Materia> GetAll();
        bool Add(Materia Model);
        bool Delete(int id);
        bool Update(Materia Model);
        Materia Get(int id);
    }

    public class Materiaservice : IMateriaService
    {
        private readonly UniversidadDbContext _universidadDbContext;

        public Materiaservice(
            UniversidadDbContext universidadDbContext
            )
        {
            _universidadDbContext = universidadDbContext;
        }

        public IEnumerable<Materia> GetAll()
        {
            var result = new List<Materia>();

            try
            {
                result = _universidadDbContext.Materia.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public Materia Get(int id)
        {
            var result = new Materia();

            try
            {
                result = _universidadDbContext.Materia.Single(x => x.MateriaId == id);
            }
            catch (System.Exception)
            {

            }

            return result;
        }
        public bool Add(Materia Model)
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

        public bool Update(Materia Model)
        {
            try
            {
                var originalModel = _universidadDbContext.Materia.Single(x =>
                    x.Nombre == Model.Nombre
                    );

                originalModel.Nombre = Model.Nombre;
                originalModel.CantCre = Model.CantCre;


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
                _universidadDbContext.Entry(new Materia { MateriaId = id }).State = EntityState.Deleted; ;
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
