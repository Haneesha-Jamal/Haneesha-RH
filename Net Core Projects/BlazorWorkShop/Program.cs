using BlazorWorkShop.Data;
using BlazorWorkShop.Extension;
using BlazorWorkShop.Interface;
using BlazorWorkShop.Repository;
using BlazorWorkShop.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);
IServerSideBlazorBuilder serverSideBlazorBuilder = builder.Services.AddServerSideBlazor();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register application services
builder.Services.AddScoped<ApplicationService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<InterviewService>();
builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<StorageService>();
builder.Services.AddScoped<UserService>();

// Register repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
// Add other services if needed
builder.Services.AddApplicationService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
