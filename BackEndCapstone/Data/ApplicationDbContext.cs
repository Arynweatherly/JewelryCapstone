using System;
using System.Collections.Generic;
using System.Text;
using BackEndCapstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEndCapstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Gemstone> Gemstone { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProductGemstone> ProductGemstone { get; set; }
        public DbSet<ProductTutorial> ProductTutorial { get; set; }
        public DbSet<Tutorial> Tutorial { get; set; }
        public DbSet<ProductWishlist> ProductWishlist { get; set; }
        public DbSet<TutorialReview> TutorialReview { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            ApplicationUser user = new ApplicationUser
            {

                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser user2 = new ApplicationUser
            {

                FirstName = "aryn",
                LastName = "weatherly",
                UserName = "aryn@aryn.com",
                NormalizedUserName = "ARYN@ARYN.COM",
                Email = "aryn@aryn.com",
                NormalizedEmail = "ARYN@ARYN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "10000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash2 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash2.HashPassword(user2, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user2);


            ApplicationUser user3 = new ApplicationUser
            {

                FirstName = "sage",
                LastName = "klein",
                UserName = "sage@sage.com",
                NormalizedUserName = "SAGE@SAGE.COM",
                Email = "sage@sage.com",
                NormalizedEmail = "SAGE@SAGE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "01000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash3 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash3.HashPassword(user3, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user3);


            ApplicationUser user4 = new ApplicationUser
            {

                FirstName = "heidi",
                LastName = "smith",
                UserName = "heidi@heidi.com",
                NormalizedUserName = "HEIDI@HEIDI.COM",
                Email = "heidi@heidi.com",
                NormalizedEmail = "HEIDI@HEIDI.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00100000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash4 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash4.HashPassword(user4, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user4);

            ApplicationUser user5 = new ApplicationUser
            {

                FirstName = "Lauren",
                LastName = "Maxwell",
                UserName = "lauren@lauren.com",
                NormalizedUserName = "LAUREN@LAUREN.COM",
                Email = "lauren@lauren.com",
                NormalizedEmail = "LAUREN@LAUREN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00010000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash5 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash5.HashPassword(user5, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user5);


            ApplicationUser user6 = new ApplicationUser
            {

                FirstName = "Dylan",
                LastName = "Griffin",
                UserName = "dylan@dylan.com",
                NormalizedUserName = "DYLAN@DYLAN.COM",
                Email = "dylan@dylan.com",
                NormalizedEmail = "DYLAN@DYLAN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00001000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash6 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash6.HashPassword(user6, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user6);

            ApplicationUser user7 = new ApplicationUser
            {

                FirstName = "madi",
                LastName = "peper",
                UserName = "madi@madi.com",
                NormalizedUserName = "MADI@MADI.COM",
                Email = "madi@madi.com",
                NormalizedEmail = "MADI@MADI.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "000001000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash7 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash7.HashPassword(user7, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user7);

            ApplicationUser user8 = new ApplicationUser
            {

                FirstName = "mo",
                LastName = "silvera",
                UserName = "mo@mo.com",
                NormalizedUserName = "MO@MO.COM",
                Email = "mo@mo.com",
                NormalizedEmail = "MO@MO.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "000000010-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash8 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash8.HashPassword(user8, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user8);

            ApplicationUser user9 = new ApplicationUser
            {

                FirstName = "taylor",
                LastName = "caroll",
                UserName = "taylor@taylor.com",
                NormalizedUserName = "TAYLOR@TAYLOR.COM",
                Email = "taylor@taylor.com",
                NormalizedEmail = "TAYLOR@TAYLOR.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "000000001-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash9 = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash9.HashPassword(user9, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user9);

            Gemstone Amazonite = new Gemstone()
            {
                Id = 1,
                Title = "Amazonite",
                UserId = user.Id,
                ImagePath = "Amazonite.gif",
                Description = "amazonite mineral rock was treasured by the ancient egyptians who made beautiful jewelry, ornamental pieces and carved important texts into this stone. amazonite has always been prized for its beauty and healing power. this pale green mineral rock is believed to date back as far as the 10th century bc.amazonite is usually pale green, but can sometimes be blue-green, turquoise or yellow-green and can also have white streaks. the color of amazonite is due to the presence of lead within the stone and color variation may exist within a single stone.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Amazonite);


            Gemstone Calcite = new Gemstone()
            {
                Id = 2,
                Title = "Calcite",
                UserId = user.Id,
                ImagePath = "cacite.jpg",
                Description = "Calcite, also called limespar, is a very common rock-forming mineral. The word calcite comes from the Latin calx and the Greek chalix, which means lime. Calcite has more uses than almost any other mineral. A great deal of calcite is formed from the shells of dead marine organisms. Calcite may also be found in volcanic or mantle-derived rocks. A relatively soft stone, calcite has a Mohs hardness of 3. Calcite is transparent to translucent and may occasionally show phosphorescence or fluorescence.Because of its understated coloring, yellow calcite matches up nicely with antiqued gold-plated brass. It can be a grounding for more flamboyant colors such as carnelian.  "
            };
            modelBuilder.Entity<Gemstone>().HasData(Calcite);

            Gemstone BlueLaceAgate = new Gemstone()
            {
                Id = 3,
                Title = "Blue Lace Agate",
                UserId = user.Id,
                ImagePath = "blueLace.gif",
                Description = "Blue lace agate is a type of variegated chalcedony, more specifically a variety of quartz. This type of agate is most notably recognized by its predominantly light blue banded layers that have also been known to include bright blue, white and brown hues. Agates typically form as nodules or geodes in igneous rocks.The soft hue of blue lace agate pairs exceptionally well with other pastel-colored gemstones. Looking at the bands of color, pair your blue lace agate with the tones of the bands to draw increased attention to the swirling pattern. For a complementary color pairing, blue lace agate provides a great base to draw attention to orange/red gemstones such as carnelian, sunstone, amber and other forms of agate or banded jaspers."
            };
            modelBuilder.Entity<Gemstone>().HasData(BlueLaceAgate);

            Gemstone PetrifiedCoral = new Gemstone()
            {
                Id = 4,
                Title = "Petrified Coral",
                UserId = user.Id,
                ImagePath = "coral.jpg",
                Description = "Coral has been called the 'garden of the sea' because it was once believed to be a plant. Instead, coral belongs to a small, but important group of organic gemstones. Coral is formed through a biological process rather than being a mineral with a crystalline structure like most colored stones. Precious coral is a deep water coral that forms in rocky seabeds with low levels of sedimentation, typically in dark environments over 500-feet deep. Coral is very sensitive to acid and heat. Coral's color is known to fade with wear and tear. To prevent color loss, avoid exposing coral to direct sunlight for prolonged periods of time and avoid temperature extremes."

            };
            modelBuilder.Entity<Gemstone>().HasData(PetrifiedCoral);

            Gemstone BlackOnyx = new Gemstone()
            {
                Id = 5,
                Title = "Black Onyx",
                UserId = user.Id,
                ImagePath = "blackOnyx.jpg",
                Description = "Onyx is a form of chalcedony, which is a microcrystalline quartz formed in the gas cavities of lava. Its multi-layered structure is similar to that of agates. When the stone has a black base and a white upper layer, it's called onyx. (Black onyx is uniformly black chalcedony. Much of what is referred to as 'black onyx' is gray chalcedony that has been chemically treated to be a rich black. Black is neutral, making it a great design element to combine with many different colored stones, other gemstone beads and all metal tones. Its deep, dark, lustrous surface can play a striking contrast to the warm-colored gemstones like garnet, carnelian and coral.) "
            };
            modelBuilder.Entity<Gemstone>().HasData(BlackOnyx);

            Gemstone Lapis = new Gemstone()
            {
                Id = 6,
                Title = "Lapis Lazuli",
                UserId = user.Id,
                ImagePath = "lapis.jpg",
                Description = "Lapis lazuli is one of the oldest opaque gemstones in history--more than 6,500 years! This deep blue stone includes tiny flecks of mica, like a night sky full of stars. Its most well-known source is deep in the mountains of modern Afghanistan. Lapis lazuli is an intensely blue stone made of a deep blue lazurite, cloudy white calcite, sparkly pyrite and other minerals. This beautiful mixture of textures gives lapis lazuli its characteristic look.Lapis lazuli is found with limestone or as separate boulders. Stones from what is now modern Afghanistan and Pakistan are still considered to be of the best quality. Royal blue lapis lazuli characteristically has either whitish or yellowish matrix or feathering. When it is flecked with white, it is perfectly complemented by silver and turquoise for a Southwestern look. If it has brassy specks, it is regal with gold. Lapis also has darker regions that can be accented when strung with black onyx or antiqued silver beads. "
            };
            modelBuilder.Entity<Gemstone>().HasData(Lapis);

            Gemstone Larimar = new Gemstone()
            {
                Id = 7,
                Title = "Larimar",
                UserId = user.Id,
                ImagePath = "larimar.jpg",
                Description = "Larimar is a rare blue variety of pectolite. The serene blue color results from the substitution of cobalt for calcium in the stone and varies from white and light-blue to green-blue and deep blue or 'volcanic blue.' With swirling bands of white, larimar mimics the wave crests of crystal blue Caribbean waters.To date, the only known major deposits of larimar are found in the Dominican Republic where it was most likely treasured by the area's first inhabitants, the Taino Indians. Many jewelry artists incorporate polished freeform larimar pendants and cabochons into necklaces and create earrings with larimar rounds and chips. Freeform larimar stones can be used in wire-wrapped designs such as necklaces, rings, bracelets and earrings."
            };
            modelBuilder.Entity<Gemstone>().HasData(Larimar);

            Gemstone Sunstone = new Gemstone()
            {
                Id = 8,
                Title = "Sunstone",
                UserId = user.Id,
                ImagePath = "sunstone.jpg",
                Description = "Sunstone began as a costly and little-known gemstone until deposits were found in Norway and Siberia. This gemstone has a special history in the United States, however, where sunstone varieties called 'heliolite' have been mined in Oregon. Sunstone gems belong to the feldspar group, which encompasses a large variety of gemstone materials--including moonstone and amazonite. The sparkly metallic glitter in this particular feldspar is called aventurescence, which is caused by flat, reflective inclusions (sometimes called 'schiller'). These inclusions can be hematite, copper or other minerals. Larger inclusions tend to be more glittery while small inclusions create a red or gold sheen on top of the stone's natural color. Sunstone, with its rich, earthy red-orange tones, works great in settings of all metal tones. You can't go wrong pairing sunstone with silver, gold, rose gold, copper or other metals. Pair with moonstone to draw attention to the schiller flash in both of these feldspar minerals. Create a complementary color scheme for high contrast and drama by pairing sunstone with emerald green and lapis lazuli blue "
            };
            modelBuilder.Entity<Gemstone>().HasData(Sunstone);

            Gemstone Lepidolite = new Gemstone()
            {
                Id = 9,
                Title = "Lepidolite",
                UserId = user.Id,
                ImagePath = "Lepidolite.jpg",
                Description = "Lepidolite is mined as a source of the element lithium along with other rare earth elements such as cesium and rubidium. Lepidolite is an important source of lithium, which is the lightest metal in the world. Lepidolite is a translucent to transparent rose to purple colored phyllosilicate mineral of the mica group. Lepidolite is associated with other lithium-bearing minerals like spodumene in pegmatite bodies. It is one of the major sources of the rare alkali metals rubidium and cesium. It is found most often as small, scaly crystals in dense aggregates. It is also found in masses and groupings such as foliated, flaky and scaly forms.With its variety of hues from pinkish rose to purple along with other shades, lepidolite offers more tonal flexibility that you might think at first glance. For a slight contrast, consider pairing lepidolite with the lighter rose quartz. "
            };
            modelBuilder.Entity<Gemstone>().HasData(Lepidolite);

            Gemstone RoseQuartz = new Gemstone()
            {
                Id = 10,
                Title = "Rose Quartz",
                UserId = user.Id,
                ImagePath = "roseQuartz.jpg",
                Description = " Quartz includes a large group of minerals based on silicon dioxide. Rose quartz is a macrocrystalline form, as are amethyst, aventurine and citrine. It is a milky pink color, often crackled, and found mainly in large clumps. Only rarely is it found in single crystal form. It is believed that the pink color is due to a small amount of titanium.Rose quartz is found in pegmatite, a course-grained igneous rock (usually granite). Transparent rose quartz is rare, but is found where the best material comes from: Madagascar.Rose quartz is typically a cloudy translucent pink or slightly peach color. The violet of amethyst, either light or dark, is close to pink on the color wheel, and makes for a lovely two-color scheme set in silver. For a beautifully cool split-complementary color scheme, match rose quartz with grass-green peridot and frosty blue-green amazonite."
            };
            modelBuilder.Entity<Gemstone>().HasData(RoseQuartz);

            Gemstone Opal = new Gemstone()
            {
                Id = 11,
                Title = "Opal",
                UserId = user.Id,
                ImagePath = "opal2.jpg",
                Description = "Opals come in three natural varieties: opalescent precious opal, fire opal (yellow to red-orange) and the generally opaque common opal. A French manufacturer, Gilson, created the first 'opalescent' imitation opal in 1973 though synthetic opals have been created since the '30s. Natural opals are non-crystalline, hydrated silicon dioxide gemstones that contain up to 30% water. It's possible for opals to dry out and crack, and they are relatively soft, fragile gemstones. Precious opals display a unique opalescence. Depending on the angle of view, rainbow-like flashes of different colors appear, caused by light reflecting off of extremely small spheres of cristobalite within the silica gel. The phenomenon is called interference. The flashing of color is often referred to as 'fire' or 'play of light.' Precious opals appear in a range of white to black (usually dark gray, green or blue backgrounds)."
            };
            modelBuilder.Entity<Gemstone>().HasData(Opal);

            Gemstone AutumnJasper = new Gemstone()
            {
                Id = 12,
                Title = "Autumn Jasper",
                UserId = user.Id,
                ImagePath = "autumnJasper.jpg",
                Description = "Jasper, an opaque chalcedony, comes in a wide variety of colors, each with unique patterning. Autumn jasper is the variety of jasper known for its mottled warm brick red and avocado green appearance. The term 'jasper' itself comes from the Greek work iaspi, which means 'spotted stone.' Jasper gemstones are found all over the world, but raw autumn jasper materials are often found in India, Madagascar and South Africa.  "
            };
            modelBuilder.Entity<Gemstone>().HasData(AutumnJasper);

            Gemstone Jasper = new Gemstone()
            {
                Id = 13,
                Title = "Jasper",
                UserId = user.Id,
                ImagePath = "jasper.jpg",
                Description = "The unique artistry of Jasper is that of Nature itself - golden sunshine, a nighttime sky, poppy fields or a deep green forest, desert sands, the undulating ocean, red rock canyons, sweeping mountains. Each stone is a masterpiece of the Creator, bold and primitive in style, solid and earthy in form, with a warm, harmonious energy that resonates with the primal self.There is a wide variety of Jaspers, characterized by color, form, and similarities to places or animals found in nature. Many are named for the regions where they are mined; others are named by those who discovered them. Though far too extensive to cover here, we will mention a few of the more popular and familiar Jaspers, some with their own pages and additional metaphysical properties. Multi-colored Jasper carries the properties of its dominant color, or colors, while still drawing energies from its subtle hues."
            };
            modelBuilder.Entity<Gemstone>().HasData(Jasper);

            Gemstone Pearl = new Gemstone()
            {
                Id = 14,
                Title = "Pearl",
                UserId = user.Id,
                ImagePath = "pearl.jpg",
                Description = "Pearls are one of a few natural or organic gemstones (others include coral, amber, jet and mother-of-pearl). Produced by the pearl oyster and the freshwater pearl mussel, natural pearls are a small irritant within the oyster or mussel which has been coated with nacre to reduce that irritation. Pearls created by a pearl farmer, who inserts a tiny piece, or 'seed' of mother-of-pearl into a freshwater pearl oyster. The pearl oyster will coat the seed with progressive layers of nacre, creating a pearl. Tennessee has been the leading state for cultured freshwater pearl production since the 1960s."
            };
            modelBuilder.Entity<Gemstone>().HasData(Pearl);


            Gemstone AquaQuartz = new Gemstone()
            {
                Id = 15,
                Title = "Aqua Quartz",
                UserId = user.Id,
                ImagePath = "aquaqtz.jpg",
                Description = "Aqua Aura Quartz is a beautiful bright blue quartz crystal created from the result of a special process involving gold. The crystals are heated and fine vaporized gold is bonded to the crystal’s surface. It is considered by many to have a high vibration and to aid communication and psychic skills."
            };
            modelBuilder.Entity<Gemstone>().HasData(AquaQuartz);

            Gemstone Wood = new Gemstone()
            {
                Id = 16,
                Title = "Wood",
                UserId = user.Id,
                ImagePath = "Wood.jpg",
                Description = "Wood is generally easy to find and work with so wherever wood is found you will find wooden beads. Regional carpenters and carvers use the most readily available species of wood and beadmaking itself was used as exercises for apprentices or as spare time work for journeymen or masters. This wide variety of woodworkers and woods makes for an astonishing variety of forms, sizes, and types of wood beads.Many species of treesprovide material for wood beads. These include olive, sandalwood,bamboo, bayong, ebony, ironwood, palm, apple, pear, and rose, to namebut a few. All of these types of wood have been used for beads eitherbecause the grain of the wood is beautiful or because the wood isaromatic."
            };
            modelBuilder.Entity<Gemstone>().HasData(Wood);

            Gemstone MotherOfPearl = new Gemstone()
            {
                Id = 17,
                UserId = user.Id,
                Title = "Mother Of Pearl",
                ImagePath = "MotherOfPearl.jpg",
                Description = "Mother-of-pearl shell for jewelry refers to the nacre that coats the inside layer of the mollusk shell which is used to form pearls--hence, it's the mother of the pearl. Mother-of-pearl shell jewelry can include much larger focal pieces than simple pearls since nacre substance takes up a whole shell's interior, offering a larger working surface for carving. The pearly luster of mother-of-pearl shell, called orient comes from an overlap of aragonite platelets under a skin of conchiolin (an organic substance). Mother-of-pearl shell offers a feminine iridescence that mixes beautifully with the shell beads. Natural mother-of-pearl shell is not bleached, making it a popular choice among the ecologically minded."
            };
            modelBuilder.Entity<Gemstone>().HasData(MotherOfPearl);

            Gemstone Aquamarine = new Gemstone()
            {
                Id = 18,
                Title = "Aquamarine",
                UserId = user.Id,
                ImagePath = "Aquamarine.jpg",
                Description = "Aquamarine gemstones evoke the colors of the sea. Aquamarine can be blue, very slightly greenish blue, greenish blue, very strongly greenish blue, or green-blue. Aquamarine gemstones are often free from inclusions and clear as water too, symbolizing purity of spirit and soul. They make fantastic gemstones for evening wear because they glitter and gleam even under muted light conditions. During the day or in bright light, they exhibit a soothing coolness.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Aquamarine);


            Gemstone Chalcedony = new Gemstone()
            {
                Id = 19,
                Title = "chalcedony",
                UserId = user.Id,
                ImagePath = "chalcedony.jpg",
                Description = "Chalcedony is the form of Quartz that is compact and microcrystalline. It occurs in many different forms, colors, and patterns, and many varieties have been used as gemstones since antiquity. In the gemstone trade, the term Chalcedony is often used specifically to describe the white, gray, or blue translucent type of Chalcedony, but its technical term includes all additional varieties.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Chalcedony);


            Gemstone Turquoise = new Gemstone()
            {
                Id = 20,
                Title = "Turquoise",
                UserId = user.Id,
                ImagePath = "turquoise.jpg",
                Description = "Turquoise can be identified by its distinctive sky blue, blue-green or apple-green color and waxy to matt luster.Turquoise is the only gemstone that has a color named after it. Turquoise is sometimes mixed with malachite or chrysocolla, which causes a blue and green mottled appearance..",
            };
            modelBuilder.Entity<Gemstone>().HasData(Turquoise);

            Gemstone Sodalite = new Gemstone()
            {
                Id = 21,
                Title = "Sodalite",
                UserId = user.Id,
                ImagePath = "sodalite.jpg",
                Description = "Sodalite can be identified by its deep blue color and strong orange fluorescence. It can sometimes exhibit a violet tint and in opaque form often has white veins or patches running through it, which are composed of calcite.Sodalite is a fairly versatile gemstone that can be used in a variety of gemstone jewelry designs. Sodalite beads are popular in beaded necklaces, earrings, and bracelets. Beads can be spherical, tubular, square or tumbled.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Sodalite);



            Gemstone Fluorite = new Gemstone()
            {
                Id = 22,
                Title = "fluorite",
                UserId = user.Id,
                ImagePath = "fluorite.jpg",
                Description = "Fluorite is considered to be one of most popular minerals in the world among gem and mineral collectors, second only to quartz. It is often referred to as 'the most colorful mineral in the world' owing to its variety of brilliant colors.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Fluorite);


            Gemstone Carnelian = new Gemstone()
            {
                Id = 23,
                Title = "Carnelian",
                UserId = user.Id,
                ImagePath = "carnelian.jpg",
                Description = "They all share some color similarities but generally Carnelian (sometimes called Cornelian) is the evenly colored orange version with a golden yellow to reddish brown range.Carnelian is a very reasonably priced gemstone and they are all similar in price no matter the color but the brighter red colors followed by reddish orange are the most sought after so will be valued just a little higher than the paler colors.",
            };
            modelBuilder.Entity<Gemstone>().HasData(Carnelian);



            Gemstone ZebraJasper = new Gemstone()
            {
                Id = 24,
                Title = "Zebra Jasper",
                UserId = user.Id,
                ImagePath = "zebraJasper.jpg",
                Description = "Like other jaspers, zebra jasper is found all over the world and has been used since antiquity. But, unlike much jasper which is spotted, this variety of jasper marble is striped. Jasper, an opaque chalcedony, comes in a wide variety of colors, each with unique patterning. Zebra jasper is the variety of jasper known for its mottled warm brick red and avocado green appearance.",
            };
            modelBuilder.Entity<Gemstone>().HasData(ZebraJasper);




            ProductType Earring = new ProductType()
            {
                ProductTypeId = 1,
                Category = "Earrings",
                ImagePath = "earrings.jpg",
            };
            modelBuilder.Entity<ProductType>().HasData(Earring);

            ProductType Necklace = new ProductType()
            {
                ProductTypeId = 2,
                Category = "Necklaces",
                ImagePath = "necklaceHome.jpg",
            };
            modelBuilder.Entity<ProductType>().HasData(Necklace);

            ProductType Bracelet = new ProductType()
            {
                ProductTypeId = 3,
                Category = "Bracelets",
                ImagePath = "braceletsHome.jpg",
            };
            modelBuilder.Entity<ProductType>().HasData(Bracelet);



            Product CalciteTriangleEarrings = new Product()
            {
                Id = 1,
                Title = "Calcite Triangle Earrings",
                UserId = user.Id,
                DateAdded = DateTime.Now,
                ImagePath = "TriangleCalciteEarrings.jpg",
                ProductTypeId = 1,
                Description = "Rustic triangle shaped copper earrings with large, round calcite gemstone.",
               
            };
            modelBuilder.Entity<Product>().HasData(CalciteTriangleEarrings);



            Product BlackOnyxEarrings = new Product()
            {
                UserId = user.Id,
                Id = 2,
                Title = "Black Onyx Dangle Earrings",
                ImagePath = "BlackOnyxDangle.jpg",
                DateAdded = DateTime.Now,
                ProductTypeId = 1,
                Description = "Elegant sterling silver and black onyx dangle earrings.",


            };
            modelBuilder.Entity<Product>().HasData(BlackOnyxEarrings);



            Product PinkBlueTassleEarrings = new Product()
            {
                Id = 3,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Pink and Blue Jasper Tassle Earrings",
                ImagePath = "blueJasperTassle.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy tassle earrings with all natural pink and coral jasper gemstones.",


            };
            modelBuilder.Entity<Product>().HasData(PinkBlueTassleEarrings);



            Product LepidoliteHoops = new Product()
            {
                Id = 4,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Lepidolite Gold Hoops",
                DateAdded = DateTime.Now,
                ImagePath = "LepidoliteChipHoops.jpg",
                Description = "Hammered out gold hoop earrings with wire-wrapped lepidolite chips.",
            };
            modelBuilder.Entity<Product>().HasData(LepidoliteHoops);



            Product CoralHoops = new Product()
            {
                Id = 5,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Gold Hoop Earrings With Petrified Coral",
                ImagePath = "coralHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold hoops with wire wrapped pieces of petrified coral.",
};
            modelBuilder.Entity<Product>().HasData(CoralHoops);



            Product HammeredGoldAndChainEarrings = new Product()
            {
                Id = 6,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Gold and Bronze Chain Earrings",
                ImagePath = "GoldBronzeChainEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold earrings with bronze chain.",


            };
            modelBuilder.Entity<Product>().HasData(HammeredGoldAndChainEarrings);



            Product BlackTassleEarrings = new Product()
            {
                Id = 7,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Teardrop Black Tassle Earrings",
                ImagePath = "GoldTeardropBlackTassle.jpg",
                DateAdded = DateTime.Now,
                Description = "Teardrop shaped gold earrings with black tassles.",
  };
            modelBuilder.Entity<Product>().HasData(BlackTassleEarrings);



            Product DiamondLarimarEarrings = new Product()
            {
                Id = 8,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Diamond Shaped Hoops with Larimar Gemstones",
                ImagePath = "DiamondLarimarEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out diamond shaped gold hoops with wire wrapped larimar gemstones.",
     };
            modelBuilder.Entity<Product>().HasData(DiamondLarimarEarrings);



            Product AmazoniteSterlingEarrings = new Product()
            {
                Id = 9,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Sterling Silver and Amazonite Earrings",
                ImagePath = "SterlingAmazoniteEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Asymmetrical sterling silver bead frames with rare cut amazonite gemstones."

            };
            modelBuilder.Entity<Product>().HasData(AmazoniteSterlingEarrings);



            Product PinkOpalCopperHoops = new Product()
            {
                Id = 10,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Copper Hoops with Pink Opal",
                ImagePath = "BronzePinkOpalHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out copper hoop earrings with wire wrapped pink opal gemstones."
 };
            modelBuilder.Entity<Product>().HasData(PinkOpalCopperHoops);


            Product FramedAutumnJasperEarrings = new Product()
            {
                Id = 11,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Framed Autumn Jasper Earrings",
                ImagePath = "AutumnJasperFramed.jpg",
                DateAdded = DateTime.Now,
                Description = "Rare cut autumn jasper gemstones set inside sterling silver bead frame."
            };
            modelBuilder.Entity<Product>().HasData(FramedAutumnJasperEarrings);


            Product BlueLaceGoldHoops = new Product()
            {
                Id = 12,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Gold Hoops with Blue Lace Agate",
                ImagePath = "BlueLaceHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold hoop earrings wire wrapped with chips of blue lace agate."
            };
            modelBuilder.Entity<Product>().HasData(BlueLaceGoldHoops);


            Product InvertedTeardropLepidolite = new Product()
            {
                Id = 13,
                UserId = user.Id,
                ProductTypeId = 1,
                Title = "Inverted Teardop Lepidolite Earrings",
                ImagePath = "InvertedTeardropLarimar.jpg",
                DateAdded = DateTime.Now,
                Description = "Inverted gold teardrop earrings with wire wrapped lepidolite gemstones."
            };
            modelBuilder.Entity<Product>().HasData(InvertedTeardropLepidolite);


            Product LapisHoops = new Product()
            {
                Id = 14,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Hoop Lapis Earrings",
                ImagePath = "LapisHoopEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold hoop earrings accented with wire wrapped, teardrop shaped lapis gemstone."
            };
            modelBuilder.Entity<Product>().HasData(LapisHoops);


            Product RoseQuartzTeardrops = new Product()
            {
                Id = 15,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Teardrop Earrings with Rose Quartz",
                ImagePath = "RoseGoldTeardrop.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold teardrop earrings with wire wrapped chips of rose quartz."
            };
            modelBuilder.Entity<Product>().HasData(RoseQuartzTeardrops);

            Product AquaQuartzHoops = new Product()
            {
                Id = 16,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Hoop earrings with Aqua Quartz Gemstone",
                ImagePath = "AquaQuartzGoldHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold hoop earrings with rare cut aqua quartz gemstones."
            };
            modelBuilder.Entity<Product>().HasData(AquaQuartzHoops);

            Product SunstoneDangleEarrings = new Product()
            {
                Id = 17,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Antique Copper Earrings With Sunstone",
                ImagePath = "sunstoneEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautiful antique copper earrings with shimmering sunstones."
            };
            modelBuilder.Entity<Product>().HasData(SunstoneDangleEarrings);

            Product AutumnJasperEarrings2 = new Product()
            {
                Id = 18,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Bronze and Autumn Jasper Dangle Earrings ",
                ImagePath = "BronzeAndAutumnJasper.jpg",
                DateAdded = DateTime.Now,
                Description = "Bronze dangle earrings with unique cut autumn jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(AutumnJasperEarrings2);

            Product ThreadPEarlEarrings = new Product()
            {
                Id = 19,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Threaded Pearl Earrings",
                ImagePath = "PearlThreadEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautifully elegant sterling silver thread earrings with freshwater pearls."
            };
            modelBuilder.Entity<Product>().HasData(ThreadPEarlEarrings);

            Product HammeredGoldPearlEarrings = new Product()
            {
                Id = 20,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Earrings with Wire Wrapped Pearls",
                ImagePath = "HammeredGoldPearl.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out gold earrings with wire wrapped freswater pearls."
            };
            modelBuilder.Entity<Product>().HasData(HammeredGoldPearlEarrings);

            Product PinkGreyJasperEarrings = new Product()
            {
                Id = 21,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Pink and Grey Jasper Earrings",
                ImagePath = "PinkGreyJasperEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Bronze hoop earrings with pink and grey jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(PinkGreyJasperEarrings);

            Product PearlNecklace = new Product()
            {
                Id = 22,
                ProductTypeId = 2,
                UserId = user.Id,
                Title = "Delicate Freshwater Pearl Necklace",
                ImagePath = "pearlNecklace.jpg",
                DateAdded = DateTime.Now,
                Description = "Delicate pink freshwater pearl necklace on gold chain."
            };
            modelBuilder.Entity<Product>().HasData(PearlNecklace);

            Product ThreadPearlNecklace = new Product()
            {
                Id = 23,
                ProductTypeId = 2,
                UserId = user.Id,
                Title = "Threaded Pearl Necklace",
                ImagePath = "ThreadPearlNecklace.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautiful threaded freshwater pearl necklace with aqua quartz and purple crystals."
            };
            modelBuilder.Entity<Product>().HasData(ThreadPearlNecklace);


            Product JasperBracelet = new Product()
            {
                Id = 24,
                ProductTypeId = 3,
                UserId = user.Id,
                Title = "Jasper and Glass Bracelet",
                ImagePath = "JasperBracelet.jpg",
                DateAdded = DateTime.Now,
                Description = "Fun earth toned bracelet made with glass beads and jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(JasperBracelet);


            Product LightWoodBracelet = new Product()
            {
                Id = 25,
                ProductTypeId = 3,
                UserId = user.Id,
                Title = "Light Wood Bracelet",
                ImagePath = "LightWoodBracelet.jpg",
                DateAdded = DateTime.Now,
                Description = "Bracelet made with wooden beads and stretchy floss cord."
            };
            modelBuilder.Entity<Product>().HasData(LightWoodBracelet);


            Product DarkWoodBracelet = new Product()
            {
                Id = 26,
                ProductTypeId = 3,
                UserId = user.Id,
                Title = "Dark Wood Bracelet",
                ImagePath = "DarkWoodBracelet.jpg",
                DateAdded = DateTime.Now,
                Description = "Bracelet made with wooden beads and stretchy floss cord."
            };
            modelBuilder.Entity<Product>().HasData(DarkWoodBracelet);

            Product MaroonNecklace = new Product()
            {
                Id = 27,
                ProductTypeId = 2,
                UserId = user.Id,
                Title = "Maroon Necklace",
                ImagePath = "maroonNecklace.jpg",
                DateAdded = DateTime.Now,
                Description = "Delicate necklace on a gold chain with maroon crystals and trendy pendant"
            };
            modelBuilder.Entity<Product>().HasData(MaroonNecklace);

            Product ZJTeardrop = new Product()
            {
                Id = 28,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Silver Teardrops With Zebra Jasper",
                ImagePath = "teardropZebraJasp.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautiful sterling silver teardrop earrings with zebra jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(ZJTeardrop);

            Product CopperRedJasperHoops = new Product()
            {
                Id = 29,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Copper Red Jasper Hoops",
                ImagePath = "CopperJaspHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered out copper hoops with red jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(CopperRedJasperHoops);

            Product TurqChain = new Product()
            {
                Id = 30,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Antique Turqouise Chain Earrnigs",
                ImagePath = "turqoiseChainEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautiful antique bronze and turquoise chain earrings."
            };
            modelBuilder.Entity<Product>().HasData(TurqChain);

            Product TurqTassel = new Product()
            {
                Id = 31,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise Fan Tassel Earrings",
                ImagePath = "turqoiseFanTassle.jpg",
                DateAdded = DateTime.Now,
                Description = "Bronze earrings with fan shaped turquoise tassels."
            };
            modelBuilder.Entity<Product>().HasData(TurqTassel);

            Product BronzeChain = new Product()
            {
                Id = 32,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Rustic Bronze Chain Earrings",
                ImagePath = "bronzeChain.jpg",
                DateAdded = DateTime.Now,
                Description = "Rustic bronze chain earrings."
            };
            modelBuilder.Entity<Product>().HasData(BronzeChain);

            Product RoseQtzFeather = new Product()
            {
                Id = 33,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Rose Quartz Feather Earrings",
                ImagePath = "RoseQtzGoldFeather.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold Feather earrings with beautiful rose quartz gemstones."
            };
            modelBuilder.Entity<Product>().HasData(RoseQtzFeather);

            Product Cactus = new Product()
            {
                Id = 34,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Bronze Cactus Earrings",
                ImagePath = "cactusEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Quirky bronze cactus earrings with turqouise colored crystals."
            };
            modelBuilder.Entity<Product>().HasData(Cactus);

            Product GoldChain = new Product()
            {
                Id = 35,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Chain Dangle Earrings",
                ImagePath = "goldChain.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold chain dangle earrings with wire wrapped gold and silver crystal beads."
            };
            modelBuilder.Entity<Product>().HasData(GoldChain);

            Product TurqFeather = new Product()
            {
                Id = 36,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise Feather Earrings",
                ImagePath = "goldTurqouiseFeather.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy gold and turqoise trendy earrings."
            };
            modelBuilder.Entity<Product>().HasData(TurqFeather);

            Product Aqua = new Product()
            {
                Id = 37,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Aquamarine Earrings",
                ImagePath = "AquamarineDangle.jpg",
                DateAdded = DateTime.Now,
                Description = "Sterling silver dangle earrings with oval aquamarine gemstones."
            };
            modelBuilder.Entity<Product>().HasData(Aqua);

            Product BlackSilver = new Product()
            {
                Id = 38,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Black and Silver Earrings",
                ImagePath = "BlackAndSilver.jpg",
                DateAdded = DateTime.Now,
                Description = "Black and silver pendant earrings with small black crystal."
            };
            modelBuilder.Entity<Product>().HasData(BlackSilver);

            Product ZebraGunmetal = new Product()
            {
                Id = 39,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Zebra Jasper Feather Earrings",
                ImagePath = "gunmetalZebraJasp.jpg",
                DateAdded = DateTime.Now,
                Description = "Dangle earrings with gunmetal feather and zebra jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(ZebraGunmetal);

            Product FlouriteRoseQtz = new Product()
            {
                Id = 40,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Soft Toned Gemstone Earrings",
                ImagePath = "FlouriteRoseQtz.jpg",
                DateAdded = DateTime.Now,
                Description = "Beautiful gold dangle earrings with Rose Quarts and Fluorite gemstones."
            };
            modelBuilder.Entity<Product>().HasData(FlouriteRoseQtz);

            Product blackAndGoldDangle = new Product()
            {
                Id = 41,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Black and Gold Dangle Earrings",
                ImagePath = "blackAndGoldDangle.jpg",
                DateAdded = DateTime.Now,
                Description = "Wire wrapped gold dangle earrings with black crystal beads."
            };
            modelBuilder.Entity<Product>().HasData(blackAndGoldDangle);

            Product triangleChainTurqoise = new Product()
            {
                Id = 42,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise Triangle Earrings",
                ImagePath = "triangleChainTurqoise.jpg",
                DateAdded = DateTime.Now,
                Description = "Triangle shaped earrings with bronze chains and turquoise gemstone chips."
            };
            modelBuilder.Entity<Product>().HasData(triangleChainTurqoise);

            Product mixedMetal = new Product()
            {
                Id = 43,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Mixed Metal Earrings",
                ImagePath = "mixedMetalEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy dangle earrings with mixed metals and shapes."
            };
            modelBuilder.Entity<Product>().HasData(mixedMetal);

            Product chalcedonyHoops = new Product()
            {
                Id = 44,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Silver and Chalcedony Hoops",
                ImagePath = "chalcedonyHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Large silver tardrop shaped earrings with chips of wire wrapped chalcedony gemstones"
            };
            modelBuilder.Entity<Product>().HasData(chalcedonyHoops);

            Product marbledBlueglass = new Product()
            {
                Id = 45,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Light blue and Silver Earrings",
                ImagePath = "marbledBlueglass.jpg",
                DateAdded = DateTime.Now,
                Description = "Dainty silver earrings with marbled light blue glass bead."
            };
            modelBuilder.Entity<Product>().HasData(marbledBlueglass);

            Product goldRed = new Product()
            {
                Id = 46,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold and Red Earrings",
                ImagePath = "GoldAndRed.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold geometric earrings with long red glass beads."
            };
            modelBuilder.Entity<Product>().HasData(goldRed);

            Product purpJaspFeather = new Product()
            {
                Id = 47,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Purple and Copper Feather Earrings",
                ImagePath = "purpJaspFeather.jpg",
                DateAdded = DateTime.Now,
                Description = "Marbled Purple Jasper gemstone earrings with metal copper feather."
            };
            modelBuilder.Entity<Product>().HasData(purpJaspFeather);

            Product glassGoldCube = new Product()
            {
                Id = 48,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Cube Earrings",
                ImagePath = "glassGoldCube.jpg",
                DateAdded = DateTime.Now,
                Description = "Glass cube earrings with gold chain."
            };
            modelBuilder.Entity<Product>().HasData(glassGoldCube);

            Product TurqAngelWing = new Product()
            {
                Id = 49,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise Wing Earrings",
                ImagePath = "TurqAngelWing.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy earrings with gold stone and turquoise wings."
            };
            modelBuilder.Entity<Product>().HasData(TurqAngelWing);

            Product gunmetalPearl = new Product()
            {
                Id = 50,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gunmetal Pearl Earrings",
                ImagePath = "gunmetalPearl.jpg",
                DateAdded = DateTime.Now,
                Description = "Gunmetal hoop earrings with freshwater pearls."
            };
            modelBuilder.Entity<Product>().HasData(gunmetalPearl);


            Product marbledGoldTeardrop = new Product()
            {
                Id = 51,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Marbled Gold Teardrops",
                ImagePath = "marbledGoldTeardrop.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold teardrop hoops framing marbled gray and black gemstone."
            };
            modelBuilder.Entity<Product>().HasData(marbledGoldTeardrop);


            Product GeometricZebraJasp = new Product()
            {
                Id = 52,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Marble and Silver Geometric Earrings",
                ImagePath = "GeometricZebraJasp.jpg",
                DateAdded = DateTime.Now,
                Description = "Sterling silver geometric earrings with marbled zebra jasper nuggets."
            };
            modelBuilder.Entity<Product>().HasData(GeometricZebraJasp);


            Product silverChain = new Product()
            {
                Id = 53,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Silver Chain Earrings",
                ImagePath = "silverChain.jpg",
                DateAdded = DateTime.Now,
                Description = "Hammered dangle earrings with silver chain."
            };
            modelBuilder.Entity<Product>().HasData(silverChain);


            Product TurqPearl = new Product()
            {
                Id = 54,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise Pearl Earrings ",
                ImagePath = "TurqPearl.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy turquoise earrings with freshwater pearls."
            };
            modelBuilder.Entity<Product>().HasData(TurqPearl);


            Product wrappedChalcedTeardrops = new Product()
            {
                Id = 55,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold Chalcedony Earrings",
                ImagePath = "wrappedChalcedTeardrops.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold earrings with wire wrapped teardop shaped chalcedony"
            };
            modelBuilder.Entity<Product>().HasData(wrappedChalcedTeardrops);


            Product carnelianEarrings = new Product()
            {
                Id = 56,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Carnelian Earrings",
                ImagePath = "carnelianEarrings.jpg",
                DateAdded = DateTime.Now,
                Description = "Statement earrings with large square carnelian gemstones."
            };
            modelBuilder.Entity<Product>().HasData(carnelianEarrings);


            Product blackGeometricHoops = new Product()
            {
                Id = 57,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Black and Bronze Geometric Hoops",
                ImagePath = "blackGeometricHoops.jpg",
                DateAdded = DateTime.Now,
                Description = "Bronze hoop earrings with long black gemstones"
            };
            modelBuilder.Entity<Product>().HasData(blackGeometricHoops);


            Product blueBronzechain = new Product()
            {
                Id = 58,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Blue and Bronze Chain Earrings",
                ImagePath = "blueBronzechain.jpg",
                DateAdded = DateTime.Now,
                Description = "Trendy bronze chain dangle earrings with blue glass beads."
            };
            modelBuilder.Entity<Product>().HasData(blueBronzechain);


            Product goldTeardropAntique = new Product()
            {
                Id = 59,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Rustic Teardrop Earrings",
                ImagePath = "goldTeardropAntique.jpg",
                DateAdded = DateTime.Now,
                Description = "Large rustic copper and bronze teardrop earrings."
            };
            modelBuilder.Entity<Product>().HasData(goldTeardropAntique);


            Product goldFramedTurq = new Product()
            {
                Id = 60,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Turquoise pendant Teardrop Earrings",
                ImagePath = "goldFramedTurq.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold teardrop earrings with turqoise pendant"
            };
            modelBuilder.Entity<Product>().HasData(goldFramedTurq);


            Product blueCrystalNecklace = new Product()
            {
                Id = 61,
                ProductTypeId = 2,
                UserId = user.Id,
                Title = "Blue Crystal Necklace",
                ImagePath = "blueCrystalNecklace.jpg",
                DateAdded = DateTime.Now,
                Description = "Long gold necklace with bright blue crystal pendant."
            };
            modelBuilder.Entity<Product>().HasData(blueCrystalNecklace);

            Product pointyTurqoise = new Product()
            {
                Id = 62,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Pointy Turquoise Earrings",
                ImagePath = "pointyTurqoise.jpg",
                DateAdded = DateTime.Now,
                Description = "Simple dangle earrings with long turquoise gemstones."
            };
            modelBuilder.Entity<Product>().HasData(pointyTurqoise);

            Product jasperCubes = new Product()
            {
                Id = 63,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Jasper Cube Earrings",
                ImagePath = "blueCrystalNecklace.jpg",
                DateAdded = DateTime.Now,
                Description = "Unique bronze dangle earrings with rare cut jasper gemstones."
            };
            modelBuilder.Entity<Product>().HasData(jasperCubes);

            Product sodaliteBlueChain = new Product()
            {
                Id = 64,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Blue Chain Earrings",
                ImagePath = "sodaliteBlueChain.jpg",
                DateAdded = DateTime.Now,
                Description = "Blue chain earrings with sodalite gemstones."
            };
            modelBuilder.Entity<Product>().HasData(sodaliteBlueChain);

            Product goldTurqMetal = new Product()
            {
                Id = 65,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Gold and Turquoise Earrings",
                ImagePath = "goldTurqMetal.jpg",
                DateAdded = DateTime.Now,
                Description = "Simple turquoise painted gold earrings."
            };
            modelBuilder.Entity<Product>().HasData(goldTurqMetal);

            Product wirewrappedLapis = new Product()
            {
                Id = 66,
                ProductTypeId = 1,
                UserId = user.Id,
                Title = "Wire Wrapped Lapis Earrings",
                ImagePath = "wirewrappedLapis.jpg",
                DateAdded = DateTime.Now,
                Description = "Gold wire wrapped earrings with bright lapis gemstones."
            };
            modelBuilder.Entity<Product>().HasData(wirewrappedLapis);








            ProductReview JasperTassleReview = new ProductReview()
            {
                Id = 1,
                Title = "awesome!",
                UserId = user.Id,
                ProductId = 3,
                Comment = "These are so pretty! love the color!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(JasperTassleReview);

            ProductReview RoseQuartzTeardropsReview = new ProductReview()
            {
                Id = 2,
                Title = "My fav",
                UserId = user.Id,
                ProductId = 15,
                Comment = "Love these gemstones and the shape of the hoops",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(RoseQuartzTeardropsReview);

            ProductReview LapisHoopsReview = new ProductReview()
            {
                Id = 3,
                Title = "love Lapis",
                UserId = user.Id,
                ProductId = 14,
                Comment = "Lapis gems are my favorite. Nice wire wrapping!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(LapisHoopsReview);

            ProductReview InvertedTeardropLepidoliteReview = new ProductReview()
            {
                Id = 4,
                Title = "My fav",
                UserId = user.Id,
                ProductId = 13,
                Comment = "These purple gems are so cool. such a pretty design!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(InvertedTeardropLepidoliteReview);

            ProductReview AquaQuartzHoopsReview = new ProductReview()
            {
                Id = 5,
                Title = "nifty",
                UserId = user.Id,
                ProductId = 16,
                Comment = "Didn't know quartz came in this color. Very cool!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(AquaQuartzHoopsReview);

            ProductReview SunstoneDangleEarringsReview = new ProductReview()
            {
                Id = 6,
                Title = "My fav",
                UserId = user.Id,
                ProductId = 17,
                Comment = "These sunstones are so pretty!!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(SunstoneDangleEarringsReview);

            ProductReview BlueLaceGoldHoopsReview = new ProductReview()
            {
                Id = 7,
                Title = "Such a pretty color",
                UserId = user.Id,
                ProductId = 12,
                Comment = "These blue lace gems are awesome. Love the wire wrapping",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(BlueLaceGoldHoopsReview);

            ProductReview FramedAutumnJasperReview1 = new ProductReview()
            {
                Id = 8,
                Title = "Very different",

                UserId = user.Id,
                ProductId = 11,
                Comment = "Interesting earrings!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(FramedAutumnJasperReview1);

            ProductReview FramedAutumnJasperReview2 = new ProductReview()
            {
                Id = 9,
                Title = "Such a pretty color",

                UserId = user.Id,
                ProductId = 11,
                Comment = "These bead frames are cool!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(FramedAutumnJasperReview2);

            ProductReview PinkOpalHoopsReview = new ProductReview()
            {
                Id = 10,
                Title = "Such a pretty color",

                UserId = user.Id,
                ProductId = 10,
                Comment = "Oh my god these are so pretty! I want a pair",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(PinkOpalHoopsReview);

            ProductReview AutumnJaspEarrings2Review = new ProductReview()
            {
                Id = 11,
                Title = "Way to go",

                UserId = user.Id,
                ProductId = 18,
                Comment = "I like how you used the bronze cirle with the gemstones!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(AutumnJaspEarrings2Review);

            ProductReview TreadedEarringReview1 = new ProductReview()
            {
                Id = 12,
                Title = "Any other threaded ones?",

                UserId = user.Id,
                ProductId = 19,
                Comment = "Threaded earrings are so pretty. do you have them in any other gemstone?",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(TreadedEarringReview1);

            ProductReview HameredGoldPearlReview1 = new ProductReview()
            {
                Id = 13,
                Title = "awesome design",

                UserId = user.Id,
                ProductId = 20,
                Comment = "I love how you got the pearls to alternate up and down!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(HameredGoldPearlReview1);

            ProductReview PearlNecklaceReview1 = new ProductReview()
            {
                Id = 14,
                Title = "pearls",

                UserId = user.Id,
                ProductId = 22,
                Comment = "These pearls are so pretty!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(PearlNecklaceReview1);

            ProductReview PearlNecklaceReview2 = new ProductReview()
            {
                Id = 15,
                Title = "great quality",

                UserId = user.Id,
                ProductId = 22,
                Comment = "Ordered this necklace and i absolutely love it. Would definitely recommend it!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(PearlNecklaceReview2);

            ProductReview BlackOnyxReview = new ProductReview()
            {
                Id = 16,
                Title = "Great vibe",

                UserId = user.Id,
                ProductId = 2,
                Comment = "I love the antique feel of these earrings!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(BlackOnyxReview);

            ProductReview LepidoliteHoopsReview = new ProductReview()
            {
                Id = 17,
                Title = "wrapping",

                UserId = user.Id,
                ProductId = 4,
                Comment = "Nice wire wrapping!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(LepidoliteHoopsReview);

            ProductReview CoralHoopsReview = new ProductReview()
            {
                Id = 18,
                Title = "nice vibe",

                UserId = user.Id,
                ProductId = 2,
                Comment = "I love the antique feel of these earrings!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(CoralHoopsReview);

            ProductReview BlackTasselReview = new ProductReview()
            {
                Id = 19,
                Title = "love",

                UserId = user.Id,
                ProductId = 7,
                Comment = "So cute and trendy!",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(BlackTasselReview);


            ProductReview LightWoodBraceletReview = new ProductReview()
            {
                Id = 20,
                Title = "Thanks again",

                UserId = user.Id,
                ProductId = 25,
                Comment = "Ordered a few of these and I love them.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(LightWoodBraceletReview);


            ProductReview DarkWoodBraceletReview = new ProductReview()
            {
                Id = 21,
                Title = "dopeee",

                UserId = user.Id,
                ProductId = 26,
                Comment = "This bracelet is dope",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<ProductReview>().HasData(DarkWoodBraceletReview);






            Tutorial CrimpTutorial = new Tutorial()
            {
                Id = 1,
                UserId = user.Id,
                Title = "How to use crimping pliers",
                VideoPath = "CrimpTutorial.mp4",
                Description = "First feed one crimp beed onto the wire and then loop it through a clasp or a jump ringand then back through the crimp. PLace the crimp in the OUTER jaw of the crimp tool and make one firm compression. Then place the crimp bead into the crescent-shaped groove of the crimp tool and firmly compress. String the remaining beads onto the wire.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<Tutorial>().HasData(CrimpTutorial);


            Tutorial WireWrappedLoopEarringsTutorial = new Tutorial()
            {
                Id = 2,
                UserId = user.Id,
                Title = "How to wire wrap loops for earrings",
                VideoPath = "WireWrappedLoopForEarrings.mp4",
                Description = "In this video, learn how to make a wrapped wire loop for jewelry making. This basic technique is used when putting a bead on a head pin or eye pin as a dangle or a link, and is more durable than a simple wire loop.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<Tutorial>().HasData(WireWrappedLoopEarringsTutorial);

            Tutorial Tools101 = new Tutorial()
            {
                Id = 3,
                UserId = user.Id,
                Title = "Tools for beginners",
                VideoPath = "Tools101.mp4",
                Description = "This video shows you how to use all the essential jewelry making tools for beginners.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<Tutorial>().HasData(Tools101);

            Tutorial WireBeadCap = new Tutorial()
            {
                Id = 4,
                UserId = user.Id,
                Title = "How to Make a Wire Wrapped Bead Cap",
                VideoPath = "WireBeadCaps.mp4",
                Description = "Learn how to make that trickey wire wrapped bead cap with this video.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<Tutorial>().HasData(WireBeadCap);





            TutorialReview CrimpVideoReview = new TutorialReview()
            {
                Id = 1,
                Title = "Perfect",
                UserId = user.Id,
                TutorialId = 1,
                Comment = "Thanks for posting. I struggled with making good looking crimps for so long. This video was very helpful.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<TutorialReview>().HasData(CrimpVideoReview);


            TutorialReview ToolsTutorialReview = new TutorialReview()
            {
                Id = 2,
                Title = "Thank you!",
                UserId = user.Id,
                TutorialId = 3,
                Comment = "Glad you posted this. I just started making jewelry and wasn't sure which tools to buy! thanks again.",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<TutorialReview>().HasData(ToolsTutorialReview);


            TutorialReview WireWrappingEarringReview = new TutorialReview()
            {
                Id = 3,
                Title = "Hopefully this helps"
                UserId = user.Id,
                TutorialId = 2,
                Comment = "My wire wrapping always looks so ugly because i was doing it wrong. Glad you posted this",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<TutorialReview>().HasData(WireWrappingEarringReview);

            TutorialReview WireWrappingEarringReview2 = new TutorialReview()
            {
                Id = 4,
                Title = "Yay",
                UserId = user.Id,
                TutorialId = 2,
                Comment = "My wire wrapping looks so much better after watching this video! thank you",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<TutorialReview>().HasData(WireWrappingEarringReview2);

            TutorialReview BeadCapTutorialReview = new TutorialReview()
            {
                Id = 5,
                Title = "I hate Bead Caps"
                UserId = user.Id,
                TutorialId = 4,
                Comment = "I've had a hard time with bead caps for a while, hoping that after seeing this video it wont be as difficult",
                DateAdded = DateTime.Now
            };
            modelBuilder.Entity<TutorialReview>().HasData(BeadCapTutorialReview);












            ProductGemstone ProductGemstone1 = new ProductGemstone()
            {
                Id = 1,
                ProductId = 1,
                GemstoneId = 2,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone1);


            ProductGemstone ProductGemstone2 = new ProductGemstone()
            {
                Id = 2,
                ProductId = 2,
                GemstoneId = 5,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone2);


            ProductGemstone ProductGemstone3 = new ProductGemstone()
            {
                Id = 3,
                ProductId = 3,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone3);

            ProductGemstone ProductGemstone4 = new ProductGemstone()
            {
                Id = 4,
                ProductId = 4,
                GemstoneId = 9,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone4);

            ProductGemstone ProductGemstone5 = new ProductGemstone()
            {
                Id = 5,
                ProductId = 5,
                GemstoneId = 4,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone5);

            ProductGemstone ProductGemstone6 = new ProductGemstone()
            {
                Id = 6,
                ProductId = 8,
                GemstoneId = 7,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone6);

            ProductGemstone ProductGemstone7 = new ProductGemstone()
            {
                Id = 7,
                ProductId = 9,
                GemstoneId = 1,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone7);

            ProductGemstone ProductGemstone8 = new ProductGemstone()
            {
                Id = 8,
                ProductId = 10,
                GemstoneId = 11,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone8);

            ProductGemstone ProductGemstone9 = new ProductGemstone()
            {
                Id = 9,
                ProductId = 11,
                GemstoneId = 12,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone9);

            ProductGemstone ProductGemstone10 = new ProductGemstone()
            {
                Id = 10,
                ProductId = 12,
                GemstoneId = 3,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone10);

            ProductGemstone ProductGemstone11 = new ProductGemstone()
            {
                Id = 11,
                ProductId = 13,
                GemstoneId = 9,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone11);

            ProductGemstone ProductGemstone12 = new ProductGemstone()
            {
                Id = 12,
                ProductId = 14,
                GemstoneId = 6,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone12);

            ProductGemstone ProductGemstone13 = new ProductGemstone()
            {
                Id = 13,
                ProductId = 15,
                GemstoneId = 10,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone13);

            ProductGemstone ProductGemstone14 = new ProductGemstone()
            {
                Id = 14,
                ProductId = 16,
                GemstoneId = 15,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone14);

            ProductGemstone ProductGemstone15 = new ProductGemstone()
            {
                Id = 15,
                ProductId = 17,
                GemstoneId = 8,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone15);

            ProductGemstone ProductGemstone16 = new ProductGemstone()
            {
                Id = 16,
                ProductId = 18,
                GemstoneId = 12,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone16);

            ProductGemstone ProductGemstone17 = new ProductGemstone()
            {
                Id = 17,
                ProductId = 19,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone17);

            ProductGemstone ProductGemstone18 = new ProductGemstone()
            {
                Id = 18,
                ProductId = 20,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone18);

        
            ProductGemstone ProductGemstone19 = new ProductGemstone()
            {
                Id = 19,
                ProductId = 21,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone19);


            ProductGemstone ProductGemstone20 = new ProductGemstone()
            {
                Id = 20,
                ProductId = 22,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone20);

            ProductGemstone ProductGemstone21 = new ProductGemstone()
            {
                Id = 21,
                ProductId = 23,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone21);


            ProductGemstone ProductGemstone22 = new ProductGemstone()
            {
                Id = 22,
                ProductId = 24,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone22);

            ProductGemstone ProductGemstone23 = new ProductGemstone()
            {
                Id = 23,
                ProductId = 25,
                GemstoneId = 16,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone23);

            ProductGemstone ProductGemstone24 = new ProductGemstone()
            {
                Id = 24,
                ProductId = 26,
                GemstoneId = 16,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone24);

            ProductGemstone ProductGemstone25 = new ProductGemstone()
            {
                Id = 25,
                ProductId = 23,
                GemstoneId = 17,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone25);

            ProductGemstone ProductGemstone26 = new ProductGemstone()
            {
                Id = 26,
                ProductId = 66,
                GemstoneId = 3,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone26);

            ProductGemstone ProductGemstone27 = new ProductGemstone()
            {
                Id = 27,
                ProductId = 64,
                GemstoneId = 21,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone27);

            ProductGemstone ProductGemstone28= new ProductGemstone()
            {
                Id = 28,
                ProductId = 52,
                GemstoneId = 24,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone28);

            ProductGemstone ProductGemstone29 = new ProductGemstone()
            {
                Id = 29,
                ProductId = 54,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone29);

            ProductGemstone ProductGemstone30 = new ProductGemstone()
            {
                Id = 30,
                ProductId = 55,
                GemstoneId = 19,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone30);

            ProductGemstone ProductGemstone31 = new ProductGemstone()
            {
                Id = 31,
                ProductId = 56,
                GemstoneId = 23,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone31);

            ProductGemstone ProductGemstone32 = new ProductGemstone()
            {
                Id = 32,
                ProductId = 50,
                GemstoneId = 14,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone32);

            ProductGemstone ProductGemstone33 = new ProductGemstone()
            {
                Id = 33,
                ProductId = 44,
                GemstoneId = 19,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone33);

            ProductGemstone ProductGemstone34 = new ProductGemstone()
            {
                Id = 34,
                ProductId = 47,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone34);

            ProductGemstone ProductGemstone35 = new ProductGemstone()
            {
                Id = 35,
                ProductId = 29,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone35);

            ProductGemstone ProductGemstone36 = new ProductGemstone()
            {
                Id = 36,
                ProductId = 63,
                GemstoneId = 13,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone36);

            ProductGemstone ProductGemstone37 = new ProductGemstone()
            {
                Id = 37,
                ProductId = 42,
                GemstoneId = 20,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone37);
            ProductGemstone ProductGemstone38 = new ProductGemstone()
            {
                Id = 38,
                ProductId = 62,
                GemstoneId = 20,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone38);
            ProductGemstone ProductGemstone39 = new ProductGemstone()
            {
                Id = 39,
                ProductId = 28,
                GemstoneId = 24,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone39);
            ProductGemstone ProductGemstone40 = new ProductGemstone()
            {
                Id = 40,
                ProductId = 42,
                GemstoneId = 20,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone40);
            ProductGemstone ProductGemstone41 = new ProductGemstone()
            {
                Id = 41,
                ProductId = 33,
                GemstoneId = 10,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone41);
            ProductGemstone ProductGemstone42 = new ProductGemstone()
            {
                Id = 42,
                ProductId = 40,
                GemstoneId = 22,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone42);
            ProductGemstone ProductGemstone43 = new ProductGemstone()
            {
                Id = 43,
                ProductId = 37,
                GemstoneId = 18,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone43);

            ProductGemstone ProductGemstone44 = new ProductGemstone()
            {
                Id = 44,
                ProductId = 39,
                GemstoneId = 24,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone44);

            ProductGemstone ProductGemstone45 = new ProductGemstone()
            {
                Id = 45,
                ProductId = 40,
                GemstoneId = 10,
            };
            modelBuilder.Entity<ProductGemstone>().HasData(ProductGemstone45);










            ProductTutorial ProductTutorial1 = new ProductTutorial()
            {
                Id = 1,
                ProductId = 3,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial1);

            ProductTutorial ProductTutorial2 = new ProductTutorial()
            {
                Id = 2,
                ProductId = 3,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial2);


            ProductTutorial ProductTutorial3 = new ProductTutorial()
            {
                Id = 3,
                ProductId = 5,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial3);

            ProductTutorial ProductTutorial4 = new ProductTutorial()
            {
                Id = 4,
                ProductId = 8,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial4);

            ProductTutorial ProductTutorial5 = new ProductTutorial()
            {
                Id = 5,
                ProductId = 10,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial5);

            ProductTutorial ProductTutorial6 = new ProductTutorial()
            {
                Id = 6,
                ProductId = 16,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial6);

            ProductTutorial ProductTutorial7 = new ProductTutorial()
            {
                Id = 7,
                ProductId = 17,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial7);

            ProductTutorial ProductTutorial8 = new ProductTutorial()
            {
                Id = 8,
                ProductId = 18,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial8);

            ProductTutorial ProductTutorial9 = new ProductTutorial()
            {
                Id = 9,
                ProductId = 21,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial9);

            ProductTutorial ProductTutorial10 = new ProductTutorial()
            {
                Id = 10,
                ProductId = 21,
                TutorialId = 2,
            };
            modelBuilder.Entity<ProductTutorial>().HasData(ProductTutorial10);
        }
    }
}
