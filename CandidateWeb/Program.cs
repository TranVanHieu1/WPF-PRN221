using Candidate_Repository;
using Candidate_Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IProfileService, ProfileService>();
builder.Services.AddScoped<IProfileRepo, ProfileRepo>();


builder.Services.AddScoped<IJobPostingService, JobPostingService>();
builder.Services.AddScoped<IJobPostingRepo, JobPostingRepo>();

builder.Services.AddScoped<IHRAccountService, HRAccountService>();
builder.Services.AddScoped<IHRAccountRepository, HRAcountRepository>();

builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseSession();

app.Run();


