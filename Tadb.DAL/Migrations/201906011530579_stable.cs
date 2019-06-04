namespace Tadb.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class stable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BDescriptions", "id_company", "dbo.Companies");
            DropForeignKey("dbo.BGeometries", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BLocations", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BRelationSizes", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BSizeSurfaces", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.CodeSurfaceSizes", "code_surface_id", "dbo.CodeSurfaces");
            DropForeignKey("dbo.DDescriptions", "id_company", "dbo.Companies");
            DropForeignKey("dbo.EBaseSurfaces", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.EBaseLocations", "base_requirement_id", "dbo.EBaseSurfaces");
            DropForeignKey("dbo.EBaseSizes", "base_requirement_id", "dbo.EBaseSurfaces");
            DropForeignKey("dbo.ECarriages", "lathe_id", "dbo.ELathes");
            DropForeignKey("dbo.EDescriptions", "id_company", "dbo.Companies");
            DropForeignKey("dbo.EDescriptions", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.EDevices", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.EFeeds", "carriage_id", "dbo.ECarriages");
            DropForeignKey("dbo.ERelationCarriages", "carriage_id", "dbo.ECarriages");
            DropForeignKey("dbo.ESpindles", "lathe_id", "dbo.ELathes");
            DropForeignKey("dbo.ESpeeds", "spindle_id", "dbo.ESpindles");
            DropForeignKey("dbo.ETransitions", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.ETransitionGeometryInputs", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionBases", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionBaseTolerances", "base_requirement_id", "dbo.ETransitionBases");
            DropForeignKey("dbo.ETransitionGeometryOutputs", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionSizes", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.Records", "Status_id_status", "dbo.Status");
            DropForeignKey("dbo.RouteCards", "id_company", "dbo.Companies");
            DropForeignKey("dbo.RouteCards", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.Routes", "number_equipment", "dbo.EDescriptions");
            DropIndex("dbo.BDescriptions", new[] { "id_company" });
            DropIndex("dbo.BGeometries", new[] { "surface_id" });
            DropIndex("dbo.BLocations", new[] { "surface_id" });
            DropIndex("dbo.BRelationSizes", new[] { "surface_id" });
            DropIndex("dbo.BSizeSurfaces", new[] { "surface_id" });
            DropIndex("dbo.CodeSurfaceSizes", new[] { "code_surface_id" });
            DropIndex("dbo.DDescriptions", new[] { "id_company" });
            DropIndex("dbo.EBaseLocations", new[] { "base_requirement_id" });
            DropIndex("dbo.EBaseSurfaces", new[] { "base_scheme_id" });
            DropIndex("dbo.EBaseSizes", new[] { "base_requirement_id" });
            DropIndex("dbo.ECarriages", new[] { "lathe_id" });
            DropIndex("dbo.EDescriptions", new[] { "id_employee" });
            DropIndex("dbo.EDescriptions", new[] { "id_company" });
            DropIndex("dbo.EDevices", new[] { "base_scheme_id" });
            DropIndex("dbo.EFeeds", new[] { "carriage_id" });
            DropIndex("dbo.ERelationCarriages", new[] { "carriage_id" });
            DropIndex("dbo.ESpeeds", new[] { "spindle_id" });
            DropIndex("dbo.ESpindles", new[] { "lathe_id" });
            DropIndex("dbo.ETransitionGeometryInputs", new[] { "transition_id" });
            DropIndex("dbo.ETransitions", new[] { "base_scheme_id" });
            DropIndex("dbo.ETransitionBases", new[] { "transition_id" });
            DropIndex("dbo.ETransitionBaseTolerances", new[] { "base_requirement_id" });
            DropIndex("dbo.ETransitionGeometryOutputs", new[] { "transition_id" });
            DropIndex("dbo.ETransitionSizes", new[] { "transition_id" });
            DropIndex("dbo.Records", new[] { "Status_id_status" });
            DropIndex("dbo.RouteCards", new[] { "id_company" });
            DropIndex("dbo.RouteCards", new[] { "id_employee" });
            AddColumn("dbo.BDescriptions", "code", c => c.Int(nullable: false));
            AddColumn("dbo.BDescriptions", "size_production", c => c.Double(nullable: false));
            AddColumn("dbo.BDescriptions", "size_transmission", c => c.Double(nullable: false));
            AddColumn("dbo.BDescriptions", "central_hole", c => c.Boolean(nullable: false));
            AddColumn("dbo.BDescriptions", "mark_material", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "type_surface", c => c.Int(nullable: false));
            AddColumn("dbo.BSurfaces", "orientation", c => c.Int(nullable: false));
            AddColumn("dbo.BSurfaces", "rmax", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "tp", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "hrc", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "depth", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "internal_stress_1", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "internal_stress_2", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "internal_stress_3", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "constructor_base", c => c.Boolean(nullable: false));
            AddColumn("dbo.CodeDeviationGeometries", "type", c => c.String());
            AddColumn("dbo.CodeDeviationGeometries", "image", c => c.String());
            AddColumn("dbo.CodeDeviationLocations", "type", c => c.String());
            AddColumn("dbo.CodeDeviationLocations", "image", c => c.String());
            AddColumn("dbo.DGeometries", "type_deviation", c => c.Int(nullable: false));
            AddColumn("dbo.DSurfaces", "name_surface", c => c.String());
            AddColumn("dbo.DLocations", "relation_surface", c => c.Int(nullable: false));
            AddColumn("dbo.DLocations", "type_deviation", c => c.Int(nullable: false));
            AddColumn("dbo.DRelationSizes", "relation_number", c => c.Int(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "min_size", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "min_tolerance", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "min_max_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "min_min_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "max_size", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "max_tolerance", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "max_max_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "max_min_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.EGroups", "id_employee", c => c.Int(nullable: false));
            AddColumn("dbo.SurfaceCatalogs", "model", c => c.String());
            AddColumn("dbo.SurfaceCatalogs", "name", c => c.String());
            AddColumn("dbo.SurfaceCatalogs", "view_small", c => c.String());
            AddColumn("dbo.SurfaceCatalogs", "view_big", c => c.String());
            AddColumn("dbo.RouteCards", "detail_id", c => c.Int());
            AddColumn("dbo.RouteCards", "billet_id", c => c.Int());
            AddColumn("dbo.RouteCards", "profile_sizes", c => c.Int(nullable: false));
            CreateIndex("dbo.EGroups", "id_employee");
            CreateIndex("dbo.RouteCards", "detail_id");
            CreateIndex("dbo.RouteCards", "billet_id");
            AddForeignKey("dbo.EGroups", "id_employee", "dbo.Employees", "id_employee", cascadeDelete: true);
            AddForeignKey("dbo.RouteCards", "billet_id", "dbo.BDescriptions", "billet_id");
            AddForeignKey("dbo.RouteCards", "detail_id", "dbo.DDescriptions", "detail_id");
            AddForeignKey("dbo.Routes", "number_equipment", "dbo.ELathes", "lathe_id", cascadeDelete: true);
            DropColumn("dbo.BDescriptions", "id_company");
            DropColumn("dbo.BDescriptions", "detail_id");
            DropColumn("dbo.BDescriptions", "code_type_billet_id");
            DropColumn("dbo.BSurfaces", "code_surface_id");
            DropColumn("dbo.BSurfaces", "rnax");
            DropColumn("dbo.CodeDeviationGeometries", "description");
            DropColumn("dbo.CodeDeviationGeometries", "image_big");
            DropColumn("dbo.CodeDeviationGeometries", "image_small");
            DropColumn("dbo.CodeDeviationLocations", "description");
            DropColumn("dbo.CodeDeviationLocations", "image_big");
            DropColumn("dbo.CodeDeviationLocations", "image_small");
            DropColumn("dbo.DDescriptions", "id_company");
            DropColumn("dbo.DDescriptions", "length");
            DropColumn("dbo.DGeometries", "code_deviation_id");
            DropColumn("dbo.DSurfaces", "requirement");
            DropColumn("dbo.DLocations", "relation_surface_id");
            DropColumn("dbo.DLocations", "code_location_id");
            DropColumn("dbo.DRelationSizes", "relation_surface_id");
            DropColumn("dbo.DSizeSurfaces", "size_description_id");
            DropColumn("dbo.DSizeSurfaces", "nominal");
            DropColumn("dbo.DSizeSurfaces", "finish");
            DropColumn("dbo.DSizeSurfaces", "max_deviation");
            DropColumn("dbo.DSizeSurfaces", "min_deviation");
            DropColumn("dbo.DSizeSurfaces", "tolerance");
            DropColumn("dbo.DSizeSurfaces", "symmetry");
            DropColumn("dbo.Operations", "number_group");
            DropColumn("dbo.Records", "Status_id_status");
            DropColumn("dbo.SurfaceCatalogs", "description");
            DropColumn("dbo.RouteCards", "id_company");
            DropColumn("dbo.RouteCards", "id_employee");
            DropColumn("dbo.Routes", "t_base");
            DropColumn("dbo.Routes", "t_piece");
            DropTable("dbo.Axes");
            DropTable("dbo.Bases");
            DropTable("dbo.BaseForSMS");
            DropTable("dbo.BaseTmpLocations");
            DropTable("dbo.BaseTmpSizes");
            DropTable("dbo.BGeometries");
            DropTable("dbo.BLocations");
            DropTable("dbo.BRelationSizes");
            DropTable("dbo.BSizeSurfaces");
            DropTable("dbo.CodeOrientations");
            DropTable("dbo.CodeSurfaces");
            DropTable("dbo.CodeTypeBillets");
            DropTable("dbo.CodeSurfaceSizes");
            DropTable("dbo.CopySMS");
            DropTable("dbo.CopyBases");
            DropTable("dbo.CopyBaseSurfaces");
            DropTable("dbo.EBaseLocations");
            DropTable("dbo.EBaseSurfaces");
            DropTable("dbo.EBaseSizes");
            DropTable("dbo.EBaseTmps");
            DropTable("dbo.EBaseSurface1");
            DropTable("dbo.ECarriages");
            DropTable("dbo.EDescriptions");
            DropTable("dbo.EDevices");
            DropTable("dbo.EFeeds");
            DropTable("dbo.EGeoSTmps");
            DropTable("dbo.EGeoTmps");
            DropTable("dbo.ERelationCarriages");
            DropTable("dbo.EResults");
            DropTable("dbo.ESpeeds");
            DropTable("dbo.ESpindles");
            DropTable("dbo.ETransitionGeometryInputs");
            DropTable("dbo.ETransitions");
            DropTable("dbo.ETransitionBases");
            DropTable("dbo.ETransitionBaseTolerances");
            DropTable("dbo.ETransitionGeometryOutputs");
            DropTable("dbo.ETransitionSizes");
            DropTable("dbo.ExchangeSizes");
            DropTable("dbo.GroupOperations");
            DropTable("dbo.NewSMS");
            DropTable("dbo.SizeDescriptions");
            DropTable("dbo.SMS");
            DropTable("dbo.Trees");
            DropTable("dbo.TypeProcesses");
            DropTable("dbo.Words");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Words",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    number_word = c.Double(nullable: false),
                    word = c.String(),
                    group_operation = c.Double(nullable: false),
                    operation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.TypeProcesses",
                c => new
                {
                    type_process_id = c.Int(nullable: false, identity: true),
                    name = c.String(),
                    description = c.String(),
                })
                .PrimaryKey(t => t.type_process_id);

            CreateTable(
                "dbo.Trees",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    variant_tp = c.String(),
                    detail = c.Double(nullable: false),
                    surface = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.SMS",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    detail_id = c.Int(nullable: false),
                    surface_id = c.Int(nullable: false),
                    number_variant = c.Double(nullable: false),
                    number_step = c.Double(nullable: false),
                    code_surface = c.String(),
                    finish = c.String(),
                    tolerance = c.Double(nullable: false),
                    symmetry = c.Boolean(nullable: false),
                    zero_point_x = c.Double(nullable: false),
                    zero_point_y = c.Double(nullable: false),
                    zero_point_z = c.Double(nullable: false),
                    surface_size_1 = c.Double(nullable: false),
                    surface_size_2 = c.Double(nullable: false),
                    surface_size_3 = c.Double(nullable: false),
                    surface_size_4 = c.Double(nullable: false),
                    surface_size_5 = c.Double(nullable: false),
                    surface_size_6 = c.Double(nullable: false),
                    surface_size_7 = c.Double(nullable: false),
                    surface_size_8 = c.Double(nullable: false),
                    ra = c.Double(nullable: false),
                    rmax = c.Double(nullable: false),
                    s = c.Double(nullable: false),
                    tp = c.Double(nullable: false),
                    hrc = c.Double(nullable: false),
                    depth = c.Double(nullable: false),
                    base_code = c.Double(nullable: false),
                    orientation = c.Double(nullable: false),
                    device_id = c.Int(nullable: false),
                    view_process = c.Double(nullable: false),
                    number_machining_step = c.Double(nullable: false),
                    not_base = c.Boolean(nullable: false),
                    number_surface = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.SizeDescriptions",
                c => new
                {
                    size_description_id = c.Int(nullable: false, identity: true),
                    size_number = c.Double(nullable: false),
                    description = c.String(),
                })
                .PrimaryKey(t => t.size_description_id);

            CreateTable(
                "dbo.NewSMS",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    detail_id = c.Int(nullable: false),
                    surface_id = c.Int(nullable: false),
                    number_variant = c.Double(nullable: false),
                    number_step = c.Double(nullable: false),
                    code_surface = c.String(),
                    finish = c.String(),
                    tolerance = c.Double(nullable: false),
                    symmetry = c.Boolean(nullable: false),
                    zero_point_x = c.Double(nullable: false),
                    zero_point_y = c.Double(nullable: false),
                    zero_point_z = c.Double(nullable: false),
                    surface_size_1 = c.Double(nullable: false),
                    surface_size_2 = c.Double(nullable: false),
                    surface_size_3 = c.Double(nullable: false),
                    surface_size_4 = c.Double(nullable: false),
                    surface_size_5 = c.Double(nullable: false),
                    surface_size_6 = c.Double(nullable: false),
                    surface_size_7 = c.Double(nullable: false),
                    surface_size_8 = c.Double(nullable: false),
                    ra = c.Double(nullable: false),
                    rmax = c.Double(nullable: false),
                    s = c.Double(nullable: false),
                    tp = c.Double(nullable: false),
                    hrc = c.Double(nullable: false),
                    depth = c.Double(nullable: false),
                    base_code = c.Double(nullable: false),
                    orientation = c.Double(nullable: false),
                    device_id = c.Int(nullable: false),
                    number_machining_step = c.Double(nullable: false),
                    not_base = c.Boolean(nullable: false),
                    number_surface = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.GroupOperations",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    number_group = c.Double(nullable: false),
                    name_group = c.String(),
                    description = c.String(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.ExchangeSizes",
                c => new
                {
                    record_id = c.Int(nullable: false, identity: true),
                    code_surface_input = c.String(),
                    code_surface_output = c.String(),
                    size_1 = c.Double(nullable: false),
                    size_2 = c.Double(nullable: false),
                    size_3 = c.Double(nullable: false),
                    size_4 = c.Double(nullable: false),
                    size_5 = c.Double(nullable: false),
                    size_6 = c.Double(nullable: false),
                    size_7 = c.Double(nullable: false),
                    size_8 = c.Double(nullable: false),
                    size_9 = c.Double(nullable: false),
                    size_10 = c.Double(nullable: false),
                    size_11 = c.Double(nullable: false),
                    size_12 = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.record_id);

            CreateTable(
                "dbo.ETransitionSizes",
                c => new
                {
                    transition_id = c.Int(nullable: false),
                    size_number = c.Double(nullable: false),
                    min_value = c.Double(nullable: false),
                    max_value = c.Double(nullable: false),
                    size_description_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.transition_id, t.size_number });

            CreateTable(
                "dbo.ETransitionGeometryOutputs",
                c => new
                {
                    transition_id = c.Int(nullable: false),
                    code_deviation_id = c.Int(nullable: false),
                    value = c.Double(nullable: false),
                    class_ = c.Double(nullable: false),
                })
                .PrimaryKey(t => new { t.transition_id, t.code_deviation_id });

            CreateTable(
                "dbo.ETransitionBaseTolerances",
                c => new
                {
                    base_requirement_id = c.Int(nullable: false),
                    size_number = c.Double(nullable: false),
                    tolerance = c.Double(nullable: false),
                    size_description_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.base_requirement_id, t.size_number });

            CreateTable(
                "dbo.ETransitionBases",
                c => new
                {
                    base_requirement_id = c.Int(nullable: false, identity: true),
                    transition_id = c.Int(nullable: false),
                    base_number = c.Double(nullable: false),
                    code_surface = c.String(),
                })
                .PrimaryKey(t => t.base_requirement_id);

            CreateTable(
                "dbo.ETransitions",
                c => new
                {
                    transition_id = c.Int(nullable: false, identity: true),
                    base_scheme_id = c.Int(nullable: false),
                    type_process_id = c.Int(nullable: false),
                    code_output_surface = c.String(),
                    output_tolerance = c.Double(nullable: false),
                    output_ra = c.Double(nullable: false),
                    output_rmax = c.Double(nullable: false),
                    output_tp = c.Double(nullable: false),
                    output_s = c.Double(nullable: false),
                    output_hrc = c.Double(nullable: false),
                    output_depth = c.Double(nullable: false),
                    output_internalstress_1 = c.Double(nullable: false),
                    output_internalstress_2 = c.Double(nullable: false),
                    output_internalstress_3 = c.Double(nullable: false),
                    code_input_surface = c.String(),
                    input_tolerance = c.Double(nullable: false),
                    input_ra = c.Double(nullable: false),
                    input_rmax = c.Double(nullable: false),
                    input_tp = c.Double(nullable: false),
                    input_s = c.Double(nullable: false),
                    input_hrc = c.Double(nullable: false),
                    input_depth = c.Double(nullable: false),
                    input_internalstress_1 = c.Double(nullable: false),
                    input_internalstress_2 = c.Double(nullable: false),
                    input_internalstress_3 = c.Double(nullable: false),
                    mark_material = c.String(),
                    enabled = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.transition_id);

            CreateTable(
                "dbo.ETransitionGeometryInputs",
                c => new
                {
                    transition_id = c.Int(nullable: false),
                    code_deviation_id = c.Int(nullable: false),
                    value = c.Double(nullable: false),
                    class_ = c.Double(nullable: false),
                })
                .PrimaryKey(t => new { t.transition_id, t.code_deviation_id });

            CreateTable(
                "dbo.ESpindles",
                c => new
                {
                    spindle_id = c.Int(nullable: false, identity: true),
                    lathe_id = c.Int(nullable: false),
                    name = c.String(),
                    step_feed = c.Boolean(nullable: false),
                    min_value = c.Double(nullable: false),
                    max_value = c.Double(nullable: false),
                    reverse_feed = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.spindle_id);

            CreateTable(
                "dbo.ESpeeds",
                c => new
                {
                    speed_id = c.Int(nullable: false, identity: true),
                    spindle_id = c.Int(nullable: false),
                    reverse = c.Boolean(nullable: false),
                    value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.speed_id);

            CreateTable(
                "dbo.EResults",
                c => new
                {
                    record_id = c.Int(nullable: false, identity: true),
                    device_id = c.Int(nullable: false),
                    view_process = c.Double(nullable: false),
                    code_surface_output = c.Double(nullable: false),
                    code_surface_input = c.Double(nullable: false),
                    mark_material = c.String(),
                    size_surface_1_max = c.Double(nullable: false),
                    size_surface_1_min = c.Double(nullable: false),
                    size_surface_2_max = c.Double(nullable: false),
                    size_surface_2_min = c.Double(nullable: false),
                    size_surface_3_max = c.Double(nullable: false),
                    size_surface_3_min = c.Double(nullable: false),
                    size_surface_4_max = c.Double(nullable: false),
                    size_surface_4_min = c.Double(nullable: false),
                    size_surface_5_max = c.Double(nullable: false),
                    size_surface_5_min = c.Double(nullable: false),
                    size_surface_6_max = c.Double(nullable: false),
                    size_surface_6_min = c.Double(nullable: false),
                    size_surface_7_max = c.Double(nullable: false),
                    size_surface_7_min = c.Double(nullable: false),
                    size_surface_8_max = c.Double(nullable: false),
                    size_surface_8_min = c.Double(nullable: false),
                    max_output_tolerance = c.Double(nullable: false),
                    min_output_tolerance = c.Double(nullable: false),
                    max_output_ra = c.Double(nullable: false),
                    min_output_ra = c.Double(nullable: false),
                    max_output_rmax = c.Double(nullable: false),
                    min_output_rmax = c.Double(nullable: false),
                    max_output_s = c.Double(nullable: false),
                    min_output_s = c.Double(nullable: false),
                    max_output_tp = c.Double(nullable: false),
                    min_output_tp = c.Double(nullable: false),
                    max_output_hrc = c.Double(nullable: false),
                    min_output_hrc = c.Double(nullable: false),
                    max_output_depth = c.Double(nullable: false),
                    min_output_depth = c.Double(nullable: false),
                    max_output_internalstress_1 = c.Double(nullable: false),
                    min_output_internalstress_1 = c.Double(nullable: false),
                    max_output_internalstress_2 = c.Double(nullable: false),
                    min_output_internalstress_2 = c.Double(nullable: false),
                    max_output_internalstress_3 = c.Double(nullable: false),
                    min_output_internalstress_3 = c.Double(nullable: false),
                    max_input_tolerance = c.Double(nullable: false),
                    min_input_tolerance = c.Double(nullable: false),
                    max_input_ra = c.Double(nullable: false),
                    min_input_ra = c.Double(nullable: false),
                    max_input_rmax = c.Double(nullable: false),
                    min_input_rmax = c.Double(nullable: false),
                    max_input_s = c.Double(nullable: false),
                    min_input_s = c.Double(nullable: false),
                    max_input_tp = c.Double(nullable: false),
                    min_input_tp = c.Double(nullable: false),
                    max_input_hrc = c.Double(nullable: false),
                    min_input_hrc = c.Double(nullable: false),
                    max_input_depth = c.Double(nullable: false),
                    min_input_depth = c.Double(nullable: false),
                    max_input_internalstress_1 = c.Double(nullable: false),
                    min_input_internalstress_1 = c.Double(nullable: false),
                    max_input_internalstress_2 = c.Double(nullable: false),
                    min_input_internalstress_2 = c.Double(nullable: false),
                    max_input_internalstress_3 = c.Double(nullable: false),
                    min_input_internalstress_3 = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.record_id);

            CreateTable(
                "dbo.ERelationCarriages",
                c => new
                {
                    relation_id = c.Int(nullable: false, identity: true),
                    carriage_id = c.Int(nullable: false),
                    relation_carriage_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.relation_id);

            CreateTable(
                "dbo.EGeoTmps",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    deviation_id = c.Int(nullable: false),
                    code_deviation = c.Double(nullable: false),
                    value_deviation = c.Double(nullable: false),
                    class_deviation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EGeoSTmps",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    deviation_id = c.Int(nullable: false),
                    code_deviation = c.Double(nullable: false),
                    value_deviation = c.Double(nullable: false),
                    class_deviation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EFeeds",
                c => new
                {
                    feed_id = c.Int(nullable: false, identity: true),
                    carriage_id = c.Int(nullable: false),
                    axis = c.Int(nullable: false),
                    value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.feed_id);

            CreateTable(
                "dbo.EDevices",
                c => new
                {
                    device_id = c.Int(nullable: false, identity: true),
                    base_scheme_id = c.Int(nullable: false),
                    name = c.String(),
                    code = c.String(),
                    enabled = c.Boolean(nullable: false),
                    description = c.String(),
                })
                .PrimaryKey(t => t.device_id);

            CreateTable(
                "dbo.EDescriptions",
                c => new
                {
                    number_equipment = c.Int(nullable: false, identity: true),
                    id_employee = c.Int(nullable: false),
                    id_company = c.Int(nullable: false),
                    device_id = c.Int(nullable: false),
                    view_process = c.Double(nullable: false),
                    code_surface_output = c.Double(nullable: false),
                    sizesurface_1_max = c.Double(nullable: false),
                    sizesurface_1_min = c.Double(nullable: false),
                    sizesurface_2_max = c.Double(nullable: false),
                    sizesurface_2_min = c.Double(nullable: false),
                    sizesurface_3_max = c.Double(nullable: false),
                    sizesurface_3_min = c.Double(nullable: false),
                    sizesurface_4_max = c.Double(nullable: false),
                    sizesurface_4_min = c.Double(nullable: false),
                    sizesurface_5_max = c.Double(nullable: false),
                    sizesurface_5_min = c.Double(nullable: false),
                    sizesurface_6_max = c.Double(nullable: false),
                    sizesurface_6_min = c.Double(nullable: false),
                    sizesurface_7_max = c.Double(nullable: false),
                    sizesurface_7_min = c.Double(nullable: false),
                    sizesurface_8_max = c.Double(nullable: false),
                    sizesurface_8_min = c.Double(nullable: false),
                    output_tolerance = c.Double(nullable: false),
                    output_ra = c.Double(nullable: false),
                    output_rmax = c.Double(nullable: false),
                    output_s = c.Double(nullable: false),
                    output_tp = c.Double(nullable: false),
                    output_hrc = c.Double(nullable: false),
                    output_depth = c.Double(nullable: false),
                    output_internalstress_1 = c.Double(nullable: false),
                    output_internalstress_2 = c.Double(nullable: false),
                    output_internalstress_3 = c.Double(nullable: false),
                    code_surface_stock = c.String(),
                    input_tolerance = c.Double(nullable: false),
                    input_ra = c.Double(nullable: false),
                    input_rmax = c.Double(nullable: false),
                    input_s = c.Double(nullable: false),
                    input_tp = c.Double(nullable: false),
                    input_hrc = c.Double(nullable: false),
                    input_depth = c.Double(nullable: false),
                    input_internalstress_1 = c.Double(nullable: false),
                    input_internalstress_2 = c.Double(nullable: false),
                    input_internalstress_3 = c.Double(nullable: false),
                    mark_material = c.String(),
                })
                .PrimaryKey(t => t.number_equipment);

            CreateTable(
                "dbo.ECarriages",
                c => new
                {
                    carriage_id = c.Int(nullable: false, identity: true),
                    lathe_id = c.Int(nullable: false),
                    name = c.String(),
                    position_count = c.Double(nullable: false),
                    synchronization = c.Boolean(nullable: false),
                    parallel_processing = c.Boolean(nullable: false),
                    move_x_value = c.Double(nullable: false),
                    move_y_value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.carriage_id);

            CreateTable(
                "dbo.EBaseSurface1",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    number_equipment = c.Double(nullable: false),
                    number_base_surface = c.Double(nullable: false),
                    code_surface = c.Double(nullable: false),
                    com_1_tol = c.String(),
                    com_2_tol = c.String(),
                    com_3_tol = c.String(),
                    com_4_tol = c.String(),
                    com_5_tol = c.String(),
                    com_6_tol = c.String(),
                    com_7_tol = c.String(),
                    com_8_tol = c.String(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EBaseTmps",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    record_id = c.Int(nullable: false),
                    number_base_surface = c.Double(nullable: false),
                    code_surface = c.Double(nullable: false),
                    com_1_max = c.Double(nullable: false),
                    com_1_min = c.Double(nullable: false),
                    com_1_tol = c.String(),
                    com_2_max = c.Double(nullable: false),
                    com_2_min = c.Double(nullable: false),
                    com_2_tol = c.String(),
                    com_3_max = c.Double(nullable: false),
                    com_3_min = c.Double(nullable: false),
                    com_3_tol = c.String(),
                    com_4_max = c.Double(nullable: false),
                    com_4_min = c.Double(nullable: false),
                    com_4_tol = c.String(),
                    loc_processbase_min = c.Double(nullable: false),
                    loc_processbase_max = c.Double(nullable: false),
                    loc_firstbase_min = c.Double(nullable: false),
                    loc_firstbase_max = c.Double(nullable: false),
                    loc_secondbase_min = c.Double(nullable: false),
                    loc_secondbase_max = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EBaseSizes",
                c => new
                {
                    base_requirement_id = c.Int(nullable: false),
                    size_number = c.Double(nullable: false),
                    min_value = c.Double(nullable: false),
                    max_value = c.Double(nullable: false),
                    size_description_id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.base_requirement_id, t.size_number });

            CreateTable(
                "dbo.EBaseSurfaces",
                c => new
                {
                    base_requirement_id = c.Int(nullable: false, identity: true),
                    base_scheme_id = c.Int(nullable: false),
                    base_number = c.Double(nullable: false),
                    code_surface = c.String(),
                    orientation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.base_requirement_id);

            CreateTable(
                "dbo.EBaseLocations",
                c => new
                {
                    base_requirement_id = c.Int(nullable: false),
                    location_number = c.Double(nullable: false),
                    size_x_min = c.Double(nullable: false),
                    size_x_max = c.Double(nullable: false),
                    size_y_min = c.Double(nullable: false),
                    size_y_max = c.Double(nullable: false),
                    size_z_min = c.Double(nullable: false),
                    size_z_max = c.Double(nullable: false),
                })
                .PrimaryKey(t => new { t.base_requirement_id, t.location_number });

            CreateTable(
                "dbo.CopyBaseSurfaces",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    number_equipment = c.Double(nullable: false),
                    number_base_surface = c.Double(nullable: false),
                    code_surface = c.Double(nullable: false),
                    com_1_max = c.Double(nullable: false),
                    com_1_min = c.Double(nullable: false),
                    com_1_tol = c.Double(nullable: false),
                    com_2_max = c.Double(nullable: false),
                    com_2_min = c.Double(nullable: false),
                    com_2_tol = c.Double(nullable: false),
                    com_3_max = c.Double(nullable: false),
                    com_3_min = c.Double(nullable: false),
                    com_3_tol = c.Double(nullable: false),
                    com_4_max = c.Double(nullable: false),
                    com_4_min = c.Double(nullable: false),
                    com_4_tol = c.Double(nullable: false),
                    com_5_max = c.Double(nullable: false),
                    com_5_min = c.Double(nullable: false),
                    com_5_tol = c.Double(nullable: false),
                    com_6_max = c.Double(nullable: false),
                    com_6_min = c.Double(nullable: false),
                    com_6_tol = c.Double(nullable: false),
                    com_7_max = c.Double(nullable: false),
                    com_7_min = c.Double(nullable: false),
                    com_7_tol = c.Double(nullable: false),
                    com_8_max = c.Double(nullable: false),
                    com_8_min = c.Double(nullable: false),
                    com_8_tol = c.Double(nullable: false),
                    locprocess_base_max = c.Double(nullable: false),
                    locprocess_base_min = c.Double(nullable: false),
                    loc_first_base_max = c.Double(nullable: false),
                    loc_first_base_min = c.Double(nullable: false),
                    loc_second_base_max = c.Double(nullable: false),
                    loc_second_base_min = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.CopyBases",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    number_equipment = c.Double(nullable: false),
                    number_base_surface = c.Double(nullable: false),
                    code_surface = c.Double(nullable: false),
                    com_1_tol = c.String(),
                    com_2_tol = c.String(),
                    com_3_tol = c.String(),
                    com_4_tol = c.String(),
                    com_5_tol = c.String(),
                    com_6_tol = c.String(),
                    com_7_tol = c.String(),
                    com_8_tol = c.String(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.CopySMS",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    detail_id = c.Int(nullable: false),
                    surface_id = c.Int(nullable: false),
                    number_variant = c.Double(nullable: false),
                    number_step = c.Double(nullable: false),
                    code_surface = c.String(),
                    finish = c.String(),
                    tolerance = c.Double(nullable: false),
                    symmetry = c.Boolean(nullable: false),
                    zero_point_x = c.Double(nullable: false),
                    zero_point_y = c.Double(nullable: false),
                    zero_point_z = c.Double(nullable: false),
                    surface_size_1 = c.Double(nullable: false),
                    surface_size_2 = c.Double(nullable: false),
                    surface_size_3 = c.Double(nullable: false),
                    surface_size_4 = c.Double(nullable: false),
                    surface_size_5 = c.Double(nullable: false),
                    surface_size_6 = c.Double(nullable: false),
                    surface_size_7 = c.Double(nullable: false),
                    surface_size_8 = c.Double(nullable: false),
                    ra = c.Double(nullable: false),
                    rmax = c.Double(nullable: false),
                    s = c.Double(nullable: false),
                    tp = c.Double(nullable: false),
                    hrc = c.Double(nullable: false),
                    depth = c.Double(nullable: false),
                    base_code = c.Double(nullable: false),
                    orientation = c.Double(nullable: false),
                    device_id = c.Int(nullable: false),
                    view_process = c.Double(nullable: false),
                    number_machining_step = c.Double(nullable: false),
                    not_base = c.Boolean(nullable: false),
                    number_surface = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.CodeSurfaceSizes",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    code_surface_id = c.Int(nullable: false),
                    size_number = c.Double(nullable: false),
                    size_description_id = c.Double(nullable: false),
                    requremeint = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.CodeTypeBillets",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    code_type_billet_id = c.Int(nullable: false),
                    name = c.String(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.CodeSurfaces",
                c => new
                {
                    code_surface_id = c.Int(nullable: false, identity: true),
                    code_surface = c.String(),
                    description = c.String(),
                    view_2d = c.String(),
                    view_3d_small = c.String(),
                    view_3d_big = c.String(),
                })
                .PrimaryKey(t => t.code_surface_id);

            CreateTable(
                "dbo.CodeOrientations",
                c => new
                {
                    orientation_id = c.Int(nullable: false, identity: true),
                    code_orientation = c.Double(nullable: false),
                    description = c.String(),
                })
                .PrimaryKey(t => t.orientation_id);

            CreateTable(
                "dbo.BSizeSurfaces",
                c => new
                {
                    size_id = c.Int(nullable: false, identity: true),
                    surface_id = c.Int(nullable: false),
                    size_description_id = c.Int(nullable: false),
                    nominal = c.Double(nullable: false),
                    finish = c.String(),
                    max_deviation = c.Double(nullable: false),
                    min_deviation = c.Double(nullable: false),
                    tolerance = c.Double(nullable: false),
                    symmetry = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.size_id);

            CreateTable(
                "dbo.BRelationSizes",
                c => new
                {
                    relation_id = c.Int(nullable: false, identity: true),
                    surface_id = c.Int(nullable: false),
                    relation_surface_id = c.Int(nullable: false),
                    size = c.Double(nullable: false),
                    tolerance = c.String(),
                    max_deviation = c.Double(nullable: false),
                    min_deviation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.relation_id);

            CreateTable(
                "dbo.BLocations",
                c => new
                {
                    location_id = c.Int(nullable: false, identity: true),
                    surface_id = c.Int(nullable: false),
                    relation_surface_id = c.Int(nullable: false),
                    code_location_id = c.Int(nullable: false),
                    limit_deviation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.location_id);

            CreateTable(
                "dbo.BGeometries",
                c => new
                {
                    deviation_id = c.Int(nullable: false, identity: true),
                    surface_id = c.Int(nullable: false),
                    code_deviation_id = c.Int(nullable: false),
                    class_deviation = c.Double(nullable: false),
                    value_deviation = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.deviation_id);

            CreateTable(
                "dbo.BaseTmpSizes",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    base_number = c.Double(nullable: false),
                    code_surface = c.Double(nullable: false),
                    orientation = c.Double(nullable: false),
                    size_number = c.Double(nullable: false),
                    size_description_id = c.Double(nullable: false),
                    description = c.String(),
                    max_value = c.Double(nullable: false),
                    min_value = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.BaseTmpLocations",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    base_number = c.Double(nullable: false),
                    location_number = c.Double(nullable: false),
                    size_X_min = c.Double(nullable: false),
                    size_X_max = c.Double(nullable: false),
                    size_Y_min = c.Double(nullable: false),
                    size_Y_max = c.Double(nullable: false),
                    size_Z_min = c.Double(nullable: false),
                    size_Z_max = c.Double(nullable: false),
                    description = c.String(),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.BaseForSMS",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    process_surface_id = c.Int(nullable: false),
                    number_base_schema = c.Double(nullable: false),
                    base_id = c.Int(nullable: false),
                    number_base = c.Double(nullable: false),
                    base_surface_id = c.Int(nullable: false),
                    number_variant = c.Double(nullable: false),
                    number_step = c.Double(nullable: false),
                    reverse = c.Boolean(nullable: false),
                    number_base_surface = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Bases",
                c => new
                {
                    device_id = c.Int(nullable: false, identity: true),
                    number_base_surface = c.Int(nullable: false),
                    code_surface = c.Double(nullable: false),
                    orientation = c.Double(nullable: false),
                    com_1_max = c.Double(nullable: false),
                    com_1_min = c.Double(nullable: false),
                    com_2_max = c.Double(nullable: false),
                    com_2_min = c.Double(nullable: false),
                    com_3_max = c.Double(nullable: false),
                    com_3_min = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.device_id);

            CreateTable(
                "dbo.Axes",
                c => new
                {
                    axis_id = c.Int(nullable: false, identity: true),
                    name = c.String(),
                })
                .PrimaryKey(t => t.axis_id);

            AddColumn("dbo.Routes", "t_piece", c => c.Double(nullable: false));
            AddColumn("dbo.Routes", "t_base", c => c.Double(nullable: false));
            AddColumn("dbo.RouteCards", "id_employee", c => c.Int());
            AddColumn("dbo.RouteCards", "id_company", c => c.Int());
            AddColumn("dbo.SurfaceCatalogs", "description", c => c.String());
            AddColumn("dbo.Records", "Status_id_status", c => c.Int());
            AddColumn("dbo.Operations", "number_group", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "symmetry", c => c.Boolean(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "tolerance", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "min_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "max_deviation", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "finish", c => c.String());
            AddColumn("dbo.DSizeSurfaces", "nominal", c => c.Double(nullable: false));
            AddColumn("dbo.DSizeSurfaces", "size_description_id", c => c.Int(nullable: false));
            AddColumn("dbo.DRelationSizes", "relation_surface_id", c => c.Int(nullable: false));
            AddColumn("dbo.DLocations", "code_location_id", c => c.Int(nullable: false));
            AddColumn("dbo.DLocations", "relation_surface_id", c => c.Int(nullable: false));
            AddColumn("dbo.DSurfaces", "requirement", c => c.Boolean(nullable: false));
            AddColumn("dbo.DGeometries", "code_deviation_id", c => c.Int(nullable: false));
            AddColumn("dbo.DDescriptions", "length", c => c.Double(nullable: false));
            AddColumn("dbo.DDescriptions", "id_company", c => c.Int(nullable: false));
            AddColumn("dbo.CodeDeviationLocations", "image_small", c => c.String());
            AddColumn("dbo.CodeDeviationLocations", "image_big", c => c.String());
            AddColumn("dbo.CodeDeviationLocations", "description", c => c.String());
            AddColumn("dbo.CodeDeviationGeometries", "image_small", c => c.String());
            AddColumn("dbo.CodeDeviationGeometries", "image_big", c => c.String());
            AddColumn("dbo.CodeDeviationGeometries", "description", c => c.String());
            AddColumn("dbo.BSurfaces", "rnax", c => c.Double(nullable: false));
            AddColumn("dbo.BSurfaces", "code_surface_id", c => c.Int(nullable: false));
            AddColumn("dbo.BDescriptions", "code_type_billet_id", c => c.Int(nullable: false));
            AddColumn("dbo.BDescriptions", "detail_id", c => c.Int(nullable: false));
            AddColumn("dbo.BDescriptions", "id_company", c => c.Int(nullable: false));
            DropForeignKey("dbo.Routes", "number_equipment", "dbo.ELathes");
            DropForeignKey("dbo.RouteCards", "detail_id", "dbo.DDescriptions");
            DropForeignKey("dbo.RouteCards", "billet_id", "dbo.BDescriptions");
            DropForeignKey("dbo.EGroups", "id_employee", "dbo.Employees");
            DropIndex("dbo.RouteCards", new[] { "billet_id" });
            DropIndex("dbo.RouteCards", new[] { "detail_id" });
            DropIndex("dbo.EGroups", new[] { "id_employee" });
            DropColumn("dbo.RouteCards", "profile_sizes");
            DropColumn("dbo.RouteCards", "billet_id");
            DropColumn("dbo.RouteCards", "detail_id");
            DropColumn("dbo.SurfaceCatalogs", "view_big");
            DropColumn("dbo.SurfaceCatalogs", "view_small");
            DropColumn("dbo.SurfaceCatalogs", "name");
            DropColumn("dbo.SurfaceCatalogs", "model");
            DropColumn("dbo.EGroups", "id_employee");
            DropColumn("dbo.DSizeSurfaces", "max_min_deviation");
            DropColumn("dbo.DSizeSurfaces", "max_max_deviation");
            DropColumn("dbo.DSizeSurfaces", "max_tolerance");
            DropColumn("dbo.DSizeSurfaces", "max_size");
            DropColumn("dbo.DSizeSurfaces", "min_min_deviation");
            DropColumn("dbo.DSizeSurfaces", "min_max_deviation");
            DropColumn("dbo.DSizeSurfaces", "min_tolerance");
            DropColumn("dbo.DSizeSurfaces", "min_size");
            DropColumn("dbo.DRelationSizes", "relation_number");
            DropColumn("dbo.DLocations", "type_deviation");
            DropColumn("dbo.DLocations", "relation_surface");
            DropColumn("dbo.DSurfaces", "name_surface");
            DropColumn("dbo.DGeometries", "type_deviation");
            DropColumn("dbo.CodeDeviationLocations", "image");
            DropColumn("dbo.CodeDeviationLocations", "type");
            DropColumn("dbo.CodeDeviationGeometries", "image");
            DropColumn("dbo.CodeDeviationGeometries", "type");
            DropColumn("dbo.BSurfaces", "constructor_base");
            DropColumn("dbo.BSurfaces", "internal_stress_3");
            DropColumn("dbo.BSurfaces", "internal_stress_2");
            DropColumn("dbo.BSurfaces", "internal_stress_1");
            DropColumn("dbo.BSurfaces", "depth");
            DropColumn("dbo.BSurfaces", "hrc");
            DropColumn("dbo.BSurfaces", "tp");
            DropColumn("dbo.BSurfaces", "rmax");
            DropColumn("dbo.BSurfaces", "orientation");
            DropColumn("dbo.BSurfaces", "type_surface");
            DropColumn("dbo.BDescriptions", "mark_material");
            DropColumn("dbo.BDescriptions", "central_hole");
            DropColumn("dbo.BDescriptions", "size_transmission");
            DropColumn("dbo.BDescriptions", "size_production");
            DropColumn("dbo.BDescriptions", "code");
            CreateIndex("dbo.RouteCards", "id_employee");
            CreateIndex("dbo.RouteCards", "id_company");
            CreateIndex("dbo.Records", "Status_id_status");
            CreateIndex("dbo.ETransitionSizes", "transition_id");
            CreateIndex("dbo.ETransitionGeometryOutputs", "transition_id");
            CreateIndex("dbo.ETransitionBaseTolerances", "base_requirement_id");
            CreateIndex("dbo.ETransitionBases", "transition_id");
            CreateIndex("dbo.ETransitions", "base_scheme_id");
            CreateIndex("dbo.ETransitionGeometryInputs", "transition_id");
            CreateIndex("dbo.ESpindles", "lathe_id");
            CreateIndex("dbo.ESpeeds", "spindle_id");
            CreateIndex("dbo.ERelationCarriages", "carriage_id");
            CreateIndex("dbo.EFeeds", "carriage_id");
            CreateIndex("dbo.EDevices", "base_scheme_id");
            CreateIndex("dbo.EDescriptions", "id_company");
            CreateIndex("dbo.EDescriptions", "id_employee");
            CreateIndex("dbo.ECarriages", "lathe_id");
            CreateIndex("dbo.EBaseSizes", "base_requirement_id");
            CreateIndex("dbo.EBaseSurfaces", "base_scheme_id");
            CreateIndex("dbo.EBaseLocations", "base_requirement_id");
            CreateIndex("dbo.DDescriptions", "id_company");
            CreateIndex("dbo.CodeSurfaceSizes", "code_surface_id");
            CreateIndex("dbo.BSizeSurfaces", "surface_id");
            CreateIndex("dbo.BRelationSizes", "surface_id");
            CreateIndex("dbo.BLocations", "surface_id");
            CreateIndex("dbo.BGeometries", "surface_id");
            CreateIndex("dbo.BDescriptions", "id_company");
            AddForeignKey("dbo.Routes", "number_equipment", "dbo.EDescriptions", "number_equipment", cascadeDelete: true);
            AddForeignKey("dbo.RouteCards", "id_employee", "dbo.Employees", "id_employee");
            AddForeignKey("dbo.RouteCards", "id_company", "dbo.Companies", "id_company");
            AddForeignKey("dbo.Records", "Status_id_status", "dbo.Status", "id_status");
            AddForeignKey("dbo.ETransitionSizes", "transition_id", "dbo.ETransitions", "transition_id", cascadeDelete: true);
            AddForeignKey("dbo.ETransitionGeometryOutputs", "transition_id", "dbo.ETransitions", "transition_id", cascadeDelete: true);
            AddForeignKey("dbo.ETransitionBaseTolerances", "base_requirement_id", "dbo.ETransitionBases", "base_requirement_id", cascadeDelete: true);
            AddForeignKey("dbo.ETransitionBases", "transition_id", "dbo.ETransitions", "transition_id", cascadeDelete: true);
            AddForeignKey("dbo.ETransitionGeometryInputs", "transition_id", "dbo.ETransitions", "transition_id", cascadeDelete: true);
            AddForeignKey("dbo.ETransitions", "base_scheme_id", "dbo.EBaseSchemes", "base_scheme_id", cascadeDelete: true);
            AddForeignKey("dbo.ESpeeds", "spindle_id", "dbo.ESpindles", "spindle_id", cascadeDelete: true);
            AddForeignKey("dbo.ESpindles", "lathe_id", "dbo.ELathes", "lathe_id", cascadeDelete: true);
            AddForeignKey("dbo.ERelationCarriages", "carriage_id", "dbo.ECarriages", "carriage_id", cascadeDelete: true);
            AddForeignKey("dbo.EFeeds", "carriage_id", "dbo.ECarriages", "carriage_id", cascadeDelete: true);
            AddForeignKey("dbo.EDevices", "base_scheme_id", "dbo.EBaseSchemes", "base_scheme_id", cascadeDelete: true);
            AddForeignKey("dbo.EDescriptions", "id_employee", "dbo.Employees", "id_employee", cascadeDelete: true);
            AddForeignKey("dbo.EDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: true);
            AddForeignKey("dbo.ECarriages", "lathe_id", "dbo.ELathes", "lathe_id", cascadeDelete: true);
            AddForeignKey("dbo.EBaseSizes", "base_requirement_id", "dbo.EBaseSurfaces", "base_requirement_id", cascadeDelete: true);
            AddForeignKey("dbo.EBaseLocations", "base_requirement_id", "dbo.EBaseSurfaces", "base_requirement_id", cascadeDelete: true);
            AddForeignKey("dbo.EBaseSurfaces", "base_scheme_id", "dbo.EBaseSchemes", "base_scheme_id", cascadeDelete: true);
            AddForeignKey("dbo.DDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: true);
            AddForeignKey("dbo.CodeSurfaceSizes", "code_surface_id", "dbo.CodeSurfaces", "code_surface_id", cascadeDelete: true);
            AddForeignKey("dbo.BSizeSurfaces", "surface_id", "dbo.BSurfaces", "surface_id", cascadeDelete: true);
            AddForeignKey("dbo.BRelationSizes", "surface_id", "dbo.BSurfaces", "surface_id", cascadeDelete: true);
            AddForeignKey("dbo.BLocations", "surface_id", "dbo.BSurfaces", "surface_id", cascadeDelete: true);
            AddForeignKey("dbo.BGeometries", "surface_id", "dbo.BSurfaces", "surface_id", cascadeDelete: true);
            AddForeignKey("dbo.BDescriptions", "id_company", "dbo.Companies", "id_company", cascadeDelete: true);
        }
    }
}