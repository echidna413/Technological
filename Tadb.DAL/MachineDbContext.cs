using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Tadb.DAL
{
    public class MachineDbContext : DbContext
    {
        public MachineDbContext() : base("name=MachineDb")
        {
        }

        public MachineDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentCatalog> EquipmentCatalogs { get; set; }
        public DbSet<FixtureCatalog> FixtureCatalogs { get; set; }
        public DbSet<ProcessCatalog> ProcessCatalogs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Company> Companies { get; set; }

        //public DbSet<Axis> Axises { get; set; }
        //public DbSet<Base> Bases { get; set; }
        //public DbSet<BaseForSMS> BasesForSMS { get; set; }
        //public DbSet<BaseTmpLocation> BasesTmpLocation { get; set; }
        //public DbSet<BaseTmpSize> BasesTmpSize { get; set; }
        public DbSet<BDescription> BDescriptions { get; set; }

        //public DbSet<BGeometry> BGeometries { get; set; }
        //public DbSet<BLocation> BLocations { get; set; }
        //public DbSet<BRelationSize> BRelationSizes { get; set; }
        //public DbSet<BSizeSurface> BSizesSurfaces { get; set; }
        public DbSet<BSurface> BSurfaces { get; set; }

        public DbSet<CodeDeviationGeometry> CodesDeviationGeometry { get; set; }
        public DbSet<CodeDeviationLocation> CodesDeviationLocation { get; set; }

        //public DbSet<CodeOrientation> CodesOrientation { get; set; }
        public DbSet<SurfaceCatalog> CodesSurfaces { get; set; }

        //public DbSet<CodeSurfaceSize> CodeSurfaceSizes { get; set; }
        //public DbSet<CodeTypeBillet> CodesTypesBillets { get; set; }
        //public DbSet<CopyBase> CopyBases { get; set; }
        //public DbSet<CopyBaseSurface> CopyBaseSurfaces { get; set; }
        //public DbSet<CopySMS> CopiesSMS { get; set; }
        public DbSet<DDescription> DDescriptions { get; set; }

        public DbSet<DGeometry> DGeometries { get; set; }
        public DbSet<DLocation> DLocations { get; set; }
        public DbSet<DRelationSize> DRelationSizes { get; set; }
        public DbSet<DSizeSurface> DSizesSurfaces { get; set; }
        public DbSet<DSurface> DSurfaces { get; set; }

        //public DbSet<EBaseLocation> EBaseLocations { get; set; }
        public DbSet<EBaseScheme> EBaseSchemes { get; set; }

        //public DbSet<EBaseSize> EBaseSizes { get; set; }
        //public DbSet<EBaseSurface> EBaseSurfaces { get; set; }
        //public DbSet<EBaseSurface1> EBaseSurfaces1 { get; set; }
        //public DbSet<EBaseTmp> EBasesTmp { get; set; }
        //public DbSet<ECarriage> ECarriages { get; set; }
        //public DbSet<EDescription> EDescriptions { get; set; }
        //public DbSet<EDevice> EDevices { get; set; }
        //public DbSet<EFeed> EFeeds { get; set; }
        //public DbSet<EGeoSTmp> EGeoSTmps { get; set; }
        //public DbSet<EGeoTmp> EGeoTmps { get; set; }
        public DbSet<EGroup> EGroups { get; set; }

        public DbSet<ELathe> ELathes { get; set; }

        //public DbSet<ERelationCarriage> ERelationCarriages { get; set; }
        //public DbSet<EResult> EResult { get; set; }
        //public DbSet<ESpeed> ESpeeds { get; set; }
        //public DbSet<ESpindle> ESpindles { get; set; }
        //public DbSet<ETransition> ETransitions { get; set; }
        //public DbSet<ETransitionBase> ETransitionsBases { get; set; }
        //public DbSet<ETransitionBaseTolerance> ETransitionsBasesTolerance { get; set; }
        //public DbSet<ETransitionGeometryInput> ETransitionGeometryInputs { get; set; }
        //public DbSet<ETransitionGeometryOutput> ETransitionsGeometryOutputs { get; set; }
        //public DbSet<ETransitionSize> ETransitionsSizes { get; set; }
        //public DbSet<ExchangeSize> ExchangeSizes { get; set; }
        //public DbSet<GroupOperation> GroupOperations { get; set; }
        //public DbSet<NewSMS> NewSMSs { get; set; }
        public DbSet<Operation> Operations { get; set; }

        //public DbSet<SizeDescription> SizeDescriptions { get; set; }
        //public DbSet<SMS> SMSes { get; set; }
        //public DbSet<Tree> Trees { get; set; }
        //public DbSet<TypeProcess> TypesProcess { get; set; }
        //public DbSet<Word> Words { get; set; }
        public DbSet<RouteCard> RouteCards { get; set; }

        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MachineDbContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SurfaceCatalog>()
                .Property(p => p.surface_code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Employee>()
                .HasRequired(x => x.Role)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.BILSurfaceCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.Employee)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.EquipmentCatalog)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.FixtureCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.FBSSurfaceCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.ProcessCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.SBSSurfaceCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.Status)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.CodeSurface)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Record>()
                .HasRequired(x => x.TBSSurfaceCode)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RouteCard>()
                .HasOptional<DDescription>(s => s.DDescription)
                .WithMany()
                .WillCascadeOnDelete(false);


            //modelBuilder.Entity<DSurface>()
            //    .HasRequired(s => s.DDescription)
            //    .WithMany(x => x.DSurfaces)
            //    .HasForeignKey(s => s.detail_id);
        }
    }
}