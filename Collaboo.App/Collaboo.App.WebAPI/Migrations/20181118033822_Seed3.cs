using Microsoft.EntityFrameworkCore.Migrations;

namespace Collaboo.App.WebAPI.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "Id",
                startValue: 1000L,
                incrementBy: 5);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 7 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 19 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 23 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 9 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 8,
                column: "SkillId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 10,
                column: "SkillId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 21 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 12,
                column: "SkillId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 20 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 15,
                column: "SkillId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 16,
                column: "SkillId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 18,
                column: "SkillId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 19 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 19 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 29,
                column: "SkillId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 31,
                column: "SkillId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 21 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 7 });

            migrationBuilder.InsertData(
                table: "ProjectRequirments",
                columns: new[] { "Id", "ProjectId", "Rating", "SkillId" },
                values: new object[,]
                {
                    { 39, null, 1, 23 },
                    { 40, null, 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Dolorum illo ab quaerat sunt vel sint ut nihil deleniti.
Et recusandae velit.
Vel magnam quam.
Sed ducimus rem iste.
Placeat eos non dolor necessitatibus quia et.
Autem et adipisci est eligendi ex.
Nobis alias nesciunt nemo magnam ut facilis veritatis.
Sint explicabo consequatur id blanditiis natus occaecati ratione dolores.
Excepturi incidunt ipsum laboriosam perferendis corporis esse.
Magnam magni consequatur reprehenderit sed saepe id.
Sed quis neque nemo laborum aut.
Reprehenderit quaerat autem facere voluptas a illum minima quae.
Sequi nulla qui sint.
Qui consequatur fugiat nemo qui recusandae vel non.
Rem repellat aut ex ut voluptatibus consectetur molestiae velit iusto.
Vitae modi omnis sunt rerum et pariatur a neque.
Ab quis delectus ut qui nesciunt rem corporis nihil et.", 58, "morgan.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Voluptatibus praesentium quae veritatis aperiam.
Et perferendis id qui.
Blanditiis maxime libero sapiente vitae at consequatur consequatur nihil quo.
Illum sunt qui.
Fuga nihil sunt velit aliquid ea enim omnis.
Aut aut saepe consequuntur quod et enim tempora.
Modi nihil est quidem maxime dolor est commodi vel vero.
Aut facilis a et ipsam id est.
Sed incidunt occaecati sit maiores aut.", 99, "douglas.org" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Aut odio dolor eos et.
Asperiores maiores sapiente.
Voluptatum maiores officia esse qui soluta voluptas pariatur et.
Eos saepe eum est est cumque cupiditate id fuga.
Molestias omnis consequuntur perspiciatis ab dolor consectetur dolor sunt.
Voluptatem et voluptas.
Veritatis dolore non assumenda nulla sit distinctio molestiae.
Molestiae magni repudiandae est sunt.", 14, "casper.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Quia veniam quo eos ipsa.
Sapiente corrupti unde possimus non.
Occaecati consequuntur ipsum et deleniti est.
Saepe exercitationem explicabo beatae blanditiis cumque esse eos similique.
Facilis molestiae non.
Quaerat natus autem.
Iure rerum ea aut voluptas.
Libero omnis recusandae.
Repellendus odio laudantium distinctio reprehenderit quo ea.", 7, "berneice.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Et tempora reprehenderit iure.
Fugiat repellat molestiae quaerat similique quibusdam veniam explicabo rerum aliquid.
Blanditiis maiores voluptate.
Voluptas aut aliquid magni quidem maiores provident est.
Adipisci qui ipsum sunt modi quaerat dolor corrupti.
Quia quo omnis quas ut eius.
Dolor similique molestias corrupti ut est consequuntur quibusdam.
Qui qui officiis voluptatem facere et corporis.
Est et fugit et adipisci.", 87, "lloyd.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Omnis sunt ut.
Praesentium magni quos praesentium esse.
Sed ex qui.
Quis excepturi eum iusto corporis.
Cumque quis provident totam.
Veniam aut aut maiores cumque debitis ipsam illum est.
Modi cum dolores commodi maxime.
Exercitationem quas ad odit quis atque temporibus aliquam soluta.
Consectetur accusamus corporis.
Corrupti eaque et atque quia.
Deleniti rem porro.
Rerum sed reiciendis reiciendis.
Fugiat optio architecto natus.", 46, "gwen.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Voluptate quibusdam ipsam possimus corporis.
Nobis dignissimos sint nemo vero amet et est.
Porro quis qui repellendus.
Eius fugiat molestias vel.
Pariatur laboriosam sed.
Nulla saepe nihil dolor quasi.
Autem quo est.
Illo laudantium dignissimos voluptatem.
Sed delectus deserunt quae necessitatibus voluptas dolorem qui.", 1, "brandy.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Et est blanditiis voluptatem similique.
Tempore velit sequi ea.
Sunt consequatur consequatur natus.
Qui libero omnis vel quo optio qui aliquam.
Tempora totam cum nemo nihil.
Non quas dicta non architecto quo id saepe.
Ut quaerat sapiente error quam.
Beatae quo id recusandae enim praesentium.
Omnis blanditiis aut molestias velit.
Laboriosam nam asperiores.
Qui maxime et.
Est autem corrupti.
Asperiores est totam laudantium in minus in quo qui voluptatem.
Quasi autem et adipisci error maxime harum voluptate.", 57, "jordi.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Ex nesciunt molestias illum dolor ea ex quae.
Asperiores minima nobis.
Exercitationem debitis quasi non commodi quia consectetur aperiam et est.
Omnis cum quia.
Eum et nihil.
Modi eum aut quam modi.
Expedita esse quibusdam officia hic vel sequi excepturi libero.
Facere suscipit quidem sequi quas ea.
Et et corrupti ut et beatae voluptatem.
Velit sunt asperiores praesentium quasi amet blanditiis pariatur.
Nihil temporibus qui ducimus.
Ut accusamus ipsa aut debitis laboriosam ab veniam enim dolor.
Eius cum doloribus id dolores nesciunt suscipit provident molestiae.", 76, "rahsaan.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Quaerat ullam corrupti laudantium ducimus quo delectus.
Praesentium vitae dolorum tempora.
Sed et est sint ullam non.
Pariatur excepturi laudantium aut cum unde blanditiis.
Occaecati modi sed impedit asperiores velit et eaque error.", 82, "rene.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Numquam et sed.
Libero magni est voluptatem fugiat.
Hic qui placeat placeat fugiat autem temporibus.
Aliquam aut rerum labore perspiciatis voluptates ut beatae officia rerum.
Explicabo voluptatum qui.
Temporibus exercitationem iste doloribus voluptate debitis quia magnam.
Iure doloremque omnis ut.
Et sed amet doloremque et vel quibusdam quam.
Commodi quia aperiam deserunt perspiciatis est enim id doloremque aut.
Sapiente blanditiis minima iure eum voluptatem recusandae pariatur odio.
Sint voluptatem eligendi esse quisquam soluta eos et iste.
Ut quis voluptatem adipisci repellendus.
Quis dolor non non est.
Tenetur temporibus cumque velit molestiae et facilis eveniet aut rerum.
Quia nulla illo nisi quia dolorem ipsa velit tempore voluptatum.
At officia dolores vitae animi perferendis.
Voluptatem quia molestias sed sint velit ut porro.
Facere veritatis quam expedita qui.
Reprehenderit velit aliquid qui accusantium fugit a atque occaecati aut.", 53, "jayne.org" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Nulla velit harum neque qui.
Rem sint sit vero odio praesentium sint.
Aliquid magnam illum sit eveniet.
Itaque minus officiis doloribus.
Adipisci voluptas doloribus tempora doloribus quo delectus.
Doloremque voluptates eos temporibus quos est sit.", 93, "dulce.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Et odio adipisci dolorem est impedit laudantium.
Repudiandae laboriosam fugit.
Facilis ut provident dolor deleniti.
Laboriosam ratione rem at atque vel corrupti laudantium.
Exercitationem similique ad distinctio quo.
Ea ut facere.
Qui quas minima dolore non est eligendi quibusdam.
Ratione hic adipisci unde odio officia cum.
Aut quibusdam a vel soluta quaerat eum ipsum.
Rerum soluta in quia labore sunt.
Dolores distinctio sit inventore eveniet perspiciatis dolorem autem qui.
Voluptatem quis aspernatur voluptatem fugiat quasi aperiam ad nostrum ipsum.
Fugiat eos dolore eveniet beatae praesentium quae aut qui.
Et autem esse velit.
Ea et eum similique harum dolorem tempora qui earum.
Quasi dignissimos consequatur.
Consequatur ab rerum ea voluptatibus corporis occaecati.
Neque illum vitae sed dolor consectetur id velit repellat soluta.", 62, "americo.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Est sed et id velit corporis.
Aut sit ut in doloremque neque sapiente aut iusto aut.
Laudantium qui perferendis atque sint.
Eaque doloribus non perferendis iure fugiat.
Rerum hic id modi et aliquid optio aut harum.
Consequatur et aut eum neque.
Qui voluptatem dolore quas autem velit sapiente.
Labore voluptatem et error nihil omnis.
Dolorum sit deleniti qui beatae natus id odit dicta.
Voluptatem fugiat quia sed quam harum.
Debitis esse beatae.", 100, "bryce.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Doloribus quia voluptatibus nulla odit magni nobis vero.
Amet aut ea non vitae sit.
Sint nesciunt dicta facilis consequatur temporibus tempora illum.
Et est aut optio debitis deleniti.
Sint nihil sunt iure possimus voluptatem reiciendis veniam laudantium.
Omnis perferendis sed tempora quasi autem qui consequatur architecto voluptatibus.
Voluptatem vel velit rerum.
Blanditiis et dignissimos cum.
Sed impedit doloremque necessitatibus.
Asperiores harum a expedita.
Aut dolor reprehenderit doloremque.
Veniam neque ipsum saepe.
Sit et dolores est adipisci voluptas necessitatibus.
Deserunt aut aut voluptas temporibus illum.
Corporis molestias laboriosam pariatur.
Voluptas voluptate quam et odio qui maiores ipsum qui.
Exercitationem optio unde et eum id numquam quam optio saepe.
Consectetur commodi pariatur.
Sapiente reprehenderit in.
Voluptates est qui quia sunt nulla et vel eligendi.", 18, "amely.info" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Quo excepturi esse nostrum est maiores corrupti sunt.
Facilis tenetur optio.
Quae sunt minus voluptatum facere voluptate consequatur.
Aut rem autem blanditiis eius et ex occaecati magnam.
Omnis vel deleniti et laboriosam expedita libero libero.
Ipsam illum nobis quia quis qui ut.
Consequatur sapiente eligendi ullam recusandae ex necessitatibus animi eaque eaque.
Quas vitae dolores sunt quo alias in voluptatem aspernatur.
Ut architecto aut vitae illum ab.
Nihil exercitationem consequatur.
Tenetur doloremque unde.
Iste nisi dolorum accusantium officia ab ullam.
Fugiat dolorem molestias sit dolore nulla quia.
Architecto dolorem deleniti in rerum necessitatibus eius fugit nemo necessitatibus.
Quod aperiam est unde.
Qui perferendis veniam.", 66, "orval.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Recusandae praesentium aut sint enim.
Possimus culpa sed aperiam maiores repellendus unde ut tempore.
Consequuntur quas quisquam cumque officiis iste qui veritatis.
Blanditiis mollitia incidunt natus occaecati consectetur repellendus.
Eos rerum molestiae repudiandae ullam aut iusto magni.
Dolorum alias repellendus voluptas quas laborum nisi.
Provident ad sunt consequatur rem vel debitis.
Corporis at ad cupiditate sit animi voluptas sed consequuntur velit.
Et facere eum cumque veniam.
Ad recusandae culpa minima pariatur tenetur voluptatibus.
Rerum doloribus sint non nulla libero voluptatem unde consequatur asperiores.
Neque est culpa voluptatem nesciunt culpa quidem explicabo veniam aspernatur.
Cumque in nostrum et adipisci dignissimos exercitationem et qui.", 91, "eladio.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Molestiae asperiores minima quod et eligendi maxime.
Facere sed sapiente eligendi repudiandae nihil cumque non vero.
Temporibus vitae quis laboriosam sint id rem qui.
Autem ut quae officiis aut.
Voluptate incidunt qui ex aliquid numquam ea.
Accusamus dolorem quia.", 29, "jewell.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Et ipsa deserunt nulla doloribus voluptas qui beatae cum enim.
Odio quis nostrum nihil.
Doloribus sit molestias consectetur.
At molestias atque.
Sapiente esse sint maxime quia ut.
Eum dignissimos ullam alias minima.
Occaecati vitae est molestias.
Vitae ut delectus placeat in sed molestiae nostrum.
Voluptatem soluta illum iure sed.
Laudantium accusantium voluptates.
Suscipit ex ullam.
Illo molestiae asperiores cumque ut eos distinctio molestiae perspiciatis est.
Molestiae sint quam numquam.
In illum doloremque et enim nihil et repudiandae totam.
Nam dolores ipsum culpa.
Voluptas dolor perferendis voluptates.
Qui quam a et expedita mollitia dolores non numquam.
Mollitia ipsa vel.", 7, "marcia.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Nobis aliquid exercitationem beatae incidunt et velit dolorem.
Delectus et nulla facilis quas.
Iure aliquam reiciendis vero animi asperiores cum.
Quam cumque ea similique dolorum soluta aut.
Expedita alias dolores voluptas iste non quas amet sequi incidunt.
Nisi ipsum omnis consequatur laudantium explicabo.
Nihil vel eligendi expedita est et aut.
Officiis vel officiis incidunt in corrupti voluptatem inventore omnis.
Excepturi quia tenetur vero placeat autem cumque consequatur quas.
In facilis suscipit eveniet voluptatum.", 9, "dereck.biz" });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 23 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 6,
                column: "SkillId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 7,
                column: "SkillId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 20, 3 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 12, 4 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 17, 4 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 13, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 13,
                column: "SkillId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 14,
                column: "SkillId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 1, 8 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 19, 8 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 1, 8 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 4, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 18, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 17, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 1, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 16, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 20, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 22, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 19, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 11, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 6, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 21, 12 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 9, 12 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 16, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 23, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 19, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 22, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 7, 15 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 18, 15 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 14, 16 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 21, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 21, 18 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 9, 19 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 15, 19 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 2, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 24, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 15, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 15, 22 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 25, 23 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 12, 25 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 2, 25 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Rating", "UserId" },
                values: new object[] { 1, 27 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 18, 27 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 1, 29 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 22, 31 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 1 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 23, 33 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 22, 35 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 4, 36 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 10, 36 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 9, 37 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 13, 40 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 5, 40 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 8, 41 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 9, 41 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 23, 41 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 1, 41 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 5, 42 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 6, 42 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 25, 42 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 4, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 22, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 13, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 22, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Rating", "UserId" },
                values: new object[] { 4, 44 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 7, 44 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 8, 45 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 6, 45 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 6, 45 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 11, 46 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 23, 46 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 8, 47 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 2, 48 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 20, 48 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 19, 49 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 18, 49 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 16, 50 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 1, 50 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 19, 51 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 25, 52 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 2, 52 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 6, 52 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 101,
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 18, 53 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 103,
                column: "SkillId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 7, 54 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 8, 54 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 13, 54 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 1, 55 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 24, 55 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 12, 55 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 12, 55 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 25, 56 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 19, 57 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 5, 57 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 18, 58 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 24, 58 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 10, 59 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 13, 60 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 63 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 20, 64 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 13, 64 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 9, 64 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 14, 65 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 19, 65 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 20, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 16, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 25, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 6, 67 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 21, 68 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 2, 69 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 23, 70 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 21, 70 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 8, 70 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 25, 71 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 10, 71 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 23, 72 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 4, 75 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 18, 75 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 6, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 7, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 19, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 2, 77 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 24 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 4, 79 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 22, 80 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 24, 80 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 15, 81 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 6, 81 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 4, 82 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 25, 82 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 13, 83 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 13, 84 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 16, 84 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 160,
                column: "SkillId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 6, 87 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 164,
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 13, 88 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 24, 88 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 23, 89 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 7, 89 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 2, 90 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 4, 90 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 23, 91 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 16, 91 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 19, 92 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 20, 92 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 24, 92 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 24, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 9, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 13, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 12, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 19, 94 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 18, 94 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 1, 95 });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "Id", "Rating", "SkillId", "UserId" },
                values: new object[,]
                {
                    { 186, 4, 13, 96 },
                    { 187, 2, 1, 97 },
                    { 188, 1, 6, 97 },
                    { 189, 4, 6, 97 },
                    { 190, 4, 20, 99 },
                    { 191, 3, 20, 99 },
                    { 192, 0, 19, 100 },
                    { 193, 5, 7, 100 },
                    { 185, 3, 22, 95 },
                    { 195, 3, 4, 100 },
                    { 194, 0, 1, 100 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Login",
                value: "Katlyn_Terry13");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Login",
                value: "Arlene.Anderson");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Login",
                value: "Ellie.Hodkiewicz57");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Login",
                value: "Jeramie.Toy58");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Login",
                value: "Orpha.Osinski");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Login",
                value: "Krystina86");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Login",
                value: "Dorothea46");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Login",
                value: "Baron_Orn40");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Login",
                value: "Hilario.Green41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Login",
                value: "Friedrich_Boehm93");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "Login",
                value: "Gwendolyn.Jaskolski");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "Login",
                value: "Amelie_Kovacek");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Login",
                value: "Ceasar.Upton25");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "Login",
                value: "Ashleigh_Effertz81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "Login",
                value: "Romaine45");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "Login",
                value: "Maia_Borer");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "Login",
                value: "Dallas.Gutmann");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "Login",
                value: "Kellen.Beatty63");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "Login",
                value: "Jaime.Schmitt");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "Login",
                value: "Zachary52");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "Login",
                value: "Abigale.Lind");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "Login",
                value: "Ray_Bergnaum26");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "Login",
                value: "Boris_Kunde74");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "Login",
                value: "Georgette.Purdy");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "Login",
                value: "Clint.Grady81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "Login",
                value: "Drew_Schaden");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "Login",
                value: "Toy_Collier");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                column: "Login",
                value: "Mariano_Dickens55");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "Login",
                value: "Brandon.Luettgen");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "Login",
                value: "Marie92");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "Login",
                value: "Emmie_Rohan42");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                column: "Login",
                value: "Terence.Schultz74");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                column: "Login",
                value: "Mafalda.Okuneva24");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                column: "Login",
                value: "Freddy.Haley73");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                column: "Login",
                value: "Dorian.Schultz");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                column: "Login",
                value: "Asia_Sipes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                column: "Login",
                value: "Rosalind.Williamson");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                column: "Login",
                value: "Amira.Towne76");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                column: "Login",
                value: "Alfonzo71");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                column: "Login",
                value: "Bennett.Gorczany");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                column: "Login",
                value: "Zoe30");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                column: "Login",
                value: "Alivia.Walsh55");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                column: "Login",
                value: "Mackenzie65");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                column: "Login",
                value: "Lisandro_McLaughlin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                column: "Login",
                value: "Stanley48");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                column: "Login",
                value: "Lela21");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                column: "Login",
                value: "Lauryn26");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                column: "Login",
                value: "Afton.Cummings");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                column: "Login",
                value: "Nolan51");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                column: "Login",
                value: "Leann67");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                column: "Login",
                value: "Vivianne45");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                column: "Login",
                value: "Reginald_Buckridge");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                column: "Login",
                value: "Shana83");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                column: "Login",
                value: "Eloy_Schaden");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                column: "Login",
                value: "Virgie_Boyer");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                column: "Login",
                value: "Maude.White");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                column: "Login",
                value: "Virginia_Champlin58");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                column: "Login",
                value: "Rhett41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                column: "Login",
                value: "Jamarcus59");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                column: "Login",
                value: "Mac_Hudson");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                column: "Login",
                value: "Emelie95");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                column: "Login",
                value: "Melba_Satterfield1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                column: "Login",
                value: "Karley.Lakin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                column: "Login",
                value: "Wiley_Aufderhar48");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                column: "Login",
                value: "Matteo.Fahey5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                column: "Login",
                value: "Johan_Bruen");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                column: "Login",
                value: "Dorian.Graham");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                column: "Login",
                value: "Meaghan.Windler56");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                column: "Login",
                value: "Eulah34");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                column: "Login",
                value: "Taurean.Smith");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                column: "Login",
                value: "Pierre48");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                column: "Login",
                value: "Jeramie.Crist69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                column: "Login",
                value: "Dereck.Ziemann69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                column: "Login",
                value: "Rose_Green41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                column: "Login",
                value: "Leslie.Feeney60");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                column: "Login",
                value: "Laverna.Kling");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                column: "Login",
                value: "Danielle3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                column: "Login",
                value: "Nils.Runte39");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                column: "Login",
                value: "Flavio55");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                column: "Login",
                value: "Calista_Adams40");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                column: "Login",
                value: "Darron_Nolan41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                column: "Login",
                value: "Courtney.Jones99");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                column: "Login",
                value: "Estel.Jones53");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                column: "Login",
                value: "Lila_Wehner");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                column: "Login",
                value: "Vernice_Ernser");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                column: "Login",
                value: "Jamel_Tremblay");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                column: "Login",
                value: "Eda79");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                column: "Login",
                value: "Mateo21");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                column: "Login",
                value: "Wallace93");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                column: "Login",
                value: "Baby_Morar71");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                column: "Login",
                value: "Alysson_Witting");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                column: "Login",
                value: "Lamont65");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                column: "Login",
                value: "Norris67");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                column: "Login",
                value: "Maggie83");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                column: "Login",
                value: "Efren_Conn20");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                column: "Login",
                value: "Lucio_Metz56");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                column: "Login",
                value: "Antonina_Parker");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                column: "Login",
                value: "Eveline.Kautzer41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                column: "Login",
                value: "Thora69");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                column: "Login",
                value: "Breana92");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "Id");

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 18 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 8,
                column: "SkillId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 22 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 10,
                column: "SkillId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 16 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 12,
                column: "SkillId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 19 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 24 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 15,
                column: "SkillId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 16,
                column: "SkillId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 18,
                column: "SkillId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 13 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 16 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 29,
                column: "SkillId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 31,
                column: "SkillId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Est eum sit reiciendis voluptates aut dolorem sequi aut ratione.
