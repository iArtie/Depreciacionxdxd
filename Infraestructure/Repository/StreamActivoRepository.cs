using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class StreamActivoRepository : IActivoModel
    {
        public string n;
        private BinaryReader binaryReader;
        private BinaryWriter binaryWriter;
        private string fileName = "activo.dat";
        public StreamActivoRepository()
        {
            
        }
        public void Add(Activo t)
        {
            
            try
            {
                int id = 0;
                Activo last = Read().LastOrDefault();
                if(last == null)
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
                    binaryWriter.Write(t.Nombre);
                    binaryWriter.Write(t.Valor);
                    binaryWriter.Write(t.VidaUtil);
                    binaryWriter.Write(t.ValorResidual);
                    binaryWriter.Write(t.Descripcion);
                    binaryWriter.Write(t.Codigo);
                    binaryWriter.Write(t.Estado);

                }

            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            Activo activo = null;
            bool success = false;
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if (length == 0)
                    {
                        return activo;
                    }

                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {
                        activo = new Activo()
                        {
                            Id = binaryReader.ReadInt32(),
                            Nombre = binaryReader.ReadString(),
                            Valor = binaryReader.ReadDouble(),
                            VidaUtil = binaryReader.ReadInt32(),
                            ValorResidual = binaryReader.ReadDouble(),
                            Descripcion = binaryReader.ReadString(),
                            Codigo = binaryReader.ReadString(),
                            Estado = binaryReader.ReadString(),
                            Empleado = binaryReader.ReadString()
                        };

                        if(activo.Id == id)
                        {
                            success = true;
                            break;
                        }
                    }

                }
                return success ? activo : null;
            }
            catch (IOException)
            {
                throw;
            }
        }

        public List<Activo> Read()
        {
            List<Activo> activos = new List<Activo>();
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new BinaryReader(fileStream);
                    long length = binaryReader.BaseStream.Length;

                    if(length == 0)
                    {
                        return activos;
                    }

                    binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (binaryReader.BaseStream.Position < length)
                    {
                        
                        activos.Add(new Activo()
                        {
                            

                        
                            Id = binaryReader.ReadInt32(),
                            Nombre = binaryReader.ReadString(),
                            Valor = binaryReader.ReadDouble(),
                            VidaUtil = binaryReader.ReadInt32(),
                            ValorResidual = binaryReader.ReadDouble()
                        });
                    }
                                     
                }
                return activos;
            }
            catch (IOException)
            {
                throw;
            }

        }
        public int Update(Activo t)
        {
            throw new NotImplementedException();
        }
    }

}
