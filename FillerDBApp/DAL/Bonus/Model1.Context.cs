﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Axes> Axes { get; set; }
        public virtual DbSet<BaseForSMS> BaseForSMS { get; set; }
        public virtual DbSet<Bases> Bases { get; set; }
        public virtual DbSet<BaseTmpLocations> BaseTmpLocations { get; set; }
        public virtual DbSet<BaseTmpSizes> BaseTmpSizes { get; set; }
        public virtual DbSet<BDescriptions> BDescriptions { get; set; }
        public virtual DbSet<BGeometries> BGeometries { get; set; }
        public virtual DbSet<BLocations> BLocations { get; set; }
        public virtual DbSet<BRelationSizes> BRelationSizes { get; set; }
        public virtual DbSet<BSizeSurfaces> BSizeSurfaces { get; set; }
        public virtual DbSet<BSurfaces> BSurfaces { get; set; }
        public virtual DbSet<CodeDeviationGeometries> CodeDeviationGeometries { get; set; }
        public virtual DbSet<CodeDeviationLocations> CodeDeviationLocations { get; set; }
        public virtual DbSet<CodeOrientations> CodeOrientations { get; set; }
        public virtual DbSet<CodeSurfaces> CodeSurfaces { get; set; }
        public virtual DbSet<CodeSurfaceSizes> CodeSurfaceSizes { get; set; }
        public virtual DbSet<CodeTypeBillets> CodeTypeBillets { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CopyBases> CopyBases { get; set; }
        public virtual DbSet<CopyBaseSurfaces> CopyBaseSurfaces { get; set; }
        public virtual DbSet<CopySMS> CopySMS { get; set; }
        public virtual DbSet<DDescriptions> DDescriptions { get; set; }
        public virtual DbSet<DGeometries> DGeometries { get; set; }
        public virtual DbSet<DLocations> DLocations { get; set; }
        public virtual DbSet<DRelationSizes> DRelationSizes { get; set; }
        public virtual DbSet<DSizeSurfaces> DSizeSurfaces { get; set; }
        public virtual DbSet<DSurfaces> DSurfaces { get; set; }
        public virtual DbSet<EBaseLocations> EBaseLocations { get; set; }
        public virtual DbSet<EBaseSchemes> EBaseSchemes { get; set; }
        public virtual DbSet<EBaseSizes> EBaseSizes { get; set; }
        public virtual DbSet<EBaseSurface1> EBaseSurface1 { get; set; }
        public virtual DbSet<EBaseSurfaces> EBaseSurfaces { get; set; }
        public virtual DbSet<EBaseTmps> EBaseTmps { get; set; }
        public virtual DbSet<ECarriages> ECarriages { get; set; }
        public virtual DbSet<EDescriptions> EDescriptions { get; set; }
        public virtual DbSet<EDevices> EDevices { get; set; }
        public virtual DbSet<EFeeds> EFeeds { get; set; }
        public virtual DbSet<EGeoSTmps> EGeoSTmps { get; set; }
        public virtual DbSet<EGeoTmps> EGeoTmps { get; set; }
        public virtual DbSet<EGroups> EGroups { get; set; }
        public virtual DbSet<ELathes> ELathes { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EquipmentCatalogs> EquipmentCatalogs { get; set; }
        public virtual DbSet<ERelationCarriages> ERelationCarriages { get; set; }
        public virtual DbSet<EResults> EResults { get; set; }
        public virtual DbSet<ESpeeds> ESpeeds { get; set; }
        public virtual DbSet<ESpindles> ESpindles { get; set; }
        public virtual DbSet<ETransitionBases> ETransitionBases { get; set; }
        public virtual DbSet<ETransitionBaseTolerances> ETransitionBaseTolerances { get; set; }
        public virtual DbSet<ETransitionGeometryInputs> ETransitionGeometryInputs { get; set; }
        public virtual DbSet<ETransitionGeometryOutputs> ETransitionGeometryOutputs { get; set; }
        public virtual DbSet<ETransitions> ETransitions { get; set; }
        public virtual DbSet<ETransitionSizes> ETransitionSizes { get; set; }
        public virtual DbSet<ExchangeSizes> ExchangeSizes { get; set; }
        public virtual DbSet<FixtureCatalogs> FixtureCatalogs { get; set; }
        public virtual DbSet<GroupOperations> GroupOperations { get; set; }
        public virtual DbSet<NewSMS> NewSMS { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<ProcessCatalogs> ProcessCatalogs { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SizeDescriptions> SizeDescriptions { get; set; }
        public virtual DbSet<SMS> SMS { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SurfaceCatalogs> SurfaceCatalogs { get; set; }
        public virtual DbSet<Trees> Trees { get; set; }
        public virtual DbSet<TypeProcesses> TypeProcesses { get; set; }
        public virtual DbSet<Words> Words { get; set; }
    }
}