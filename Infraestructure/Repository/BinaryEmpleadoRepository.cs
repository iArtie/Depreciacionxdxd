using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryEmpleadoRepository : IEmpleadoModel
    {
        public EmpleadoRAFContext EmpContext;
        public const int SIZE = 564;
        public BinaryEmpleadoRepository()
        {
            EmpContext = new EmpleadoRAFContext("empleado", SIZE);
        }
        public void Add(Empleado t)
        {
            try
            {
                EmpContext.Create<Empleado>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Empleado t)
        {
            EmpContext.Delete(t.Id);
        }

        public Empleado GetById(int id)
        {
            try
            {
                return EmpContext.Get<Empleado>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empleado> Read()
        {
            try
            {
                return EmpContext.GetAll<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Empleado t)
        {
            try
            {
                return EmpContext.Update<Empleado>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
