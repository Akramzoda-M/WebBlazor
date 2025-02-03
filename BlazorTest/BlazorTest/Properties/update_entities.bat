@echo off
dotnet ef dbcontext scaffold "Host=192.168.109.99;Database=suhrob_official;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL -o Entities -f --project BlazorTest
