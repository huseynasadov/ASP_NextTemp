namespace ASPFinal.Migrations
{
    using ASPFinal.DAL;
    using ASPFinal.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPFinal.DAL.JoobsyDbContext>
    {
        private readonly JoobsyDbContext _db;
        public Configuration()
        {
            _db = new JoobsyDbContext();
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASPFinal.DAL.JoobsyDbContext context)
        {
            //AboutUs
            _db.AboutUs.AddOrUpdate(a => a.Title, new AboutUs[]
            {
                new AboutUs{
                    Title ="Vestibulum ante primis faucibus ?",
                    Content ="<p class='text-muted'>Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.</p>" +
                    "<p class='text-muted'>Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus.</p>" +
                    "<p class='text-muted'>Sed consequat leo eget bibendum sodales augue at velit cursus nunc.</p>",
                    Status=true
                },
                new AboutUs{
                    Title ="Class aptent taciti torquent per ?",
                    Content ="<p class='text-muted'>Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.</p>" +
                    "<p class='text-muted'>Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus.</p>" +
                    "<p class='text-muted'>Sed consequat leo eget bibendum sodales augue at velit cursus nunc.</p>",
                    Status=true
                },
                new AboutUs{
                    Title ="Maecenas ullamcorper eros pede ?",
                    Content ="<p class='text-muted'>Aenean eros et nisl sagittis as vestibulum at Nullam nulla eros ultricies site amet nonummy id imperdiet feugiat pede as Sed lectuse Donec mollis hendrerit Phasellus at nec sem in at pellentesque facilisis at Praesent congue erat at massa Sed sit cursus turpis vitae tortor that a Donec posuere as vulputate arcu Phasellus accumsan velit.</p>" +
                    "<p class='text-muted'>Maecenas tempus tellus eget as that condimentum rhoncus sem quam semper libero amete adipiscing sem neque sed ipsum Nam quam nunce blandit at luctus pulvinar hendrerit id lorem Maecenas nec et ante tincidunt tempus.</p>" +
                    "<p class='text-muted'>Sed consequat leo eget bibendum sodales augue at velit cursus nunc.</p>",
                    Status=true
                }
            });

            // Job Categories
            _db.JobCategories.AddOrUpdate(b => b.Name, new JobCategory[] {
                new JobCategory{Name="Software Developer",Status=true},
                new JobCategory{Name="Accounting",Status=true},
                new JobCategory{Name="Marketing Job ",Status=true},
                new JobCategory{Name="Graphic Dsigner ",Status=true},
                new JobCategory{Name="Web Developer ",Status=true},
                new JobCategory{Name="Web Designer ",Status=true},
                new JobCategory{Name="Digital Marketing ",Status=true},
                new JobCategory{Name="Education & Training ",Status=true},
                new JobCategory{Name="Engineering Jobs ",Status=true},
                new JobCategory{Name="Government Jobs ",Status=true}
            });

            // Blog
            _db.Blogs.AddOrUpdate(b => b.Title, new Blog[] {
                new Blog{
                    Title ="A small river named Duden flows by their place and supplies regelialia.",
                    Slug="a-small-river-named-duden-flows-by-their-place-and-supplies-regelialia",
                    Content ="<p class='text-muted mb-3 f-13'>The Big Oxmox advised her not to do so because there were thousands of bad Commas as wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way But nothing the copy said could convince her and s didn’t take long until a few insidious Copy Writers ambushed made her drunk with Longe and Parole and dragged a into their agency where they abused her for their projects again and again. And if hasn’t been rewritten.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=1,
                    Photos="blog-list/img-1.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Blog{
                    Title ="In a felis quis tortor malesuada pretium Pellentesque auctor neque nec.",
                    Slug="in-a-felis-quis-tortor-malesuada-pretium-pellentesque-auctor-neque-nec",
                    Content ="<p class='text-muted mb-3 f-13'>Ut non enim eleifend felis pretium feugiat Vivamus quis mi. Phasellus a est Phasellus magna hac habitasse platea dictumst Curabitur at lacus ac velit ornare lobortis.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=2,
                    Photos="blog-list/img-2.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Blog{
                    Title ="Donec interdum et hendrerit aliquet dolor diam sagittis ligula eget egestas libero.",
                    Slug="donec-interdum-et-hendrerit-aliquet-dolor-diam-sagittis-ligula-eget-egestas-libero",
                    Content ="<p class='text-muted mb-3 f-13'>Phasellus blandit leo ut odio maecenas ullamcorper dui plaerat feugiat eros pede varius nisi condimentum viverra felis nunc et lorem. Sed magna purus fermentum eu.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=3,
                    Photos="blog-list/img-3.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Blog{
                    Title ="Suspendisse enim turpis dictum sed iaculis a condimentum nec nisi Praesent nec nis.",
                    Slug="suspendisse-enim-turpis-dictum-sed-iaculis-a-condimentum-nec-nisi-praesent-nec-nis",
                    Content ="<p class='text-muted mb-3 f-13'>Vestibulum rutrum nec elementum a vehicula eros quamnisl a fringilla neque ante vel mi Morbi mollis tellus a sapien volutpat metus eget egestas mollis lacus lacus vel turpis dui.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=4,
                    Photos="blog-list/img-4.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Blog{
                    Title ="Sed augue ipsum egestas as vestibulum et malesuada Nulla neque adipiscing.",
                    Slug="sed-augue-ipsum-egestas-as-vestibulum-et-malesuada-nulla-neque-adipiscing",
                    Content ="<p class='text-muted mb-3 f-13'>Vestibulum rutrum nec elementum vehicula eros quamnisl a fringilla neque ante vel mi Morbi mollis tellus a sapien volutpat metus eget egestas mollis lacus lacus blandit dui Fusce vel dui.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=5,
                    Photos="blog-list/img-5.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Blog{
                    Title ="Duis vel nibh at velit scelerisque suscipit Curabitur turpis as vestibulum.",
                    Slug="duis-vel-nibh-at-velit-scelerisque-suscipit-curabitur-turpis-as-vestibulum",
                    Content ="<p class='text-muted mb-3 f-13'>Fusce ac felis a amet ligula pharetra condimentum Maecenas egestas arcu quis ligula mattis placerat Duis lobortis massa imperdiet quam Suspendisse potenti.</p>" +
                             "<p class='text-muted f-13'>The copy warned the Little Blind Text that where it came from would have rewritten thousand times and everything that was left from its origin would be the word and the Little Blind Text should turn around and return its own, safe country But nothing the copy said could convince.</p>"+
                             "<div class='blog-blockquote-desc mb-5 mt-4'>"+
                            "<blockquote class='blockquote position-relative'>"+
                                "<i class='fas fa-quote-left text-custom'></i>"+
                                "<p class='mb-2 font-italic f-14 text-dark'>It is a paradisematic country in which roasted parts of sentences fly into your mouth Even the all-powerful Pointing has control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name as of Lorem Ipsum decided to leave.</p>"+
                                "<h6 class='mb-0'><a href = '#' class='text-dark'>By : Maude J.McDowell</a></h6>"+
                            "</blockquote></div>",
                    CategoryId=6,
                    Photos="blog-list/img-6.jpg",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
            });

            // Candidate
            _db.Candidates.AddOrUpdate(c => c.Email, new Candidate[] {
                new Candidate{
                    Firstname="Michael",
                    Lastname="Brown",
                    Email="Webthemesltd@gmail.com",
                    Slug="Michael-Brown",
                    BirthDate= new DateTime(1994,01,29),
                    Phone="123 456 7890",
                    Photo="candidates-profile-img.jpg",
                    AboutMe="<p class='text-muted f-14 mb-3'>Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.</p>"+
                             "<p class='text-muted f-14 mb-0'>Libero venenatis faucibus ullam quis ante tiam sit amet orci eget eros faucibus tincidunt ed fringilla mauris sit amet nibh Donec sodales sagittis magna ed consequat leo eget bibendum sodales augue velit cursus nunc quis gravida magna mi libero usce vulputate eleifend sapien estibulum purus qua scelerisque ut mollis sed nonummy id metus ullam accumsan lorem Vivamus elementum semper enean vulputate eleifend tellus enean leo ligula porttitor.</p>",
                    Overview="<p class='text-muted f-14 mb-3'>Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.</p>"+
                                "<p class='text-muted f-14 mb-0'>Sed consequat eget bibendum augue cursus nunc quis gravida magna mi a Itaque earum rerum hic tenetur a sapiente delectus ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat liber fusce vulputate eleifend sapien vestibulum purus quam scelerisque ut mollis sed nonummy id metus nullam accumsan lorem in dui cras ultricies mi eu turpis hendrerit fringilla vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia in dui quis consectetuer lacinia nam pretium turpis arcu duis arcu tortor.</p>",
                    Gender=Gender.Male,
                    MartialStatus=MartialStatus.Single,
                    Country="Turkey",
                    City="Pen Road Manhattan",
                    Address="NY 10016",
                    Website="Www.webthemes.co.in",
                    Amount="$700 - $900",
                    Status=true,
                    Profession="Web Developer"
                },
                new Candidate{
                    Firstname="Mary",
                    Lastname="Mainor",
                    Email="Mainor.ltd@gmail.com",
                    Slug="Mary-Mainor",
                    BirthDate= new DateTime(1994,01,29),
                    Phone="123 456 7890",
                    Photo="candidates/img-1.jpg",
                    AboutMe="<p class='text-muted f-14 mb-3'>Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.</p>"+
                             "<p class='text-muted f-14 mb-0'>Libero venenatis faucibus ullam quis ante tiam sit amet orci eget eros faucibus tincidunt ed fringilla mauris sit amet nibh Donec sodales sagittis magna ed consequat leo eget bibendum sodales augue velit cursus nunc quis gravida magna mi libero usce vulputate eleifend sapien estibulum purus qua scelerisque ut mollis sed nonummy id metus ullam accumsan lorem Vivamus elementum semper enean vulputate eleifend tellus enean leo ligula porttitor.</p>",
                    Overview="<p class='text-muted f-14 mb-3'>Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.</p>"+
                                "<p class='text-muted f-14 mb-0'>Sed consequat eget bibendum augue cursus nunc quis gravida magna mi a Itaque earum rerum hic tenetur a sapiente delectus ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat liber fusce vulputate eleifend sapien vestibulum purus quam scelerisque ut mollis sed nonummy id metus nullam accumsan lorem in dui cras ultricies mi eu turpis hendrerit fringilla vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia in dui quis consectetuer lacinia nam pretium turpis arcu duis arcu tortor.</p>",
                    Gender=Gender.Female,
                    MartialStatus=MartialStatus.Married,
                    Country="Usa",
                    City="Atlanta.",
                    Address="Scenic Way",
                    Website="Www.webthemes.co.in",
                    Amount="$700 - $900",
                    Status=true,
                    Profession="Web Developer"
                },
                new Candidate{
                    Firstname="Jack",
                    Lastname="Hallock",
                    Email="Hallock.ltd@gmail.com",
                    Slug="Jack-Hallock",
                    BirthDate= new DateTime(1994,01,29),
                    Phone="123 456 7890",
                    Photo="candidates/img-2.jpg",
                    AboutMe="<p class='text-muted f-14 mb-3'>Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.</p>"+
                             "<p class='text-muted f-14 mb-0'>Libero venenatis faucibus ullam quis ante tiam sit amet orci eget eros faucibus tincidunt ed fringilla mauris sit amet nibh Donec sodales sagittis magna ed consequat leo eget bibendum sodales augue velit cursus nunc quis gravida magna mi libero usce vulputate eleifend sapien estibulum purus qua scelerisque ut mollis sed nonummy id metus ullam accumsan lorem Vivamus elementum semper enean vulputate eleifend tellus enean leo ligula porttitor.</p>",
                    Overview="<p class='text-muted f-14 mb-3'>Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.</p>"+
                                "<p class='text-muted f-14 mb-0'>Sed consequat eget bibendum augue cursus nunc quis gravida magna mi a Itaque earum rerum hic tenetur a sapiente delectus ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat liber fusce vulputate eleifend sapien vestibulum purus quam scelerisque ut mollis sed nonummy id metus nullam accumsan lorem in dui cras ultricies mi eu turpis hendrerit fringilla vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia in dui quis consectetuer lacinia nam pretium turpis arcu duis arcu tortor.</p>",
                    Gender=Gender.Male,
                    MartialStatus=MartialStatus.Married,
                    Country="Usa",
                    City="Chicago",
                    Address="Parrill",
                    Website="Www.Hallock.co.in",
                    Amount="$500 - $600",
                    Status=true,
                    Profession="Graphic Designer"
                },
                 new Candidate{
                    Firstname="Rodney",
                    Lastname="Wells",
                    Email="Wells.ltd@gmail.com",
                    Slug="Rodney-Wells",
                    BirthDate= new DateTime(1994,01,29),
                    Phone="123 456 7890",
                    Photo="candidates/img-3.jpg",
                    AboutMe="<p class='text-muted f-14 mb-3'>Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.</p>"+
                             "<p class='text-muted f-14 mb-0'>Libero venenatis faucibus ullam quis ante tiam sit amet orci eget eros faucibus tincidunt ed fringilla mauris sit amet nibh Donec sodales sagittis magna ed consequat leo eget bibendum sodales augue velit cursus nunc quis gravida magna mi libero usce vulputate eleifend sapien estibulum purus qua scelerisque ut mollis sed nonummy id metus ullam accumsan lorem Vivamus elementum semper enean vulputate eleifend tellus enean leo ligula porttitor.</p>",
                    Overview="<p class='text-muted f-14 mb-3'>Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.</p>"+
                                "<p class='text-muted f-14 mb-0'>Sed consequat eget bibendum augue cursus nunc quis gravida magna mi a Itaque earum rerum hic tenetur a sapiente delectus ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat liber fusce vulputate eleifend sapien vestibulum purus quam scelerisque ut mollis sed nonummy id metus nullam accumsan lorem in dui cras ultricies mi eu turpis hendrerit fringilla vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia in dui quis consectetuer lacinia nam pretium turpis arcu duis arcu tortor.</p>",
                    Gender=Gender.Male,
                    MartialStatus=MartialStatus.Single,
                    Country="Usa",
                    City="Chicago",
                    Address="Parrill",
                    Website="Www.Wells.co.in",
                    Amount="$1000 - $1200",
                    Status=true,
                    Profession="Web Develope"
                },
                 new Candidate{
                    Firstname="Ruth",
                    Lastname="Miles",
                    Email="Miles.ltd@gmail.com",
                    Slug="Ruth-Miles",
                    BirthDate= new DateTime(1994,01,29),
                    Phone="123 456 7890",
                    Photo="candidates/img-4.jpg",
                    AboutMe="<p class='text-muted f-14 mb-3'>Aliquam erat volutpat Etiam vitae tortor Morbi vestibulum volutpat enim Aliquam nunc Nunc sed turpis sed mollis eros et ultrices tempus mauris ipsum aliquam libero non adipiscing dolor urna a orci Nulla porta dolor. Class aptent taciti sociosqu ad litora torquent per conubia nostra inceptos hymenaeos pellentesque dapibus hendrerit tortor Praesent egestas tristique nibh sed a libero cras us varius donec vitae orci sed dolor rutrum auctor fusce egestas elit eget lorem.</p>"+
                             "<p class='text-muted f-14 mb-0'>Libero venenatis faucibus ullam quis ante tiam sit amet orci eget eros faucibus tincidunt ed fringilla mauris sit amet nibh Donec sodales sagittis magna ed consequat leo eget bibendum sodales augue velit cursus nunc quis gravida magna mi libero usce vulputate eleifend sapien estibulum purus qua scelerisque ut mollis sed nonummy id metus ullam accumsan lorem Vivamus elementum semper enean vulputate eleifend tellus enean leo ligula porttitor.</p>",
                    Overview="<p class='text-muted f-14 mb-3'>Cras dapibus Vivamus elementum semper nisi Aenean vulputate eleifend tellus Aenean leo ligula porttitor eu consequat vitae eleifend ac enim aliquam lorem ante dapibus in viverra quis feugiat a tellus phasellus viverra nulla ut metus variuse laoreet quisque rutrum aenean imperdiet etiam ultricies nisi that is maecenas tempus tini tellus eget condimentum rhoncus sem semper libero sit amet adipiscing sem neque sed ipsum nam quam nunc blandit vel luctus pulvinar hendrerit lorem maecenas nec odio et ante tincidunt tempus donec vitae libero venenatis faucibus nullam quis ante etiam sit amet orci eget eros faucibus tincidunt Duis leo Sed fringilla a mauris sit amet nibh donec sodales sagittis magna vel augue curabitur ullamcorper ultricies nisi nam eget dui etiame rhoncus ut enim as minima veniam quis nostrum exercitationem ullam corporis suscipit laboriosam nisi ut aliquid commodi.</p>"+
                                "<p class='text-muted f-14 mb-0'>Sed consequat eget bibendum augue cursus nunc quis gravida magna mi a Itaque earum rerum hic tenetur a sapiente delectus ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat liber fusce vulputate eleifend sapien vestibulum purus quam scelerisque ut mollis sed nonummy id metus nullam accumsan lorem in dui cras ultricies mi eu turpis hendrerit fringilla vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia in dui quis consectetuer lacinia nam pretium turpis arcu duis arcu tortor.</p>",
                    Gender=Gender.Male,
                    MartialStatus=MartialStatus.Single,
                    Country="Usa",
                    City="Chicago",
                    Address="Parrill",
                    Website="Www.Miles.co.in",
                    Amount="$750 - $950",
                    Status=true,
                    Profession="PHP Develope"
                }
            });

            // Social Links
            _db.SocialLinks.AddOrUpdate(c => c.Name, new SocialLink[] {
                new SocialLink{Name="facebook",OrderBy=1,Status=true},
                new SocialLink{Name="linkedin",OrderBy=2,Status=true},
                new SocialLink{Name="google",OrderBy=3,Status=true},
                new SocialLink{Name="twitter",OrderBy=4,Status=true},
                new SocialLink{Name="instagram",OrderBy=5,Status=true},
            });

            // Candidate Social
            _db.CandidateSocials.AddOrUpdate(c => c.Link, new CandidateSocial[] {
                new CandidateSocial{SocialLinkId=1,CandidateId=1,Link="https://www.facebook.com/"},
                new CandidateSocial{SocialLinkId=2,CandidateId=1,Link="https://www.linkedin.com/feed/"},
                new CandidateSocial{SocialLinkId=3,CandidateId=1,Link="https://mail.google.com/"},
                new CandidateSocial{SocialLinkId=4,CandidateId=1,Link="https://twitter.com/?lang=en"},
                new CandidateSocial{SocialLinkId=5,CandidateId=1,Link="https://www.instagram.com/"},
                new CandidateSocial{SocialLinkId=1,CandidateId=2,Link="https://www.facebook.com/a"},
                new CandidateSocial{SocialLinkId=2,CandidateId=2,Link="https://www.linkedin.com/feed/a"},
                new CandidateSocial{SocialLinkId=3,CandidateId=2,Link="https://mail.google.com/a"},
                new CandidateSocial{SocialLinkId=4,CandidateId=2,Link="https://twitter.com/?lang=en/a"},
                new CandidateSocial{SocialLinkId=5,CandidateId=2,Link="https://www.instagram.com/a"},
                new CandidateSocial{SocialLinkId=1,CandidateId=3,Link="https://www.facebook.com/b"},
                new CandidateSocial{SocialLinkId=2,CandidateId=3,Link="https://www.linkedin.com/feed/b"},
                new CandidateSocial{SocialLinkId=3,CandidateId=3,Link="https://mail.google.com/b"},
                new CandidateSocial{SocialLinkId=4,CandidateId=3,Link="https://twitter.com/?lang=en/b"},
                new CandidateSocial{SocialLinkId=5,CandidateId=3,Link="https://www.instagram.com/b"},
                new CandidateSocial{SocialLinkId=1,CandidateId=4,Link="https://www.facebook.com/c"},
                new CandidateSocial{SocialLinkId=2,CandidateId=4,Link="https://www.linkedin.com/feed/c"},
                new CandidateSocial{SocialLinkId=3,CandidateId=4,Link="https://mail.google.com/c"},
                new CandidateSocial{SocialLinkId=4,CandidateId=4,Link="https://twitter.com/?lang=en/c"},
                new CandidateSocial{SocialLinkId=5,CandidateId=4,Link="https://www.instagram.com/c"},
                new CandidateSocial{SocialLinkId=1,CandidateId=5,Link="https://www.facebook.com/d"},
                new CandidateSocial{SocialLinkId=2,CandidateId=5,Link="https://www.linkedin.com/feed/d"},
                new CandidateSocial{SocialLinkId=3,CandidateId=5,Link="https://mail.google.com/d"},
                new CandidateSocial{SocialLinkId=4,CandidateId=5,Link="https://twitter.com/?lang=en/d"},
                new CandidateSocial{SocialLinkId=5,CandidateId=5,Link="https://www.instagram.com/d"},
            });

            // Blog Review
            _db.BlogReviews.AddOrUpdate(b => b.Text, new BlogReview[] {
                new BlogReview{CandidateId=1,BlogId=1,Text="The Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",Date=DateTime.Now},
                new BlogReview{CandidateId=2,BlogId=2,Text="When she reached the first hills of the Italic Mountains, she had a last view on the skyline her hometown the headline.",Date=DateTime.Now},
                new BlogReview{CandidateId=3,BlogId=1,Text="Similique sunt in culpa qui officia deserunt mollitia animi id est laborum et dolorum fuga et harum quidem rerum.",Date=DateTime.Now},
                new BlogReview{CandidateId=4,BlogId=3,Text="Nam libero tempore, cum soluta nobis est at eligendi optio cumque nihil impedit quo minus id quod maxime placeat.",Date=DateTime.Now},
                new BlogReview{CandidateId=1,BlogId=4,Text="Nam Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",Date=DateTime.Now},
                new BlogReview{CandidateId=2,BlogId=4,Text="Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",Date=DateTime.Now},
                new BlogReview{CandidateId=5,BlogId=4,Text="advised Big Oxmox advised her not to do so, because there were thousands of bad a Commas wild Question Marks and devious Semikoli.",Date=DateTime.Now},
            });

            // Education Level
            _db.JobEduLevels.AddOrUpdate(j => j.Name, new JobEduLevel[] {
                new JobEduLevel{ Name="Level-1",Status=true},
                new JobEduLevel{ Name="Level-2",Status=true},
                new JobEduLevel{ Name="Level-3",Status=true},
                new JobEduLevel{ Name="Level-4",Status=true},
            });

            // Education
            _db.Educations.AddOrUpdate(e => e.EduAddition, new Education[] {
                new Education{
                    University ="UNIVERSITY OF USA",
                    CourseTitle ="Diploma In Management Studies",
                    EduAddition="Suspendisse faucibus et pellentesque egestas lacus ante convallis.",
                    JobEduLevelId=1,
                    BeginDate=new DateTime(2015,06,01),
                    FinalDate=new DateTime(2019,06,01),
                    CandidateId=1
                },
                 new Education{
                    University ="UNIVERSITY OF USA",
                    CourseTitle ="Diploma In Management",
                    EduAddition="Sucibus et pellentesque egestas lacus ante convallis.",
                    JobEduLevelId=2,
                    BeginDate=new DateTime(2014,06,01),
                    FinalDate=new DateTime(2018,06,01),
                    CandidateId=1
                },
                 new Education{
                    University ="UNIVERSITY OF USA",
                    CourseTitle ="Management Of Company",
                    EduAddition="pellentesque egestas lacus ante convallis.",
                    JobEduLevelId=3,
                    BeginDate=new DateTime(2013,06,01),
                    FinalDate=new DateTime(2017,06,01),
                    CandidateId=1
                }
            });

            // Employer
            _db.Employers.AddOrUpdate(e => e.Slug, new Employer[] {
                new Employer{
                    Firstname="Kyle",
                    Lastname="Jones",
                    Slug="Kyle-Jones",
                    Address="419 Lakeland Terrace Detroit, MI 48226",
                    Rate=4,
                    Photo="employers/img-1.jpg",
                    isVerified=true,
                    CompanyAdress="4102 Aviation Way Los Angeles, CA 90017",
                    CompanyEmail="Themescodeltd2018@gmail.com",
                    CompanyName="Themes code Pvt.Ltd",
                    CompanyPhone="123 456 7890",
                    CompanyWebsite="Themescodeltd.co.in",
                    Type="Create Website",
                    ExperienceDate="4 Years",
                    Empl0yers=5540,
                    minSalary= 700,
                    maxSalary=1200,
                    Followers=584230 ,
                    Overview="<p class='text-muted f-14 mb-3'>At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.</p>"+
                               "<p class='text-muted f-14 mb-3'>Nobis est eligendi optio cumque nihil impedit quo minus quod maxime at placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam eligendi optio cumque nihil impedit quo minus quod maxime placeat voluptatem quia that voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec this pellentesque eu pretium quis sem hasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdie tiam ultricies nisi vel augue.</p>"+
                               "<p class='text-muted f-14 mb-0'>Optio cumque nihil impedit quo minus quod maxime at placeate facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit um sociis natoque penatibus magnis dis parturient montes nascetur at ridiculus mus onec quam felis ultricies nec nihil impedit quo minus quod maxime at placeat facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet tiam ultricies nisi vel augue Donec elit libero sodales nec volutpat a suscipit non turpis ullam sagittis Suspendisse pulvinar at augue ac venenatis condimentum sem libero volutpat nibh nec pellentesque velit pede quis nunc estibulum ante ipsum primis in faucibus orci luctus et ultrices as cubilia Curae usce id purus varius tincidunt libero Phasellus dolor.</p>",
                    Services=
                        "<p class='text-muted f-14 mb-3'>Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.</p>"+
                        "<h4 class='text-dark'>Details</h4>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Praesent congue erat at massa Sed cursus turpis vitae tortor onec posuere vulputate arcu.</p></div>",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Employer{
                    Firstname="Susan",
                    Lastname="Roth",
                    Slug="Susan-Roth",
                    Address="19 Lakeland Terrace Detroit, MI 48226",
                    Rate=3,
                    Photo="employers/img-2.jpg",
                    isVerified=true,
                    CompanyAdress="Way Los Angeles, CA 90017",
                    CompanyEmail="Susan@gmail.com",
                    CompanyName="Susan code Pvt.Ltd",
                    CompanyPhone="123 456 7890",
                    CompanyWebsite="Susan.co.in",
                    Type="Create Website",
                    ExperienceDate="3 Years",
                    Empl0yers=5540,
                    minSalary= 700,
                    maxSalary=1200,
                    Followers=584230 ,
                    Overview="<p class='text-muted f-14 mb-3'>At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.</p>"+
                               "<p class='text-muted f-14 mb-3'>Nobis est eligendi optio cumque nihil impedit quo minus quod maxime at placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam eligendi optio cumque nihil impedit quo minus quod maxime placeat voluptatem quia that voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec this pellentesque eu pretium quis sem hasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdie tiam ultricies nisi vel augue.</p>"+
                               "<p class='text-muted f-14 mb-0'>Optio cumque nihil impedit quo minus quod maxime at placeate facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit um sociis natoque penatibus magnis dis parturient montes nascetur at ridiculus mus onec quam felis ultricies nec nihil impedit quo minus quod maxime at placeat facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet tiam ultricies nisi vel augue Donec elit libero sodales nec volutpat a suscipit non turpis ullam sagittis Suspendisse pulvinar at augue ac venenatis condimentum sem libero volutpat nibh nec pellentesque velit pede quis nunc estibulum ante ipsum primis in faucibus orci luctus et ultrices as cubilia Curae usce id purus varius tincidunt libero Phasellus dolor.</p>",
                    Services=
                        "<p class='text-muted f-14 mb-3'>Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.</p>"+
                        "<h4 class='text-dark'>Details</h4>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Praesent congue erat at massa Sed cursus turpis vitae tortor onec posuere vulputate arcu.</p></div>",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Employer{
                    Firstname="Rickyh",
                    Lastname="Cash",
                    Slug="Ricky Cash",
                    Address="Detroit, MI 48226",
                    Rate=5,
                    Photo="employers/img-3.jpg",
                    isVerified=true,
                    CompanyAdress="Los Angeles, CA 90017",
                    CompanyEmail="Ricky@gmail.com",
                    CompanyName="Ricky code Pvt.Ltd",
                    CompanyPhone="123 456 7890",
                    CompanyWebsite="Ricky.co.in",
                    Type="Create Website",
                    ExperienceDate="6 Years",
                    Empl0yers=5540,
                    minSalary= 700,
                    maxSalary=1200,
                    Followers=584230 ,
                    Overview="<p class='text-muted f-14 mb-3'>At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.</p>"+
                               "<p class='text-muted f-14 mb-3'>Nobis est eligendi optio cumque nihil impedit quo minus quod maxime at placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam eligendi optio cumque nihil impedit quo minus quod maxime placeat voluptatem quia that voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec this pellentesque eu pretium quis sem hasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdie tiam ultricies nisi vel augue.</p>"+
                               "<p class='text-muted f-14 mb-0'>Optio cumque nihil impedit quo minus quod maxime at placeate facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit um sociis natoque penatibus magnis dis parturient montes nascetur at ridiculus mus onec quam felis ultricies nec nihil impedit quo minus quod maxime at placeat facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet tiam ultricies nisi vel augue Donec elit libero sodales nec volutpat a suscipit non turpis ullam sagittis Suspendisse pulvinar at augue ac venenatis condimentum sem libero volutpat nibh nec pellentesque velit pede quis nunc estibulum ante ipsum primis in faucibus orci luctus et ultrices as cubilia Curae usce id purus varius tincidunt libero Phasellus dolor.</p>",
                    Services=
                        "<p class='text-muted f-14 mb-3'>Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.</p>"+
                        "<h4 class='text-dark'>Details</h4>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Praesent congue erat at massa Sed cursus turpis vitae tortor onec posuere vulputate arcu.</p></div>",
                    CreatedAt=DateTime.Now,
                    Status=true
                },
                new Employer{
                    Firstname="Kelly",
                    Lastname="Perez",
                    Slug="Kelly Perez",
                    Address="Detroit, MI 48226",
                    Rate=5,
                    Photo="employers/img-4.jpg",
                    isVerified=true,
                    CompanyAdress="Angeles, CA 90017",
                    CompanyEmail="Perez@gmail.com",
                    CompanyName="Perez code Pvt.Ltd",
                    CompanyPhone="123 456 7890",
                    CompanyWebsite="Perez.co.in",
                    Type="Create Website",
                    ExperienceDate="4 Years",
                    Empl0yers=5540,
                    minSalary= 700,
                    maxSalary=1200,
                    Followers=584230 ,
                    Overview="<p class='text-muted f-14 mb-3'>At vero eos accusamus iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti that is atque corrupti dolores et quas molestias excepturi sint occaecati cupiditate non at provident similique sunt in culpa qui officia deserunt mollitia animi id est laboru at dolorum fuga Nam libero tempore cum soluta nobis est eligendi optio cumque nihil impedit quo minus quod maxime placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes nascetur ridiculus mus donec quam felis ultricies nec pellentesque eu pretium quis sem that phasellus viverra nulla ut metus varius laoreet.</p>"+
                               "<p class='text-muted f-14 mb-3'>Nobis est eligendi optio cumque nihil impedit quo minus quod maxime at placeat facere possimus omnis voluptas assumenda est omnis dolor repellendus at enim ipsam eligendi optio cumque nihil impedit quo minus quod maxime placeat voluptatem quia that voluptas aut odit aut fugit Cum sociis natoque penatibus magnis dis parturient montes, nascetur ridiculus mus.Donec quam felis, ultricies nec this pellentesque eu pretium quis sem hasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdie tiam ultricies nisi vel augue.</p>"+
                               "<p class='text-muted f-14 mb-0'>Optio cumque nihil impedit quo minus quod maxime at placeate facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enim ipsam voluptatem quia voluptas aut odit aut fugit um sociis natoque penatibus magnis dis parturient montes nascetur at ridiculus mus onec quam felis ultricies nec nihil impedit quo minus quod maxime at placeat facere possimuse omnis voluptas assumenda est omnis dolor repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet tiam ultricies nisi vel augue Donec elit libero sodales nec volutpat a suscipit non turpis ullam sagittis Suspendisse pulvinar at augue ac venenatis condimentum sem libero volutpat nibh nec pellentesque velit pede quis nunc estibulum ante ipsum primis in faucibus orci luctus et ultrices as cubilia Curae usce id purus varius tincidunt libero Phasellus dolor.</p>",
                    Services=
                        "<p class='text-muted f-14 mb-3'>Aenean tellus metus bibendum sed posuere ac mattis non nunc estibulum fringilla pede sit amet augue n turpis Pellentesque posuere raesent turpis enean posuere tortor sed cursus feugiat nunc augue blandit nunc sollicitudin at dolor sagittis lacus estibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Sed aliquam nisi quis porttitor congue elit erat euismod orci ac placerat dolor lectus quis orci repellendus at enime pellentesque eu pretium quis sem Phasellus viverra nulla hasellus consectetuer vestibulum elit.</p>"+
                        "<h4 class='text-dark'>Details</h4>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Morbi mattis ullamcorper velit hasellus gravida semper nisi nullam vel sem.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Phasellus viverra nulla ut metus varius laoreet uisque rutrum enean imperdiet.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Etiam ultricies nisi vel augue Curabitur ullamcorper ultricies nisi am eget dui tiam rhoncus.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Donec mollis hendrerit risus hasellus nec sem in justo pellentesque facilisis.</p></div>"+
                        "<div class='job-details-desc-item'><div class='float-left mr-3'><i class='mdi mdi-minus text-muted f-16'></i></div><p class='text-muted f-14 mb-2'>Praesent congue erat at massa Sed cursus turpis vitae tortor onec posuere vulputate arcu.</p></div>",
                    CreatedAt=DateTime.Now,
                    Status=true
                }
            });

            // Employer Category
            _db.EmployerCategories.AddOrUpdate(e => e.EmployerId, new EmployerCategory[] {
                new EmployerCategory{ CategoryId=1,EmployerId=1},
                new EmployerCategory{ CategoryId=2,EmployerId=2},
                new EmployerCategory{ CategoryId=3,EmployerId=3},
                new EmployerCategory{ CategoryId=4,EmployerId=4}
            });

            // EmployerReview
            _db.EmployerReviews.AddOrUpdate(e => e.Text, new EmployerReview[] {
                new EmployerReview{CandidateId=1,EmployerId=1,Text="Phasellus viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui.",Date=DateTime.Now},
                new EmployerReview{CandidateId=2,EmployerId=1,Text="viverra nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui.",Date=DateTime.Now},
                new EmployerReview{CandidateId=3,EmployerId=1,Text="nulla ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui.",Date=DateTime.Now},
                new EmployerReview{CandidateId=1,EmployerId=2,Text="ut metus varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui.",Date=DateTime.Now},
                new EmployerReview{CandidateId=1,EmployerId=3,Text=" varius laoreet quisque rutrum aenean imperdiet etiam ultricies nisi avel augue curabitur ullamcorper ultricies nisi nam eget dui.",Date=DateTime.Now},

            });

            // Experience
            _db.Experiences.AddOrUpdate(e => e.Website, new Experience[] {
                new Experience{
                    Company ="Web Themes Pvt.Ltd",
                    JobCategoryId=1,
                    BeginDate=new DateTime(2016,01,01),
                    FinalDate=new DateTime(2017,12,01),
                    Website="www.webthemesltd.co.in",
                    Address="1919 Ward Road West Nyack, NY",
                    CandidateId=1
                },
                new Experience{
                    Company ="Web Themes Pvt.Ltd",
                    JobCategoryId=2,
                    BeginDate=new DateTime(2016,01,01),
                    FinalDate=new DateTime(2017,12,01),
                    Website="www.ebthemesltd.co.in",
                    Address="Road West Nyack, NY",
                    CandidateId=1
                },
                new Experience{
                    Company ="Web Themes Pvt.Ltd",
                    JobCategoryId=3,
                    BeginDate=new DateTime(2016,01,01),
                    FinalDate=new DateTime(2017,12,01),
                    Website="www.bthemesltd.co.in",
                    Address=" Ward Road West Nyack, NY",
                    CandidateId=1
                },
                new Experience{
                    Company ="Web Themes Pvt.Ltd",
                    JobCategoryId=1,
                    BeginDate=new DateTime(2016,01,01),
                    FinalDate=new DateTime(2017,12,01),
                    Website="www.wthemesltd.co.in",
                    Address="Nyack, NY",
                    CandidateId=1
                },
            });

            // Faq
            _db.Faqs.AddOrUpdate(e => e.Question, new Faq[] {
                new Faq{
                    Question="Ut feugiat eleifend metus ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.General,
                    Status=true
                },
                new Faq{
                    Question="feugiat eleifend metus ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.General,
                    Status=true
                },
                new Faq{
                    Question="eleifend metus ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.General,
                    Status=true
                },
                new Faq{
                    Question="Ut eleifend metus ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.Career,
                    Status=true
                },
                new Faq{
                    Question="Ut feugiat metus ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.Career,
                    Status=true
                },
                new Faq{
                    Question="Ut feugiat eleifend ?",
                    Answer="Temporibus autem quibusdam aut officiis debitis aut rerum necessitatibus saepe eveniet voluptates repudiandae sint et molestiae non recusandae that Itaque earum rerum sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis was doloribus asperiores repellat sed ut perspiciatis unde omnis iste natus error at accusantium doloremque laudantium totam rem aperiam eaque ipsa quae ab.",
                    OrderBy=1,
                    CategoryFaq=CategoryFaq.Career,
                    Status=true
                },

            });

            // How It Work
            _db.HowItWorks.AddOrUpdate(e => e.OrderBy, new HowItWork[] {
                new HowItWork{
                    Content="Donec pede justo fringilla vel aliquet nec vulputate eget arcu. In enim justo rhoncus ut a, venenatis vitae justo.",
                    OrderBy=1,
                    Status=true,
                    Title="Register an account",
                    Photo="how-it-work/img-1.png"
                },
                new HowItWork{
                    Content="Donec pede justo fringilla vel aliquet nec vulputate eget arcu. In enim justo rhoncus ut a, venenatis vitae justo.",
                    OrderBy=2,
                    Status=true,
                    Title="Search your job",
                    Photo="how-it-work/img-2.png"
                },
                new HowItWork{
                    Content="Donec pede justo fringilla vel aliquet nec vulputate eget arcu. In enim justo rhoncus ut a, venenatis vitae justo.",
                    OrderBy=3,
                    Status=true,
                    Title="Apply for job",
                    Photo="how-it-work/img-3.png"
                }
            });

            // Job
            _db.Jobs.AddOrUpdate(j => j.Email, new Job[] {
                new Job{
                    Title="Neque porro quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Slug="Web-Themes-pvt-Ltd",
                    CategoryId=1,
                    JobEduLevellId=1,
                    JobExpYear=JobExpYear.Two,
                    JobType=JobType.Fulltime,
                    Gender=Gender.Male,
                    Shift=Shift.Evening,
                    Address="659 Meadowcrest Lane Lexington, KY 40507",
                    MinSalary=700,
                    MaxSalary=800,
                    WebSite="https://www.WebTheme.com",
                    CompanyName="Web Themes.pvt.Ltd",
                    Phone="1987 6543 21",
                    Email="Webthemescom@gmail",
                    Desc="<p class='text-muted f-14 mb-3'>Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.</p>"+
                        "<p class='text-muted f-14 mb-0'>Itaque earum rerum hic tenetur sapiente delectus aut reiciendis voluptatibus maiores that alias consequatur aut perferendis doloribus asperiores repellat Sed ut perspiciatis unde omnis iste sit at natus error sit voluptatem accusantium doloremque laudantium niti totame rem aperiam eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>",
                    Photo="featured-job/img-1.png",
                    CreatedAt=DateTime.Now,
                    Hours="9AM - 7PM | 9AM - 7PM | 9AM - 7PM | 9AM - 7PM |9AM - 7PM | 6:30AM - 1PM | Closed"
                },
                new Job{
                    Title="quisquam est qui dolorem ipsum dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Slug="Web-Themes-pvt",
                    CategoryId=2,
                    JobEduLevellId=1,
                    JobExpYear=JobExpYear.Two,
                    JobType=JobType.Fulltime,
                    Gender=Gender.Male,
                    Shift=Shift.Evening,
                    Address="501 Ripple Street Saginaw, MI 48601",
                    MinSalary=700,
                    MaxSalary=800,
                    WebSite="https://www.WebTheme.com",
                    CompanyName="Web Themes.pvt.Ltd",
                    Phone="1987 6543 21",
                    Email="themescom@gmail",
                    Desc="<p class='text-muted f-14 mb-3'>Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.</p>"+
                        "<p class='text-muted f-14 mb-0'>Itaque earum rerum hic tenetur sapiente delectus aut reiciendis voluptatibus maiores that alias consequatur aut perferendis doloribus asperiores repellat Sed ut perspiciatis unde omnis iste sit at natus error sit voluptatem accusantium doloremque laudantium niti totame rem aperiam eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>",
                    Photo="featured-job/img-2.png",
                    CreatedAt=DateTime.Now,
                    Hours="9AM - 7PM | 9AM - 7PM | 9AM - 7PM | 9AM - 7PM |9AM - 7PM | 6:30AM - 1PM | Closed"
                },
                new Job{
                    Title="dolor sit amet consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Slug="Web-Themes",
                    CategoryId=3,
                    JobEduLevellId=1,
                    JobExpYear=JobExpYear.Two,
                    JobType=JobType.Fulltime,
                    Gender=Gender.Male,
                    Shift=Shift.Evening,
                    Address="501 Ripple Street Saginaw, MI 48601",
                    MinSalary=600,
                    MaxSalary=800,
                    WebSite="https://www.WebTheme.com",
                    CompanyName="Web Themes.pvt",
                    Phone="1987 6543 21",
                    Email="hemescom@gmail",
                    Desc="<p class='text-muted f-14 mb-3'>Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.</p>"+
                        "<p class='text-muted f-14 mb-0'>Itaque earum rerum hic tenetur sapiente delectus aut reiciendis voluptatibus maiores that alias consequatur aut perferendis doloribus asperiores repellat Sed ut perspiciatis unde omnis iste sit at natus error sit voluptatem accusantium doloremque laudantium niti totame rem aperiam eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>",
                    Photo="featured-job/img-4.png",
                    CreatedAt=DateTime.Now,
                    Hours="9AM - 7PM | 9AM - 7PM | 9AM - 7PM | 9AM - 7PM |9AM - 7PM | 6:30AM - 1PM | Closed"
                },
                new Job{
                    Title="consectetur adipisci velit a quia non eius modi tempora incidunt ut labore dolore magnam aliquam quaerat voluptatem Nemo enim ipsam voluptatem quia voluptas sit aspernatur odit aut fugit sed quia consequuntur magni dolores eose.",
                    Slug="Web-Theme-pvt",
                    CategoryId=2,
                    JobEduLevellId=1,
                    JobExpYear=JobExpYear.Two,
                    JobType=JobType.Fulltime,
                    Gender=Gender.Male,
                    Shift=Shift.Evening,
                    Address="Saginaw, MI 48601",
                    MinSalary=500,
                    MaxSalary=800,
                    WebSite="https://www.WebTheme.com",
                    CompanyName="Web Themes",
                    Phone="1987 6543 21",
                    Email="mescom@gmail",
                    Desc="<p class='text-muted f-14 mb-3'>Quis autem vel eum iure reprehenderit qui in ea voluptate velite esse quam nihil molestiae consequatur vel illum qui dolorem eum fugiat at quo voluptas nulla pariatur vero eos accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias at excepturi sint that occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est Quis autem vel eum iure reprehenderit qui in ea that voluptate esse quam nihil molestiae consequatur vel qui dolorem eum fugiat quo voluptas nulla by the pariatur laborum At vero eos et accusamus et iusto odio dignissimos ducimus blanditiis praesentium voluptatum deleniti atque corrupti quos dolores quas molestias excepturi sint occaecati cupiditate non provident et dolorum fuga.</p>"+
                        "<p class='text-muted f-14 mb-0'>Itaque earum rerum hic tenetur sapiente delectus aut reiciendis voluptatibus maiores that alias consequatur aut perferendis doloribus asperiores repellat Sed ut perspiciatis unde omnis iste sit at natus error sit voluptatem accusantium doloremque laudantium niti totame rem aperiam eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.</p>",
                    Photo="featured-job/img-3.png",
                    CreatedAt=DateTime.Now,
                    Hours="9AM - 7PM | 9AM - 7PM | 9AM - 7PM | 9AM - 7PM |9AM - 7PM | 6:30AM - 1PM | Closed"
                }
            });

            // Qualification
            _db.Qualifications.AddOrUpdate(q => q.Content, new Qualification[] {
                new Qualification{Content="Morbi mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.",Status=true,JobId=1},
                new Qualification{Content="Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet.",Status=true,JobId=1},
                new Qualification{Content="Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus..",Status=true,JobId=1},
                new Qualification{Content="Donec mollis hendrerit risus. Phasellus nec sem in justo pellentesque facilisis.",Status=true,JobId=1},
                new Qualification{Content="mattis ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.",Status=true,JobId=1},
                new Qualification{Content="ullamcorper velit. Phasellus gravida semper nisi nullam vel sem.",Status=true,JobId=1},
                new Qualification{Content="velit. Phasellus gravida semper nisi nullam vel sem.",Status=true,JobId=1},
                new Qualification{Content="gravida semper nisi nullam vel sem.",Status=true,JobId=1},
            });

            // Responsibility
            _db.Responsibilities.AddOrUpdate(r => r.Content, new Responsibility[] {
                new Responsibility{ Content="HTML, CSS & Scss",Status=true,JobId=1},
                new Responsibility{ Content="Javascript",Status=true,JobId=1},
                new Responsibility{ Content="PHP",Status=true,JobId=1},
                new Responsibility{ Content="Photoshop",Status=true,JobId=1},
                new Responsibility{ Content="Illustrator",Status=true,JobId=1},
                new Responsibility{ Content="HTML, CSS",Status=true,JobId=2},
            }) ;

            //Partner
            _db.Partners.AddOrUpdate(p=>p.Name,new Partner[] {
                new Partner{Name="Cofee",Photo="clients/1.png",OrderBy=1,Status=true},
                new Partner{Name="Fisherman",Photo="clients/2.png",OrderBy=2,Status=true},
                new Partner{Name="Mountain",Photo="clients/3.png",OrderBy=3,Status=true},
                new Partner{Name="Monntain",Photo="clients/4.png",OrderBy=4,Status=true}
            });

            //Pricing
            _db.Pricings.AddOrUpdate(p=>p.Name,new Pricing[] {
                new Pricing{Name="FREE",Amount=0,Bandwidth=1,Onlinespace=50,Domain=5,Fees=true,Support=false, OrderBy=1,Status=true},
                new Pricing{Name="ECONOMY",Amount=70,Bandwidth=1,Onlinespace=50,Domain=10,Fees=false,Support=false, OrderBy=2,Status=true},
                new Pricing{Name="DELUXE",Amount=95,Bandwidth=2,Onlinespace=50,Domain=15,Fees=true,Support=false, OrderBy=3,Status=true},
            });

            //Service
            _db.Services.AddOrUpdate(s => s.Title, new Service[] {
                new Service{Title="Awesome Support",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="account",OrderBy=1,Status=true},
                new Service{Title="Goal Business",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="image-filter-tilt-shift",OrderBy=2,Status=true},
                new Service{Title="Branding Identity",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="ungroup",OrderBy=3,Status=true},
                new Service{Title="Solutions Business",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="invert-colors",OrderBy=4,Status=true},
                new Service{Title="Digital Design",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="monitor",OrderBy=5,Status=true},
                new Service{Title="Dynamic Growth",Content="Aenean leo ligula porttitor eu consequat vitae eleifend enim liquam lorem ante dapibus in viverra feugia hasellus viverra at metus.",Icon="image-filter-center-focus",OrderBy=6,Status=true},
            });

            // Setting
            _db.Settings.AddOrUpdate(s => s.LogoName, new Setting[] {
                new Setting{
                    Logo ="logo-light.png",
                    LogoName="Joobsy",
                    Adress="2453 Clinton StreetLittle Rock, AR 72211",
                    Email="Support@mail.com",
                    HomeTitle="Find your New Job Easiest Way With Joobsy",
                    Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium"
                }
            });

            // SettingSocial
            _db.SettingSocials.AddOrUpdate(s => s.Link, new SettingSocial[] {
                new SettingSocial{ SettingId=1, SocialLinkId=1, Link="https://www.facebook.com/"},
                new SettingSocial{ SettingId=1, SocialLinkId=2, Link="https://www.linkedin.com/feed/"},
                new SettingSocial{ SettingId=1, SocialLinkId=3, Link="https://mail.google.com/"},
                new SettingSocial{ SettingId=1, SocialLinkId=4, Link="https://twitter.com/?lang=en"},
                new SettingSocial{ SettingId=1, SocialLinkId=5, Link="https://www.instagram.com/"},
            });

            // Skill
            _db.Skills.AddOrUpdate(s => s.Name, new Skill[] {
                new Skill{ CandidateId=1, Name="HTML/CSS", Degree =80},
                new Skill{ CandidateId=1, Name="Javascript", Degree =65},
                new Skill{ CandidateId=1, Name="PHP", Degree =75},
                new Skill{ CandidateId=1, Name="Photoshop", Degree =90}
            });

            // Team
            _db.Teams.AddOrUpdate(t => t.Slug, new Team[] {
                new Team{
                    Firstname ="Stormy",
                    Lastname="Bush",
                    Slug="Stormy-Bush",
                    CategoryId=1,
                    Photo="candidates/img-1.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=1,
                    Status=true
                },
                new Team{
                    Firstname ="Darryl",
                    Lastname="Abell",
                    Slug="Darryl-Abell",
                    CategoryId=1,
                    Photo="candidates/img-2.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=2,
                    Status=true
                },
                new Team{
                    Firstname ="Roger",
                    Lastname="Utz",
                    Slug="Roger-Utz",
                    CategoryId=1,
                    Photo="candidates/img-3.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=3,
                    Status=true
                },
                new Team{
                    Firstname ="Mark",
                    Lastname="Mitchell",
                    Slug="Mark-Mitchell",
                    CategoryId=3,
                    Photo="candidates/img-4.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=4,
                    Status=true
                },
                new Team{
                    Firstname ="Juan",
                    Lastname="Bluford",
                    Slug="Juan-Bluford",
                    CategoryId=2,
                    Photo="candidates/img-5.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=5,
                    Status=true
                },
                new Team{
                    Firstname ="Robin",
                    Lastname="Douglas",
                    Slug="Robin-Douglas",
                    CategoryId=4,
                    Photo="candidates/img-6.jpg",
                    ShortInfo="Maecenas tellus eget condimentum sem quam semper.",
                    OrderBy=6,
                    Status=true
                },
            });

            // Team Social
            _db.TeamSocial.AddOrUpdate(t=>t.Link,new TeamSocial[] {
                new TeamSocial{Link="https://www.facebook.com/", SocialId=1, TeamId=1},
                new TeamSocial{Link="https://www.linkedin.com/feed/", SocialId=2, TeamId=1},
                new TeamSocial{Link="https://mail.google.com/", SocialId=3, TeamId=1},
                new TeamSocial{Link="https://twitter.com/?lang=en", SocialId=4, TeamId=1},
                new TeamSocial{Link="https://www.instagram.com/", SocialId=5, TeamId=1},
            });

            // Company Photo
            _db.CompanyPhoto.AddOrUpdate(c => c.Photo, new CompanyPhoto[] {
                new CompanyPhoto{ EmployerId=1, Photo="blog-post/img-7.jpg"},
                new CompanyPhoto{ EmployerId=1, Photo="blog-post/img-2.jpg"},
                new CompanyPhoto{ EmployerId=1, Photo="blog-post/img-9.jpg"},
                new CompanyPhoto{ EmployerId=2, Photo="blog-post/img-10.jpg"},
                new CompanyPhoto{ EmployerId=2, Photo="blog-post/img-1.jpg"},
                new CompanyPhoto{ EmployerId=3, Photo="blog-post/img-8.jpg"},
                new CompanyPhoto{ EmployerId=3, Photo="blog-post/img-3.jpg"},
                new CompanyPhoto{ EmployerId=4, Photo="blog-post/img-4.jpg"},
                new CompanyPhoto{ EmployerId=4, Photo="blog-post/img-5.jpg"},
                new CompanyPhoto{ EmployerId=4, Photo="blog-post/img-6.jpg"}
            });

            // HeaderSetting
            _db.HeaderSetting.AddOrUpdate(h => h.Page, new HeaderSetting[] {
                new HeaderSetting{Page=Page.Home,Photo="bg-home.jpg"},
                new HeaderSetting{Page=Page.JobGrid,Photo="bg-page-header.jpg"},
                new HeaderSetting{Page=Page.JobDetail,Photo="job-details-bg.jpg"},
                new HeaderSetting{Page=Page.JobPost,Photo="post-a-job-bg.jpg"},
                new HeaderSetting{Page=Page.CandidateList,Photo="candidates-profile-bg.jpg"},
                new HeaderSetting{Page=Page.CandidateDetail,Photo="job-details-bg.jpg"},
                new HeaderSetting{Page=Page.CandidateResume,Photo="create-resume-bg.jpg"},
                new HeaderSetting{Page=Page.EmployerList,Photo="employers-list-bg.jpg"},
                new HeaderSetting{Page=Page.EmlpoyerDetail,Photo="employers-details-bg.jpg"},
                new HeaderSetting{Page=Page.BlogList,Photo="blog-list-bg.jpg"},
                new HeaderSetting{Page=Page.BlogDetail,Photo="blog-details-bg.jpg"},
                new HeaderSetting{Page=Page.AboutUs,Photo="about-bg.jpg"},
                new HeaderSetting{Page=Page.Service,Photo="services-bg.jpg"},
                new HeaderSetting{Page=Page.Faq,Photo="faq-bg.jpg"},
                new HeaderSetting{Page=Page.Pricing,Photo="pricing-bg.jpg"},
                new HeaderSetting{Page=Page.Team,Photo="cta-bg.jpg"},
                new HeaderSetting{Page=Page.Contact,Photo="contact-bg.jpg"}
            });
            _db.SaveChanges();
        }
    }
}
