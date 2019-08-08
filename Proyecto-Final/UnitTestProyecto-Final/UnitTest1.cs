using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Persistence;
using Proyecto_Final.Controllers;
using Services;

namespace UnitTestProyecto_Final
{
    [TestClass]
    public class UnitTest1
    {
        UniversidadDbContext dbContext = new UniversidadDbContext(new DbContextOptions<UniversidadDbContext>());
        private readonly Estudiante estudiante;
        private readonly Materia materia;
        private readonly Profesor profesor;
        private readonly Secciones secciones;
        private readonly Carrera carrera; 
        private readonly UniversidadDbContext _universidadDbContext;


        [TestMethod]
        public void AddEstudiante()
        {
            var service = new Estudianteservice(dbContext);
            var controller = new EstudianteController(service);
            var fin = service.Add(estudiante);
            Assert.IsNotNull(fin); 

        }
        [TestMethod]
        public void DeleteEstudiante()
        {
            var service = new Estudianteservice(dbContext);
            var controller = new EstudianteController(service);
            var fin = service.Delete('1');
            Assert.IsNotNull(fin);

        }

        [TestMethod]
        public void AddMateria()
        {
            var service = new Materiaservice(dbContext);
            var controller = new MateriaController(service);
            var fin = service.Add(materia);
            Assert.IsNotNull(fin);

        }
        [TestMethod]
        public void UpdateMateria()
        {
            var service = new Materiaservice(dbContext);
            var controller = new MateriaController(service);
            var fin = service.Update(materia);
            Assert.IsNotNull(fin);

        }


        [TestMethod]
        public void AddCarrrera()
        {
            var service = new Carreraservice(dbContext);
            var controller = new CarreraController(service);
            var fin = service.Add(carrera);
            Assert.IsNotNull(fin);

        }

        [TestMethod]
        public void AddProfesor()
        {
            var service = new Profesorservice(dbContext);
            var controller = new ProfesorController(service);
            var fin = service.Add(profesor);
            Assert.IsNotNull(fin);

        }

        [TestMethod]
        public void AddSecciones()
        {
            var service = new Seccionesservice(dbContext);
            var controller = new SeccionesController(service);
            var fin = service.Add(secciones);
            Assert.IsNotNull(fin);

        }
    }
}
