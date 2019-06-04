using System;
using System.Collections.Generic;
using System.Linq;
using Tadb.DAL;

namespace Tadb.BL
{
    public class ImportService
    {
        public Record ParseRecordString(string[] args)
        {
            if (args.Length != 176)
            {
                throw new ArgumentException("Количество данных!");
            }

            var numbers = args.Select(x => decimal.Parse(x)).ToArray();

            #region Страшная инициализация записи

            Record record = new Record(
                    1, 1,
                    (int)numbers[0],
                    (int)numbers[1],
                    (int)numbers[2],
                    (int)numbers[3],
                    numbers[4],
                    numbers[5],
                    numbers[6],
                    numbers[7],
                    numbers[8],
                    numbers[9],
                    numbers[10],
                    numbers[11],
                    numbers[12],
                    numbers[13],
                    numbers[14],
                    numbers[15],
                    numbers[16],
                    numbers[17],
                    numbers[18],
                    numbers[19],
                    numbers[20],
                    numbers[22],
                    numbers[23],
                    numbers[24],
                    numbers[25],
                    numbers[26],
                    (int)numbers[27],
                    (int)numbers[28],
                    numbers[29],
                    numbers[30],
                    numbers[31],
                    numbers[32],
                    numbers[33],
                    numbers[34],
                    numbers[35],
                    numbers[36],
                    numbers[37],
                    numbers[38],
                    numbers[39],
                    numbers[40],
                    numbers[41],
                    numbers[42],
                    numbers[43],
                    numbers[44],
                    numbers[45],
                    numbers[46],
                    numbers[47],
                    (int)numbers[48],
                    numbers[49],
                    numbers[50],
                    numbers[51],
                    numbers[52],
                    numbers[53],
                    numbers[54],
                    numbers[55],
                    numbers[56],
                    numbers[57],
                    numbers[58],
                    numbers[59],
                    numbers[60],
                    numbers[61],
                    numbers[62],
                    numbers[63],
                    numbers[64],
                    numbers[65],
                    numbers[66],
                    numbers[67],
                    numbers[68],
                    numbers[69],
                    numbers[70],
                    (int)numbers[71],
                    (int)numbers[72],
                    numbers[73],
                    numbers[74],
                    numbers[75],
                    numbers[76],
                    numbers[77],
                    numbers[78],
                    numbers[79],
                    numbers[80],
                    numbers[81],
                    numbers[82],
                    numbers[83],
                    numbers[84],
                    numbers[85],
                    numbers[86],
                    numbers[87],
                    numbers[88],
                    numbers[89],
                    numbers[90],
                    numbers[91],
                    (int)numbers[92],
                    numbers[93],
                    numbers[94],
                    numbers[95],
                    numbers[96],
                    numbers[97],
                    numbers[98],
                    numbers[99],
                    numbers[100],
                    numbers[101],
                    numbers[102],
                    numbers[103],
                    numbers[104],
                    numbers[105],
                    numbers[106],
                    numbers[107],
                    numbers[108],
                    numbers[109],
                    numbers[110],
                    numbers[111],
                    numbers[112],
                    numbers[113],
                    numbers[114],
                    (int)numbers[115],
                    numbers[116],
                    numbers[117],
                    (int)numbers[118],
                    numbers[119],
                    numbers[120],
                    numbers[121],
                    numbers[122],
                    numbers[123],
                    numbers[124],
                    numbers[125],
                    numbers[126],
                    numbers[127],
                    numbers[128],
                    numbers[129],
                    numbers[130],
                    numbers[131],
                    numbers[132],
                    numbers[133],
                    numbers[134],
                    numbers[135],
                    numbers[136],
                    numbers[137],
                    numbers[138],
                    numbers[139],
                    numbers[140],
                    (int)numbers[141],
                    numbers[142],
                    numbers[143],
                    numbers[144],
                    numbers[145],
                    (int)numbers[146],
                    numbers[147],
                    numbers[148],
                    numbers[149],
                    numbers[150],
                    numbers[151],
                    numbers[152],
                    numbers[153],
                    numbers[154],
                    numbers[155],
                    numbers[156],
                    numbers[157],
                    numbers[158],
                    numbers[159],
                    numbers[160],
                    numbers[161],
                    numbers[162],
                    numbers[163],
                    numbers[164],
                    numbers[165],
                    numbers[166],
                    numbers[167],
                    numbers[168],
                    (int)numbers[169],
                    numbers[170],
                    numbers[171],
                    numbers[172],
                    numbers[173],
                    numbers[174],
                    numbers[175]
                );

            #endregion Страшная инициализация записи

            return record;
        }

        public void FillDatabase(string[] args)
        {
            List<Record> records = new List<Record>();
            foreach (string line in args)
            {
                string[] lines = line.Split(new[] { ';', ',' });
                Record record = this.ParseRecordString(lines);
                records.Add(record);
            }

            using (MachineDbContext context = new MachineDbContext())
            {
                context.Records.AddRange(records);
                context.SaveChanges();
            }
        }
    }
}