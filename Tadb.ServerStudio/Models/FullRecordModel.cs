using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tadb.ServerStudio.Models
{
    public class FullRecordModel
    {
        public int id_status { get; set; }
        public int equipment_code { get; set; }

        
        public int fixture_code { get; set; }

        
        public int process_code { get; set; }

       
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
    }
}