namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Axes",
                c => new
                    {
                        axis_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.axis_id);
            
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
                "dbo.BDescriptions",
                c => new
                    {
                        billet_id = c.Int(nullable: false, identity: true),
                        detail_id = c.Int(nullable: false),
                        code_type_billet_id = c.Int(nullable: false),
                        mass_billet = c.Double(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.billet_id);
            
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
                .PrimaryKey(t => t.deviation_id)
                .ForeignKey("dbo.BSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
            CreateTable(
                "dbo.BSurfaces",
                c => new
                    {
                        surface_id = c.Int(nullable: false, identity: true),
                        billet_id = c.Int(nullable: false),
                        number_surface = c.Double(nullable: false),
                        code_surface_id = c.Int(nullable: false),
                        zero_point_X = c.Double(nullable: false),
                        zero_point_Y = c.Double(nullable: false),
                        zero_point_Z = c.Double(nullable: false),
                        ra = c.Double(nullable: false),
                        rnax = c.Double(nullable: false),
                        s = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.surface_id)
                .ForeignKey("dbo.BDescriptions", t => t.billet_id, cascadeDelete: true)
                .Index(t => t.billet_id);
            
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
                .PrimaryKey(t => t.location_id)
                .ForeignKey("dbo.BSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
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
                .PrimaryKey(t => t.relation_id)
                .ForeignKey("dbo.BSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
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
                .PrimaryKey(t => t.size_id)
                .ForeignKey("dbo.BSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
            CreateTable(
                "dbo.CodeDeviationGeometries",
                c => new
                    {
                        code_geo_deviation_id = c.Int(nullable: false, identity: true),
                        description = c.String(),
                        image_big = c.String(),
                        image_small = c.String(),
                    })
                .PrimaryKey(t => t.code_geo_deviation_id);
            
            CreateTable(
                "dbo.CodeDeviationLocations",
                c => new
                    {
                        code_geo_deviation_id = c.Int(nullable: false, identity: true),
                        description = c.String(),
                        image_big = c.String(),
                        image_small = c.String(),
                    })
                .PrimaryKey(t => t.code_geo_deviation_id);
            
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
                "dbo.CodeTypeBillets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code_type_billet_id = c.Int(nullable: false),
                        name = c.String(),
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
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CodeSurfaces", t => t.code_surface_id, cascadeDelete: true)
                .Index(t => t.code_surface_id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id_company = c.Int(nullable: false, identity: true),
                        responsible_employee = c.Int(nullable: false),
                        numberof_branch = c.Int(nullable: false),
                        name = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.id_company);
            
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
                "dbo.DDescriptions",
                c => new
                    {
                        detail_id = c.Int(nullable: false, identity: true),
                        code_detail = c.String(),
                        name_detail = c.String(),
                        mark_material = c.String(),
                        size_production = c.Double(nullable: false),
                        size_transmission = c.Double(nullable: false),
                        mass_detail = c.Double(nullable: false),
                        length = c.Double(nullable: false),
                        central_hole = c.Boolean(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.detail_id);
            
            CreateTable(
                "dbo.DGeometries",
                c => new
                    {
                        deviation_id = c.Int(nullable: false, identity: true),
                        surface_id = c.Int(nullable: false),
                        code_deviation_id = c.Int(nullable: false),
                        class_deviation = c.Double(nullable: false),
                        value_deviation = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.deviation_id)
                .ForeignKey("dbo.DSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
            CreateTable(
                "dbo.DSurfaces",
                c => new
                    {
                        surface_id = c.Int(nullable: false, identity: true),
                        detail_id = c.Int(nullable: false),
                        number_surface = c.Double(nullable: false),
                        code_surface = c.String(),
                        zero_point_X = c.Double(nullable: false),
                        zero_point_Y = c.Double(nullable: false),
                        zero_point_Z = c.Double(nullable: false),
                        ra = c.Double(nullable: false),
                        rmax = c.Double(nullable: false),
                        s = c.Double(nullable: false),
                        tp = c.Double(nullable: false),
                        hrc = c.Double(nullable: false),
                        depth = c.Double(nullable: false),
                        internal_stress_1 = c.Double(nullable: false),
                        internal_stress_2 = c.Double(nullable: false),
                        internal_stress_3 = c.Double(nullable: false),
                        constructor_base = c.Boolean(nullable: false),
                        orientation = c.Double(nullable: false),
                        requirement = c.Boolean(nullable: false),
                        image = c.String(),
                    })
                .PrimaryKey(t => t.surface_id)
                .ForeignKey("dbo.DDescriptions", t => t.detail_id, cascadeDelete: true)
                .Index(t => t.detail_id);
            
            CreateTable(
                "dbo.DLocations",
                c => new
                    {
                        location_id = c.Int(nullable: false, identity: true),
                        surface_id = c.Int(nullable: false),
                        relation_surface_id = c.Int(nullable: false),
                        code_location_id = c.Int(nullable: false),
                        limit_deviation = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.location_id)
                .ForeignKey("dbo.DSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
            CreateTable(
                "dbo.DRelationSizes",
                c => new
                    {
                        relation_id = c.Int(nullable: false, identity: true),
                        surface_id = c.Int(nullable: false),
                        relation_surface_id = c.Int(nullable: false),
                        size = c.Double(nullable: false),
                        tolerance = c.String(),
                        min_deviation = c.Double(nullable: false),
                        max_deviation = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.relation_id)
                .ForeignKey("dbo.DSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
            CreateTable(
                "dbo.DSizeSurfaces",
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
                .PrimaryKey(t => t.size_id)
                .ForeignKey("dbo.DSurfaces", t => t.surface_id, cascadeDelete: true)
                .Index(t => t.surface_id);
            
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
                .PrimaryKey(t => new { t.base_requirement_id, t.location_number })
                .ForeignKey("dbo.EBaseSurfaces", t => t.base_requirement_id, cascadeDelete: true)
                .Index(t => t.base_requirement_id);
            
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
                .PrimaryKey(t => t.base_requirement_id)
                .ForeignKey("dbo.EBaseSchemes", t => t.base_scheme_id, cascadeDelete: true)
                .Index(t => t.base_scheme_id);
            
            CreateTable(
                "dbo.EBaseSchemes",
                c => new
                    {
                        base_scheme_id = c.Int(nullable: false, identity: true),
                        lathe_id = c.Int(nullable: false),
                        name = c.String(),
                        enabled = c.Boolean(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.base_scheme_id)
                .ForeignKey("dbo.ELathes", t => t.lathe_id, cascadeDelete: true)
                .Index(t => t.lathe_id);
            
            CreateTable(
                "dbo.ELathes",
                c => new
                    {
                        lathe_id = c.Int(nullable: false, identity: true),
                        group_id = c.Int(nullable: false),
                        name = c.String(),
                        code = c.String(),
                        enabled = c.Boolean(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.lathe_id)
                .ForeignKey("dbo.EGroups", t => t.group_id, cascadeDelete: true)
                .Index(t => t.group_id);
            
            CreateTable(
                "dbo.EGroups",
                c => new
                    {
                        group_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.group_id);
            
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
                .PrimaryKey(t => new { t.base_requirement_id, t.size_number })
                .ForeignKey("dbo.EBaseSurfaces", t => t.base_requirement_id, cascadeDelete: true)
                .Index(t => t.base_requirement_id);
            
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
                .PrimaryKey(t => t.carriage_id)
                .ForeignKey("dbo.ELathes", t => t.lathe_id, cascadeDelete: true)
                .Index(t => t.lathe_id);
            
            CreateTable(
                "dbo.EDescriptions",
                c => new
                    {
                        number_equipment = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.device_id)
                .ForeignKey("dbo.EBaseSchemes", t => t.base_scheme_id, cascadeDelete: true)
                .Index(t => t.base_scheme_id);
            
            CreateTable(
                "dbo.EFeeds",
                c => new
                    {
                        feed_id = c.Int(nullable: false, identity: true),
                        carriage_id = c.Int(nullable: false),
                        axis = c.Int(nullable: false),
                        value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.feed_id)
                .ForeignKey("dbo.ECarriages", t => t.carriage_id, cascadeDelete: true)
                .Index(t => t.carriage_id);
            
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
                "dbo.Employees",
                c => new
                    {
                        id_employee = c.Int(nullable: false, identity: true),
                        id_role = c.Int(nullable: false),
                        id_company = c.Int(nullable: false),
                        first_name = c.String(),
                        second_name = c.String(),
                        patronymic = c.String(),
                        login = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id_employee)
                .ForeignKey("dbo.Companies", t => t.id_company, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.id_role)
                .Index(t => t.id_role)
                .Index(t => t.id_company);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id_role = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        canEnter = c.Boolean(nullable: false),
                        canGetData = c.Boolean(nullable: false),
                        canEdit = c.Boolean(nullable: false),
                        canEditCatalog = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_role);
            
            CreateTable(
                "dbo.EquipmentCatalogs",
                c => new
                    {
                        equipment_code = c.Int(nullable: false, identity: true),
                        model = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.equipment_code);
            
            CreateTable(
                "dbo.ERelationCarriages",
                c => new
                    {
                        relation_id = c.Int(nullable: false, identity: true),
                        carriage_id = c.Int(nullable: false),
                        relation_carriage_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.relation_id)
                .ForeignKey("dbo.ECarriages", t => t.carriage_id, cascadeDelete: true)
                .Index(t => t.carriage_id);
            
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
                "dbo.ESpeeds",
                c => new
                    {
                        speed_id = c.Int(nullable: false, identity: true),
                        spindle_id = c.Int(nullable: false),
                        reverse = c.Boolean(nullable: false),
                        value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.speed_id)
                .ForeignKey("dbo.ESpindles", t => t.spindle_id, cascadeDelete: true)
                .Index(t => t.spindle_id);
            
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
                .PrimaryKey(t => t.spindle_id)
                .ForeignKey("dbo.ELathes", t => t.lathe_id, cascadeDelete: true)
                .Index(t => t.lathe_id);
            
            CreateTable(
                "dbo.ETransitionGeometryInputs",
                c => new
                    {
                        transition_id = c.Int(nullable: false),
                        code_deviation_id = c.Int(nullable: false),
                        value = c.Double(nullable: false),
                        class_ = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.transition_id, t.code_deviation_id })
                .ForeignKey("dbo.ETransitions", t => t.transition_id, cascadeDelete: true)
                .Index(t => t.transition_id);
            
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
                .PrimaryKey(t => t.transition_id)
                .ForeignKey("dbo.EBaseSchemes", t => t.base_scheme_id, cascadeDelete: true)
                .Index(t => t.base_scheme_id);
            
            CreateTable(
                "dbo.ETransitionBases",
                c => new
                    {
                        base_requirement_id = c.Int(nullable: false, identity: true),
                        transition_id = c.Int(nullable: false),
                        base_number = c.Double(nullable: false),
                        code_surface = c.String(),
                    })
                .PrimaryKey(t => t.base_requirement_id)
                .ForeignKey("dbo.ETransitions", t => t.transition_id, cascadeDelete: true)
                .Index(t => t.transition_id);
            
            CreateTable(
                "dbo.ETransitionBaseTolerances",
                c => new
                    {
                        base_requirement_id = c.Int(nullable: false),
                        size_number = c.Double(nullable: false),
                        tolerance = c.Double(nullable: false),
                        size_description_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.base_requirement_id, t.size_number })
                .ForeignKey("dbo.ETransitionBases", t => t.base_requirement_id, cascadeDelete: true)
                .Index(t => t.base_requirement_id);
            
            CreateTable(
                "dbo.ETransitionGeometryOutputs",
                c => new
                    {
                        transition_id = c.Int(nullable: false),
                        code_deviation_id = c.Int(nullable: false),
                        value = c.Double(nullable: false),
                        class_ = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.transition_id, t.code_deviation_id })
                .ForeignKey("dbo.ETransitions", t => t.transition_id, cascadeDelete: true)
                .Index(t => t.transition_id);
            
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
                .PrimaryKey(t => new { t.transition_id, t.size_number })
                .ForeignKey("dbo.ETransitions", t => t.transition_id, cascadeDelete: true)
                .Index(t => t.transition_id);
            
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
                "dbo.FixtureCatalogs",
                c => new
                    {
                        fixture_code = c.Int(nullable: false, identity: true),
                        fixture_value = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.fixture_code);
            
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
                "dbo.Operations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        number_operation = c.Double(nullable: false),
                        number_group = c.Double(nullable: false),
                        name_operation = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProcessCatalogs",
                c => new
                    {
                        process_code = c.Int(nullable: false, identity: true),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.process_code);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        id_record = c.Int(nullable: false, identity: true),
                        id_company = c.Int(nullable: false),
                        id_employee = c.Int(nullable: false),
                        id_status = c.Int(nullable: false),
                        equipment_code = c.Int(nullable: false),
                        fixture_code = c.Int(nullable: false),
                        process_code = c.Int(nullable: false),
                        surface_code = c.Int(nullable: false),
                        surf_min_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_min_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_max_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_complexSurface_code = c.Int(nullable: false),
                        surf_qualification = c.Int(nullable: false),
                        surf_Ra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_Rmax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_S = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_tp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_hardnessHRC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_voltage1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_voltage2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_voltage3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_straightness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_flatness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_roundness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_cylindricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_longitudinalSectionProfile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_radialBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_faceBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_fullRadialBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_fullFaceBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_formProfile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        surf_formSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_surfaceCode = c.Int(nullable: false),
                        bil_min_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_min_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_max_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_complexSurface_code = c.Int(nullable: false),
                        bil_qualification = c.Int(nullable: false),
                        bil_Ra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_Rmax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_S = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_tp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_hardnessHRC = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_voltage1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_voltage2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_voltage3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_straightness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_flatness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_roundness = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_cylindricity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_longitudinalSectionProfile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_radialBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_faceBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_fullRadialBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_fullFaceBeat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_formProfile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        bil_formSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_surfaceCode = c.Int(nullable: false),
                        fbs_min_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_min_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_complexSurface_code = c.Int(nullable: false),
                        fbs_min_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fbs_max_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_surfaceCode = c.Int(nullable: false),
                        sbs_min_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_complexSurface_code = c.Int(nullable: false),
                        sbs_min_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_min_toFbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sbs_max_toFbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_surfaceCode = c.Int(nullable: false),
                        tbs_min_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_sd = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_ld = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_length = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_angleX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_angleY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_angleZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_distPlaneX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_distPlaneY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_distPlaneZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_complexSurface_code = c.Int(nullable: false),
                        tbs_min_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_toSurface = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_toFbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_toFbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_min_toSbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        tbs_max_toSbs = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id_record)
                .ForeignKey("dbo.SurfaceCatalogs", t => t.bil_surfaceCode)
                .ForeignKey("dbo.Companies", t => t.id_company, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.id_employee)
                .ForeignKey("dbo.EquipmentCatalogs", t => t.equipment_code)
                .ForeignKey("dbo.SurfaceCatalogs", t => t.fbs_surfaceCode)
                .ForeignKey("dbo.FixtureCatalogs", t => t.fixture_code)
                .ForeignKey("dbo.ProcessCatalogs", t => t.process_code)
                .ForeignKey("dbo.SurfaceCatalogs", t => t.sbs_surfaceCode)
                .ForeignKey("dbo.Status", t => t.id_status)
                .ForeignKey("dbo.SurfaceCatalogs", t => t.surface_code)
                .ForeignKey("dbo.SurfaceCatalogs", t => t.tbs_surfaceCode)
                .Index(t => t.id_company)
                .Index(t => t.id_employee)
                .Index(t => t.id_status)
                .Index(t => t.equipment_code)
                .Index(t => t.fixture_code)
                .Index(t => t.process_code)
                .Index(t => t.surface_code)
                .Index(t => t.bil_surfaceCode)
                .Index(t => t.fbs_surfaceCode)
                .Index(t => t.sbs_surfaceCode)
                .Index(t => t.tbs_surfaceCode);
            
            CreateTable(
                "dbo.SurfaceCatalogs",
                c => new
                    {
                        surface_code = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.surface_code);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id_status = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id_status);
            
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
                "dbo.TypeProcesses",
                c => new
                    {
                        type_process_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.type_process_id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Records", "tbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "surface_code", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "id_status", "dbo.Status");
            DropForeignKey("dbo.Records", "sbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "process_code", "dbo.ProcessCatalogs");
            DropForeignKey("dbo.Records", "fixture_code", "dbo.FixtureCatalogs");
            DropForeignKey("dbo.Records", "fbs_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.Records", "equipment_code", "dbo.EquipmentCatalogs");
            DropForeignKey("dbo.Records", "id_employee", "dbo.Employees");
            DropForeignKey("dbo.Records", "id_company", "dbo.Companies");
            DropForeignKey("dbo.Records", "bil_surfaceCode", "dbo.SurfaceCatalogs");
            DropForeignKey("dbo.ETransitionSizes", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionGeometryOutputs", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionBaseTolerances", "base_requirement_id", "dbo.ETransitionBases");
            DropForeignKey("dbo.ETransitionBases", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitionGeometryInputs", "transition_id", "dbo.ETransitions");
            DropForeignKey("dbo.ETransitions", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.ESpeeds", "spindle_id", "dbo.ESpindles");
            DropForeignKey("dbo.ESpindles", "lathe_id", "dbo.ELathes");
            DropForeignKey("dbo.ERelationCarriages", "carriage_id", "dbo.ECarriages");
            DropForeignKey("dbo.Employees", "id_role", "dbo.Roles");
            DropForeignKey("dbo.Employees", "id_company", "dbo.Companies");
            DropForeignKey("dbo.EFeeds", "carriage_id", "dbo.ECarriages");
            DropForeignKey("dbo.EDevices", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.ECarriages", "lathe_id", "dbo.ELathes");
            DropForeignKey("dbo.EBaseSizes", "base_requirement_id", "dbo.EBaseSurfaces");
            DropForeignKey("dbo.EBaseLocations", "base_requirement_id", "dbo.EBaseSurfaces");
            DropForeignKey("dbo.EBaseSurfaces", "base_scheme_id", "dbo.EBaseSchemes");
            DropForeignKey("dbo.EBaseSchemes", "lathe_id", "dbo.ELathes");
            DropForeignKey("dbo.ELathes", "group_id", "dbo.EGroups");
            DropForeignKey("dbo.DSizeSurfaces", "surface_id", "dbo.DSurfaces");
            DropForeignKey("dbo.DRelationSizes", "surface_id", "dbo.DSurfaces");
            DropForeignKey("dbo.DLocations", "surface_id", "dbo.DSurfaces");
            DropForeignKey("dbo.DGeometries", "surface_id", "dbo.DSurfaces");
            DropForeignKey("dbo.DSurfaces", "detail_id", "dbo.DDescriptions");
            DropForeignKey("dbo.CodeSurfaceSizes", "code_surface_id", "dbo.CodeSurfaces");
            DropForeignKey("dbo.BSizeSurfaces", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BRelationSizes", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BLocations", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BGeometries", "surface_id", "dbo.BSurfaces");
            DropForeignKey("dbo.BSurfaces", "billet_id", "dbo.BDescriptions");
            DropIndex("dbo.Records", new[] { "tbs_surfaceCode" });
            DropIndex("dbo.Records", new[] { "sbs_surfaceCode" });
            DropIndex("dbo.Records", new[] { "fbs_surfaceCode" });
            DropIndex("dbo.Records", new[] { "bil_surfaceCode" });
            DropIndex("dbo.Records", new[] { "surface_code" });
            DropIndex("dbo.Records", new[] { "process_code" });
            DropIndex("dbo.Records", new[] { "fixture_code" });
            DropIndex("dbo.Records", new[] { "equipment_code" });
            DropIndex("dbo.Records", new[] { "id_status" });
            DropIndex("dbo.Records", new[] { "id_employee" });
            DropIndex("dbo.Records", new[] { "id_company" });
            DropIndex("dbo.ETransitionSizes", new[] { "transition_id" });
            DropIndex("dbo.ETransitionGeometryOutputs", new[] { "transition_id" });
            DropIndex("dbo.ETransitionBaseTolerances", new[] { "base_requirement_id" });
            DropIndex("dbo.ETransitionBases", new[] { "transition_id" });
            DropIndex("dbo.ETransitions", new[] { "base_scheme_id" });
            DropIndex("dbo.ETransitionGeometryInputs", new[] { "transition_id" });
            DropIndex("dbo.ESpindles", new[] { "lathe_id" });
            DropIndex("dbo.ESpeeds", new[] { "spindle_id" });
            DropIndex("dbo.ERelationCarriages", new[] { "carriage_id" });
            DropIndex("dbo.Employees", new[] { "id_company" });
            DropIndex("dbo.Employees", new[] { "id_role" });
            DropIndex("dbo.EFeeds", new[] { "carriage_id" });
            DropIndex("dbo.EDevices", new[] { "base_scheme_id" });
            DropIndex("dbo.ECarriages", new[] { "lathe_id" });
            DropIndex("dbo.EBaseSizes", new[] { "base_requirement_id" });
            DropIndex("dbo.ELathes", new[] { "group_id" });
            DropIndex("dbo.EBaseSchemes", new[] { "lathe_id" });
            DropIndex("dbo.EBaseSurfaces", new[] { "base_scheme_id" });
            DropIndex("dbo.EBaseLocations", new[] { "base_requirement_id" });
            DropIndex("dbo.DSizeSurfaces", new[] { "surface_id" });
            DropIndex("dbo.DRelationSizes", new[] { "surface_id" });
            DropIndex("dbo.DLocations", new[] { "surface_id" });
            DropIndex("dbo.DSurfaces", new[] { "detail_id" });
            DropIndex("dbo.DGeometries", new[] { "surface_id" });
            DropIndex("dbo.CodeSurfaceSizes", new[] { "code_surface_id" });
            DropIndex("dbo.BSizeSurfaces", new[] { "surface_id" });
            DropIndex("dbo.BRelationSizes", new[] { "surface_id" });
            DropIndex("dbo.BLocations", new[] { "surface_id" });
            DropIndex("dbo.BSurfaces", new[] { "billet_id" });
            DropIndex("dbo.BGeometries", new[] { "surface_id" });
            DropTable("dbo.Words");
            DropTable("dbo.TypeProcesses");
            DropTable("dbo.Trees");
            DropTable("dbo.SMS");
            DropTable("dbo.SizeDescriptions");
            DropTable("dbo.Status");
            DropTable("dbo.SurfaceCatalogs");
            DropTable("dbo.Records");
            DropTable("dbo.ProcessCatalogs");
            DropTable("dbo.Operations");
            DropTable("dbo.NewSMS");
            DropTable("dbo.GroupOperations");
            DropTable("dbo.FixtureCatalogs");
            DropTable("dbo.ExchangeSizes");
            DropTable("dbo.ETransitionSizes");
            DropTable("dbo.ETransitionGeometryOutputs");
            DropTable("dbo.ETransitionBaseTolerances");
            DropTable("dbo.ETransitionBases");
            DropTable("dbo.ETransitions");
            DropTable("dbo.ETransitionGeometryInputs");
            DropTable("dbo.ESpindles");
            DropTable("dbo.ESpeeds");
            DropTable("dbo.EResults");
            DropTable("dbo.ERelationCarriages");
            DropTable("dbo.EquipmentCatalogs");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.EGeoTmps");
            DropTable("dbo.EGeoSTmps");
            DropTable("dbo.EFeeds");
            DropTable("dbo.EDevices");
            DropTable("dbo.EDescriptions");
            DropTable("dbo.ECarriages");
            DropTable("dbo.EBaseSurface1");
            DropTable("dbo.EBaseTmps");
            DropTable("dbo.EBaseSizes");
            DropTable("dbo.EGroups");
            DropTable("dbo.ELathes");
            DropTable("dbo.EBaseSchemes");
            DropTable("dbo.EBaseSurfaces");
            DropTable("dbo.EBaseLocations");
            DropTable("dbo.DSizeSurfaces");
            DropTable("dbo.DRelationSizes");
            DropTable("dbo.DLocations");
            DropTable("dbo.DSurfaces");
            DropTable("dbo.DGeometries");
            DropTable("dbo.DDescriptions");
            DropTable("dbo.CopyBaseSurfaces");
            DropTable("dbo.CopyBases");
            DropTable("dbo.CopySMS");
            DropTable("dbo.Companies");
            DropTable("dbo.CodeSurfaceSizes");
            DropTable("dbo.CodeTypeBillets");
            DropTable("dbo.CodeSurfaces");
            DropTable("dbo.CodeOrientations");
            DropTable("dbo.CodeDeviationLocations");
            DropTable("dbo.CodeDeviationGeometries");
            DropTable("dbo.BSizeSurfaces");
            DropTable("dbo.BRelationSizes");
            DropTable("dbo.BLocations");
            DropTable("dbo.BSurfaces");
            DropTable("dbo.BGeometries");
            DropTable("dbo.BDescriptions");
            DropTable("dbo.BaseTmpSizes");
            DropTable("dbo.BaseTmpLocations");
            DropTable("dbo.BaseForSMS");
            DropTable("dbo.Bases");
            DropTable("dbo.Axes");
        }
    }
}
