﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klinik.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KlinikModelContainer : DbContext
    {
        public KlinikModelContainer()
            : base("name=KlinikModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MsPatient> MsPatients { get; set; }
        public virtual DbSet<PatientVisit> PatientVisits { get; set; }
        public virtual DbSet<DetailPatientVisit> DetailPatientVisits { get; set; }
        public virtual DbSet<MsMedicinePurchase> MsMedicinePurchases { get; set; }
        public virtual DbSet<MsMedicine> MsMedicines { get; set; }
        public virtual DbSet<MedicineStock> MedicineStocks { get; set; }
        public virtual DbSet<DetailMedicinePurchase> DetailMedicinePurchases { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<DetailHospitalized> DetailHospitalizeds { get; set; }
        public virtual DbSet<MsHospitalized> MsHospitalizeds { get; set; }
        public virtual DbSet<MsDiagnose> MsDiagnoses { get; set; }
        public virtual DbSet<MsSection> MsSections { get; set; }
    }
}
