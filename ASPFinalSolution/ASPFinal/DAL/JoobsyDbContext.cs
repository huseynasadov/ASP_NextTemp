using ASPFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPFinal.DAL
{
    public class JoobsyDbContext:DbContext
    {
        public JoobsyDbContext() : base("JoobsyConnection")
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogReview> BlogReviews { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateSocial> CandidateSocials { get; set; }
        public DbSet<CompanyPhoto> CompanyPhoto { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmployerCategory> EmployerCategories { get; set; }
        public DbSet<EmployerReview> EmployerReviews { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<HowItWork> HowItWorks { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobEduLevel> JobEduLevels { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SettingSocial> SettingSocials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamSocial> TeamSocial { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<HeaderSetting> HeaderSetting { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        public DbSet<AdminManager> AdminManagers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}