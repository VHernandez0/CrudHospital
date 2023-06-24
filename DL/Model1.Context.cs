﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<TipoSangre> TipoSangre { get; set; }
    
        public virtual int Addpaciente(string nombre, string aP, string aM, Nullable<System.DateTime> fechaNacimiento, Nullable<System.DateTime> fechaIngreso, Nullable<byte> idTipoSangre, string sexo, string sintomas)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var aPParameter = aP != null ?
                new ObjectParameter("AP", aP) :
                new ObjectParameter("AP", typeof(string));
    
            var aMParameter = aM != null ?
                new ObjectParameter("AM", aM) :
                new ObjectParameter("AM", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var idTipoSangreParameter = idTipoSangre.HasValue ?
                new ObjectParameter("IdTipoSangre", idTipoSangre) :
                new ObjectParameter("IdTipoSangre", typeof(byte));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var sintomasParameter = sintomas != null ?
                new ObjectParameter("Sintomas", sintomas) :
                new ObjectParameter("Sintomas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Addpaciente", nombreParameter, aPParameter, aMParameter, fechaNacimientoParameter, fechaIngresoParameter, idTipoSangreParameter, sexoParameter, sintomasParameter);
        }
    
        public virtual ObjectResult<GetAllPacientes_Result> GetAllPacientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPacientes_Result>("GetAllPacientes");
        }
    
        public virtual ObjectResult<GetAllSangre_Result> GetAllSangre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSangre_Result>("GetAllSangre");
        }
    
        public virtual int DeletePaciente(Nullable<int> idPaciente)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("IdPaciente", idPaciente) :
                new ObjectParameter("IdPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePaciente", idPacienteParameter);
        }
    
        public virtual int UpdatePaciente(Nullable<int> idPaciente, string nombre, string aP, string aM, Nullable<System.DateTime> fechaNacimiento, Nullable<System.DateTime> fechaIngreso, Nullable<byte> idTipoSangre, string sexo, string sintomas)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("IdPaciente", idPaciente) :
                new ObjectParameter("IdPaciente", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var aPParameter = aP != null ?
                new ObjectParameter("AP", aP) :
                new ObjectParameter("AP", typeof(string));
    
            var aMParameter = aM != null ?
                new ObjectParameter("AM", aM) :
                new ObjectParameter("AM", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var idTipoSangreParameter = idTipoSangre.HasValue ?
                new ObjectParameter("IdTipoSangre", idTipoSangre) :
                new ObjectParameter("IdTipoSangre", typeof(byte));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var sintomasParameter = sintomas != null ?
                new ObjectParameter("Sintomas", sintomas) :
                new ObjectParameter("Sintomas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePaciente", idPacienteParameter, nombreParameter, aPParameter, aMParameter, fechaNacimientoParameter, fechaIngresoParameter, idTipoSangreParameter, sexoParameter, sintomasParameter);
        }
    
        public virtual ObjectResult<GetByIdpaciente_Result> GetByIdpaciente(Nullable<int> idpaciente)
        {
            var idpacienteParameter = idpaciente.HasValue ?
                new ObjectParameter("Idpaciente", idpaciente) :
                new ObjectParameter("Idpaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdpaciente_Result>("GetByIdpaciente", idpacienteParameter);
        }
    }
}
