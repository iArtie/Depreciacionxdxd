using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class StreamEmpleadoReopsitory : IEmpleadoModel
    {
        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName = "empleado.dat";
        public void Add(Empleado t)
        {
            try
            {
                int id = 0;
                Empleado last = Read().LastOrDefault();
                if (last == null)
                {
                    id = 1;
                }
                else
                {
                    id = last.Id + 1;
                }

                using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(id);
                    binaryWriter.Write(t.Nombres);
                    binaryWriter.Write(t.Apellidos);
                    binaryWriter.Write(t.Cedula);
                    binaryWriter.Write(t.Direccion);
                    binaryWriter.Write(t.Telefono);
                    binaryWriter.Write(t.email);
                    binaryWriter.Write(t.Estado);
                }

            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado GetById(int id)
        {
            Empleado empleado = null;
            bool success = false;
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return empleado;
                    }

                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {
                        empleado = new Empleado()
                        {
                            Id = binaryReader.ReadInt32(),
                            Nombres = binaryReader.ReadString(),
                            Apellidos = binaryReader.ReadString(),
                            Cedula = binaryReader.ReadString(),
                            Direccion = binaryReader.ReadString(),
                            Telefono = binaryReader.ReadInt32(),
                            email = binaryReader.ReadString(),
                            Estado = binaryReader.ReadString()
                        };

                        if (empleado.Id == id)
                        {
                            success = true;
                            break;
                        }
                    }

                }
                return success ? empleado : null;
            }
            catch (IOException)
            {
                throw;
            }
        }

        public List<Empleado> Read()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return empleados;
                    }

                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {

                        empleados.Add(new Empleado()
                        {
                            Id = binaryReader.ReadInt32(),
                            Nombres = binaryReader.ReadString(),
                            Apellidos = binaryReader.ReadString(),
                            Cedula = binaryReader.ReadString(),
                            Direccion = binaryReader.ReadString(),
                            Telefono = binaryReader.ReadInt32(),
                            email = binaryReader.ReadString(),
                            Estado = binaryReader.ReadString()
                        });
                    }

                }
                return empleados;
            }
            catch (IOException)
            {
                throw;
            }
        }

        public int Update(Empleado t)
        {
            throw new NotImplementedException();
        }
    }
}
