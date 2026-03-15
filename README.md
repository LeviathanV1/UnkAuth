UnkAuth API

A comprehensive license key authentication system built with ASP.NET Core 8.0 and MongoDB.
This API provides secure user authentication, license key management, HWID binding, and blacklist functionality with Discord webhook integration for monitoring.

Purpose

This project was created primarily for personal use and study.

It was designed to serve as an authentication, logging, and registration system for my C# projects. During development and testing using Postman, the API proved to be stable and functional. However, it was never fully integrated into my production projects due to limited time and experience at the time.

The goal of this project was to build a well-structured authentication system capable of replacing the traditional KeyAuth.cs approach while providing a higher level of security using AES-256 encryption.

The project is now open source and available for anyone who wants to study, improve, or integrate it into their own systems.

Quick Start
Prerequisites

.NET 8.0 SDK

MongoDB instance (local or cloud)

Setup
git clone https://github.com/onlyredz/UnkAuthAPI.git
cd UnkAuthAPI
cp appsettings.Example.json appsettings.json

Edit appsettings.json with your configuration.

dotnet restore
dotnet run

API documentation will be available at:

https://localhost:7001/swagger
Technology Stack

.NET 8.0

ASP.NET Core Web API

MongoDB

MongoDB.Driver

Swagger / OpenAPI

Dependency Injection (built-in .NET container)

Frameworks and Libraries

Microsoft.AspNetCore.Authentication (v2.3.0) — Authentication framework

Microsoft.Extensions.Configuration.UserSecrets (v8.0.0) — Secure configuration management

MongoDB.Driver (v2.24.0) — Official MongoDB driver for .NET

Swashbuckle.AspNetCore (v6.5.0) — Swagger/OpenAPI documentation

Security Notice

This project has been prepared for open-source release. Before using it in production, consider the following:

Missing Production Security Features

Authentication / Authorization
Admin endpoints currently do not require authentication. Implement proper security such as JWT, API keys, or OAuth.

Rate Limiting
No rate limiting is currently implemented. It is recommended to add request throttling.

CORS Configuration
CORS policies are not configured. Configure them appropriately for your domain.

HTTPS Configuration
Ensure HTTPS is properly configured in production environments.

Input Validation
Basic validation exists, but additional validation and sanitization should be implemented.

Logging
Logging currently uses Console.WriteLine. Replace this with structured logging (Serilog, NLog, etc.) for production environments.

Always review and test security measures before deploying this project in a production environment.

Documentation

Detailed documentation, setup instructions, and API references are available in the Project Wiki.

Available documentation includes:

Complete Setup Guide

Configuration Guide

API Reference

Security Guide

Quick Start Guide

Portuguese Documentation

Main Features

User authentication (register and login with HWID binding)

License key management (generation, validation, and usage tracking)

Blacklist system (ban and unban users, IPs, and HWIDs)

Administrative functions (HWID reset, key management)

Discord webhook integration for monitoring and logging

Status page for API health monitoring

Open Source Preparation and Security Review

This codebase was prepared for public release with structural improvements and documentation updates.

Please maintain the original credits when using or modifying this project.

License

This project is licensed under the Apache 2.0 License.
See the LICENSE file for more details.

Contributing

Fork the repository

Create a feature branch

git checkout -b feature/your-feature

Commit your changes

git commit -m "Add new feature"

Push to the branch

git push origin feature/your-feature

Open a Pull Request

Support

If you need help or have questions:

Open an issue in the GitHub repository

Check the API documentation at /swagger

Review the Project Wiki

Note: This API is intended for educational purposes and legitimate software projects. Ensure compliance with applicable laws and regulations before using it in production environments.
