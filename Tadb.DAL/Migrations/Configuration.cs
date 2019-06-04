namespace Tadb.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Tadb.DAL.MachineDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        private string HashPassword(string password)
        {
            StringBuilder hashedPasswordStringBuilder;
            using (SHA512 m = new SHA512Managed())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashedPasswordBytes = m.ComputeHash(passwordBytes);

                hashedPasswordStringBuilder = new StringBuilder(128);
                foreach (var b in hashedPasswordBytes)
                    hashedPasswordStringBuilder.Append(b.ToString("X2"));
            }
            return hashedPasswordStringBuilder.ToString();
        }

        protected override void Seed(Tadb.DAL.MachineDbContext context)
        {
            SeedRoles(context);
            SeedCompanies(context);
            SeedEmployees(context);

            SeedDetails(context);

            SeedEquipmentCatalog(context);
            SeedSurfaceCatalog(context);
            SeedFixtureCatalog(context);
            SeedProcessCatalog(context);

            context.SaveChanges();
        }

        private void SeedEmployees(MachineDbContext context)
        {
            string adminPassword = "12345";

            Employee rootAdmin = new Employee
            {
                id_role = 1,
                id_company = 1,
                first_name = "����",
                second_name = "������",
                patronymic = "��������",
                login = "admin",
                passwordHash = HashPassword(adminPassword),
            };

            context.Employees.AddOrUpdate(rootAdmin);
        }

        private static void SeedCompanies(MachineDbContext context)
        {
            Company devCompany = new Company
            {
                id_company = 1,
                responsible_employee = 1,
                numberof_branch = 1,
                name = "����",
                address = "�������, ���������������, 77"
            };

            context.Companies.AddOrUpdate(devCompany);

            #region ����� ��� ���������� ��������

            //Company[] companies = new Company[]
            //{
            //    new Company()
            //    {
            //        id_company = 1,
            //        responsible_employee= 1,
            //        numberof_branch= 1,
            //        name = "�������������",
            //        address = "����� �������, ��� �����������"
            //    },
            //    new Company()
            //    {
            //        id_company = 2,
            //        responsible_employee= 2,
            //        numberof_branch= 1,
            //        name = "����������� ���������",
            //        address = "����� �������, ��� �����������"
            //    },
            //    new Company()
            //    {
            //        id_company = 2,
            //        responsible_employee= 5,
            //        numberof_branch= 2,
            //        name = "����������� ���������",
            //        address = "����� �������, ��� 1"
            //    }
            //};

            //context.Companies.AddOrUpdate(companies);

            #endregion ����� ��� ���������� ��������
        }

        private static void SeedRoles(MachineDbContext context)
        {
            Role[] roles = new[]
            {
                new Role
                {
                    id_role = 1,
                    name = "�������������",
                    canEnter = true,
                    canGetData = true,
                    canEdit = true,
                    canEditCatalog = true
                },
                new Role
                {
                    id_role = 2,
                    name = "�������� �� ���� ������������",
                    canEnter = true,
                    canGetData = true,
                    canEdit = false,
                    canEditCatalog = false
                },
                new Role
                {
                    id_role = 3,
                    name = "�������� �� ���� �������",
                    canEnter = false,
                    canGetData = false,
                    canEdit = false,
                    canEditCatalog = true
                }
            };

            context.Roles.AddOrUpdate(roles);
        }

        private static void SeedDetails(MachineDbContext context)
        {
            DDescription[] details = new[]{
                new DDescription()
                {
                    detail_id = 1,
                    id_employee = 1,
                    name_detail = "����� � ���������� ���������",
                    mark_material = "38�",
                    size_production = 200,
                    size_transmission = 80,
                    central_hole = true,
                }
            };

            context.DDescriptions.AddOrUpdate(details);
        }

        private static void SeedSurfaceCatalog(MachineDbContext context)
        {
            SurfaceCatalog[] surfaceCatalog = new[]
            {
                new SurfaceCatalog()
                {
                    surface_code = 9111,
                    name = "���������� ��������������"
                },
                new SurfaceCatalog()
                {
                    surface_code = 131,
                    name = "������� ��������"
                },
                new SurfaceCatalog()
                {
                    surface_code = 9121,
                    name = "������� ����������"
                },
                new SurfaceCatalog()
                {
                    surface_code = 9312,
                    name = "����� �� �������������� ��������� ������������ ���"
                },
                new SurfaceCatalog()
                {
                    surface_code = 311,
                    name = "����� ��������"
                }
            };

            context.CodesSurfaces.AddOrUpdate(surfaceCatalog);
        }

        private static void SeedEquipmentCatalog(MachineDbContext context)
        {
            EquipmentCatalog[] equipmentCatalog = new[]
            {
                new EquipmentCatalog()
                {
                    equipment_code = 1,
                    model = "16�20",
                    description = "�������-�����������"
                },
                new EquipmentCatalog()
                {
                    equipment_code = 2,
                    model = "16�21",
                    description = "��������"
                },
                new EquipmentCatalog()
                {
                    equipment_code = 3,
                    model = "16�22",
                    description = "�����������"
                },
            };

            context.EquipmentCatalogs.AddOrUpdate(equipmentCatalog);
        }

        private static void SeedProcessCatalog(MachineDbContext context)
        {
            ProcessCatalog[] processCatalog = new[]
            {
                new ProcessCatalog()
                {
                    process_code = 1,
                    description = "������� ��������"
                },
                new ProcessCatalog()
                {
                    process_code = 2,
                    description = "������� ������������"
                },
                new ProcessCatalog()
                {
                    process_code = 3,
                    description = "������� ��������"
                },
                new ProcessCatalog()
                {
                    process_code = 4,
                    description = "������� ������"
                },
                new ProcessCatalog()
                {
                    process_code = 5,
                    description = "���������� ���������������"
                },
                new ProcessCatalog()
                {
                    process_code = 6,
                    description = "���������� ��������"
                },
                new ProcessCatalog()
                {
                    process_code = 17,
                    description = "������������"
                },
            };

            context.ProcessCatalogs.AddOrUpdate(processCatalog);
        }

        private static void SeedFixtureCatalog(MachineDbContext context)
        {
            FixtureCatalog[] fixtureCatalog = new[]
            {
                new FixtureCatalog()
                {
                    fixture_code = 1,
                    fixture_value = "7100-0007",
                    description = "�������������� ������"
                },
                new FixtureCatalog()
                {
                    fixture_code = 2,
                    fixture_value = "7100-0008",
                    description = "������"
                },
            };

            context.FixtureCatalogs.AddOrUpdate(fixtureCatalog);
        }
    }
}