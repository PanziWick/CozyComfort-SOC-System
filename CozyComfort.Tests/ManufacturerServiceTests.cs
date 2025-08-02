using Xunit;
using Microsoft.EntityFrameworkCore;
using CozyComfort.Services.Data;
using CozyComfort.Services.Services.Implementations;
using CozyComfort.Services.DTOs;
using AutoMapper;
using CozyComfort.Services.Mappings;

public class ManufacturerServiceTests
{
    private readonly ManufacturerService _service;
    private readonly ApplicationDbContext _context;

    public ManufacturerServiceTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;

        _context = new ApplicationDbContext(options);

        var mapperConfig = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<AutoMapperProfile>();
        });
        var mapper = mapperConfig.CreateMapper();

        _service = new ManufacturerService(_context, mapper);
    }

    [Fact]
    public async Task CreateBlanket_ShouldAddBlanket()
    {
        // Arrange
        var dto = new BlanketDTO { ModelName = "Test Blanket", Material = "Wool", ProductionCapacity = 50, InStock = 10 };

        // Act
        var result = await _service.CreateBlanketAsync(dto);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Test Blanket", result.ModelName);
        Assert.Single(_context.Blankets);
    }
}
