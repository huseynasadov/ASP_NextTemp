namespace ASPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        BlogId = c.Int(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        Photos = c.String(maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false, storeType: "date"),
                        CategoryId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.JobCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        CountryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        JobEduLevellId = c.Int(nullable: false),
                        JobExpYear = c.Int(nullable: false),
                        JobType = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Shift = c.Int(nullable: false),
                        City = c.String(nullable: false, maxLength: 80),
                        Street = c.String(nullable: false, maxLength: 80),
                        MinSalary = c.Decimal(precision: 18, scale: 2),
                        MaxSalary = c.Decimal(precision: 18, scale: 2),
                        WebSiteLink = c.String(maxLength: 200),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 13),
                        Desc = c.String(nullable: false, storeType: "ntext"),
                        Qualification = c.String(maxLength: 100),
                        Responsibilities = c.String(maxLength: 100),
                        Photo = c.String(maxLength: 250),
                        CreatedAt = c.DateTime(nullable: false),
                        Hours = c.String(),
                        Status = c.Boolean(nullable: false),
                        JobEduLevel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobCategories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.JobEduLevels", t => t.JobEduLevel_Id)
                .Index(t => t.CountryId)
                .Index(t => t.CategoryId)
                .Index(t => t.JobEduLevel_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobEduLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false, storeType: "date"),
                        Photo = c.String(maxLength: 250),
                        AboutMe = c.String(storeType: "ntext"),
                        Overview = c.String(storeType: "ntext"),
                        Profession = c.String(maxLength: 50),
                        Gender = c.Int(nullable: false),
                        MartialStatus = c.Int(nullable: false),
                        CountryId = c.Int(),
                        City = c.String(maxLength: 20),
                        Phone = c.String(),
                        Website = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Amount = c.String(),
                        Status = c.Boolean(nullable: false),
                        JobEduLevel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.JobEduLevels", t => t.JobEduLevel_Id)
                .Index(t => t.CountryId)
                .Index(t => t.JobEduLevel_Id);
            
            CreateTable(
                "dbo.CandidateSocials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialLinkId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.SocialLinks", t => t.SocialLinkId, cascadeDelete: true)
                .Index(t => t.SocialLinkId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.SocialLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Graduation = c.String(maxLength: 50),
                        University = c.String(maxLength: 50),
                        Degree = c.String(maxLength: 50),
                        CourseTitle = c.String(maxLength: 50),
                        EduAddition = c.String(maxLength: 50),
                        JobEduLevelId = c.Int(),
                        BeginDate = c.DateTime(nullable: false, storeType: "date"),
                        FinalDate = c.DateTime(nullable: false, storeType: "date"),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.JobEduLevels", t => t.JobEduLevelId)
                .Index(t => t.JobEduLevelId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(maxLength: 50),
                        JobCategoryId = c.Int(nullable: false),
                        BeginDate = c.DateTime(nullable: false, storeType: "date"),
                        FinalDate = c.DateTime(nullable: false, storeType: "date"),
                        Website = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.JobCategories", t => t.JobCategoryId, cascadeDelete: true)
                .Index(t => t.JobCategoryId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Degree = c.Int(),
                        CandidateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.CareerAdvices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Content = c.String(nullable: false, maxLength: 250),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Photo = c.String(maxLength: 250),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 250),
                        EmployerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.EmployerId);
            
            CreateTable(
                "dbo.Employers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 150),
                        Rate = c.Int(),
                        Photo = c.String(maxLength: 250),
                        isVerified = c.Boolean(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 150),
                        CompanyAdress = c.String(nullable: false, maxLength: 150),
                        CompanyPhone = c.String(nullable: false, maxLength: 150),
                        CompanyWebsite = c.String(maxLength: 150),
                        CompanyEmail = c.String(nullable: false),
                        Empl0yers = c.Int(),
                        Type = c.String(),
                        ExperienceDate = c.String(),
                        minSalary = c.Int(),
                        maxSalary = c.Int(),
                        Followers = c.Int(nullable: false),
                        Overview = c.String(storeType: "ntext"),
                        Services = c.String(storeType: "ntext"),
                        CreatedAt = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployerCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        EmployerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobCategories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.EmployerId);
            
            CreateTable(
                "dbo.EmployerReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployerId = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        Text = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidateId, cascadeDelete: true)
                .ForeignKey("dbo.Employers", t => t.EmployerId, cascadeDelete: true)
                .Index(t => t.EmployerId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Faqs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        Answer = c.String(),
                        Status = c.Boolean(nullable: false),
                        OrderBy = c.Int(),
                        CategoryFaq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HowItWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false, maxLength: 250),
                        Photo = c.String(maxLength: 250),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Partners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(maxLength: 250),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pricings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                        Amount = c.Int(nullable: false),
                        Bandwidth = c.Byte(nullable: false),
                        Onlinespace = c.Byte(nullable: false),
                        Support = c.Boolean(nullable: false),
                        Domain = c.Byte(nullable: false),
                        Fees = c.Boolean(nullable: false),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Content = c.String(nullable: false, maxLength: 100),
                        Icon = c.String(nullable: false, maxLength: 100),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogoName = c.String(nullable: false, maxLength: 50),
                        Logo = c.String(maxLength: 200),
                        Adress = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, storeType: "ntext"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SettingSocials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialLinkId = c.Int(nullable: false),
                        SettingId = c.Int(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Settings", t => t.SettingId, cascadeDelete: true)
                .ForeignKey("dbo.SocialLinks", t => t.SocialLinkId, cascadeDelete: true)
                .Index(t => t.SocialLinkId)
                .Index(t => t.SettingId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(maxLength: 250),
                        CategoryId = c.Int(nullable: false),
                        ShortInfo = c.String(nullable: false, maxLength: 50),
                        OrderBy = c.Int(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.TeamSocials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SocialLinks", t => t.SocialId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.SocialId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamSocials", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamSocials", "SocialId", "dbo.SocialLinks");
            DropForeignKey("dbo.Teams", "CategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.SettingSocials", "SocialLinkId", "dbo.SocialLinks");
            DropForeignKey("dbo.SettingSocials", "SettingId", "dbo.Settings");
            DropForeignKey("dbo.EmployerReviews", "EmployerId", "dbo.Employers");
            DropForeignKey("dbo.EmployerReviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.EmployerCategories", "EmployerId", "dbo.Employers");
            DropForeignKey("dbo.EmployerCategories", "CategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.CompanyPhotoes", "EmployerId", "dbo.Employers");
            DropForeignKey("dbo.BlogReviews", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Blogs", "CategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.Jobs", "JobEduLevel_Id", "dbo.JobEduLevels");
            DropForeignKey("dbo.Candidates", "JobEduLevel_Id", "dbo.JobEduLevels");
            DropForeignKey("dbo.Skills", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Experiences", "JobCategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.Experiences", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Educations", "JobEduLevelId", "dbo.JobEduLevels");
            DropForeignKey("dbo.Educations", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Candidates", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.CandidateSocials", "SocialLinkId", "dbo.SocialLinks");
            DropForeignKey("dbo.CandidateSocials", "CandidateId", "dbo.Candidates");
            DropForeignKey("dbo.Jobs", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Jobs", "CategoryId", "dbo.JobCategories");
            DropForeignKey("dbo.BlogReviews", "BlogId", "dbo.Blogs");
            DropIndex("dbo.TeamSocials", new[] { "TeamId" });
            DropIndex("dbo.TeamSocials", new[] { "SocialId" });
            DropIndex("dbo.Teams", new[] { "CategoryId" });
            DropIndex("dbo.SettingSocials", new[] { "SettingId" });
            DropIndex("dbo.SettingSocials", new[] { "SocialLinkId" });
            DropIndex("dbo.EmployerReviews", new[] { "CandidateId" });
            DropIndex("dbo.EmployerReviews", new[] { "EmployerId" });
            DropIndex("dbo.EmployerCategories", new[] { "EmployerId" });
            DropIndex("dbo.EmployerCategories", new[] { "CategoryId" });
            DropIndex("dbo.CompanyPhotoes", new[] { "EmployerId" });
            DropIndex("dbo.Skills", new[] { "CandidateId" });
            DropIndex("dbo.Experiences", new[] { "CandidateId" });
            DropIndex("dbo.Experiences", new[] { "JobCategoryId" });
            DropIndex("dbo.Educations", new[] { "CandidateId" });
            DropIndex("dbo.Educations", new[] { "JobEduLevelId" });
            DropIndex("dbo.CandidateSocials", new[] { "CandidateId" });
            DropIndex("dbo.CandidateSocials", new[] { "SocialLinkId" });
            DropIndex("dbo.Candidates", new[] { "JobEduLevel_Id" });
            DropIndex("dbo.Candidates", new[] { "CountryId" });
            DropIndex("dbo.Jobs", new[] { "JobEduLevel_Id" });
            DropIndex("dbo.Jobs", new[] { "CategoryId" });
            DropIndex("dbo.Jobs", new[] { "CountryId" });
            DropIndex("dbo.Blogs", new[] { "CategoryId" });
            DropIndex("dbo.BlogReviews", new[] { "BlogId" });
            DropIndex("dbo.BlogReviews", new[] { "CandidateId" });
            DropTable("dbo.TeamSocials");
            DropTable("dbo.Teams");
            DropTable("dbo.SettingSocials");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.Pricings");
            DropTable("dbo.Partners");
            DropTable("dbo.HowItWorks");
            DropTable("dbo.Faqs");
            DropTable("dbo.EmployerReviews");
            DropTable("dbo.EmployerCategories");
            DropTable("dbo.Employers");
            DropTable("dbo.CompanyPhotoes");
            DropTable("dbo.CareerAdvices");
            DropTable("dbo.Skills");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.SocialLinks");
            DropTable("dbo.CandidateSocials");
            DropTable("dbo.Candidates");
            DropTable("dbo.JobEduLevels");
            DropTable("dbo.Countries");
            DropTable("dbo.Jobs");
            DropTable("dbo.JobCategories");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogReviews");
            DropTable("dbo.AboutUs");
        }
    }
}
