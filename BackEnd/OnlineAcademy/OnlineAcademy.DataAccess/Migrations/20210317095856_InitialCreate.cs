using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineAcademy.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CourseCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CorseId",
                        column: x => x.CorseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTeachers",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTeachers", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CourseTeachers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "ModifiedByName", "ModifiedDate", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(2395), true, false, false, null, null, "Yazılım Geliştirme", null },
                    { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7007), true, false, false, null, null, "İşletme", null },
                    { 3, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7014), true, false, false, null, null, "Web Geliştirme", 1 },
                    { 4, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7018), true, false, false, null, null, "Veri Bilimi", 1 },
                    { 5, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7022), true, false, false, null, null, "JavaScript", 3 },
                    { 6, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 141, DateTimeKind.Local).AddTicks(7026), true, false, false, null, null, "React", 3 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "IsModified", "ModifiedByName", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 166, DateTimeKind.Local).AddTicks(4011), "Bu kursta sıfırdan başlayarak ileri düzeyde React öğreneceksiniz.", true, false, false, null, null, "Sıfırdan İleri Seviye React Kursu!" },
                    { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 166, DateTimeKind.Local).AddTicks(4067), "Bu kursta sıfırdan başlayarak ileri düzeyde JavaScript öğreneceksiniz.", true, false, false, null, null, "Sıfırdan İleri Seviye JavaScript Kursu!" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2873), true, false, false, null, null, "Admin" },
                    { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2925), true, false, false, null, null, "Moderator" },
                    { 3, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2929), true, false, false, null, null, "Teacher" },
                    { 4, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 176, DateTimeKind.Local).AddTicks(2933), true, false, false, null, null, "Student" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Email", "Firstname", "IsActive", "IsDeleted", "IsModified", "Lastname", "ModifiedByName", "ModifiedDate", "Password" },
                values: new object[,]
                {
                    { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1909), "mhmt.cetin00@gmail.com", "Mehmet", true, false, false, "Çetin", null, null, "123456" },
                    { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1963), "mail@mail.com", "MailF", true, false, false, "MailL", null, null, "123456" },
                    { 3, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1968), "student1@gmail.com", "student1F", true, false, false, "student1L", null, null, "123456" },
                    { 4, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 182, DateTimeKind.Local).AddTicks(1971), "student2@mail.com", "student2F", true, false, false, "student2L", null, null, "123456" }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 6, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "CourseTeachers",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CorseId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "ModifiedByName", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 3, 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3151), true, false, false, null, null, "Course 2 Section 1" },
                    { 2, 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3147), true, false, false, null, null, "Course 1 Section 2" },
                    { 1, 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 179, DateTimeKind.Local).AddTicks(3035), true, false, false, null, null, "Course 1 Section 1" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "Length", "ModifiedByName", "ModifiedDate", "SectionId", "Title", "Video" },
                values: new object[] { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 173, DateTimeKind.Local).AddTicks(9949), true, false, false, 15, null, null, 1, "Section 1 Lesson 1", "https://www.youtube.com/watch?v=w7ejDZ8SWv8&ab_channel=TraversyMedia" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "Length", "ModifiedByName", "ModifiedDate", "SectionId", "Title", "Video" },
                values: new object[] { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 174, DateTimeKind.Local).AddTicks(6), true, false, false, 23, null, null, 1, "Section 1 Lesson 2", "https://www.youtube.com/watch?v=dGcsHMXbSOA&ab_channel=DevEd" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "Length", "ModifiedByName", "ModifiedDate", "SectionId", "Title", "Video" },
                values: new object[] { 3, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 174, DateTimeKind.Local).AddTicks(11), true, false, false, 23, null, null, 2, "Section 2 Lesson 1", "https://www.youtube.com/watch?v=Law7wfdg_ls&ab_channel=DevEd" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "LessonId", "Message", "ModifiedByName", "ModifiedDate", "Title", "UserId" },
                values: new object[] { 1, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 150, DateTimeKind.Local).AddTicks(9584), true, false, false, 1, "Eğitim çok başarılı.", null, null, "Teşekkür", 3 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "IsModified", "LessonId", "Message", "ModifiedByName", "ModifiedDate", "Title", "UserId" },
                values: new object[] { 2, "Initial Create", new DateTime(2021, 3, 17, 12, 58, 56, 150, DateTimeKind.Local).AddTicks(9638), true, false, false, 1, "Tebrikler. Eğitim çok başarılı.", null, null, "Tebrik", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LessonId",
                table: "Comments",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CategoryId",
                table: "CourseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_UserId",
                table: "CourseStudents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeachers_UserId",
                table: "CourseTeachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SectionId",
                table: "Lessons",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CorseId",
                table: "Sections",
                column: "CorseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "CourseTeachers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
