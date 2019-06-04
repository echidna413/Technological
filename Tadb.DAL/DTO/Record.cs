using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tadb.DAL
{
    public class Record
    {
        #region Конструктор

        public Record()
        {
        }

        public Record(int id_employee, int id_status, int equipment_code, int fixture_code, int process_code, int surface_code, decimal surf_min_sd, decimal surf_max_sd, decimal surf_min_ld, decimal surf_max_ld, decimal surf_min_length, decimal surf_max_length, decimal surf_min_width, decimal surf_max_width, decimal surf_min_height, decimal surf_max_height, decimal surf_min_angleX, decimal surf_max_angleX, decimal surf_min_angleY, decimal surf_max_angleY, decimal surf_min_angleZ, decimal surf_max_angleZ, decimal surf_min_distPlaneX, decimal surf_max_distPlaneX, decimal surf_min_distPlaneY, decimal surf_max_distPlaneY, decimal surf_min_distPlaneZ, decimal surf_max_distPlaneZ, int surf_complexSurface_code, int surf_qualification, decimal surf_Ra, decimal surf_Rmax, decimal surf_S, decimal surf_tp, decimal surf_hardnessHRC, decimal surf_voltage1, decimal surf_voltage2, decimal surf_voltage3, decimal surf_straightness, decimal surf_flatness, decimal surf_roundness, decimal surf_cylindricity, decimal surf_longitudinalSectionProfile, decimal surf_radialBeat, decimal surf_faceBeat, decimal surf_fullRadialBeat, decimal surf_fullFaceBeat, decimal surf_formProfile, decimal surf_formSurface, int bil_surfaceCode, decimal bil_min_sd, decimal bil_max_sd, decimal bil_min_ld, decimal bil_max_ld, decimal bil_min_length, decimal bil_max_length, decimal bil_min_width, decimal bil_max_width, decimal bil_min_height, decimal bil_max_height, decimal bil_min_angleX, decimal bil_max_angleX, decimal bil_min_angleY, decimal bil_max_angleY, decimal bil_min_angleZ, decimal bil_max_angleZ, decimal bil_min_distPlaneX, decimal bil_max_distPlaneX, decimal bil_min_distPlaneY, decimal bil_max_distPlaneY, decimal bil_min_distPlaneZ, decimal bil_max_distPlaneZ, int bil_complexSurface_code, int bil_qualification, decimal bil_Ra, decimal bil_Rmax, decimal bil_S, decimal bil_tp, decimal bil_hardnessHRC, decimal bil_voltage1, decimal bil_voltage2, decimal bil_voltage3, decimal bil_straightness, decimal bil_flatness, decimal bil_roundness, decimal bil_cylindricity, decimal bil_longitudinalSectionProfile, decimal bil_radialBeat, decimal bil_faceBeat, decimal bil_fullRadialBeat, decimal bil_fullFaceBeat, decimal bil_formProfile, decimal bil_formSurface, int fbs_surfaceCode, decimal fbs_min_sd, decimal fbs_max_sd, decimal fbs_min_ld, decimal fbs_max_ld, decimal fbs_min_length, decimal fbs_max_length, decimal fbs_min_width, decimal fbs_max_width, decimal fbs_min_height, decimal fbs_max_height, decimal fbs_min_angleX, decimal fbs_max_angleX, decimal fbs_min_angleY, decimal fbs_max_angleY, decimal fbs_min_angleZ, decimal fbs_max_angleZ, decimal fbs_min_distPlaneX, decimal fbs_max_distPlaneX, decimal fbs_min_distPlaneY, decimal fbs_max_distPlaneY, decimal fbs_min_distPlaneZ, decimal fbs_max_distPlaneZ, int fbs_complexSurface_code, decimal fbs_min_toSurface, decimal fbs_max_toSurface, int sbs_surfaceCode, decimal sbs_min_sd, decimal sbs_max_sd, decimal sbs_min_ld, decimal sbs_max_ld, decimal sbs_min_length, decimal sbs_max_length, decimal sbs_min_width, decimal sbs_max_width, decimal sbs_min_height, decimal sbs_max_height, decimal sbs_min_angleX, decimal sbs_max_angleX, decimal sbs_min_angleY, decimal sbs_max_angleY, decimal sbs_min_angleZ, decimal sbs_max_angleZ, decimal sbs_min_distPlaneX, decimal sbs_max_distPlaneX, decimal sbs_min_distPlaneY, decimal sbs_max_distPlaneY, decimal sbs_min_distPlaneZ, decimal sbs_max_distPlaneZ, int sbs_complexSurface_code, decimal sbs_min_toSurface, decimal sbs_max_toSurface, decimal sbs_min_toFbs, decimal sbs_max_toFbs, int tbs_surfaceCode, decimal tbs_min_sd, decimal tbs_max_sd, decimal tbs_min_ld, decimal tbs_max_ld, decimal tbs_min_length, decimal tbs_max_length, decimal tbs_min_width, decimal tbs_max_width, decimal tbs_min_height, decimal tbs_max_height, decimal tbs_min_angleX, decimal tbs_max_angleX, decimal tbs_min_angleY, decimal tbs_max_angleY, decimal tbs_min_angleZ, decimal tbs_max_angleZ, decimal tbs_min_distPlaneX, decimal tbs_max_distPlaneX, decimal tbs_min_distPlaneY, decimal tbs_max_distPlaneY, decimal tbs_min_distPlaneZ, decimal tbs_max_distPlaneZ, int tbs_complexSurface_code, decimal tbs_min_toSurface, decimal tbs_max_toSurface, decimal tbs_min_toFbs, decimal tbs_max_toFbs, decimal tbs_min_toSbs, decimal tbs_max_toSbs)
        {
            this.id_employee = id_employee;
            this.id_status = id_status;
            this.equipment_code = equipment_code;
            this.fixture_code = fixture_code;
            this.process_code = process_code;
            this.surface_code = surface_code;
            this.surf_min_sd = surf_min_sd;
            this.surf_max_sd = surf_max_sd;
            this.surf_min_ld = surf_min_ld;
            this.surf_max_ld = surf_max_ld;
            this.surf_min_length = surf_min_length;
            this.surf_max_length = surf_max_length;
            this.surf_min_width = surf_min_width;
            this.surf_max_width = surf_max_width;
            this.surf_min_height = surf_min_height;
            this.surf_max_height = surf_max_height;
            this.surf_min_angleX = surf_min_angleX;
            this.surf_max_angleX = surf_max_angleX;
            this.surf_min_angleY = surf_min_angleY;
            this.surf_max_angleY = surf_max_angleY;
            this.surf_min_angleZ = surf_min_angleZ;
            this.surf_max_angleZ = surf_max_angleZ;
            this.surf_min_distPlaneX = surf_min_distPlaneX;
            this.surf_max_distPlaneX = surf_max_distPlaneX;
            this.surf_min_distPlaneY = surf_min_distPlaneY;
            this.surf_max_distPlaneY = surf_max_distPlaneY;
            this.surf_min_distPlaneZ = surf_min_distPlaneZ;
            this.surf_max_distPlaneZ = surf_max_distPlaneZ;
            this.surf_complexSurface_code = surf_complexSurface_code;
            this.surf_qualification = surf_qualification;
            this.surf_Ra = surf_Ra;
            this.surf_Rmax = surf_Rmax;
            this.surf_S = surf_S;
            this.surf_tp = surf_tp;
            this.surf_hardnessHRC = surf_hardnessHRC;
            this.surf_voltage1 = surf_voltage1;
            this.surf_voltage2 = surf_voltage2;
            this.surf_voltage3 = surf_voltage3;
            this.surf_straightness = surf_straightness;
            this.surf_flatness = surf_flatness;
            this.surf_roundness = surf_roundness;
            this.surf_cylindricity = surf_cylindricity;
            this.surf_longitudinalSectionProfile = surf_longitudinalSectionProfile;
            this.surf_radialBeat = surf_radialBeat;
            this.surf_faceBeat = surf_faceBeat;
            this.surf_fullRadialBeat = surf_fullRadialBeat;
            this.surf_fullFaceBeat = surf_fullFaceBeat;
            this.surf_formProfile = surf_formProfile;
            this.surf_formSurface = surf_formSurface;
            this.bil_surfaceCode = bil_surfaceCode;
            this.bil_min_sd = bil_min_sd;
            this.bil_max_sd = bil_max_sd;
            this.bil_min_ld = bil_min_ld;
            this.bil_max_ld = bil_max_ld;
            this.bil_min_length = bil_min_length;
            this.bil_max_length = bil_max_length;
            this.bil_min_width = bil_min_width;
            this.bil_max_width = bil_max_width;
            this.bil_min_height = bil_min_height;
            this.bil_max_height = bil_max_height;
            this.bil_min_angleX = bil_min_angleX;
            this.bil_max_angleX = bil_max_angleX;
            this.bil_min_angleY = bil_min_angleY;
            this.bil_max_angleY = bil_max_angleY;
            this.bil_min_angleZ = bil_min_angleZ;
            this.bil_max_angleZ = bil_max_angleZ;
            this.bil_min_distPlaneX = bil_min_distPlaneX;
            this.bil_max_distPlaneX = bil_max_distPlaneX;
            this.bil_min_distPlaneY = bil_min_distPlaneY;
            this.bil_max_distPlaneY = bil_max_distPlaneY;
            this.bil_min_distPlaneZ = bil_min_distPlaneZ;
            this.bil_max_distPlaneZ = bil_max_distPlaneZ;
            this.bil_complexSurface_code = bil_complexSurface_code;
            this.bil_qualification = bil_qualification;
            this.bil_Ra = bil_Ra;
            this.bil_Rmax = bil_Rmax;
            this.bil_S = bil_S;
            this.bil_tp = bil_tp;
            this.bil_hardnessHRC = bil_hardnessHRC;
            this.bil_voltage1 = bil_voltage1;
            this.bil_voltage2 = bil_voltage2;
            this.bil_voltage3 = bil_voltage3;
            this.bil_straightness = bil_straightness;
            this.bil_flatness = bil_flatness;
            this.bil_roundness = bil_roundness;
            this.bil_cylindricity = bil_cylindricity;
            this.bil_longitudinalSectionProfile = bil_longitudinalSectionProfile;
            this.bil_radialBeat = bil_radialBeat;
            this.bil_faceBeat = bil_faceBeat;
            this.bil_fullRadialBeat = bil_fullRadialBeat;
            this.bil_fullFaceBeat = bil_fullFaceBeat;
            this.bil_formProfile = bil_formProfile;
            this.bil_formSurface = bil_formSurface;
            this.fbs_surfaceCode = fbs_surfaceCode;
            this.fbs_min_sd = fbs_min_sd;
            this.fbs_max_sd = fbs_max_sd;
            this.fbs_min_ld = fbs_min_ld;
            this.fbs_max_ld = fbs_max_ld;
            this.fbs_min_length = fbs_min_length;
            this.fbs_max_length = fbs_max_length;
            this.fbs_min_width = fbs_min_width;
            this.fbs_max_width = fbs_max_width;
            this.fbs_min_height = fbs_min_height;
            this.fbs_max_height = fbs_max_height;
            this.fbs_min_angleX = fbs_min_angleX;
            this.fbs_max_angleX = fbs_max_angleX;
            this.fbs_min_angleY = fbs_min_angleY;
            this.fbs_max_angleY = fbs_max_angleY;
            this.fbs_min_angleZ = fbs_min_angleZ;
            this.fbs_max_angleZ = fbs_max_angleZ;
            this.fbs_min_distPlaneX = fbs_min_distPlaneX;
            this.fbs_max_distPlaneX = fbs_max_distPlaneX;
            this.fbs_min_distPlaneY = fbs_min_distPlaneY;
            this.fbs_max_distPlaneY = fbs_max_distPlaneY;
            this.fbs_min_distPlaneZ = fbs_min_distPlaneZ;
            this.fbs_max_distPlaneZ = fbs_max_distPlaneZ;
            this.fbs_complexSurface_code = fbs_complexSurface_code;
            this.fbs_min_toSurface = fbs_min_toSurface;
            this.fbs_max_toSurface = fbs_max_toSurface;
            this.sbs_surfaceCode = sbs_surfaceCode;
            this.sbs_min_sd = sbs_min_sd;
            this.sbs_max_sd = sbs_max_sd;
            this.sbs_min_ld = sbs_min_ld;
            this.sbs_max_ld = sbs_max_ld;
            this.sbs_min_length = sbs_min_length;
            this.sbs_max_length = sbs_max_length;
            this.sbs_min_width = sbs_min_width;
            this.sbs_max_width = sbs_max_width;
            this.sbs_min_height = sbs_min_height;
            this.sbs_max_height = sbs_max_height;
            this.sbs_min_angleX = sbs_min_angleX;
            this.sbs_max_angleX = sbs_max_angleX;
            this.sbs_min_angleY = sbs_min_angleY;
            this.sbs_max_angleY = sbs_max_angleY;
            this.sbs_min_angleZ = sbs_min_angleZ;
            this.sbs_max_angleZ = sbs_max_angleZ;
            this.sbs_min_distPlaneX = sbs_min_distPlaneX;
            this.sbs_max_distPlaneX = sbs_max_distPlaneX;
            this.sbs_min_distPlaneY = sbs_min_distPlaneY;
            this.sbs_max_distPlaneY = sbs_max_distPlaneY;
            this.sbs_min_distPlaneZ = sbs_min_distPlaneZ;
            this.sbs_max_distPlaneZ = sbs_max_distPlaneZ;
            this.sbs_complexSurface_code = sbs_complexSurface_code;
            this.sbs_min_toSurface = sbs_min_toSurface;
            this.sbs_max_toSurface = sbs_max_toSurface;
            this.sbs_min_toFbs = sbs_min_toFbs;
            this.sbs_max_toFbs = sbs_max_toFbs;
            this.tbs_surfaceCode = tbs_surfaceCode;
            this.tbs_min_sd = tbs_min_sd;
            this.tbs_max_sd = tbs_max_sd;
            this.tbs_min_ld = tbs_min_ld;
            this.tbs_max_ld = tbs_max_ld;
            this.tbs_min_length = tbs_min_length;
            this.tbs_max_length = tbs_max_length;
            this.tbs_min_width = tbs_min_width;
            this.tbs_max_width = tbs_max_width;
            this.tbs_min_height = tbs_min_height;
            this.tbs_max_height = tbs_max_height;
            this.tbs_min_angleX = tbs_min_angleX;
            this.tbs_max_angleX = tbs_max_angleX;
            this.tbs_min_angleY = tbs_min_angleY;
            this.tbs_max_angleY = tbs_max_angleY;
            this.tbs_min_angleZ = tbs_min_angleZ;
            this.tbs_max_angleZ = tbs_max_angleZ;
            this.tbs_min_distPlaneX = tbs_min_distPlaneX;
            this.tbs_max_distPlaneX = tbs_max_distPlaneX;
            this.tbs_min_distPlaneY = tbs_min_distPlaneY;
            this.tbs_max_distPlaneY = tbs_max_distPlaneY;
            this.tbs_min_distPlaneZ = tbs_min_distPlaneZ;
            this.tbs_max_distPlaneZ = tbs_max_distPlaneZ;
            this.tbs_complexSurface_code = tbs_complexSurface_code;
            this.tbs_min_toSurface = tbs_min_toSurface;
            this.tbs_max_toSurface = tbs_max_toSurface;
            this.tbs_min_toFbs = tbs_min_toFbs;
            this.tbs_max_toFbs = tbs_max_toFbs;
            this.tbs_min_toSbs = tbs_min_toSbs;
            this.tbs_max_toSbs = tbs_max_toSbs;
        }

        #endregion Конструктор

        [ForeignKey("id_employee")]
        public Employee Employee { get; set; }

        [ForeignKey("id_company")]
        public Company Company { get; set; }

        [ForeignKey("id_status")]
        public Status Status { get; set; }

        [ForeignKey("equipment_code")]
        public EquipmentCatalog EquipmentCatalog { get; set; }

        [ForeignKey("fixture_code")]
        public FixtureCatalog FixtureCode { get; set; }

        [ForeignKey("process_code")]
        public ProcessCatalog ProcessCode { get; set; }

        [ForeignKey("surface_code")]
        public SurfaceCatalog CodeSurface { get; set; }

        [ForeignKey("bil_surfaceCode")]
        public SurfaceCatalog BILSurfaceCode { get; set; }

        [ForeignKey("fbs_surfaceCode")]
        public SurfaceCatalog FBSSurfaceCode { get; set; }

        [ForeignKey("sbs_surfaceCode")]
        public SurfaceCatalog SBSSurfaceCode { get; set; }

        [ForeignKey("tbs_surfaceCode")]
        public SurfaceCatalog TBSSurfaceCode { get; set; }

        #region VALUES

        [Key]
        public int id_record { get; set; }

        [Required]
        public int id_company { get; set; }

        [Required]
        public int id_employee { get; set; }

        [Required]
        public int id_status { get; set; }

        [Required]
        public int equipment_code { get; set; }

        [Required]
        public int fixture_code { get; set; }

        [Required]
        public int process_code { get; set; }

        [Required]
        public int surface_code { get; set; }

        public decimal? surf_min_sd { get; set; }
        public decimal? surf_max_sd { get; set; }
        public decimal? surf_min_ld { get; set; }
        public decimal? surf_max_ld { get; set; }
        public decimal? surf_min_length { get; set; }
        public decimal? surf_max_length { get; set; }
        public decimal? surf_min_width { get; set; }
        public decimal? surf_max_width { get; set; }
        public decimal? surf_min_height { get; set; }
        public decimal? surf_max_height { get; set; }
        public decimal? surf_min_angleX { get; set; }
        public decimal? surf_max_angleX { get; set; }
        public decimal? surf_min_angleY { get; set; }
        public decimal? surf_max_angleY { get; set; }
        public decimal? surf_min_angleZ { get; set; }
        public decimal? surf_max_angleZ { get; set; }
        public decimal? surf_min_distPlaneX { get; set; }
        public decimal? surf_max_distPlaneX { get; set; }
        public decimal? surf_min_distPlaneY { get; set; }
        public decimal? surf_max_distPlaneY { get; set; }
        public decimal? surf_min_distPlaneZ { get; set; }
        public decimal? surf_max_distPlaneZ { get; set; }
        public int? surf_complexSurface_code { get; set; }
        public int? surf_qualification { get; set; }
        public decimal? surf_Ra { get; set; }
        public decimal? surf_Rmax { get; set; }
        public decimal? surf_S { get; set; }
        public decimal? surf_tp { get; set; }
        public decimal? surf_hardnessHRC { get; set; }
        public decimal? surf_voltage1 { get; set; }
        public decimal? surf_voltage2 { get; set; }
        public decimal? surf_voltage3 { get; set; }
        public decimal? surf_straightness { get; set; }
        public decimal? surf_flatness { get; set; }
        public decimal? surf_roundness { get; set; }
        public decimal? surf_cylindricity { get; set; }
        public decimal? surf_longitudinalSectionProfile { get; set; }
        public decimal? surf_radialBeat { get; set; }
        public decimal? surf_faceBeat { get; set; }
        public decimal? surf_fullRadialBeat { get; set; }
        public decimal? surf_fullFaceBeat { get; set; }
        public decimal? surf_formProfile { get; set; }
        public decimal? surf_formSurface { get; set; }

        [Required]
        public int bil_surfaceCode { get; set; }

        public decimal? bil_min_sd { get; set; }
        public decimal? bil_max_sd { get; set; }
        public decimal? bil_min_ld { get; set; }
        public decimal? bil_max_ld { get; set; }
        public decimal? bil_min_length { get; set; }
        public decimal? bil_max_length { get; set; }
        public decimal? bil_min_width { get; set; }
        public decimal? bil_max_width { get; set; }
        public decimal? bil_min_height { get; set; }
        public decimal? bil_max_height { get; set; }
        public decimal? bil_min_angleX { get; set; }
        public decimal? bil_max_angleX { get; set; }
        public decimal? bil_min_angleY { get; set; }
        public decimal? bil_max_angleY { get; set; }
        public decimal? bil_min_angleZ { get; set; }
        public decimal? bil_max_angleZ { get; set; }
        public decimal? bil_min_distPlaneX { get; set; }
        public decimal? bil_max_distPlaneX { get; set; }
        public decimal? bil_min_distPlaneY { get; set; }
        public decimal? bil_max_distPlaneY { get; set; }
        public decimal? bil_min_distPlaneZ { get; set; }
        public decimal? bil_max_distPlaneZ { get; set; }
        public int? bil_complexSurface_code { get; set; }
        public int? bil_qualification { get; set; }
        public decimal? bil_Ra { get; set; }
        public decimal? bil_Rmax { get; set; }
        public decimal? bil_S { get; set; }
        public decimal? bil_tp { get; set; }
        public decimal? bil_hardnessHRC { get; set; }
        public decimal? bil_voltage1 { get; set; }
        public decimal? bil_voltage2 { get; set; }
        public decimal? bil_voltage3 { get; set; }
        public decimal? bil_straightness { get; set; }
        public decimal? bil_flatness { get; set; }
        public decimal? bil_roundness { get; set; }
        public decimal? bil_cylindricity { get; set; }
        public decimal? bil_longitudinalSectionProfile { get; set; }
        public decimal? bil_radialBeat { get; set; }
        public decimal? bil_faceBeat { get; set; }
        public decimal? bil_fullRadialBeat { get; set; }
        public decimal? bil_fullFaceBeat { get; set; }
        public decimal? bil_formProfile { get; set; }
        public decimal? bil_formSurface { get; set; }

        [Required]
        public int fbs_surfaceCode { get; set; }

        public decimal? fbs_min_sd { get; set; }
        public decimal? fbs_max_sd { get; set; }
        public decimal? fbs_min_ld { get; set; }
        public decimal? fbs_max_ld { get; set; }
        public decimal? fbs_min_length { get; set; }
        public decimal? fbs_max_length { get; set; }
        public decimal? fbs_min_width { get; set; }
        public decimal? fbs_max_width { get; set; }
        public decimal? fbs_min_height { get; set; }
        public decimal? fbs_max_height { get; set; }
        public decimal? fbs_min_angleX { get; set; }
        public decimal? fbs_max_angleX { get; set; }
        public decimal? fbs_min_angleY { get; set; }
        public decimal? fbs_max_angleY { get; set; }
        public decimal? fbs_min_angleZ { get; set; }
        public decimal? fbs_max_angleZ { get; set; }
        public decimal? fbs_min_distPlaneX { get; set; }
        public decimal? fbs_max_distPlaneX { get; set; }
        public decimal? fbs_min_distPlaneY { get; set; }
        public decimal? fbs_max_distPlaneY { get; set; }
        public decimal? fbs_min_distPlaneZ { get; set; }
        public decimal? fbs_max_distPlaneZ { get; set; }
        public int? fbs_complexSurface_code { get; set; }
        public decimal? fbs_min_toSurface { get; set; }
        public decimal? fbs_max_toSurface { get; set; }

        [Required]
        public int sbs_surfaceCode { get; set; }

        public decimal? sbs_min_sd { get; set; }
        public decimal? sbs_max_sd { get; set; }
        public decimal? sbs_min_ld { get; set; }
        public decimal? sbs_max_ld { get; set; }
        public decimal? sbs_min_length { get; set; }
        public decimal? sbs_max_length { get; set; }
        public decimal? sbs_min_width { get; set; }
        public decimal? sbs_max_width { get; set; }
        public decimal? sbs_min_height { get; set; }
        public decimal? sbs_max_height { get; set; }
        public decimal? sbs_min_angleX { get; set; }
        public decimal? sbs_max_angleX { get; set; }
        public decimal? sbs_min_angleY { get; set; }
        public decimal? sbs_max_angleY { get; set; }
        public decimal? sbs_min_angleZ { get; set; }
        public decimal? sbs_max_angleZ { get; set; }
        public decimal? sbs_min_distPlaneX { get; set; }
        public decimal? sbs_max_distPlaneX { get; set; }
        public decimal? sbs_min_distPlaneY { get; set; }
        public decimal? sbs_max_distPlaneY { get; set; }
        public decimal? sbs_min_distPlaneZ { get; set; }
        public decimal? sbs_max_distPlaneZ { get; set; }
        public int? sbs_complexSurface_code { get; set; }
        public decimal? sbs_min_toSurface { get; set; }
        public decimal? sbs_max_toSurface { get; set; }
        public decimal? sbs_min_toFbs { get; set; }
        public decimal? sbs_max_toFbs { get; set; }

        [Required]
        public int tbs_surfaceCode { get; set; }

        public decimal? tbs_min_sd { get; set; }
        public decimal? tbs_max_sd { get; set; }
        public decimal? tbs_min_ld { get; set; }
        public decimal? tbs_max_ld { get; set; }
        public decimal? tbs_min_length { get; set; }
        public decimal? tbs_max_length { get; set; }
        public decimal? tbs_min_width { get; set; }
        public decimal? tbs_max_width { get; set; }
        public decimal? tbs_min_height { get; set; }
        public decimal? tbs_max_height { get; set; }
        public decimal? tbs_min_angleX { get; set; }
        public decimal? tbs_max_angleX { get; set; }
        public decimal? tbs_min_angleY { get; set; }
        public decimal? tbs_max_angleY { get; set; }
        public decimal? tbs_min_angleZ { get; set; }
        public decimal? tbs_max_angleZ { get; set; }
        public decimal? tbs_min_distPlaneX { get; set; }
        public decimal? tbs_max_distPlaneX { get; set; }
        public decimal? tbs_min_distPlaneY { get; set; }
        public decimal? tbs_max_distPlaneY { get; set; }
        public decimal? tbs_min_distPlaneZ { get; set; }
        public decimal? tbs_max_distPlaneZ { get; set; }
        public int? tbs_complexSurface_code { get; set; }
        public decimal? tbs_min_toSurface { get; set; }
        public decimal? tbs_max_toSurface { get; set; }
        public decimal? tbs_min_toFbs { get; set; }
        public decimal? tbs_max_toFbs { get; set; }
        public decimal? tbs_min_toSbs { get; set; }
        public decimal? tbs_max_toSbs { get; set; }

        public override bool Equals(object obj)
        {
            var record = obj as Record;
            return record != null &&
                   EqualityComparer<EquipmentCatalog>.Default.Equals(EquipmentCatalog, record.EquipmentCatalog) &&
                   EqualityComparer<FixtureCatalog>.Default.Equals(FixtureCode, record.FixtureCode) &&
                   EqualityComparer<ProcessCatalog>.Default.Equals(ProcessCode, record.ProcessCode) &&
                   EqualityComparer<SurfaceCatalog>.Default.Equals(CodeSurface, record.CodeSurface) &&
                   EqualityComparer<SurfaceCatalog>.Default.Equals(BILSurfaceCode, record.BILSurfaceCode) &&
                   EqualityComparer<SurfaceCatalog>.Default.Equals(FBSSurfaceCode, record.FBSSurfaceCode) &&
                   EqualityComparer<SurfaceCatalog>.Default.Equals(SBSSurfaceCode, record.SBSSurfaceCode) &&
                   EqualityComparer<SurfaceCatalog>.Default.Equals(TBSSurfaceCode, record.TBSSurfaceCode) &&
                   equipment_code == record.equipment_code &&
                   fixture_code == record.fixture_code &&
                   process_code == record.process_code &&
                   surface_code == record.surface_code &&
                   surf_min_sd == record.surf_min_sd &&
                   surf_max_sd == record.surf_max_sd &&
                   surf_min_ld == record.surf_min_ld &&
                   surf_max_ld == record.surf_max_ld &&
                   surf_min_length == record.surf_min_length &&
                   surf_max_length == record.surf_max_length &&
                   surf_min_width == record.surf_min_width &&
                   surf_max_width == record.surf_max_width &&
                   surf_min_height == record.surf_min_height &&
                   surf_max_height == record.surf_max_height &&
                   surf_min_angleX == record.surf_min_angleX &&
                   surf_max_angleX == record.surf_max_angleX &&
                   surf_min_angleY == record.surf_min_angleY &&
                   surf_max_angleY == record.surf_max_angleY &&
                   surf_min_angleZ == record.surf_min_angleZ &&
                   surf_max_angleZ == record.surf_max_angleZ &&
                   surf_min_distPlaneX == record.surf_min_distPlaneX &&
                   surf_max_distPlaneX == record.surf_max_distPlaneX &&
                   surf_min_distPlaneY == record.surf_min_distPlaneY &&
                   surf_max_distPlaneY == record.surf_max_distPlaneY &&
                   surf_min_distPlaneZ == record.surf_min_distPlaneZ &&
                   surf_max_distPlaneZ == record.surf_max_distPlaneZ &&
                   surf_complexSurface_code == record.surf_complexSurface_code &&
                   surf_qualification == record.surf_qualification &&
                   surf_Ra == record.surf_Ra &&
                   surf_Rmax == record.surf_Rmax &&
                   surf_S == record.surf_S &&
                   surf_tp == record.surf_tp &&
                   surf_hardnessHRC == record.surf_hardnessHRC &&
                   surf_voltage1 == record.surf_voltage1 &&
                   surf_voltage2 == record.surf_voltage2 &&
                   surf_voltage3 == record.surf_voltage3 &&
                   surf_straightness == record.surf_straightness &&
                   surf_flatness == record.surf_flatness &&
                   surf_roundness == record.surf_roundness &&
                   surf_cylindricity == record.surf_cylindricity &&
                   surf_longitudinalSectionProfile == record.surf_longitudinalSectionProfile &&
                   surf_radialBeat == record.surf_radialBeat &&
                   surf_faceBeat == record.surf_faceBeat &&
                   surf_fullRadialBeat == record.surf_fullRadialBeat &&
                   surf_fullFaceBeat == record.surf_fullFaceBeat &&
                   surf_formProfile == record.surf_formProfile &&
                   surf_formSurface == record.surf_formSurface &&
                   bil_surfaceCode == record.bil_surfaceCode &&
                   bil_min_sd == record.bil_min_sd &&
                   bil_max_sd == record.bil_max_sd &&
                   bil_min_ld == record.bil_min_ld &&
                   bil_max_ld == record.bil_max_ld &&
                   bil_min_length == record.bil_min_length &&
                   bil_max_length == record.bil_max_length &&
                   bil_min_width == record.bil_min_width &&
                   bil_max_width == record.bil_max_width &&
                   bil_min_height == record.bil_min_height &&
                   bil_max_height == record.bil_max_height &&
                   bil_min_angleX == record.bil_min_angleX &&
                   bil_max_angleX == record.bil_max_angleX &&
                   bil_min_angleY == record.bil_min_angleY &&
                   bil_max_angleY == record.bil_max_angleY &&
                   bil_min_angleZ == record.bil_min_angleZ &&
                   bil_max_angleZ == record.bil_max_angleZ &&
                   bil_min_distPlaneX == record.bil_min_distPlaneX &&
                   bil_max_distPlaneX == record.bil_max_distPlaneX &&
                   bil_min_distPlaneY == record.bil_min_distPlaneY &&
                   bil_max_distPlaneY == record.bil_max_distPlaneY &&
                   bil_min_distPlaneZ == record.bil_min_distPlaneZ &&
                   bil_max_distPlaneZ == record.bil_max_distPlaneZ &&
                   bil_complexSurface_code == record.bil_complexSurface_code &&
                   bil_qualification == record.bil_qualification &&
                   bil_Ra == record.bil_Ra &&
                   bil_Rmax == record.bil_Rmax &&
                   bil_S == record.bil_S &&
                   bil_tp == record.bil_tp &&
                   bil_hardnessHRC == record.bil_hardnessHRC &&
                   bil_voltage1 == record.bil_voltage1 &&
                   bil_voltage2 == record.bil_voltage2 &&
                   bil_voltage3 == record.bil_voltage3 &&
                   bil_straightness == record.bil_straightness &&
                   bil_flatness == record.bil_flatness &&
                   bil_roundness == record.bil_roundness &&
                   bil_cylindricity == record.bil_cylindricity &&
                   bil_longitudinalSectionProfile == record.bil_longitudinalSectionProfile &&
                   bil_radialBeat == record.bil_radialBeat &&
                   bil_faceBeat == record.bil_faceBeat &&
                   bil_fullRadialBeat == record.bil_fullRadialBeat &&
                   bil_fullFaceBeat == record.bil_fullFaceBeat &&
                   bil_formProfile == record.bil_formProfile &&
                   bil_formSurface == record.bil_formSurface &&
                   fbs_surfaceCode == record.fbs_surfaceCode &&
                   fbs_min_sd == record.fbs_min_sd &&
                   fbs_max_sd == record.fbs_max_sd &&
                   fbs_min_ld == record.fbs_min_ld &&
                   fbs_max_ld == record.fbs_max_ld &&
                   fbs_min_length == record.fbs_min_length &&
                   fbs_max_length == record.fbs_max_length &&
                   fbs_min_width == record.fbs_min_width &&
                   fbs_max_width == record.fbs_max_width &&
                   fbs_min_height == record.fbs_min_height &&
                   fbs_max_height == record.fbs_max_height &&
                   fbs_min_angleX == record.fbs_min_angleX &&
                   fbs_max_angleX == record.fbs_max_angleX &&
                   fbs_min_angleY == record.fbs_min_angleY &&
                   fbs_max_angleY == record.fbs_max_angleY &&
                   fbs_min_angleZ == record.fbs_min_angleZ &&
                   fbs_max_angleZ == record.fbs_max_angleZ &&
                   fbs_min_distPlaneX == record.fbs_min_distPlaneX &&
                   fbs_max_distPlaneX == record.fbs_max_distPlaneX &&
                   fbs_min_distPlaneY == record.fbs_min_distPlaneY &&
                   fbs_max_distPlaneY == record.fbs_max_distPlaneY &&
                   fbs_min_distPlaneZ == record.fbs_min_distPlaneZ &&
                   fbs_max_distPlaneZ == record.fbs_max_distPlaneZ &&
                   fbs_complexSurface_code == record.fbs_complexSurface_code &&
                   fbs_min_toSurface == record.fbs_min_toSurface &&
                   fbs_max_toSurface == record.fbs_max_toSurface &&
                   sbs_surfaceCode == record.sbs_surfaceCode &&
                   sbs_min_sd == record.sbs_min_sd &&
                   sbs_max_sd == record.sbs_max_sd &&
                   sbs_min_ld == record.sbs_min_ld &&
                   sbs_max_ld == record.sbs_max_ld &&
                   sbs_min_length == record.sbs_min_length &&
                   sbs_max_length == record.sbs_max_length &&
                   sbs_min_width == record.sbs_min_width &&
                   sbs_max_width == record.sbs_max_width &&
                   sbs_min_height == record.sbs_min_height &&
                   sbs_max_height == record.sbs_max_height &&
                   sbs_min_angleX == record.sbs_min_angleX &&
                   sbs_max_angleX == record.sbs_max_angleX &&
                   sbs_min_angleY == record.sbs_min_angleY &&
                   sbs_max_angleY == record.sbs_max_angleY &&
                   sbs_min_angleZ == record.sbs_min_angleZ &&
                   sbs_max_angleZ == record.sbs_max_angleZ &&
                   sbs_min_distPlaneX == record.sbs_min_distPlaneX &&
                   sbs_max_distPlaneX == record.sbs_max_distPlaneX &&
                   sbs_min_distPlaneY == record.sbs_min_distPlaneY &&
                   sbs_max_distPlaneY == record.sbs_max_distPlaneY &&
                   sbs_min_distPlaneZ == record.sbs_min_distPlaneZ &&
                   sbs_max_distPlaneZ == record.sbs_max_distPlaneZ &&
                   sbs_complexSurface_code == record.sbs_complexSurface_code &&
                   sbs_min_toSurface == record.sbs_min_toSurface &&
                   sbs_max_toSurface == record.sbs_max_toSurface &&
                   sbs_min_toFbs == record.sbs_min_toFbs &&
                   sbs_max_toFbs == record.sbs_max_toFbs &&
                   tbs_surfaceCode == record.tbs_surfaceCode &&
                   tbs_min_sd == record.tbs_min_sd &&
                   tbs_max_sd == record.tbs_max_sd &&
                   tbs_min_ld == record.tbs_min_ld &&
                   tbs_max_ld == record.tbs_max_ld &&
                   tbs_min_length == record.tbs_min_length &&
                   tbs_max_length == record.tbs_max_length &&
                   tbs_min_width == record.tbs_min_width &&
                   tbs_max_width == record.tbs_max_width &&
                   tbs_min_height == record.tbs_min_height &&
                   tbs_max_height == record.tbs_max_height &&
                   tbs_min_angleX == record.tbs_min_angleX &&
                   tbs_max_angleX == record.tbs_max_angleX &&
                   tbs_min_angleY == record.tbs_min_angleY &&
                   tbs_max_angleY == record.tbs_max_angleY &&
                   tbs_min_angleZ == record.tbs_min_angleZ &&
                   tbs_max_angleZ == record.tbs_max_angleZ &&
                   tbs_min_distPlaneX == record.tbs_min_distPlaneX &&
                   tbs_max_distPlaneX == record.tbs_max_distPlaneX &&
                   tbs_min_distPlaneY == record.tbs_min_distPlaneY &&
                   tbs_max_distPlaneY == record.tbs_max_distPlaneY &&
                   tbs_min_distPlaneZ == record.tbs_min_distPlaneZ &&
                   tbs_max_distPlaneZ == record.tbs_max_distPlaneZ &&
                   tbs_complexSurface_code == record.tbs_complexSurface_code &&
                   tbs_min_toSurface == record.tbs_min_toSurface &&
                   tbs_max_toSurface == record.tbs_max_toSurface &&
                   tbs_min_toFbs == record.tbs_min_toFbs &&
                   tbs_max_toFbs == record.tbs_max_toFbs &&
                   tbs_min_toSbs == record.tbs_min_toSbs &&
                   tbs_max_toSbs == record.tbs_max_toSbs;
        }

        public override int GetHashCode()
        {
            var hashCode = -1138161344;
            hashCode = hashCode * -1521134295 + EqualityComparer<EquipmentCatalog>.Default.GetHashCode(EquipmentCatalog);
            hashCode = hashCode * -1521134295 + EqualityComparer<FixtureCatalog>.Default.GetHashCode(FixtureCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<ProcessCatalog>.Default.GetHashCode(ProcessCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<SurfaceCatalog>.Default.GetHashCode(CodeSurface);
            hashCode = hashCode * -1521134295 + EqualityComparer<SurfaceCatalog>.Default.GetHashCode(BILSurfaceCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<SurfaceCatalog>.Default.GetHashCode(FBSSurfaceCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<SurfaceCatalog>.Default.GetHashCode(SBSSurfaceCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<SurfaceCatalog>.Default.GetHashCode(TBSSurfaceCode);
            hashCode = hashCode * -1521134295 + equipment_code.GetHashCode();
            hashCode = hashCode * -1521134295 + fixture_code.GetHashCode();
            hashCode = hashCode * -1521134295 + process_code.GetHashCode();
            hashCode = hashCode * -1521134295 + surface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_length.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_length.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_width.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_width.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_height.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_height.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_min_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_max_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_complexSurface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_qualification.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_Ra.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_Rmax.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_S.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_tp.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_hardnessHRC.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_voltage1.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_voltage2.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_voltage3.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_straightness.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_flatness.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_roundness.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_cylindricity.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_longitudinalSectionProfile.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_radialBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_faceBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_fullRadialBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_fullFaceBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_formProfile.GetHashCode();
            hashCode = hashCode * -1521134295 + surf_formSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_surfaceCode.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_length.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_length.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_width.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_width.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_height.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_height.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_min_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_max_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_complexSurface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_qualification.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_Ra.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_Rmax.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_S.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_tp.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_hardnessHRC.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_voltage1.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_voltage2.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_voltage3.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_straightness.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_flatness.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_roundness.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_cylindricity.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_longitudinalSectionProfile.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_radialBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_faceBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_fullRadialBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_fullFaceBeat.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_formProfile.GetHashCode();
            hashCode = hashCode * -1521134295 + bil_formSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_surfaceCode.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_length.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_length.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_width.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_width.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_height.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_height.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_complexSurface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_min_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + fbs_max_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_surfaceCode.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_length.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_length.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_width.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_width.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_height.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_height.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_complexSurface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_min_toFbs.GetHashCode();
            hashCode = hashCode * -1521134295 + sbs_max_toFbs.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_surfaceCode.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_sd.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_ld.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_length.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_length.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_width.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_width.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_height.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_height.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_angleX.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_angleY.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_angleZ.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_distPlaneX.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_distPlaneY.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_distPlaneZ.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_complexSurface_code.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_toSurface.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_toFbs.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_toFbs.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_min_toSbs.GetHashCode();
            hashCode = hashCode * -1521134295 + tbs_max_toSbs.GetHashCode();
            return hashCode;
        }

        #endregion VALUES
    }
}