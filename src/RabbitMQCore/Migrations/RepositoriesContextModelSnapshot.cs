﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PangeaServices.Models;

namespace RabbitMQCore.Migrations
{
    [DbContext(typeof(RepositoriesContext))]
    partial class RepositoriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-preview1-22509")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PangeaServices.Models.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("avatar_url");

                    b.Property<string>("events_url");

                    b.Property<string>("followers_url");

                    b.Property<string>("following_url");

                    b.Property<string>("gists_url");

                    b.Property<string>("gravatar_id");

                    b.Property<string>("html_url");

                    b.Property<string>("login");

                    b.Property<string>("organizations_url");

                    b.Property<string>("received_events_url");

                    b.Property<string>("repos_url");

                    b.Property<bool>("site_admin");

                    b.Property<string>("starred_url");

                    b.Property<string>("subscriptions_url");

                    b.Property<string>("type");

                    b.Property<string>("url");

                    b.HasKey("id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("PangeaServices.Models.Permissions", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("admin");

                    b.Property<bool>("pull");

                    b.Property<bool>("push");

                    b.HasKey("id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("PangeaServices.Models.Repository", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("_private");

                    b.Property<string>("archive_url");

                    b.Property<string>("assignees_url");

                    b.Property<string>("blobs_url");

                    b.Property<string>("branches_url");

                    b.Property<string>("clone_url");

                    b.Property<string>("collaborators_url");

                    b.Property<string>("comments_url");

                    b.Property<string>("commits_url");

                    b.Property<string>("compare_url");

                    b.Property<string>("contents_url");

                    b.Property<string>("contributors_url");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("default_branch");

                    b.Property<string>("deployments_url");

                    b.Property<string>("description");

                    b.Property<string>("downloads_url");

                    b.Property<string>("events_url");

                    b.Property<bool>("fork");

                    b.Property<int>("forks");

                    b.Property<int>("forks_count");

                    b.Property<string>("forks_url");

                    b.Property<string>("full_name");

                    b.Property<string>("git_commits_url");

                    b.Property<string>("git_refs_url");

                    b.Property<string>("git_tags_url");

                    b.Property<string>("git_url");

                    b.Property<bool>("has_downloads");

                    b.Property<bool>("has_issues");

                    b.Property<bool>("has_pages");

                    b.Property<bool>("has_wiki");

                    b.Property<string>("homepage");

                    b.Property<string>("hooks_url");

                    b.Property<string>("html_url");

                    b.Property<string>("issue_comment_url");

                    b.Property<string>("issue_events_url");

                    b.Property<string>("issues_url");

                    b.Property<string>("keys_url");

                    b.Property<string>("labels_url");

                    b.Property<string>("language");

                    b.Property<string>("languages_url");

                    b.Property<string>("merges_url");

                    b.Property<string>("milestones_url");

                    b.Property<string>("mirror_url");

                    b.Property<string>("name");

                    b.Property<string>("notifications_url");

                    b.Property<int>("open_issues");

                    b.Property<int>("open_issues_count");

                    b.Property<int?>("ownerid");

                    b.Property<int?>("permissionsid");

                    b.Property<string>("pulls_url");

                    b.Property<DateTime>("pushed_at");

                    b.Property<string>("releases_url");

                    b.Property<int>("size");

                    b.Property<string>("ssh_url");

                    b.Property<int>("stargazers_count");

                    b.Property<string>("stargazers_url");

                    b.Property<string>("statuses_url");

                    b.Property<string>("subscribers_url");

                    b.Property<string>("subscription_url");

                    b.Property<string>("svn_url");

                    b.Property<string>("tags_url");

                    b.Property<string>("teams_url");

                    b.Property<string>("trees_url");

                    b.Property<DateTime>("updated_at");

                    b.Property<string>("url");

                    b.Property<int>("watchers");

                    b.Property<int>("watchers_count");

                    b.HasKey("id");

                    b.HasIndex("ownerid");

                    b.HasIndex("permissionsid");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("PangeaServices.Models.Repository", b =>
                {
                    b.HasOne("PangeaServices.Models.Owner", "owner")
                        .WithMany()
                        .HasForeignKey("ownerid");

                    b.HasOne("PangeaServices.Models.Permissions", "permissions")
                        .WithMany()
                        .HasForeignKey("permissionsid");
                });
        }
    }
}
