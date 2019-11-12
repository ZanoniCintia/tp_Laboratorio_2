using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesAbstractas;
using ClasesInstanciables;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void ValidoExcepciones()
        {
            Alumno auxPerson = new Alumno(2, "Denu", "Moreno", "129jkl1654", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void ValidoNacionlidad()
        {
            Alumno auxAlum = new Alumno(2, "cin", "zanoni", "31917371", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
        }
        [TestMethod]
        public void ValidoNumero()
        {
            int numero = 1;
            Alumno AuxMatias = new Alumno(2, "matias", "moll", "1", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Assert.AreEqual(numero, AuxMatias.DNI);
        }
        [TestMethod]
        public void ValidarNull()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Alumnos);
        }
    }
}
