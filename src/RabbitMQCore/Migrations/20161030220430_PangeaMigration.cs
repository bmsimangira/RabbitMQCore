using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;

namespace RabbitMQCore.Migrations
{
    public partial class PangeaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    id = table.Column<int>(nullable: true),
                    avatar_url = table.Column<string>(nullable: true),
                    events_url = table.Column<string>(nullable: true),
                    followers_url = table.Column<string>(nullable: true),
                    following_url = table.Column<string>(nullable: true),
                    gists_url = table.Column<string>(nullable: true),
                    gravatar_id = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    login = table.Column<string>(nullable: true),
                    organizations_url = table.Column<string>(nullable: true),
                    received_events_url = table.Column<string>(nullable: true),
                    repos_url = table.Column<string>(nullable: true),
                    site_admin = table.Column<bool>(nullable: false),
                    starred_url = table.Column<string>(nullable: true),
                    subscriptions_url = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin = table.Column<bool>(nullable: false),
                    pull = table.Column<bool>(nullable: false),
                    push = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _private = table.Column<bool>(nullable: false),
                    archive_url = table.Column<string>(nullable: true),
                    assignees_url = table.Column<string>(nullable: true),
                    blobs_url = table.Column<string>(nullable: true),
                    branches_url = table.Column<string>(nullable: true),
                    clone_url = table.Column<string>(nullable: true),
                    collaborators_url = table.Column<string>(nullable: true),
                    comments_url = table.Column<string>(nullable: true),
                    commits_url = table.Column<string>(nullable: true),
                    compare_url = table.Column<string>(nullable: true),
                    contents_url = table.Column<string>(nullable: true),
                    contributors_url = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    default_branch = table.Column<string>(nullable: true),
                    deployments_url = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    downloads_url = table.Column<string>(nullable: true),
                    events_url = table.Column<string>(nullable: true),
                    fork = table.Column<bool>(nullable: false),
                    forks = table.Column<int>(nullable: false),
                    forks_count = table.Column<int>(nullable: false),
                    forks_url = table.Column<string>(nullable: true),
                    full_name = table.Column<string>(nullable: true),
                    git_commits_url = table.Column<string>(nullable: true),
                    git_refs_url = table.Column<string>(nullable: true),
                    git_tags_url = table.Column<string>(nullable: true),
                    git_url = table.Column<string>(nullable: true),
                    has_downloads = table.Column<bool>(nullable: false),
                    has_issues = table.Column<bool>(nullable: false),
                    has_pages = table.Column<bool>(nullable: false),
                    has_wiki = table.Column<bool>(nullable: false),
                    homepage = table.Column<string>(nullable: true),
                    hooks_url = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    issue_comment_url = table.Column<string>(nullable: true),
                    issue_events_url = table.Column<string>(nullable: true),
                    issues_url = table.Column<string>(nullable: true),
                    keys_url = table.Column<string>(nullable: true),
                    labels_url = table.Column<string>(nullable: true),
                    language = table.Column<string>(nullable: true),
                    languages_url = table.Column<string>(nullable: true),
                    merges_url = table.Column<string>(nullable: true),
                    milestones_url = table.Column<string>(nullable: true),
                    mirror_url = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    notifications_url = table.Column<string>(nullable: true),
                    open_issues = table.Column<int>(nullable: false),
                    open_issues_count = table.Column<int>(nullable: false),
                    ownerid = table.Column<int>(nullable: true),
                    permissionsid = table.Column<int>(nullable: true),
                    pulls_url = table.Column<string>(nullable: true),
                    pushed_at = table.Column<DateTime>(nullable: false),
                    releases_url = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    ssh_url = table.Column<string>(nullable: true),
                    stargazers_count = table.Column<int>(nullable: false),
                    stargazers_url = table.Column<string>(nullable: true),
                    statuses_url = table.Column<string>(nullable: true),
                    subscribers_url = table.Column<string>(nullable: true),
                    subscription_url = table.Column<string>(nullable: true),
                    svn_url = table.Column<string>(nullable: true),
                    tags_url = table.Column<string>(nullable: true),
                    teams_url = table.Column<string>(nullable: true),
                    trees_url = table.Column<string>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    watchers = table.Column<int>(nullable: false),
                    watchers_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Repositories_Owner_ownerid",
                        column: x => x.ownerid,
                        principalTable: "Owner",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repositories_Permissions_permissionsid",
                        column: x => x.permissionsid,
                        principalTable: "Permissions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_ownerid",
                table: "Repositories",
                column: "ownerid");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_permissionsid",
                table: "Repositories",
                column: "permissionsid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
