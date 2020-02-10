using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndCapstone.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGemstone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    GemstoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGemstone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTutorial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    TutorialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTutorial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Gemstone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gemstone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gemstone_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutorial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutorial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutorial_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ProductTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TutorialReview",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    TutorialId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorialReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TutorialReview_Tutorial_TutorialId",
                        column: x => x.TutorialId,
                        principalTable: "Tutorial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReview",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReview_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "4fa86da6-ba5c-4c13-9eee-ddac16f0eee2", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFzJnqP0wZIobE5VZcPSLBR1ZaaRNjEt3gHvxZQ6stTBypgncZ22XDSVVXIczsSo8A==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" },
                    { "10000000-ffff-ffff-ffff-ffffffffffff", 0, "1009a5e1-3810-43ed-886b-bb4d6d0bc31f", "ApplicationUser", "aryn@aryn.com", true, false, null, "ARYN@ARYN.COM", "ARYN@ARYN.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "aryn@aryn.com", "aryn", "weatherly" },
                    { "01000000-ffff-ffff-ffff-ffffffffffff", 0, "be90ee07-092e-4108-8c04-5caa24696008", "ApplicationUser", "sage@sage.com", true, false, null, "SAGE@SAGE.COM", "SAGE@SAGE.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "sage@sage.com", "sage", "klein" },
                    { "00100000-ffff-ffff-ffff-ffffffffffff", 0, "64cdae4c-d16a-48fb-a3a7-87d297f1c90e", "ApplicationUser", "heidi@heidi.com", true, false, null, "HEIDI@HEIDI.COM", "HEIDI@HEIDI.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "heidi@heidi.com", "heidi", "smith" },
                    { "00010000-ffff-ffff-ffff-ffffffffffff", 0, "55bdd100-3236-4d56-8f54-84e433bbdc59", "ApplicationUser", "lauren@lauren.com", true, false, null, "LAUREN@LAUREN.COM", "LAUREN@LAUREN.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "lauren@lauren.com", "Lauren", "Maxwell" },
                    { "00001000-ffff-ffff-ffff-ffffffffffff", 0, "32ee75f3-4aef-4ffd-bc0f-5f390cc5f144", "ApplicationUser", "dylan@dylan.com", true, false, null, "DYLAN@DYLAN.COM", "DYLAN@DYLAN.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "dylan@dylan.com", "Dylan", "Griffin" },
                    { "000001000-ffff-ffff-ffff-ffffffffffff", 0, "39a498ef-aff2-4ad7-b85a-eb6af7f743e6", "ApplicationUser", "madi@madi.com", true, false, null, "MADI@MADI.COM", "MADI@MADI.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "madi@madi.com", "madi", "peper" },
                    { "000000010-ffff-ffff-ffff-ffffffffffff", 0, "744b8706-5e8a-4100-9929-73864528a28c", "ApplicationUser", "mo@mo.com", true, false, null, "MO@MO.COM", "MO@MO.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "mo@mo.com", "mo", "silvera" },
                    { "000000001-ffff-ffff-ffff-ffffffffffff", 0, "39dd5d3c-563c-42a4-a0da-74354c6d541f", "ApplicationUser", "taylor@taylor.com", true, false, null, "TAYLOR@TAYLOR.COM", "TAYLOR@TAYLOR.COM", null, null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "taylor@taylor.com", "taylor", "caroll" }
                });

            migrationBuilder.InsertData(
                table: "ProductGemstone",
                columns: new[] { "Id", "GemstoneId", "ProductId" },
                values: new object[,]
                {
                    { 17, 14, 19 },
                    { 18, 14, 20 },
                    { 19, 13, 21 },
                    { 20, 14, 22 },
                    { 21, 14, 23 },
                    { 25, 17, 23 },
                    { 23, 16, 25 },
                    { 24, 16, 26 },
                    { 16, 12, 18 },
                    { 26, 15, 23 },
                    { 22, 13, 24 },
                    { 14, 15, 16 },
                    { 15, 8, 17 },
                    { 12, 6, 14 },
                    { 13, 10, 15 },
                    { 2, 5, 2 },
                    { 3, 13, 3 },
                    { 4, 9, 4 },
                    { 5, 4, 5 },
                    { 6, 7, 8 },
                    { 1, 2, 1 },
                    { 8, 11, 10 },
                    { 9, 12, 11 },
                    { 10, 3, 12 },
                    { 11, 9, 13 },
                    { 7, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductTutorial",
                columns: new[] { "Id", "ProductId", "TutorialId" },
                values: new object[,]
                {
                    { 10, 21, 2 },
                    { 9, 21, 2 },
                    { 8, 18, 2 },
                    { 7, 17, 2 },
                    { 6, 16, 2 },
                    { 4, 8, 2 },
                    { 3, 5, 2 },
                    { 2, 3, 2 },
                    { 1, 3, 2 },
                    { 5, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "Category", "ImagePath" },
                values: new object[,]
                {
                    { 2, "Necklaces", "necklaceHome.jpg" },
                    { 1, "Earrings", "earrings.jpg" },
                    { 3, "Bracelets", "braceletsHome.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Gemstone",
                columns: new[] { "Id", "Description", "ImagePath", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "amazonite mineral rock was treasured by the ancient egyptians who made beautiful jewelry, ornamental pieces and carved important texts into this stone. amazonite has always been prized for its beauty and healing power. this pale green mineral rock is believed to date back as far as the 10th century bc.amazonite is usually pale green, but can sometimes be blue-green, turquoise or yellow-green and can also have white streaks. the color of amazonite is due to the presence of lead within the stone and color variation may exist within a single stone.", "Amazonite.gif", "Amazonite", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 17, "Mother-of-pearl shell for jewelry refers to the nacre that coats the inside layer of the mollusk shell which is used to form pearls--hence, it's the mother of the pearl. Mother-of-pearl shell jewelry can include much larger focal pieces than simple pearls since nacre substance takes up a whole shell's interior, offering a larger working surface for carving. The pearly luster of mother-of-pearl shell, called orient comes from an overlap of aragonite platelets under a skin of conchiolin (an organic substance). Mother-of-pearl shell offers a feminine iridescence that mixes beautifully with the shell beads. Natural mother-of-pearl shell is not bleached, making it a popular choice among the ecologically minded.", "MotherOfPearl.jpg", "Mother Of Pearl", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 15, "Aqua Aura Quartz is a beautiful bright blue quartz crystal created from the result of a special process involving gold. The crystals are heated and fine vaporized gold is bonded to the crystal’s surface. It is considered by many to have a high vibration and to aid communication and psychic skills.", "aquaqtz.jpg", "Aqua Quartz", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 14, "Pearls are one of a few natural or organic gemstones (others include coral, amber, jet and mother-of-pearl). Produced by the pearl oyster and the freshwater pearl mussel, natural pearls are a small irritant within the oyster or mussel which has been coated with nacre to reduce that irritation. Pearls created by a pearl farmer, who inserts a tiny piece, or 'seed' of mother-of-pearl into a freshwater pearl oyster. The pearl oyster will coat the seed with progressive layers of nacre, creating a pearl. Tennessee has been the leading state for cultured freshwater pearl production since the 1960s.", "pearl.jpg", "Pearl", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, "The unique artistry of Jasper is that of Nature itself - golden sunshine, a nighttime sky, poppy fields or a deep green forest, desert sands, the undulating ocean, red rock canyons, sweeping mountains. Each stone is a masterpiece of the Creator, bold and primitive in style, solid and earthy in form, with a warm, harmonious energy that resonates with the primal self.There is a wide variety of Jaspers, characterized by color, form, and similarities to places or animals found in nature. Many are named for the regions where they are mined; others are named by those who discovered them. Though far too extensive to cover here, we will mention a few of the more popular and familiar Jaspers, some with their own pages and additional metaphysical properties. Multi-colored Jasper carries the properties of its dominant color, or colors, while still drawing energies from its subtle hues.", "jasper.jpg", "Jasper", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, "Jasper, an opaque chalcedony, comes in a wide variety of colors, each with unique patterning. Autumn jasper is the variety of jasper known for its mottled warm brick red and avocado green appearance. The term 'jasper' itself comes from the Greek work iaspi, which means 'spotted stone.' Jasper gemstones are found all over the world, but raw autumn jasper materials are often found in India, Madagascar and South Africa.  ", "autumnJasper.jpg", "Autumn Jasper", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, "Opals come in three natural varieties: opalescent precious opal, fire opal (yellow to red-orange) and the generally opaque common opal. A French manufacturer, Gilson, created the first 'opalescent' imitation opal in 1973 though synthetic opals have been created since the '30s. Natural opals are non-crystalline, hydrated silicon dioxide gemstones that contain up to 30% water. It's possible for opals to dry out and crack, and they are relatively soft, fragile gemstones. Precious opals display a unique opalescence. Depending on the angle of view, rainbow-like flashes of different colors appear, caused by light reflecting off of extremely small spheres of cristobalite within the silica gel. The phenomenon is called interference. The flashing of color is often referred to as 'fire' or 'play of light.' Precious opals appear in a range of white to black (usually dark gray, green or blue backgrounds).", "opal2.jpg", "Opal", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, " Quartz includes a large group of minerals based on silicon dioxide. Rose quartz is a macrocrystalline form, as are amethyst, aventurine and citrine. It is a milky pink color, often crackled, and found mainly in large clumps. Only rarely is it found in single crystal form. It is believed that the pink color is due to a small amount of titanium.Rose quartz is found in pegmatite, a course-grained igneous rock (usually granite). Transparent rose quartz is rare, but is found where the best material comes from: Madagascar.Rose quartz is typically a cloudy translucent pink or slightly peach color. The violet of amethyst, either light or dark, is close to pink on the color wheel, and makes for a lovely two-color scheme set in silver. For a beautifully cool split-complementary color scheme, match rose quartz with grass-green peridot and frosty blue-green amazonite.", "roseQuartz.jpg", "Rose Quartz", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 16, "Wood is generally easy to find and work with so wherever wood is found you will find wooden beads. Regional carpenters and carvers use the most readily available species of wood and beadmaking itself was used as exercises for apprentices or as spare time work for journeymen or masters. This wide variety of woodworkers and woods makes for an astonishing variety of forms, sizes, and types of wood beads.Many species of treesprovide material for wood beads. These include olive, sandalwood,bamboo, bayong, ebony, ironwood, palm, apple, pear, and rose, to namebut a few. All of these types of wood have been used for beads eitherbecause the grain of the wood is beautiful or because the wood isaromatic.", "Wood.jpg", "Wood", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, "Sunstone began as a costly and little-known gemstone until deposits were found in Norway and Siberia. This gemstone has a special history in the United States, however, where sunstone varieties called 'heliolite' have been mined in Oregon. Sunstone gems belong to the feldspar group, which encompasses a large variety of gemstone materials--including moonstone and amazonite. The sparkly metallic glitter in this particular feldspar is called aventurescence, which is caused by flat, reflective inclusions (sometimes called 'schiller'). These inclusions can be hematite, copper or other minerals. Larger inclusions tend to be more glittery while small inclusions create a red or gold sheen on top of the stone's natural color. Sunstone, with its rich, earthy red-orange tones, works great in settings of all metal tones. You can't go wrong pairing sunstone with silver, gold, rose gold, copper or other metals. Pair with moonstone to draw attention to the schiller flash in both of these feldspar minerals. Create a complementary color scheme for high contrast and drama by pairing sunstone with emerald green and lapis lazuli blue ", "sunstone.jpg", "Sunstone", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, "Larimar is a rare blue variety of pectolite. The serene blue color results from the substitution of cobalt for calcium in the stone and varies from white and light-blue to green-blue and deep blue or 'volcanic blue.' With swirling bands of white, larimar mimics the wave crests of crystal blue Caribbean waters.To date, the only known major deposits of larimar are found in the Dominican Republic where it was most likely treasured by the area's first inhabitants, the Taino Indians. Many jewelry artists incorporate polished freeform larimar pendants and cabochons into necklaces and create earrings with larimar rounds and chips. Freeform larimar stones can be used in wire-wrapped designs such as necklaces, rings, bracelets and earrings.", "larimar.jpg", "Larimar", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, "Lapis lazuli is one of the oldest opaque gemstones in history--more than 6,500 years! This deep blue stone includes tiny flecks of mica, like a night sky full of stars. Its most well-known source is deep in the mountains of modern Afghanistan. Lapis lazuli is an intensely blue stone made of a deep blue lazurite, cloudy white calcite, sparkly pyrite and other minerals. This beautiful mixture of textures gives lapis lazuli its characteristic look.Lapis lazuli is found with limestone or as separate boulders. Stones from what is now modern Afghanistan and Pakistan are still considered to be of the best quality. Royal blue lapis lazuli characteristically has either whitish or yellowish matrix or feathering. When it is flecked with white, it is perfectly complemented by silver and turquoise for a Southwestern look. If it has brassy specks, it is regal with gold. Lapis also has darker regions that can be accented when strung with black onyx or antiqued silver beads. ", "lapis.jpg", "Lapis Lazuli", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, "Onyx is a form of chalcedony, which is a microcrystalline quartz formed in the gas cavities of lava. Its multi-layered structure is similar to that of agates. When the stone has a black base and a white upper layer, it's called onyx. (Black onyx is uniformly black chalcedony. Much of what is referred to as 'black onyx' is gray chalcedony that has been chemically treated to be a rich black. Black is neutral, making it a great design element to combine with many different colored stones, other gemstone beads and all metal tones. Its deep, dark, lustrous surface can play a striking contrast to the warm-colored gemstones like garnet, carnelian and coral.) ", "blackOnyx.jpg", "Black Onyx", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, "Coral has been called the 'garden of the sea' because it was once believed to be a plant. Instead, coral belongs to a small, but important group of organic gemstones. Coral is formed through a biological process rather than being a mineral with a crystalline structure like most colored stones. Precious coral is a deep water coral that forms in rocky seabeds with low levels of sedimentation, typically in dark environments over 500-feet deep. Coral is very sensitive to acid and heat. Coral's color is known to fade with wear and tear. To prevent color loss, avoid exposing coral to direct sunlight for prolonged periods of time and avoid temperature extremes.", "coral.jpg", "Petrified Coral", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "Blue lace agate is a type of variegated chalcedony, more specifically a variety of quartz. This type of agate is most notably recognized by its predominantly light blue banded layers that have also been known to include bright blue, white and brown hues. Agates typically form as nodules or geodes in igneous rocks.The soft hue of blue lace agate pairs exceptionally well with other pastel-colored gemstones. Looking at the bands of color, pair your blue lace agate with the tones of the bands to draw increased attention to the swirling pattern. For a complementary color pairing, blue lace agate provides a great base to draw attention to orange/red gemstones such as carnelian, sunstone, amber and other forms of agate or banded jaspers.", "blueLace.gif", "Blue Lace Agate", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Calcite, also called limespar, is a very common rock-forming mineral. The word calcite comes from the Latin calx and the Greek chalix, which means lime. Calcite has more uses than almost any other mineral. A great deal of calcite is formed from the shells of dead marine organisms. Calcite may also be found in volcanic or mantle-derived rocks. A relatively soft stone, calcite has a Mohs hardness of 3. Calcite is transparent to translucent and may occasionally show phosphorescence or fluorescence.Because of its understated coloring, yellow calcite matches up nicely with antiqued gold-plated brass. It can be a grounding for more flamboyant colors such as carnelian.  ", "cacite.jpg", "Calcite", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, "Lepidolite is mined as a source of the element lithium along with other rare earth elements such as cesium and rubidium. Lepidolite is an important source of lithium, which is the lightest metal in the world. Lepidolite is a translucent to transparent rose to purple colored phyllosilicate mineral of the mica group. Lepidolite is associated with other lithium-bearing minerals like spodumene in pegmatite bodies. It is one of the major sources of the rare alkali metals rubidium and cesium. It is found most often as small, scaly crystals in dense aggregates. It is also found in masses and groupings such as foliated, flaky and scaly forms.With its variety of hues from pinkish rose to purple along with other shades, lepidolite offers more tonal flexibility that you might think at first glance. For a slight contrast, consider pairing lepidolite with the lighter rose quartz. ", "Lepidolite.jpg", "Lepidolite", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "DateAdded", "Description", "ImagePath", "ProductTypeId", "Title", "UserId" },
                values: new object[,]
                {
                    { 13, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2389), "Inverted gold teardrop earrings with wire wrapped lepidolite gemstones.", "InvertedTeardropLarimar.jpg", 1, "Inverted Teardop Lepidolite Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 14, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2407), "Gold hoop earrings accented with wire wrapped, teardrop shaped lapis gemstone.", "LapisHoopEarrings.jpg", 1, "Gold Hoop Lapis Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 15, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2424), "Hammered out gold teardrop earrings with wire wrapped chips of rose quartz.", "RoseGoldTeardrop.jpg", 1, "Gold Teardrop Earrings with Rose Quartz", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 16, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2442), "Hammered out gold hoop earrings with rare cut aqua quartz gemstones.", "AquaQuartzGoldHoops.jpg", 1, "Gold Hoop earrings with Aqua Quartz Gemstone", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 17, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2460), "Beautiful antique copper earrings with shimmering sunstones.", "sunstoneEarrings.jpg", 1, "Antique Copper Earrings With Sunstone", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 18, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2531), "Bronze dangle earrings with unique cut autumn jasper gemstones.", "BronzeAndAutumnJasper.jpg", 1, "Bronze and Autumn Jasper Dangle Earrings ", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 22, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2607), "Delicate pink freshwater pearl necklace on gold chain.", "pearlNecklace.jpg", 2, "Delicate Freshwater Pearl Necklace", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 20, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2572), "Hammered out gold earrings with wire wrapped freswater pearls.", "HammeredGoldPearl.jpg", 1, "Gold Earrings with Wire Wrapped Pearls", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 21, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2589), "Bronze hoop earrings with pink and grey jasper gemstones.", "PinkGreyJasperEarrings.jpg", 1, "Pink and Grey Jasper Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 23, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2625), "Beautiful threaded freshwater pearl necklace with aqua quartz and purple crystals.", "ThreadPearlNecklace.jpg", 2, "Threaded Pearl Necklace", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 24, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2643), "Fun earth toned bracelet made with glass beads and jasper gemstones.", "JasperBracelet.jpg", 3, "Jasper and Glass Bracelet", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2371), "Hammered out gold hoop earrings wire wrapped with chips of blue lace agate.", "BlueLaceHoops.jpg", 1, "Gold Hoops with Blue Lace Agate", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 19, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2553), "Beautifully elegant sterling silver thread earrings with freshwater pearls.", "PearlThreadEarrings.jpg", 1, "Threaded Pearl Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2353), "Rare cut autumn jasper gemstones set inside sterling silver bead frame.", "AutumnJasperFramed.jpg", 1, "Framed Autumn Jasper Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2192), "Trendy tassle earrings with all natural pink and coral jasper gemstones.", "blueJasperTassle.jpg", 1, "Pink and Blue Jasper Tassle Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2315), "Asymmetrical sterling silver bead frames with rare cut amazonite gemstones.", "SterlingAmazoniteEarrings.jpg", 1, "Sterling Silver and Amazonite Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2297), "Hammered out diamond shaped gold hoops with wire wrapped larimar gemstones.", "DiamondLarimarEarrings.jpg", 1, "Diamond Shaped Hoops with Larimar Gemstones", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2279), "Teardrop shaped gold earrings with black tassles.", "GoldTeardropBlackTassle.jpg", 1, "Teardrop Black Tassle Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2260), "Hammered out gold earrings with bronze chain.", "GoldBronzeChainEarrings.jpg", 1, "Gold and Bronze Chain Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2237), "Hammered out gold hoops with wire wrapped pieces of petrified coral.", "coralHoops.jpg", 1, "Gold Hoop Earrings With Petrified Coral", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2216), "Hammered out gold hoop earrings with wire-wrapped lepidolite chips.", "LepidoliteChipHoops.jpg", 1, "Lepidolite Gold Hoops", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 25, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2661), "Bracelet made with wooden beads and stretchy floss cord.", "LightWoodBracelet.jpg", 3, "Light Wood Bracelet", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2094), "Elegant sterling silver and black onyx dangle earrings.", "BlackOnyxDangle.jpg", 1, "Black Onyx Dangle Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, new DateTime(2020, 2, 9, 21, 58, 52, 168, DateTimeKind.Local).AddTicks(855), "Rustic triangle shaped copper earrings with large, round calcite gemstone.", "TriangleCalciteEarrings.jpg", 1, "Calcite Triangle Earrings", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2335), "Hammered out copper hoop earrings with wire wrapped pink opal gemstones.", "BronzePinkOpalHoops.jpg", 1, "Copper Hoops with Pink Opal", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 26, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(2680), "Bracelet made with wooden beads and stretchy floss cord.", "DarkWoodBracelet.jpg", 3, "Dark Wood Bracelet", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Tutorial",
                columns: new[] { "Id", "DateAdded", "Description", "ProductId", "Title", "UserId", "VideoPath" },
                values: new object[,]
                {
                    { 4, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(8212), "Learn how to make that trickey wire wrapped bead cap with this video.", 0, "How to Make a Wire Wrapped Bead Cap", "00000000-ffff-ffff-ffff-ffffffffffff", "WireBeadCaps.mp4" },
                    { 3, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(8191), "This video shows you how to use all the essential jewelry making tools for beginners.", 0, "Tools for beginners", "00000000-ffff-ffff-ffff-ffffffffffff", "Tools101.mp4" },
                    { 2, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(8143), "In this video, learn how to make a wrapped wire loop for jewelry making. This basic technique is used when putting a bead on a head pin or eye pin as a dangle or a link, and is more durable than a simple wire loop.", 0, "How to wire wrap loops for earrings", "00000000-ffff-ffff-ffff-ffffffffffff", "WireWrappedLoopForEarrings.mp4" },
                    { 1, new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(7554), "First feed one crimp beed onto the wire and then loop it through a clasp or a jump ringand then back through the crimp. PLace the crimp in the OUTER jaw of the crimp tool and make one firm compression. Then place the crimp bead into the crescent-shaped groove of the crimp tool and firmly compress. String the remaining beads onto the wire.", 0, "How to use crimping pliers", "00000000-ffff-ffff-ffff-ffffffffffff", "CrimpTutorial.mp4" }
                });

            migrationBuilder.InsertData(
                table: "ProductReview",
                columns: new[] { "Id", "Comment", "DateAdded", "ProductId", "UserId" },
                values: new object[,]
                {
                    { 9, "These bead frames are cool!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5346), 11, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 15, "Ordered this necklace and i absolutely love it. Would definitely recommend it!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5484), 22, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 14, "These pearls are so pretty!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5465), 22, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, "I love how you got the pearls to alternate up and down!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5418), 20, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, "Threaded earrings are so pretty. do you have them in any other gemstone?", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5400), 19, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, "I like how you used the bronze cirle with the gemstones!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5383), 18, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, "These sunstones are so pretty!!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5291), 17, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, "Didn't know quartz came in this color. Very cool!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5269), 16, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Love these gemstones and the shape of the hoops", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5173), 15, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "Lapis gems are my favorite. Nice wire wrapping!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5229), 14, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, "These purple gems are so cool. such a pretty design!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5251), 13, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, "These blue lace gems are awesome. Love the wire wrapping", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5309), 12, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 21, "This bracelet is dope", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5617), 26, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, "Interesting earrings!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5327), 11, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, "Oh my god these are so pretty! I want a pair", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5365), 10, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 19, "So cute and trendy!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5580), 7, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 17, "Nice wire wrapping!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5542), 4, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, "These are so pretty! love the color!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(4473), 3, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 18, "I love the antique feel of these earrings!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5562), 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 16, "I love the antique feel of these earrings!", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5522), 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 20, "Ordered a few of these and I love them.", new DateTime(2020, 2, 9, 21, 58, 52, 170, DateTimeKind.Local).AddTicks(5598), 25, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "TutorialReview",
                columns: new[] { "Id", "Comment", "DateAdded", "TutorialId", "UserId" },
                values: new object[,]
                {
                    { 5, "I've had a hard time with bead caps for a while, hoping that after seeing this video it wont be as difficult", new DateTime(2020, 2, 9, 21, 58, 52, 171, DateTimeKind.Local).AddTicks(910), 4, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Glad you posted this. I just started making jewelry and wasn't sure which tools to buy! thanks again.", new DateTime(2020, 2, 9, 21, 58, 52, 171, DateTimeKind.Local).AddTicks(821), 3, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, "My wire wrapping looks so much better after watching this video! thank you", new DateTime(2020, 2, 9, 21, 58, 52, 171, DateTimeKind.Local).AddTicks(891), 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "My wire wrapping always looks so ugly because i was doing it wrong. Glad you posted this", new DateTime(2020, 2, 9, 21, 58, 52, 171, DateTimeKind.Local).AddTicks(868), 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, "Thanks for posting. I struggled with making good looking crimps for so long. This video was very helpful.", new DateTime(2020, 2, 9, 21, 58, 52, 171, DateTimeKind.Local).AddTicks(222), 1, "00000000-ffff-ffff-ffff-ffffffffffff" }
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
                name: "IX_Gemstone_UserId",
                table: "Gemstone",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReview_ProductId",
                table: "ProductReview",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutorial_UserId",
                table: "Tutorial",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorialReview_TutorialId",
                table: "TutorialReview",
                column: "TutorialId");
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
                name: "Gemstone");

            migrationBuilder.DropTable(
                name: "ProductGemstone");

            migrationBuilder.DropTable(
                name: "ProductReview");

            migrationBuilder.DropTable(
                name: "ProductTutorial");

            migrationBuilder.DropTable(
                name: "TutorialReview");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Tutorial");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
