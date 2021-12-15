using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCampus.DAL.Migrations
{
    public partial class IC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    CountryName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    GenderDescription = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ProvinceName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CountryId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "Province_FK",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    Firstname = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Middlename = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Lastname = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NRC = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    GenderId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "Students_FK",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DistrictName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ProvinceId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    CountryId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictId);
                    table.ForeignKey(
                        name: "District_FK",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId");
                    table.ForeignKey(
                        name: "District_FK_1",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId");
                });

            migrationBuilder.CreateTable(
                name: "Institution",
                columns: table => new
                {
                    InstitutionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    InstitutionName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CountryId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    ProvinceId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DistrictId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institution", x => x.InstitutionId);
                    table.ForeignKey(
                        name: "Institution_FK",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Institution_FK_1",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Institution_FK_2",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programme",
                columns: table => new
                {
                    ProgrammeId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    ProgrammeCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ProgrammeDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    InstitutionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programme", x => x.ProgrammeId);
                    table.ForeignKey(
                        name: "Programme_FK",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "InstitutionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    SchoolCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SchoolDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    InstitutionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolId);
                    table.ForeignKey(
                        name: "School_FK",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "InstitutionId");
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    CourseCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CourseDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ProgrammeId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                    table.ForeignKey(
                        name: "Course_FK",
                        column: x => x.ProgrammeId,
                        principalTable: "Programme",
                        principalColumn: "ProgrammeId");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    DepartmentCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DepartmentDescription = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ProgrammeId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    SchoolId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "Departments_FK",
                        column: x => x.ProgrammeId,
                        principalTable: "Programme",
                        principalColumn: "ProgrammeId");
                });

            migrationBuilder.CreateTable(
                name: "Lecturer",
                columns: table => new
                {
                    LecturerId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    LastName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    NRC = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    PassportNo = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    SchoolId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    DepartmentId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true),
                    InstitutionId = table.Column<string>(type: "varchar(450)", unicode: false, maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturer", x => x.LecturerId);
                    table.ForeignKey(
                        name: "Lecturer_FK",
                        column: x => x.InstitutionId,
                        principalTable: "Institution",
                        principalColumn: "InstitutionId");
                    table.ForeignKey(
                        name: "Lecturer_FK_1",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "SchoolId");
                    table.ForeignKey(
                        name: "Lecturer_FK_2",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProgrammeId",
                table: "Course",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ProgrammeId",
                table: "Departments",
                column: "ProgrammeId");

            migrationBuilder.CreateIndex(
                name: "IX_District_CountryId",
                table: "District",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceId",
                table: "District",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_CountryId",
                table: "Institution",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_DistrictId",
                table: "Institution",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Institution_ProvinceId",
                table: "Institution",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturer_DepartmentId",
                table: "Lecturer",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturer_InstitutionId",
                table: "Lecturer",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturer_SchoolId",
                table: "Lecturer",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Programme_InstitutionId",
                table: "Programme",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                table: "Province",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_School_InstitutionId",
                table: "School",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId",
                table: "Students",
                column: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Lecturer");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Programme");

            migrationBuilder.DropTable(
                name: "Institution");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
