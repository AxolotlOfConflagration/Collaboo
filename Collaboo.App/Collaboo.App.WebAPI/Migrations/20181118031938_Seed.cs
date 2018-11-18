using Microsoft.EntityFrameworkCore.Migrations;

namespace Collaboo.App.WebAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "GitHubRepoUrl", "OwnerId", "ProjectName" },
                values: new object[,]
                {
                    { 1, "Deserunt impedit hic dolorem et delectus eligendi harum iusto.. Blanditiis iure quasi rerum assumenda occaecati excepturi est.. Minus iste odit repellendus nihil cupiditate.. Quisquam quasi at vel aut facere illum praesentium ea.. Consequuntur et deserunt in autem consequuntur amet ipsum qui iusto.. Numquam voluptates magnam voluptate et.. Quod veniam corrupti molestiae cupiditate.. Magnam et fuga dolor inventore impedit nihil similique.. Cupiditate saepe qui est perferendis beatae earum.. Et et optio dicta omnis molestias.. Id ut assumenda ea.. Dolor officiis tenetur.", null, 60, "damian.info" },
                    { 21, "Enim quia dolores delectus culpa nemo atque voluptas.. Ex est tempore.. Necessitatibus dolores ea voluptatum sapiente.. Cupiditate aut voluptas aliquid laboriosam.. Ullam accusamus pariatur labore omnis provident consectetur nobis quia.. Quo cupiditate qui sunt accusantium qui.. Aliquam sed iste deleniti incidunt illum omnis harum dicta.. Veritatis ut quidem totam assumenda.. Aspernatur veniam iusto quidem dicta quaerat dolorem sed doloribus.. Voluptatum repellendus quo maxime.. Exercitationem magni labore qui ut repellendus.", null, 39, "annetta.com" },
                    { 20, "Aut et ea enim.. Dolorem fuga sit.. Culpa quia incidunt quia assumenda sunt odit tenetur est fugiat.. Optio voluptatem sit debitis sed minima voluptatum veniam.. Id impedit ad doloribus.", null, 57, "dave.info" },
                    { 19, "Aut quis et et enim quibusdam perferendis sequi.. Aut deserunt quae et nostrum.. Consequatur quod adipisci asperiores dolore quae autem dolor esse assumenda.. Quidem rerum sed esse quibusdam omnis atque eaque blanditiis voluptate.. Voluptatum aspernatur ad aut laudantium.. Debitis nihil quidem est voluptatem nobis animi aspernatur.. Ducimus soluta quidem.. Molestias est eos voluptas.. Quis et hic aut.. Error accusantium quo deleniti facilis ut aspernatur quisquam odio.. Aspernatur ut quo magni ipsum autem a.. Ipsam autem sit et ea labore ut quo suscipit est.. Et pariatur placeat.. Rerum architecto maxime nihil sed tenetur fugiat et est.. Illo sed id recusandae.. Sequi repellendus esse.. Quidem eius atque omnis fuga mollitia culpa recusandae.. Voluptas id aut qui aliquid aperiam dolorem illo molestiae hic.. Maiores atque rerum id natus ut quia exercitationem dolor.", null, 33, "lexie.biz" },
                    { 18, "Fugiat dolorem velit blanditiis omnis.. Cum omnis ut illo perferendis corrupti mollitia officiis ut error.. Aperiam cupiditate consequatur molestias maiores id neque illum eligendi.. Omnis est reprehenderit sint inventore expedita alias totam in adipisci.. Qui omnis quidem aut et voluptate impedit est.. Praesentium quos animi deleniti fugiat similique perspiciatis eos nulla dicta.. Rerum vero asperiores.. Fugit in ut tenetur.. Mollitia ea quas quis sit numquam voluptas qui ea.. Sit qui quia.. Nihil inventore quae repudiandae soluta corrupti fugit qui.. Enim nesciunt eaque sapiente assumenda molestias doloribus.. Et facere dolor ea illo.. Tempora exercitationem dolorum aut vel blanditiis repellendus possimus qui et.. Similique et et.. Vero totam porro qui dolor consectetur numquam qui.. Repellat eius velit porro laudantium.. Molestiae vel quis quasi qui et veritatis nobis.. Nobis quo iste sunt est.", null, 84, "colin.info" },
                    { 17, "Mollitia id quo accusantium vitae.. Temporibus sunt fuga sunt nihil.. Ipsum inventore delectus quia consequuntur a.. Ea neque soluta.. Aut velit rerum repudiandae labore.. Rerum vel id eum.. Sunt consequatur corporis modi.. Eos quis quidem ipsam et saepe.. Est explicabo unde sit qui dolorem.", null, 35, "sanford.com" },
                    { 15, "Perspiciatis est sunt et sit odio enim debitis dolores nobis.. Atque dignissimos ut nihil error.. Earum et impedit accusamus adipisci molestiae maiores qui dicta totam.. Consequatur optio error amet repellat quos voluptatem est repellendus explicabo.. Expedita hic et.. Autem consequatur distinctio dicta blanditiis aut laudantium porro.. Facilis ut voluptatem ut voluptas.. Nulla dolore aut veniam molestias iusto sed.. Corrupti hic placeat sit.. At quo asperiores possimus consequatur ut unde voluptatibus minus.. Perferendis perferendis et.. Corporis ut minus totam aut molestiae adipisci dolore at nobis.. Ex modi quaerat accusamus quia dolores nihil a.. Eos molestiae et molestias perferendis aut numquam est.. Dolore sapiente ut.. Blanditiis vel mollitia possimus atque rerum explicabo.. Est voluptatibus enim explicabo et voluptatem nostrum.. Natus et nemo.. Modi sed debitis.. Modi qui repellat impedit officia dolores id est in facere.", null, 77, "immanuel.biz" },
                    { 14, "Et nisi sit porro qui dolores dolorem ea possimus.. Sunt et enim.. Dignissimos ratione delectus omnis molestiae ut.. Ut sed officiis necessitatibus modi.. Et quia vel.. Nesciunt perferendis quis excepturi magni.. Ex tenetur omnis hic hic culpa illo.. Quas non cum rerum repellendus rerum ut itaque ad dolores.. Aut blanditiis dolorem mollitia vitae et.. Autem facere non laborum maiores.. Enim ut laborum dolorem libero in commodi assumenda atque aut.. Optio vel ea suscipit iusto aspernatur.. Quod temporibus inventore voluptas.. Non ex cum doloremque.", null, 67, "concepcion.biz" },
                    { 13, "Consequatur illum quo voluptate voluptas illum.. Et repudiandae vel sit et non veniam accusantium.. Corrupti sequi natus ex voluptatibus quibusdam ut nam dolorem.. Sit nam modi dignissimos reprehenderit magni.. Cumque eius temporibus voluptas enim nihil aut.. Blanditiis libero nesciunt quae similique sunt sint.. Non quo asperiores a est.. Non nulla ipsum culpa sit atque.. Ea rem quam.. Non eum veritatis ut.. Eius qui officia.. Non magni consequatur dolorum aliquam eos vel eum optio.. Qui quia voluptatibus magnam aut rerum deserunt.. Sunt corrupti corrupti ab adipisci quod nulla ea.. Blanditiis quae cupiditate et ut quis consequatur et.. Aperiam omnis quia.. Tempore nobis impedit et voluptatem accusantium.. In ab nostrum voluptate.. Rerum aspernatur ipsam voluptatum recusandae quasi est.. Sed ex suscipit ipsum doloribus magni et ipsum sit non.", null, 91, "ally.info" },
                    { 12, "Dicta fugit id unde sed impedit voluptas aliquam quae.. Itaque molestias itaque voluptatem rerum labore.. Voluptatem accusantium enim provident mollitia vel et quia earum.. Corrupti occaecati quis sed repellat pariatur.. Eum vitae harum quis rerum ut.. Non exercitationem iusto voluptates dolor quaerat.. Excepturi neque fuga.. Consequatur deleniti minima corrupti minus doloribus modi.. Voluptas aliquid minus omnis nemo.. Distinctio quos corrupti et id dolores eum possimus debitis id.. Rerum nihil qui soluta aliquid.. Ea distinctio molestias harum consequatur dolorem laboriosam ut rerum veritatis.. Earum eaque velit sed magni ut.. Assumenda ut est iste magni tempora est.. Cum amet temporibus quis vitae culpa aut.. Quis aut quibusdam nemo exercitationem.", null, 33, "caleigh.name" },
                    { 16, "Omnis et aspernatur aliquam dignissimos nisi esse commodi.. Molestiae dolores omnis eum et quia.. Suscipit itaque impedit provident doloremque hic.. Asperiores voluptatum autem qui optio eveniet.. Nulla quo qui numquam unde adipisci consequuntur.. Et unde consequatur sunt molestias repellendus explicabo culpa modi.. Consectetur autem et.. Error rerum dolorum consequatur deleniti aut dolor.. Possimus quisquam totam.. Beatae expedita velit dolorem odit perferendis magnam voluptatum quas neque.. Itaque odio animi ut saepe sequi sint quas.", null, 53, "bonita.info" },
                    { 10, "Quis aut eius officiis at optio.. Dolore eligendi mollitia.. Temporibus quia sapiente aliquam ut iste eum corporis blanditiis.. Et facilis architecto ut velit minus.. Unde cumque id earum.. Est delectus alias ratione.. Illum dolorum temporibus excepturi illum qui sit omnis porro porro.. Omnis est odio atque et aut similique commodi qui.. Odio sapiente officiis cumque asperiores.. Voluptates iste atque asperiores aliquam qui est error soluta libero.. Maiores et maxime voluptas optio sit voluptatem est molestiae neque.. Et soluta qui quidem alias et.. Expedita repudiandae vel qui sequi quam.. Incidunt quisquam sunt eum.. Debitis aut omnis consequuntur.. Et in similique maxime rerum omnis non.. Dolorem qui possimus.. Animi et reprehenderit doloribus amet voluptatem facere quasi dolorem.. Voluptas perspiciatis laudantium ullam placeat.", null, 39, "niko.biz" },
                    { 9, "Corrupti est explicabo.. Consequatur delectus aut voluptas blanditiis.. Officia incidunt sed molestias omnis fuga.. Quibusdam adipisci laudantium suscipit porro quia.. Voluptatem nam maxime quia rerum ab exercitationem accusantium perspiciatis qui.. In totam eum.. Vitae id enim dolores ut distinctio voluptatem.. Voluptas quibusdam eum molestiae eaque accusamus.. Omnis assumenda rem neque.. Laboriosam eius impedit aut voluptate ratione natus nobis reprehenderit deleniti.. Sequi odit ut aut est voluptatem qui voluptates enim exercitationem.. Ut autem illo dolorum quaerat.. Enim eum quaerat odit.. Velit eius et doloremque molestiae.. Sed aspernatur suscipit aut commodi qui tempore voluptatem.. Possimus molestias id amet error necessitatibus cum beatae ipsam.", null, 34, "reva.net" },
                    { 8, "Quisquam nam rerum explicabo sed impedit autem nesciunt repudiandae.. Inventore quasi totam eveniet vitae quos non.. Ut sit cumque non ex.. Officia voluptatem quia.. Exercitationem enim rem.. Ut quae quia ea sit placeat enim omnis.. Sed dolorem aut accusantium quia aut quis molestiae est.. Quis consequuntur quidem vitae adipisci enim omnis molestias.. Sed enim eos animi veritatis voluptate aspernatur quam sunt.. Rem omnis voluptatem omnis sit neque ea et.. Velit nemo rerum.. Sunt mollitia aspernatur cupiditate.. Delectus magni sunt et et.. Modi natus tempore error ab dolorum architecto.. Quo dolore magnam recusandae aliquid aliquid qui.", null, 92, "rita.com" },
                    { 7, "Sed veniam hic pariatur.. Porro totam quo quasi odio sit neque cumque.. Quia architecto iusto ipsa alias possimus sunt non repellendus.. Voluptatum aut minus optio quos ut facere consequatur dolorum aliquid.. Amet ullam ipsam rerum eum.. Odit ut repudiandae assumenda.. Ut et assumenda in.. Ut dolores nesciunt facilis doloribus dolores.. Quis minus maiores.. Nisi provident est quis ut aliquid praesentium itaque est.. Nesciunt et laborum.. Tempore officiis dolor voluptas nam beatae.. Sint veritatis atque cum praesentium impedit autem eligendi exercitationem earum.. In quis omnis consequatur.. Qui est repellat consectetur.. Et ex aut sint unde quia voluptatem dolorum dolorem.. Quasi et nulla.. Totam quia optio beatae rerum vitae.. Deleniti sit consequatur eius.", null, 24, "meghan.name" },
                    { 6, "Ea aut ratione eaque et a.. Aut et eum aspernatur architecto aut delectus quae amet qui.. Mollitia necessitatibus aspernatur aut et.. Libero sint dolores.. Beatae aut voluptatem aut corrupti ut sint voluptatibus et.. Qui accusantium nihil nulla rerum.. Recusandae inventore aut cupiditate quas consequuntur cumque enim in.. Quia animi libero odit consequatur excepturi qui.. Eveniet temporibus veritatis numquam.. Eos qui veritatis rerum sed similique sunt.. Magnam neque et aut laborum earum.. Ex hic enim ab atque saepe est.", null, 92, "elvis.com" },
                    { 5, "Vel cum saepe distinctio accusantium sunt quibusdam.. Facilis quisquam numquam voluptas et.. Voluptate consequatur sit enim reiciendis quae et.. Consequuntur in eos praesentium in enim sint et dolorum quasi.. Alias et voluptate reprehenderit provident necessitatibus debitis ut reprehenderit.. Vitae iure voluptatem nesciunt voluptatibus quam qui odio amet doloremque.. Dicta quos omnis ipsam.", null, 52, "keshawn.org" },
                    { 4, "Quo quis et iusto asperiores.. Eum est quasi sapiente beatae impedit earum dignissimos expedita.. Nostrum dolorem sit officia dolores est occaecati consectetur molestiae.. Tempora ducimus non dolor ullam ab eos qui odit.. Beatae beatae voluptatibus.. Consequatur dicta veniam consectetur sint ducimus assumenda.. Error et animi nesciunt deserunt error eum amet.", null, 77, "jaida.com" },
                    { 3, "Quam impedit dolorem ipsa sint quisquam vel incidunt.. Beatae inventore suscipit.. Ut accusantium omnis est sequi nesciunt suscipit.. Sint ipsam et debitis in ipsum quia aspernatur laboriosam.. Accusantium possimus doloremque quas et.. Facere quidem hic quo nam est quasi eligendi officiis doloribus.. Aliquam similique sed quos est sit quo et qui.. Neque sed omnis ipsum magni cumque repellendus doloremque.. Occaecati voluptas a quo voluptatem sint non.. Qui qui et quod consequatur velit.. Tenetur non aut et quam nihil.. Consequatur libero amet officia.. Qui libero provident architecto veniam distinctio exercitationem.. Earum ullam qui excepturi reiciendis in.. Optio ex voluptatem repellat nesciunt impedit ipsum eius animi.", null, 90, "wilson.name" },
                    { 2, "Nisi consequuntur praesentium voluptatem.. Expedita eligendi perferendis at omnis tempora enim quibusdam pariatur.. Nemo eum iste cumque id praesentium dolor.. Earum corporis corrupti.. Est itaque quibusdam nihil tempore et.. Sunt autem sequi tempore eius saepe illum ratione placeat.. Ut dolores minima sit.", null, 31, "lula.net" },
                    { 11, "Omnis vel assumenda.. Ab quidem quo commodi rerum facere voluptas.. Praesentium molestiae sed tenetur doloribus quia est dolor aut illo.. Occaecati architecto voluptatem minima facilis aut.. Enim ut autem quisquam magnam temporibus nulla.. Earum omnis nemo reprehenderit amet esse sit ex vitae.. Dolor autem in.. Mollitia officiis accusantium et qui magnam non.. Ex quasi iste.. Odio repellendus quia quod quia.. Odit velit ut eos voluptatum.. Et alias et porro earum et laudantium.. Qui qui rerum.. Eligendi facere reprehenderit mollitia quaerat sint adipisci labore fugiat voluptas.. Incidunt sit nisi eos pariatur est velit ut blanditiis in.", null, 41, "loraine.info" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "SkillName" },
                values: new object[,]
                {
                    { 16, "Python" },
                    { 17, "PL/SQL" },
                    { 18, "MongoDb" },
                    { 19, "Lisp" },
                    { 24, ".Net" },
                    { 21, "D" },
                    { 22, "Rust" },
                    { 23, "Android" },
                    { 15, "C++" },
                    { 20, "Prolog" },
                    { 14, "C" },
                    { 13, "TypeScript" },
                    { 1, "C#" },
                    { 11, "MS-SQL" },
                    { 10, "Perl" },
                    { 9, "Ruby" },
                    { 8, "Go" },
                    { 7, "Assembly" },
                    { 6, "PHP" },
                    { 5, "R" },
                    { 4, "Java" },
                    { 3, "Swift" },
                    { 2, "Haskel" },
                    { 12, "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "GitHubId", "Login" },
                values: new object[,]
                {
                    { 66, null, 0, "Gabriel_Reichert6" },
                    { 67, null, 0, "Graham_Schinner39" },
                    { 68, null, 0, "Arne.Rice44" },
                    { 69, null, 0, "Alessandro6" },
                    { 74, null, 0, "Dallin_Dietrich33" },
                    { 71, null, 0, "Heidi_Carroll80" },
                    { 72, null, 0, "Tanner63" },
                    { 73, null, 0, "Payton.Schulist" },
                    { 65, null, 0, "Kaela_Schuppe43" },
                    { 70, null, 0, "Martine_Quitzon" },
                    { 64, null, 0, "Dakota_Hagenes" },
                    { 58, null, 0, "Ray76" },
                    { 62, null, 0, "Serena.Bergnaum77" },
                    { 61, null, 0, "Kathlyn_Franecki95" },
                    { 60, null, 0, "Hilma_Parker35" },
                    { 59, null, 0, "Reyna18" },
                    { 57, null, 0, "William96" },
                    { 56, null, 0, "Eda38" },
                    { 55, null, 0, "Daniella.Herzog43" },
                    { 54, null, 0, "Keaton58" },
                    { 53, null, 0, "Mateo_Marvin49" },
                    { 63, null, 0, "Keyshawn.Brekke" },
                    { 75, null, 0, "Bailee.Sawayn52" },
                    { 98, null, 0, "Adolphus.Wiza69" },
                    { 77, null, 0, "Estevan.Rau" },
                    { 99, null, 0, "Magali99" },
                    { 52, null, 0, "Abigayle_Rolfson" },
                    { 97, null, 0, "Maximus_Ferry87" },
                    { 96, null, 0, "Dallin11" },
                    { 95, null, 0, "Aglae45" },
                    { 94, null, 0, "Stacey58" },
                    { 93, null, 0, "Jarvis_Erdman8" },
                    { 92, null, 0, "Felicity75" },
                    { 91, null, 0, "Bianka_Emard81" },
                    { 90, null, 0, "Avis1" },
                    { 76, null, 0, "Gino74" },
                    { 89, null, 0, "Laurianne.Wehner60" },
                    { 87, null, 0, "Wilfrid.Heathcote" },
                    { 86, null, 0, "Orie_Corwin78" },
                    { 85, null, 0, "Bobby_Kohler8" },
                    { 84, null, 0, "Larry_Koepp17" },
                    { 83, null, 0, "Florine_Monahan9" },
                    { 82, null, 0, "Raegan56" },
                    { 81, null, 0, "Trudie.Auer" },
                    { 80, null, 0, "Novella44" },
                    { 79, null, 0, "Kendra_Effertz" },
                    { 78, null, 0, "Modesta31" },
                    { 88, null, 0, "Jermey.Swift" },
                    { 51, null, 0, "Rosalyn40" },
                    { 28, null, 0, "Austyn.Fadel83" },
                    { 49, null, 0, "Hermann.Langosh48" },
                    { 22, null, 0, "Nona_Schamberger" },
                    { 21, null, 0, "Hailie15" },
                    { 20, null, 0, "Keanu9" },
                    { 19, null, 0, "Coty94" },
                    { 18, null, 0, "Maya65" },
                    { 17, null, 0, "Jose76" },
                    { 16, null, 0, "Reynold_Fadel36" },
                    { 15, null, 0, "Osbaldo93" },
                    { 14, null, 0, "Claude.OKeefe4" },
                    { 13, null, 0, "Eliezer_Gleason68" },
                    { 23, null, 0, "Raina97" },
                    { 12, null, 0, "Stephan.Auer10" },
                    { 10, null, 0, "Immanuel_Buckridge46" },
                    { 9, null, 0, "Margie_Dickens95" },
                    { 8, null, 0, "Dimitri39" },
                    { 7, null, 0, "Cathrine96" },
                    { 6, null, 0, "Lia.Cummerata32" },
                    { 5, null, 0, "Jamir.Hand90" },
                    { 4, null, 0, "Enrico_Kuvalis" },
                    { 3, null, 0, "Abigayle.Bayer" },
                    { 2, null, 0, "Bianka_Leannon5" },
                    { 1, null, 0, "Enos_DuBuque82" },
                    { 11, null, 0, "Polly_Erdman57" },
                    { 50, null, 0, "Fernando_Collins" },
                    { 24, null, 0, "Naomie_Christiansen" },
                    { 26, null, 0, "Danielle_Kuphal47" },
                    { 48, null, 0, "Alysson46" },
                    { 47, null, 0, "Howell_Kemmer" },
                    { 46, null, 0, "Dora.Osinski58" },
                    { 45, null, 0, "Ismael.Dach" },
                    { 44, null, 0, "Rahul37" },
                    { 43, null, 0, "Jeanie55" },
                    { 42, null, 0, "Maiya.Schiller" },
                    { 41, null, 0, "Norbert_Fay16" },
                    { 40, null, 0, "Forest_Connelly0" },
                    { 39, null, 0, "Kamryn.Will62" },
                    { 25, null, 0, "Godfrey.Hauck" },
                    { 38, null, 0, "Timmothy.Renner95" },
                    { 36, null, 0, "Meta74" },
                    { 35, null, 0, "Danial86" },
                    { 34, null, 0, "Talia67" },
                    { 33, null, 0, "Dakota86" },
                    { 32, null, 0, "Arnold55" },
                    { 31, null, 0, "Aglae91" },
                    { 30, null, 0, "Monica95" },
                    { 29, null, 0, "Hazle.Quigley60" },
                    { 100, null, 0, "Myrtie.Frami36" },
                    { 27, null, 0, "Kailey92" },
                    { 37, null, 0, "Stone.Rath" },
                    { 101, null, 0, "Ila.Schneider95" }
                });

            migrationBuilder.InsertData(
                table: "ProjectRequirments",
                columns: new[] { "Id", "ProjectId", "Rating", "SkillId" },
                values: new object[,]
                {
                    { 9, null, 2, 1 },
                    { 11, null, 2, 23 },
                    { 8, null, 4, 23 },
                    { 4, null, 3, 22 },
                    { 13, null, 5, 18 },
                    { 7, null, 3, 18 },
                    { 16, null, 1, 17 },
                    { 5, null, 5, 17 },
                    { 1, null, 1, 15 },
                    { 19, null, 3, 14 },
                    { 3, null, 1, 18 },
                    { 15, null, 5, 13 },
                    { 21, null, 3, 13 },
                    { 20, null, 3, 5 },
                    { 2, null, 4, 6 },
                    { 6, null, 4, 7 },
                    { 10, null, 3, 2 },
                    { 17, null, 2, 9 },
                    { 14, null, 4, 10 },
                    { 18, null, 3, 12 },
                    { 12, null, 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "Id", "Rating", "SkillId", "UserId" },
                values: new object[,]
                {
                    { 65, 2, 23, 65 },
                    { 73, 3, 3, 73 },
                    { 72, 1, 9, 72 },
                    { 71, 4, 22, 71 },
                    { 70, 2, 12, 70 },
                    { 69, 2, 11, 69 },
                    { 68, 5, 1, 68 },
                    { 67, 5, 4, 67 },
                    { 66, 4, 13, 66 },
                    { 64, 5, 11, 64 },
                    { 53, 2, 16, 53 },
                    { 62, 5, 18, 62 },
                    { 61, 4, 19, 61 },
                    { 60, 5, 20, 60 },
                    { 59, 1, 19, 59 },
                    { 58, 2, 3, 58 },
                    { 57, 5, 4, 57 },
                    { 56, 1, 4, 56 },
                    { 55, 2, 6, 55 },
                    { 54, 5, 3, 54 },
                    { 74, 4, 16, 74 },
                    { 63, 5, 6, 63 },
                    { 75, 1, 8, 75 },
                    { 86, 4, 16, 86 },
                    { 77, 3, 6, 77 },
                    { 99, 1, 16, 99 },
                    { 98, 5, 8, 98 },
                    { 97, 5, 5, 97 },
                    { 96, 4, 15, 96 },
                    { 95, 2, 12, 95 },
                    { 94, 1, 16, 94 },
                    { 93, 3, 2, 93 },
                    { 92, 2, 22, 92 },
                    { 91, 3, 7, 91 },
                    { 90, 2, 20, 90 },
                    { 76, 2, 13, 76 },
                    { 89, 4, 15, 89 },
                    { 87, 4, 8, 87 },
                    { 52, 3, 13, 52 },
                    { 85, 2, 8, 85 },
                    { 84, 2, 20, 84 },
                    { 83, 3, 13, 83 },
                    { 82, 5, 9, 82 },
                    { 81, 4, 9, 81 },
                    { 80, 3, 1, 80 },
                    { 79, 2, 17, 79 },
                    { 78, 4, 11, 78 },
                    { 88, 1, 19, 88 },
                    { 51, 2, 6, 51 },
                    { 40, 4, 4, 40 },
                    { 49, 2, 9, 49 },
                    { 22, 2, 11, 22 },
                    { 21, 4, 17, 21 },
                    { 20, 1, 9, 20 },
                    { 19, 2, 4, 19 },
                    { 18, 3, 9, 18 },
                    { 17, 2, 20, 17 },
                    { 16, 2, 20, 16 },
                    { 15, 4, 15, 15 },
                    { 14, 4, 19, 14 },
                    { 13, 3, 3, 13 },
                    { 23, 2, 9, 23 },
                    { 12, 3, 1, 12 },
                    { 10, 1, 5, 10 },
                    { 9, 5, 1, 9 },
                    { 8, 4, 5, 8 },
                    { 7, 3, 21, 7 },
                    { 6, 4, 9, 6 },
                    { 5, 4, 17, 5 },
                    { 4, 5, 23, 4 },
                    { 3, 4, 16, 3 },
                    { 2, 4, 20, 2 },
                    { 1, 2, 12, 1 },
                    { 11, 4, 7, 11 },
                    { 50, 1, 13, 50 },
                    { 24, 5, 20, 24 },
                    { 26, 3, 18, 26 },
                    { 48, 3, 13, 48 },
                    { 47, 5, 12, 47 },
                    { 46, 2, 15, 46 },
                    { 45, 3, 13, 45 },
                    { 44, 1, 9, 44 },
                    { 43, 1, 13, 43 },
                    { 42, 1, 12, 42 },
                    { 41, 2, 20, 41 },
                    { 100, 4, 22, 100 },
                    { 39, 5, 22, 39 },
                    { 25, 4, 4, 25 },
                    { 38, 3, 1, 38 },
                    { 36, 5, 19, 36 },
                    { 35, 2, 6, 35 },
                    { 34, 1, 14, 34 },
                    { 33, 2, 19, 33 },
                    { 32, 2, 1, 32 },
                    { 31, 5, 4, 31 },
                    { 30, 2, 14, 30 },
                    { 29, 1, 16, 29 },
                    { 28, 2, 1, 28 },
                    { 27, 4, 20, 27 },
                    { 37, 5, 16, 37 },
                    { 101, 5, 19, 101 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMember_UserId",
                table: "ProjectMember",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectMember_Users_UserId",
                table: "ProjectMember");

            migrationBuilder.DropIndex(
                name: "IX_ProjectMember_UserId",
                table: "ProjectMember");

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProjectRequirments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);
        }
    }
}