Fuga pariatur et et delectus eaque asperiores cumque.
Iusto qui ipsum.
Vel qui excepturi pariatur ut est soluta.
Vitae dolores ad et nesciunt.
Enim est est aut laborum accusantium est aspernatur.
Ipsum numquam et sint sed.
Ullam rem et numquam quo.
Sint exercitationem ipsam sit.
Totam odio ut porro officia.", 71, "ramiro.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Autem omnis non.
Aut quo sed laboriosam.
Ex quia voluptatum tenetur repellendus distinctio velit impedit.
Culpa facere reprehenderit sit cumque quia.
Ipsum iste natus culpa quas aut modi.
Ipsam et sint expedita quasi nihil.
Qui tenetur soluta dolorem fugit doloribus.
Possimus illo dolor repellat consequatur quo.
Dolorum ipsa pariatur rerum qui quo sequi natus possimus magni.
Hic repellat rerum eos maxime facere rerum.
Consequuntur ea odio et officiis non sunt est.
Quas ea molestias iusto excepturi excepturi eligendi aut et.
Atque accusamus ullam quo adipisci unde ad neque asperiores.
Saepe enim nihil ex harum qui est dolor reprehenderit.
Cum perferendis voluptatem aliquid illo ex fuga fugit odio atque.
Voluptatibus cum maiores sequi accusamus eum occaecati dolore aut mollitia.", 5, "kirsten.org" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Reiciendis voluptatem aut non.
Excepturi corrupti sunt explicabo rem porro rerum repellendus quo molestiae.
Est molestias ut repudiandae.
Odio sed omnis facere dicta recusandae quis vel.
Iusto enim ducimus vero autem rem nemo excepturi.
Et quos qui necessitatibus soluta voluptatem rerum.
Voluptate dolor iusto quia et earum asperiores natus.
Hic ipsa quia vel culpa sed impedit.
Eaque voluptate et molestiae praesentium blanditiis.
Non non totam quam ab unde occaecati laborum accusamus.
Cupiditate aut rerum ullam consequatur.
Qui ullam quo cupiditate voluptatem.
Voluptas at nostrum debitis nihil.
Quod eum vel rerum est culpa fugit eos.
In molestias doloribus molestiae et corporis.
Illo sunt voluptas dolorem libero eaque.
Fuga fuga non.
Officiis neque et consequuntur quia consequuntur debitis.
Corrupti sed in iure commodi amet incidunt eveniet officiis.", 80, "rosalyn.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Corporis quibusdam sed.
Aliquam reiciendis nihil.
Amet quia autem asperiores labore.
Vero qui suscipit et omnis natus vel molestiae deleniti nihil.
Reiciendis iusto eos ipsum fugiat dolor.
Facere quo eos illum et veritatis accusamus eveniet dolorem.
Aliquid aliquam deserunt quis.
Quaerat ipsa nihil praesentium reiciendis perspiciatis ad modi autem voluptatem.
Impedit ad ut error dolorem ex.
A labore ea aut eaque non enim.
Et reprehenderit libero in modi aut doloremque doloremque dolor aspernatur.
Autem et nostrum deleniti et corrupti et nihil.
Mollitia ea id voluptatibus asperiores.
Quidem dolores unde ratione alias eveniet amet voluptatibus.
Aut iste quibusdam explicabo iure soluta et commodi laudantium quam.
Quod libero possimus temporibus fuga ut aut sint in nostrum.
Nobis culpa excepturi rem saepe atque aperiam explicabo at.
Illum qui mollitia inventore.", 69, "grover.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Repellat eos natus perferendis ut.
Autem omnis occaecati laudantium autem ut culpa animi explicabo accusamus.
Qui sint repellendus omnis.
Quis similique autem et enim.
Qui recusandae eos quasi.
Ab exercitationem et quia.
Perspiciatis quas occaecati est excepturi harum veritatis.
Labore autem quas consectetur rem qui sed rerum officia libero.
Asperiores modi quae optio numquam doloremque officia voluptas quisquam.
Non nemo dignissimos.
Est eaque velit ut aperiam illum id molestias.
Nobis voluptatum expedita sed praesentium voluptatem hic ea praesentium.
Aut magni nisi et consequatur corporis eligendi molestiae.
Laboriosam eveniet impedit corrupti veritatis.
Dolorem dolor nihil dolorum iste at.", 3, "jazmyne.info" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Natus dolores consequuntur aut.
Distinctio quasi cum natus laborum nemo ut id sapiente.
Saepe et ipsum aut reiciendis.
Mollitia sunt quidem sed dolore quod et est at facilis.
Eos deserunt maxime velit quibusdam exercitationem similique labore rerum consequatur.
Eum sint labore aut expedita numquam a.
Ipsam vel eum incidunt sapiente ea quos.
Cupiditate et neque et impedit ut.
Ea aut eius qui aspernatur.
Animi id laboriosam quia.", 10, "devonte.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Vitae eligendi illum aliquam.
Laborum facere ea dolor quibusdam.
Dolorem quae ipsam voluptatum et.
Eos sed fugiat sunt odio quasi eos praesentium porro.
Quae illo accusamus qui quis ipsum eum quo.
Dicta qui rerum cumque est et.
Ut temporibus enim iste quam eos.
Corporis in sint laudantium ab.
Dolorum tenetur quibusdam laborum aut impedit nemo repudiandae.", 66, "tremayne.name" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Alias qui nisi modi et amet.
Alias est quasi ratione nesciunt modi.
Repellendus error quod qui.
Suscipit adipisci at dolores et accusantium qui itaque.
Cupiditate eligendi at expedita saepe.
Eos ducimus sapiente dolor esse minima est rerum saepe aut.
Qui placeat non occaecati ut repudiandae atque rerum.
Veniam voluptatem nobis est velit.
Dolore aspernatur deleniti aperiam eius corrupti ut veniam quia.
Id error eaque molestiae est.
A magnam consequatur sunt reiciendis velit qui.
Omnis quis quo error.
Impedit voluptas ad reiciendis rerum doloremque excepturi nesciunt.
Nam nesciunt amet totam quia amet maxime aliquid ducimus.
Animi est adipisci iusto nobis fuga quibusdam.", 84, "dorris.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Omnis cumque fuga laborum sunt sit qui qui qui.
In aspernatur officia nulla.
Excepturi sed quidem et molestiae et.
Sapiente recusandae sint voluptas.
Aliquid nulla adipisci ut at id vel.
Corrupti voluptas deserunt laborum velit voluptas.
Quia iure voluptas.
Nulla voluptas et.
Harum rerum officiis eum molestiae.", 59, "mya.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Quod incidunt omnis sed.
Perspiciatis dolores est praesentium eveniet libero est voluptatem sit nam.
Quasi in id quam atque placeat aut natus natus.
Reiciendis est necessitatibus quibusdam facere voluptatem dolores.
Tempore provident et sint voluptate.
Animi quasi vel ut dolorum accusantium et vero dolorem.", 6, "jon.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Omnis doloribus quia doloribus rerum vel error quisquam.
Nam qui sint fugit est nisi magni quis voluptatem dolorem.
Illum velit quis voluptas itaque sed reiciendis quia id.
Veniam deserunt et qui est soluta velit molestias minima.
Numquam aut amet.
Sed aut repudiandae delectus excepturi eaque soluta ea.", 100, "devante.org" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Ex ab odit ea dignissimos fugit quae.
Omnis ducimus nostrum ipsa nam porro.
Officiis eos est itaque modi expedita error quo fuga.
Est similique sequi.
Animi aut sapiente quaerat veritatis illo blanditiis ipsum et est.
Eos suscipit et expedita dolorum molestiae pariatur voluptatem illum.
Vero et et consequuntur sapiente autem.
Atque reprehenderit quo unde.
Blanditiis tenetur rerum sit dolor animi nam ea nihil excepturi.
Quia vitae quia voluptates dolor consequatur vitae omnis magnam.", 34, "ian.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Dolores aut voluptatem.
Est ut recusandae eius.
Aut optio perferendis quis.
Dolore expedita esse repellendus.
Vel placeat ipsa quidem aut.
Voluptatum nemo beatae.
Iste sit non corrupti exercitationem.", 65, "jessyca.info" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Ad ut tenetur.
Dignissimos numquam dolorem porro itaque excepturi mollitia et expedita.
Laboriosam quis explicabo laudantium vel quia.
Non vero et eligendi.
Corrupti non doloribus et placeat aliquam magnam assumenda quasi.
Autem sed adipisci libero accusamus possimus consequatur error cumque harum.
Vel ratione consequatur omnis aperiam.", 2, "vernon.net" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Aperiam ratione culpa.
Quidem qui iusto voluptas nisi tempore rerum sit.
Dolores necessitatibus enim quo suscipit qui.
Exercitationem modi inventore quas cum vel maiores.
Quo ut nostrum delectus est officiis omnis inventore et rerum.
Doloremque recusandae et ea.
Voluptatum atque quisquam excepturi nam voluptas nemo fuga aliquid repellendus.
Vel sunt architecto ab quaerat quod corrupti ab.
Vel sint id.
Minus eum expedita assumenda aut quam et.", 50, "salvador.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Expedita voluptatum veniam hic.
Libero et itaque consequuntur hic ut ut saepe aut nostrum.
Placeat magnam qui iste debitis ipsum.
Quo odit ut cupiditate non nesciunt magnam rerum asperiores.
At animi ut.", 21, "bartholome.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Libero molestiae repellendus eos sed.
Consequuntur magni sit maxime laborum molestias rem voluptatem corrupti.
Dignissimos voluptas iure ratione est dolor officiis alias.
Quos ipsa autem voluptatem ut facilis quasi officiis aliquam non.
Doloribus reiciendis doloribus libero in quibusdam aut molestias.
Atque in sed aut sunt.
Quaerat autem error laborum rerum iste repellendus rerum fuga.
Placeat aut rerum aspernatur ut quidem numquam odit placeat.
Totam at porro placeat saepe consequatur consequatur nam.
Repudiandae quas ut qui voluptatum iure.
Enim facilis quia sit quia.
Commodi quo est.
Accusantium voluptate quibusdam pariatur commodi molestiae ea et.
Voluptate beatae illum quisquam architecto.
Sed reprehenderit quo voluptas.
Distinctio rem quo voluptatem voluptas similique.", 79, "kendrick.info" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Aut aspernatur sed repellendus a accusamus.
Omnis architecto et qui sit reiciendis velit quos.
Magnam asperiores dicta cumque et molestias dolorem accusantium omnis eligendi.
Cupiditate autem facilis quibusdam commodi sint sint.
Porro sint nostrum incidunt.
Placeat nesciunt aliquam in.
Quis id veritatis.
Facilis provident sunt velit cum quo autem recusandae dolor.
Ut laboriosam sed possimus.
Aut eius ut inventore consequatur est.
A omnis quo hic quos magnam.", 60, "veda.biz" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Est voluptatem aut modi hic labore.
Qui repellendus laboriosam.
Delectus repudiandae et.
Dolorem laudantium at voluptatem cum inventore.
Ut in consequatur.
Qui nisi quia nisi modi sapiente enim.
Et id ipsam rerum ut doloremque aut sit maiores.
Eveniet quibusdam molestiae.
Sunt molestiae consequuntur aspernatur dolore.
Velit fuga sint sed esse.
Excepturi quod optio dignissimos fugit aspernatur.
Quae velit quibusdam molestias in qui asperiores cumque.
Architecto neque cum aut et voluptate aliquam optio numquam.
Porro doloremque blanditiis aut.
Dolor rem saepe sint ut corrupti ut a.
Qui aut quia nostrum sint unde sint aliquam culpa.
Unde possimus vero ea est aut corrupti.
Incidunt maiores vel et officia reprehenderit aut qui odit eligendi.
Totam iure provident sed aut accusamus.
Quis sapiente dolor nam laborum laudantium qui sint aliquam.", 94, "theodore.com" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "OwnerId", "ProjectName" },
                values: new object[] { @"Placeat corrupti enim ut quam sint.
Qui sit consectetur dignissimos dolorem.
Aut voluptatem sit iste reiciendis sed tenetur illum non.
Error autem sint quia.
Dolores dolor aut ipsa occaecati veritatis quisquam eveniet.
Incidunt laudantium ex deleniti.
Omnis officia modi temporibus nobis laboriosam voluptas.", 25, "garry.org" });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 19, 1 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 22 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 6,
                column: "SkillId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 7,
                column: "SkillId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 14, 4 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 10, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 19, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 14, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 23, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 13,
                column: "SkillId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 14,
                column: "SkillId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 25, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 7, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 7, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 10, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 12, 10 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 15, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 3, 12 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 3, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 25, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 14, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 14, 15 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 25, 15 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 18, 15 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 1, 16 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 14, 16 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 6, 16 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 22, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 24, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 7, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 22, 17 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 6, 19 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 2, 19 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 20, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 2, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 11, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 9, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 21, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 4, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 24, 22 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 5, 23 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 2, 24 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 22 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 19, 27 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 27 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Rating", "UserId" },
                values: new object[] { 5, 28 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 21, 31 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 6, 31 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 19 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 11, 32 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 21 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 3 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 5, 32 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 25, 33 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 18, 34 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 19, 34 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 21, 35 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 9, 36 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 11, 36 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 25, 37 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 13, 37 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 20, 38 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 8, 38 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 9, 39 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 19, 39 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 19, 40 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 11, 40 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 16, 40 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 3, 42 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 18, 42 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Rating", "UserId" },
                values: new object[] { 1, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 15, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 4, 43 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 2, 44 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 4, 44 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 9, 45 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 18, 45 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 14, 46 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 1, 46 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 16, 46 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 24, 47 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 21, 48 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 4, 48 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 13, 49 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 5 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 11, 50 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 2, 51 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 1, 51 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 18, 51 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 101,
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 20, 54 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 103,
                column: "SkillId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 1, 56 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 7, 56 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 23, 57 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 4, 57 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 5, 57 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 17, 58 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 24, 60 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 10, 60 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 4, 61 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 14, 61 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 25, 61 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 8, 61 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 2, 62 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 63 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 13 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 20 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 9, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 24, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 9, 66 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 3, 67 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 5, 67 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 22, 68 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 3, 68 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 23, 69 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 21, 69 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 5, 71 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 13, 71 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 6, 72 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 11, 72 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 16, 72 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 15, 73 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 6, 73 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 16, 74 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 14, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 22, 76 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 11, 77 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 15, 77 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 10, 78 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 8, 78 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 10, 79 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 7, 79 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 6 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 6, 80 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 1, 81 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 1, 81 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 24, 82 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 19, 83 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 7, 84 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 8, 84 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 25, 85 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 8, 85 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 15, 85 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 5, 25 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 160,
                column: "SkillId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 15, 88 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 164,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 16, 89 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 19, 89 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Rating", "SkillId" },
                values: new object[] { 0, 22 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 6, 91 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 19, 92 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 9, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 6, 93 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 24, 96 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 96 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 2, 11, 97 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 14, 97 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 18, 97 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 5, 8, 98 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 0, 25, 98 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 5, 99 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 4, 1, 99 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 1, 9, 99 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "SkillId", "UserId" },
                values: new object[] { 1, 99 });

            migrationBuilder.UpdateData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Rating", "SkillId", "UserId" },
                values: new object[] { 3, 14, 99 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Login",
                value: "Jordan_Jenkins81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Login",
                value: "Jonas.Mraz71");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Login",
                value: "Desiree.Hagenes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Login",
                value: "Danny_Cummings4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Login",
                value: "Blanca.Heller3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Login",
                value: "Grace14");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Login",
                value: "Kathleen.Fisher99");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Login",
                value: "Jeffrey.Turner");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Login",
                value: "Sunny.Rempel");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Login",
                value: "Houston.Fadel81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "Login",
                value: "Stacey.Gibson32");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "Login",
                value: "Zaria_Mante");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Login",
                value: "Lloyd.Yost28");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "Login",
                value: "Emory81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "Login",
                value: "Tristian98");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "Login",
                value: "Ibrahim_Schinner17");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "Login",
                value: "Leola_Schamberger72");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "Login",
                value: "Wilfred_McDermott");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "Login",
                value: "Henry_Gibson80");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "Login",
                value: "Makayla44");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "Login",
                value: "Josiah.OReilly");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "Login",
                value: "Russ_Considine");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "Login",
                value: "Celestine_Kuphal92");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "Login",
                value: "Houston_Krajcik54");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "Login",
                value: "Alberto81");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "Login",
                value: "Madelyn.OConner");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "Login",
                value: "Alejandra7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28,
                column: "Login",
                value: "Mabel34");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "Login",
                value: "Estevan.Dickens93");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "Login",
                value: "Oda_Fritsch8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "Login",
                value: "Misael_Breitenberg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32,
                column: "Login",
                value: "Ian.Willms52");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33,
                column: "Login",
                value: "Elroy.Denesik79");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34,
                column: "Login",
                value: "Mohammad50");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35,
                column: "Login",
                value: "Laverne.Boyle65");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36,
                column: "Login",
                value: "King8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37,
                column: "Login",
                value: "Jamir71");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38,
                column: "Login",
                value: "Eldridge_Altenwerth");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39,
                column: "Login",
                value: "Edna46");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40,
                column: "Login",
                value: "Cody_Ernser");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41,
                column: "Login",
                value: "Rudolph.Cruickshank");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42,
                column: "Login",
                value: "Triston64");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                column: "Login",
                value: "Naomi.Hills24");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44,
                column: "Login",
                value: "Isabell.Walker87");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45,
                column: "Login",
                value: "Geraldine59");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46,
                column: "Login",
                value: "Silas_Powlowski");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47,
                column: "Login",
                value: "Ian.Gaylord39");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48,
                column: "Login",
                value: "Seth_Halvorson");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49,
                column: "Login",
                value: "Hannah14");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50,
                column: "Login",
                value: "Maye_Kub");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51,
                column: "Login",
                value: "Tiana68");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52,
                column: "Login",
                value: "Roman.Murazik");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53,
                column: "Login",
                value: "Eric63");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54,
                column: "Login",
                value: "Devonte_Goldner7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55,
                column: "Login",
                value: "Ericka_Swift97");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56,
                column: "Login",
                value: "Rick_Waelchi51");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57,
                column: "Login",
                value: "Dessie_Bayer2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58,
                column: "Login",
                value: "Malcolm.Mraz11");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59,
                column: "Login",
                value: "Chester.Metz");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60,
                column: "Login",
                value: "Myrl28");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61,
                column: "Login",
                value: "Toy53");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62,
                column: "Login",
                value: "Gabe_Bernhard");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63,
                column: "Login",
                value: "Selena.Goyette41");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64,
                column: "Login",
                value: "Adolph21");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65,
                column: "Login",
                value: "Dillan0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66,
                column: "Login",
                value: "Wayne54");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67,
                column: "Login",
                value: "Lisette.Tremblay28");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68,
                column: "Login",
                value: "Verla_Treutel73");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69,
                column: "Login",
                value: "Ayana_Hintz66");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70,
                column: "Login",
                value: "Elmore.Jenkins1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71,
                column: "Login",
                value: "Theresia39");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72,
                column: "Login",
                value: "Johnpaul.Feeney");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73,
                column: "Login",
                value: "Shayne_Goyette83");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74,
                column: "Login",
                value: "Xavier64");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75,
                column: "Login",
                value: "Francisca5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76,
                column: "Login",
                value: "Marilie10");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77,
                column: "Login",
                value: "Narciso_Kuhn");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78,
                column: "Login",
                value: "Rosina30");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79,
                column: "Login",
                value: "Electa_Mraz33");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80,
                column: "Login",
                value: "Mustafa.Becker");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81,
                column: "Login",
                value: "Sunny.Hermann54");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82,
                column: "Login",
                value: "Myron_Waters");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83,
                column: "Login",
                value: "Alysson95");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84,
                column: "Login",
                value: "Dedric.Walker76");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85,
                column: "Login",
                value: "Nannie.Torp");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86,
                column: "Login",
                value: "Marjory_Rutherford");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87,
                column: "Login",
                value: "Frederick.Schumm");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88,
                column: "Login",
                value: "Liza_Lindgren77");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89,
                column: "Login",
                value: "Heloise.Kunze75");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90,
                column: "Login",
                value: "Maeve54");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91,
                column: "Login",
                value: "Yvette.Grant");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92,
                column: "Login",
                value: "Abdullah96");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93,
                column: "Login",
                value: "Elvis_Miller67");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94,
                column: "Login",
                value: "Abner37");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95,
                column: "Login",
                value: "Beth.Batz");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96,
                column: "Login",
                value: "Madie46");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97,
                column: "Login",
                value: "Jevon_Jacobi");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98,
                column: "Login",
                value: "Yessenia84");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99,
                column: "Login",
                value: "Brianne19");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                column: "Login",
                value: "Yasmeen.Schulist");
        }
    }
}
